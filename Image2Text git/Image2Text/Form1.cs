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

namespace Image2Text
{
    public partial class Image2Text : Form
    {
        public Image2Text()
        {
            InitializeComponent();
         //   imageBoxInput.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            maxReference = 255;
        }
        Image<Bgr, byte> imageIn;
        Image<Bgra, byte> grid;

        //       int totalRows = 0, totalCols = 0;
        bool flagBinary = false;
        bool startDrawing = false;
        int totalRows, totalCols;
        Bitmap imgDisplay, gridDisplay;
        Point previousPoint;
        MCvScalar lineColor;
        private void buttonOpenImageClick(object sender, EventArgs e)
        {
            startDrawing = false;
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
                        imgDisplay = imageIn.Bitmap;
                        imageBoxInput.Image = imgDisplay;
                        textBoxInfo.Text = "Displaying Image";
                       
                        progressBar.PerformStep();
                        saveMultiple(path2ImageFile);
                    }
                }
                catch (Exception exep)
                {
                    textBoxInfo.ForeColor = Color.Red;
                    textBoxInfo.Text = Convert.ToString(exep);
                }
            }
            else
            {
                textBoxInfo.ForeColor = Color.Red;
                textBoxInfo.Text = "Error in Opening File, please select bitmap image file";
            }
            openFileDialog.Dispose();
        }
        byte maxReference;
        private void saveMultiple(string fileName)
        {
            try
            {
                fileName += ".txt";
                using (StreamWriter fs = new StreamWriter(fileName, true))
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
                    textBoxInfo.Text = "Conversion Done";
                }
            }
            catch (Exception exep)
            {
                //display error here
                textBoxInfo.ForeColor = Color.Red;
                textBoxInfo.Text = Convert.ToString(exep);
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
               
                CvInvoke.Line(imageIn, previousPoint, currentPoint, lineColor,1,LineType.EightConnected);
              
                previousPoint = currentPoint;
            }
            imgDisplay = imageIn.Bitmap;
            imageBoxInput.Image = imgDisplay;
        }

        private void imageBoxInputMouseUp(object sender, MouseEventArgs e)
        {
            startDrawing = false;
        }

        private void imageBoxInputMouseDown(object sender, MouseEventArgs e)
        {
            if (imageIn == null) return;
                previousPoint = coordinatesConversion(e.X, e.Y);
                CvInvoke.Line(imageIn, previousPoint, previousPoint, lineColor);
            imgDisplay = imageIn.Bitmap;
            imageBoxInput.Image = imgDisplay;

        }

        private Point coordinatesConversion(int x, int y)
        {
            Point convertedPoint;
            float X, Y;

            var wRatio = (float)imageBoxInput.Width / totalCols;
            var hRatio = (float)imageBoxInput.Height / totalRows;
            X = x / wRatio;
            Y = y / hRatio;
            convertedPoint = new Point((int)X, (int)Y);

            //float imgBoxAspectRatio = imageBoxInput.Width / imageBoxInput.Height;
            //float imageAspectRatio = totalCols / totalRows;

            //if (imgBoxAspectRatio > imageAspectRatio)
            //{
            //    Y = totalRows * y / imageBoxInput.Height;
            //    float scaledWidth = totalCols * imageBoxInput.Height / totalRows;
            //    var dx = (totalCols - scaledWidth) / 2;
            //    X = (x - dx) * totalRows / imageBoxInput.Height;
            //}
            //else
            //{
            //    X = totalCols * x  / imageBoxInput.Width;
            //    float scaledHeight = totalRows * imageBoxInput.Width / totalCols;
            //    var dy = (totalRows - scaledHeight) / 2;
            //    Y = (y - dy) * totalCols / imageBoxInput.Width;
            //}
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
                imgDisplay = imageIn.Bitmap;
                imageBoxInput.Image = imgDisplay;
            }
            catch (Exception)
            {
                textBoxInfo.ForeColor = Color.Red;
                textBoxInfo.Text = "Error in generating blank image, did you selected proper resolution?";
            }

            //creating Grid
            grid = new Image<Bgra, byte>(imageBoxGrid.Width, imageBoxGrid.Height);
            for (int row = 0; row < grid.Rows; row++)
            {
             
                for (int col = 0; col < grid.Cols; col++)
                {
                    grid.Data[row, col, 1] = 0;
                    grid.Data[row, col, 2] = 0;
                    grid.Data[row, col, 0] = 0;
                    grid.Data[row, col, 3] = 0;

                    if (row % (grid.Rows/totalRows) == 0)
                    {
                       grid.Data[row, col, 3] = 250;
                    }
                    if (col % (grid.Rows / totalRows) == 0)
                    {
                        grid.Data[row, col, 3] = 250;

                    }
                }
            }
            imageBoxGrid.Parent = imageBoxInput;
            imageBoxGrid.Location = new Point(0, 0);
            gridDisplay = grid.Bitmap;
            imageBoxGrid.Image = gridDisplay;
        }

        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            var color = colorDialog.ShowDialog();
            if (color == DialogResult.OK)
            {
                var selectedColor = colorDialog.Color;
                lineColor = new MCvScalar(selectedColor.B, selectedColor.G, selectedColor.R);
            }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                CvInvoke.Imwrite("testImage.bmp", imageIn);
            }
            catch (Exception)
            {
                textBoxInfo.Text="Error in saving Image, did you open or made New file?";              
            }           
        }

        private void buttonSaveFileClick(object sender, EventArgs e)
        {
            flagBinary = Convert.ToBoolean(checkBoxBinary.CheckState);
            if (totalCols == 0 || totalRows == 0)
            {
                textBoxInfo.ForeColor = Color.Red;
                textBoxInfo.Text = "Please Select Image first";
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
                            textBoxInfo.Text = "Conversion Done";
                        }

                    }
                    catch (Exception exep)
                    {
                        //display error here
                        textBoxInfo.ForeColor = Color.Red;
                        textBoxInfo.Text = Convert.ToString(exep);
                    }
                }
                else
                {
                    textBoxInfo.ForeColor = Color.Red;
                    textBoxInfo.Text = "Error in Creating File, please create or select text file (.txt)";
                }
                saveFileDialog1.Dispose();
                imageIn.Dispose();
            }
           
        }
       
       
    }
}
