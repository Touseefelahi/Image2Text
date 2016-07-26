namespace Image2Text
{
    partial class Image2Text
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image2Text));
            this.button_open_image = new System.Windows.Forms.Button();
            this.button_save_file = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.borderPanel1 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.imageBox_input = new Emgu.CV.UI.ImageBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbr_info = new System.Windows.Forms.RichTextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.checkBox_binary = new System.Windows.Forms.CheckBox();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_input)).BeginInit();
            this.SuspendLayout();
            // 
            // button_open_image
            // 
            this.button_open_image.Location = new System.Drawing.Point(69, 0);
            this.button_open_image.Name = "button_open_image";
            this.button_open_image.Size = new System.Drawing.Size(75, 34);
            this.button_open_image.TabIndex = 0;
            this.button_open_image.Text = "Open Image File";
            this.button_open_image.UseVisualStyleBackColor = true;
            this.button_open_image.Click += new System.EventHandler(this.button_open_image_Click);
            // 
            // button_save_file
            // 
            this.button_save_file.Location = new System.Drawing.Point(150, 0);
            this.button_save_file.Name = "button_save_file";
            this.button_save_file.Size = new System.Drawing.Size(75, 34);
            this.button_save_file.TabIndex = 1;
            this.button_save_file.Text = "Conver to Text File";
            this.button_save_file.UseVisualStyleBackColor = true;
            this.button_save_file.Click += new System.EventHandler(this.button_save_file_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg Files(*.jpg)|*.jpg|Png files (*.png)|*.png|All fi" +
    "les (*.*)|*.*";
            // 
            // borderPanel1
            // 
            this.borderPanel1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.borderPanel1.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel1.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel1.Controls.Add(this.imageBox_input);
            this.borderPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.borderPanel1.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.Location = new System.Drawing.Point(3, 33);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(300, 300);
            this.borderPanel1.TabIndex = 2;
            this.borderPanel1.UseInnerColor = false;
            // 
            // imageBox_input
            // 
            this.imageBox_input.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageBox_input.BackColor = System.Drawing.SystemColors.Control;
            this.imageBox_input.Location = new System.Drawing.Point(5, 5);
            this.imageBox_input.Name = "imageBox_input";
            this.imageBox_input.Size = new System.Drawing.Size(290, 290);
            this.imageBox_input.TabIndex = 2;
            this.imageBox_input.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // tbr_info
            // 
            this.tbr_info.Location = new System.Drawing.Point(3, 347);
            this.tbr_info.Name = "tbr_info";
            this.tbr_info.ReadOnly = true;
            this.tbr_info.Size = new System.Drawing.Size(300, 53);
            this.tbr_info.TabIndex = 3;
            this.tbr_info.Text = "Please open image file";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(3, 334);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(25, 13);
            this.label_info.TabIndex = 4;
            this.label_info.Text = "Info";
            // 
            // checkBox_binary
            // 
            this.checkBox_binary.AutoSize = true;
            this.checkBox_binary.Location = new System.Drawing.Point(249, 10);
            this.checkBox_binary.Name = "checkBox_binary";
            this.checkBox_binary.Size = new System.Drawing.Size(55, 17);
            this.checkBox_binary.TabIndex = 5;
            this.checkBox_binary.Text = "Binary";
            this.checkBox_binary.UseVisualStyleBackColor = true;
            this.checkBox_binary.CheckedChanged += new System.EventHandler(this.checkBox_binary_CheckedChanged);
            // 
            // Image2Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 402);
            this.Controls.Add(this.checkBox_binary);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.button_save_file);
            this.Controls.Add(this.button_open_image);
            this.Controls.Add(this.tbr_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 440);
            this.MinimumSize = new System.Drawing.Size(320, 440);
            this.Name = "Image2Text";
            this.Text = "Image2Text";
            this.borderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open_image;
        private System.Windows.Forms.Button button_save_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel1;
        private Emgu.CV.UI.ImageBox imageBox_input;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox tbr_info;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.CheckBox checkBox_binary;
    }
}

