using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            imageBox_input.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
        }
        Image<Gray, byte> image_in;
        int total_rows = 0, total_cols = 0;
        bool flag_binary = true;
    
        private void button_open_image_Click(object sender, EventArgs e)
        {  
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string path_to_image = openFileDialog.FileName;
                try
                {
                    image_in = new Image<Gray, byte>(path_to_image);
                    total_rows = image_in.Rows;
                    total_cols = image_in.Cols;
                    if (image_in.Rows > 300 || image_in.Cols > 300)
                    {
                        Image<Gray, byte> image_in_small = image_in.Resize(300, 300, Inter.Linear);//this is image with resize
                        imageBox_input.Image = image_in_small;
                        tbr_info.ForeColor = Color.Green;
                        tbr_info.Text = "Displaying Resized Image";
                    }
                    else
                    {
                        tbr_info.ForeColor = Color.Green;
                        imageBox_input.Image = image_in;
                        tbr_info.Text = "Displaying Image";
                    }
                }
                catch (Exception exep)
                {
                    tbr_info.ForeColor = Color.Red;
                    tbr_info.Text = Convert.ToString(exep);
                }
            }
            else
            {
                tbr_info.ForeColor = Color.Red;
                tbr_info.Text = "Error in Opening File, please select bitmap image file";
            }
            openFileDialog.Dispose();
        }

        private void checkBox_binary_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button_save_file_Click(object sender, EventArgs e)
        {
            flag_binary = Convert.ToBoolean(checkBox_binary.CheckState);
            if (total_cols == 0 || total_rows == 0)
            {
                tbr_info.ForeColor = Color.Red;
                tbr_info.Text = "Please Select Image first";
            }
            else
            {
                DialogResult res = saveFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        string path_to_textfile = saveFileDialog1.FileName;
                        using (StreamWriter fs = new StreamWriter(path_to_textfile, true))
                        {
                            fs.Write("unsigned int array[" + total_rows + "][" + total_cols + "]=");
                            int row, col;
                            byte pixel;
                            for (row = 0; row < total_rows; row++)
                            {
                                fs.Write("{");
                                for (col = 0; col < total_cols; col++)
                                {
                                    pixel = image_in.Data[row, col, 0];

                                    if (flag_binary)
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
                                        fs.Write(pixel);
                                    }
                                    if (col != (total_cols - 1)) fs.Write(",");

                                    if ((col + 1) % 20 == 0) fs.Write("\r\n");
                                }
                                if (row != (total_rows - 1)) fs.Write("},\r\n");
                            }
                            fs.Write("}};");
                            fs.Flush(); // Added
                            tbr_info.ForeColor = Color.Green;
                            tbr_info.Text = "Conversion Done";
                        }

                    }
                    catch (Exception exep)
                    {
                        //display error here
                        tbr_info.ForeColor = Color.Red;
                        tbr_info.Text = Convert.ToString(exep);
                    }
                }
                else
                {
                    tbr_info.ForeColor = Color.Red;
                    tbr_info.Text = "Error in Creating File, please create or select text file (.txt)";
                }
                saveFileDialog1.Dispose();
                image_in.Dispose();
            }
           
        }
       
       
    }
}
