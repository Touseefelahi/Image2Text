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
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageBoxInput = new Emgu.CV.UI.ImageBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxBinary = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxInvert = new System.Windows.Forms.CheckBox();
            this.textBoxRows = new System.Windows.Forms.MaskedTextBox();
            this.textBoxColumns = new System.Windows.Forms.MaskedTextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelCol = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonPickColor = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.imageBoxGrid = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(276, 510);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(75, 34);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Open Image File";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImageClick);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(357, 510);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 34);
            this.buttonSaveFile.TabIndex = 1;
            this.buttonSaveFile.Text = "Conver to Text File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFileClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg Files(*.jpg)|*.jpg|Png files (*.png)|*.png|All fi" +
    "les (*.*)|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // imageBoxInput
            // 
            this.imageBoxInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.imageBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxInput.Location = new System.Drawing.Point(4, 5);
            this.imageBoxInput.Name = "imageBoxInput";
            this.imageBoxInput.Size = new System.Drawing.Size(500, 500);
            this.imageBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxInput.TabIndex = 2;
            this.imageBoxInput.TabStop = false;
            this.imageBoxInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseDown);
            this.imageBoxInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseMove);
            this.imageBoxInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(5, 593);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(500, 53);
            this.textBoxInfo.TabIndex = 3;
            this.textBoxInfo.Text = "Please open image file";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(5, 580);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Info";
            // 
            // checkBoxBinary
            // 
            this.checkBoxBinary.AutoSize = true;
            this.checkBoxBinary.Location = new System.Drawing.Point(453, 509);
            this.checkBoxBinary.Name = "checkBoxBinary";
            this.checkBoxBinary.Size = new System.Drawing.Size(55, 17);
            this.checkBoxBinary.TabIndex = 5;
            this.checkBoxBinary.Text = "Binary";
            this.checkBoxBinary.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 549);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 23);
            this.progressBar.TabIndex = 6;
            // 
            // checkBoxInvert
            // 
            this.checkBoxInvert.AutoSize = true;
            this.checkBoxInvert.Checked = true;
            this.checkBoxInvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInvert.Location = new System.Drawing.Point(453, 528);
            this.checkBoxInvert.Name = "checkBoxInvert";
            this.checkBoxInvert.Size = new System.Drawing.Size(53, 17);
            this.checkBoxInvert.TabIndex = 7;
            this.checkBoxInvert.Text = "Invert";
            this.checkBoxInvert.UseVisualStyleBackColor = true;
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(56, 523);
            this.textBoxRows.Mask = "000";
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(41, 20);
            this.textBoxRows.TabIndex = 9;
            this.textBoxRows.Text = "16";
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(104, 523);
            this.textBoxColumns.Mask = "000";
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(41, 20);
            this.textBoxColumns.TabIndex = 10;
            this.textBoxColumns.Text = "16";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(57, 510);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(38, 13);
            this.labelRows.TabIndex = 11;
            this.labelRows.Text = "Height";
            // 
            // labelCol
            // 
            this.labelCol.AutoSize = true;
            this.labelCol.Location = new System.Drawing.Point(107, 510);
            this.labelCol.Name = "labelCol";
            this.labelCol.Size = new System.Drawing.Size(35, 13);
            this.labelCol.TabIndex = 12;
            this.labelCol.Text = "Width";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(5, 511);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(49, 34);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "New";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPickColor
            // 
            this.buttonPickColor.Location = new System.Drawing.Point(150, 523);
            this.buttonPickColor.Name = "buttonPickColor";
            this.buttonPickColor.Size = new System.Drawing.Size(64, 22);
            this.buttonPickColor.TabIndex = 15;
            this.buttonPickColor.Text = "Pick Color";
            this.buttonPickColor.UseVisualStyleBackColor = true;
            this.buttonPickColor.Click += new System.EventHandler(this.buttonPickColor_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(220, 511);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(50, 34);
            this.buttonSaveImage.TabIndex = 16;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // imageBoxGrid
            // 
            this.imageBoxGrid.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxGrid.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxGrid.Location = new System.Drawing.Point(4, 5);
            this.imageBoxGrid.Name = "imageBoxGrid";
            this.imageBoxGrid.Size = new System.Drawing.Size(500, 500);
            this.imageBoxGrid.TabIndex = 2;
            this.imageBoxGrid.TabStop = false;
            this.imageBoxGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseDown);
            this.imageBoxGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseMove);
            this.imageBoxGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseUp);
            // 
            // Image2Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 652);
            this.Controls.Add(this.imageBoxGrid);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonPickColor);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.imageBoxInput);
            this.Controls.Add(this.labelCol);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.checkBoxInvert);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBoxBinary);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonOpenImage);
            this.Controls.Add(this.textBoxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Image2Text";
            this.Text = "Image2Text";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Emgu.CV.UI.ImageBox imageBoxInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxBinary;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox checkBoxInvert;
        private System.Windows.Forms.MaskedTextBox textBoxRows;
        private System.Windows.Forms.MaskedTextBox textBoxColumns;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelCol;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonPickColor;
        private System.Windows.Forms.Button buttonSaveImage;
        private Emgu.CV.UI.ImageBox imageBoxGrid;
    }
}

