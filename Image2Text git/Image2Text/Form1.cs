using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.IO;
using System.Threading.Tasks;

namespace Image2Text
{
    public partial class Image2Text : Form
    {
        public Image2Text()
        {
            InitializeComponent();
            imageBoxInput.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            maxReference = 255;
            imageBoxInput.MouseWheel += ImageBoxInput_MouseWheel;
        }
        private void Image2Text_Load(object sender, EventArgs e)
        {
            info = "Scroll Up/Down to Change Line Thickness";
            lineType = LineType.AntiAlias;
            buttonClear.PerformClick();
        }

        LineType lineType;
        private void ImageBoxInput_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((trackBarLineThickness.Value + e.Delta / 100) < 6 && (trackBarLineThickness.Value + e.Delta / 100)>0)
            trackBarLineThickness.Value += e.Delta/100;
        }

        string info
        {
            set
            {
                textBoxInfo.Invoke((MethodInvoker)(() => textBoxInfo.SelectionStart = textBoxInfo.Text.Length));
                textBoxInfo.Invoke((MethodInvoker)(() => textBoxInfo.ScrollToCaret()));
                textBoxInfo.AppendText("\n"+value);
            }
        }
        Image<Bgr, byte> imageIn;
        Image<Bgra, byte> grid;

        //       int totalRows = 0, totalCols = 0;
        bool flagBinary = false;
        bool startDrawing = false;
        int totalRows, totalCols;
        Point previousPoint;
        MCvScalar lineColor;

        private async void buttonOpenImageClick(object sender, EventArgs e)
        {
          
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var path2Image = openFileDialog.FileNames;
                var totalImages = path2Image.Length;
                progressBar.Value = 0;
                progressBar.Maximum = totalImages;
                progressBar.Step = 1;
                try
                {
                    foreach(string path2ImageFile in path2Image)
                    {                        
                        imageIn = new Image<Bgr, byte>(path2ImageFile);
                        totalRows = imageIn.Rows;
                        totalCols = imageIn.Cols;
                        
                        textBoxInfo.ForeColor = Color.Green;

                        imageBoxInput.Image = imageIn;
                        await Task.Delay(100);
                        info = "Displaying Image"; 
                        progressBar.PerformStep();
                        saveMultiple(path2ImageFile);
                    }
                    startDrawing = false;
                    imageBoxPreview.Image = imageIn;
                    imageBoxPreview.SetZoomScale(0.5, new Point(imageBoxPreview.Width / 2, imageBoxPreview.Height / 2));
                    if (totalRows + totalCols < 500)
                        gridGenerator();
                }
                catch (Exception exep)
                {
                    textBoxInfo.ForeColor = Color.Red;
                    info=Convert.ToString(exep);
                }
            }
            else
            {
                textBoxInfo.ForeColor = Color.Red;
                info="Error in Opening File, please select bitmap image file\n";
            }
           
            openFileDialog.Dispose();
        }

        byte maxReference;
        private void saveMultiple(string fileName)
        {
            try
            {
                var splited = fileName.Split('.'); //To remove old extension
                var newName = "";
                var builder = new StringBuilder();
                builder.Append(newName);
                for (int index = 0; index < splited.Length - 1; index++)
                {
                    builder.Append(splited[index]);
                }
                newName = builder.ToString();
                var splited2=newName.Split('\\');
                var arrayName = splited2[splited2.Length-1];
                fileName = newName+".txt";
                using (StreamWriter fs = new StreamWriter(fileName, false))
                {
                    fs.Write("unsigned int "+ arrayName+"[" + totalRows + "][" + totalCols + "]=");
                    int row, col;
                    byte pixel;
                    fs.Write("{");
                    for (row = 0; row < totalRows; row++)
                    {
                        fs.Write("{");
                        for (col = 0; col < totalCols; col++)
                        {
                            pixel = imageIn.Data[row, col, 0];

                            if (checkBoxBinary.Checked)
                            {
                                if (pixel > 122)
                                {
                                    fs.Write("0x00");
                                }
                                else
                                    fs.Write("0xFF");
                            }
                            else
                            {
                                if (checkBoxInvert.Checked)
                                    fs.Write(maxReference - pixel);
                                else
                                    fs.Write(pixel);
                            }
                            if (col != (totalCols - 1)) fs.Write(",");

                            if ((col + 1) % 20 == 0) fs.Write("\r\n");
                        }
                        if (row != (totalRows - 1)) fs.Write("},\r\n");
                    }
                    fs.Write("}};");
                    fs.Flush(); // Added
                    textBoxInfo.ForeColor = Color.Green;
                    info = "Text File Saved in " + fileName;
                }
            }
            catch (Exception exep)
            {
                //display error here
                textBoxInfo.ForeColor = Color.Red;
                info=Convert.ToString(exep);
            }
        }

        private void imageBoxInputMouseMove(object sender, MouseEventArgs e)
        {
            if (imageIn == null) return;
            if (e.Button != MouseButtons.Left) return;
            startDrawing = true;
            if (startDrawing)
            {
                var currentPoint = coordinatesConversion(e.X, e.Y);

                CvInvoke.Line(imageIn, previousPoint, currentPoint, lineColor, trackBarLineThickness.Value,lineType);
              
                previousPoint = currentPoint;
            }
            imageBoxPreview.Image = imageIn;
            imageBoxPreview.SetZoomScale(0.5, new Point(imageBoxPreview.Width / 2, imageBoxPreview.Height / 2));
            imageBoxInput.Image = imageIn;
        }

        private void imageBoxInputMouseUp(object sender, MouseEventArgs e)
        {
            startDrawing = false;
        }

        private void imageBoxInputMouseDown(object sender, MouseEventArgs e)
        {
            if (imageIn == null) { textBoxInfo.ForeColor = Color.Red; info = "Open a file or create a new one"; return; }
                previousPoint = coordinatesConversion(e.X, e.Y);
                CvInvoke.Line(imageIn, previousPoint, previousPoint, lineColor, trackBarLineThickness.Value, lineType);
                imageBoxInput.Image = imageIn;
            imageBoxPreview.Image = imageIn;
            imageBoxPreview.SetZoomScale(0.5, new Point(imageBoxPreview.Width/2, imageBoxPreview.Height/2));
        }

        private Point coordinatesConversion(int x, int y)
        {
            Point convertedPoint;
            float X, Y;
            var wRatio = (float)imageBoxInput.Width / totalCols;
            var hRatio = (float)imageBoxInput.Height / totalRows;
            X = (x / wRatio);
            Y = (y / hRatio);
            convertedPoint = new Point((int)X, (int)Y);
            return convertedPoint;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                totalRows = Convert.ToInt16(textBoxRows.Text);
                totalCols = Convert.ToInt16(textBoxColumns.Text);
                imageIn = new Image<Bgr, byte>(totalCols, totalRows);
                for (int row = 0; row < totalRows; row++)
                {
                    for (int col = 0; col < totalCols; col++)
                    {
                        imageIn.Data[row, col, 0] = 255;
                        imageIn.Data[row, col, 1] = 255;
                        imageIn.Data[row, col, 2] = 255;

                    }
                }
                imageBoxInput.Image = imageIn;
            }
            catch (Exception)
            {
                textBoxInfo.ForeColor = Color.Red;
                info="Error in generating blank image, did you selected proper resolution?";
            }
            if(totalRows+totalCols<500)
            gridGenerator();
        }
        private void gridGenerator()
        {
            //creating Grid
            grid = new Image<Bgra, byte>(500, 500);
            for (int row = 0; row < grid.Rows-5; row++)
            {

                for (int col = 0; col < grid.Cols-5; col++)
                {
                    grid.Data[row, col, 1] = 0;
                    grid.Data[row, col, 2] = 0;
                    grid.Data[row, col, 0] = 0;
                    grid.Data[row, col, 3] = 0;

                    if (row % (grid.Rows / totalRows) == 0)
                    {
                        if (col % (grid.Rows / totalRows) == 0)
                        {
                            grid.Data[row, col, 3] = 250;      
                        }                      
                    }
                }
            }
            imageBoxGrid.Parent = imageBoxInput;
            imageBoxGrid.Location = new Point(0, 0);
            imageBoxGrid.Image = grid;
            CvInvoke.Line(grid, new Point(grid.Cols / 2, grid.Rows / 2), new Point(grid.Cols / 2, grid.Rows / 2), new MCvScalar(0, 0, 255,255), 5);
        }

        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            var color = colorDialog.ShowDialog();
            if (color == DialogResult.OK)
            {
                var selectedColor = colorDialog.Color;
                lineColor = new MCvScalar(selectedColor.B, selectedColor.G, selectedColor.R);
                colorPicked.BackColor = selectedColor;
            }

        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                var res = saveFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    CvInvoke.Imwrite(fileName, imageIn);
                    info="Image Saved: " + fileName;
                }
               
            }
            catch (Exception)
            {
                info="\nError in saving Image, did you open or made New file?";              
            }           
        }

        private void checkBoxBlurredLine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlurredLine.CheckState == CheckState.Checked)
            {
                lineType = LineType.AntiAlias;
            }
            else if (checkBoxBlurredLine.CheckState == CheckState.Unchecked)
                lineType = LineType.EightConnected;
            else
                lineType = LineType.FourConnected;
        }

        private async void buttonSaveIco_Click(object sender, EventArgs e)
        {
            CvInvoke.Imwrite("ico.png", imageIn);
            await Task.Delay(1500);
            IcoConverter.ConvertToIcon(Application.StartupPath+"//ico.png", Application.StartupPath+"//ico.ico",64);
/*
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var inputPath = openFileDialog.FileName;
                
                var res2 = saveFileDialog.ShowDialog();
                if (res2 == DialogResult.OK)
                {
                    var outputPath = saveFileDialog.FileName;
                    IcoConverter.ConvertToIcon(inputPath, outputPath);
                }
                else
                    return;
            }
            else
                return;*/
        }

        private void buttonSaveFileClick(object sender, EventArgs e)
        {
            flagBinary = Convert.ToBoolean(checkBoxBinary.CheckState);
            if (totalCols == 0 || totalRows == 0)
            {
                textBoxInfo.ForeColor = Color.Red;
               info="\nPlease Select Image first";
            }
            else
            {
                var res = saveFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        var path2Textfile = saveFileDialog1.FileName;
                        using (StreamWriter fs = new StreamWriter(path2Textfile, true))
                        {
                            fs.Write("unsigned int array[" + totalRows + "][" + totalCols + "]=");
                            int row, col;
                            byte pixel;
                            for (row = 0; row < totalRows; row++)
                            {
                                fs.Write("{");
                                for (col = 0; col < totalCols; col++)
                                {
                                    pixel = imageIn.Data[row, col, 0];

                                    if (flagBinary)
                                    {
                                        if (pixel > 122)
                                        {
                                            fs.Write("0x00");
                                        }
                                        else
                                            fs.Write("0xFF");
                                    }
                                    else
                                    {
                                        if (checkBoxInvert.Checked)
                                            fs.Write(maxReference - pixel);
                                        else
                                            fs.Write(pixel);
                                    }
                                    if (col != (totalCols - 1)) fs.Write(",");

                                    if ((col + 1) % 20 == 0) fs.Write("\r\n");
                                }
                                if (row != (totalRows - 1)) fs.Write("},\r\n");
                            }
                            fs.Write("}};");
                            fs.Flush(); // Added
                            textBoxInfo.ForeColor = Color.Green;
                            info="\nConversion Done";
                        }

                    }
                    catch (Exception exep)
                    {
                        //display error here
                        textBoxInfo.ForeColor = Color.Red;
                        info=Convert.ToString(exep);
                    }
                }
                else
                {
                    textBoxInfo.ForeColor = Color.Red;
                    info = "Error in Creating File, please create or select text file (.txt)";
                }
                saveFileDialog1.Dispose();
                imageIn.Dispose();
            }
           
        }
       
       
    }
}
