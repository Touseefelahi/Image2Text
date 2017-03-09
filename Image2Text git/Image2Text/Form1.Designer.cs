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
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.imageBoxGrid = new Emgu.CV.UI.ImageBox();
            this.imageBoxPreview = new Emgu.CV.UI.ImageBox();
            this.labelPreview = new System.Windows.Forms.Label();
            this.borderPanel1 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.borderPanel2 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.borderPanel3 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.colorPicked = new System.Windows.Forms.Button();
            this.trackBarLineThickness = new System.Windows.Forms.TrackBar();
            this.labelLineThickness = new System.Windows.Forms.Label();
            this.checkBoxBlurredLine = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveIco = new System.Windows.Forms.Button();
            this.borderPanel4 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.maskedTextBoxThreshold = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxPreview)).BeginInit();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).BeginInit();
            this.borderPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonOpenImage.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonOpenImage.Location = new System.Drawing.Point(545, 7);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(75, 34);
            this.buttonOpenImage.TabIndex = 4;
            this.buttonOpenImage.Text = "Open Image File";
            this.buttonOpenImage.UseVisualStyleBackColor = false;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImageClick);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSaveFile.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonSaveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.buttonSaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSaveFile.Location = new System.Drawing.Point(626, 7);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 34);
            this.buttonSaveFile.TabIndex = 5;
            this.buttonSaveFile.Text = "Conver to Text File";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
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
            this.imageBoxInput.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxInput.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxInput.Location = new System.Drawing.Point(2, 3);
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
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxInfo.Location = new System.Drawing.Point(5, 577);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(751, 53);
            this.textBoxInfo.TabIndex = 3;
            this.textBoxInfo.Text = "Please open image file, or create a New one";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(5, 564);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Info";
            // 
            // checkBoxBinary
            // 
            this.checkBoxBinary.AutoSize = true;
            this.checkBoxBinary.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBinary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxBinary.Location = new System.Drawing.Point(659, 469);
            this.checkBoxBinary.Name = "checkBoxBinary";
            this.checkBoxBinary.Size = new System.Drawing.Size(55, 17);
            this.checkBoxBinary.TabIndex = 6;
            this.checkBoxBinary.Text = "Binary";
            this.checkBoxBinary.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(5, 552);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(757, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // checkBoxInvert
            // 
            this.checkBoxInvert.AutoSize = true;
            this.checkBoxInvert.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxInvert.Checked = true;
            this.checkBoxInvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInvert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxInvert.Location = new System.Drawing.Point(706, 16);
            this.checkBoxInvert.Name = "checkBoxInvert";
            this.checkBoxInvert.Size = new System.Drawing.Size(53, 17);
            this.checkBoxInvert.TabIndex = 7;
            this.checkBoxInvert.Text = "Invert";
            this.checkBoxInvert.UseVisualStyleBackColor = false;
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(102, 17);
            this.textBoxRows.Mask = "000";
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(41, 20);
            this.textBoxRows.TabIndex = 1;
            this.textBoxRows.Text = "32";
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(57, 17);
            this.textBoxColumns.Mask = "000";
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(41, 20);
            this.textBoxColumns.TabIndex = 0;
            this.textBoxColumns.Text = "32";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.BackColor = System.Drawing.Color.Transparent;
            this.labelRows.Location = new System.Drawing.Point(104, 3);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(38, 13);
            this.labelRows.TabIndex = 11;
            this.labelRows.Text = "Height";
            // 
            // labelCol
            // 
            this.labelCol.AutoSize = true;
            this.labelCol.BackColor = System.Drawing.Color.Transparent;
            this.labelCol.Location = new System.Drawing.Point(61, 3);
            this.labelCol.Name = "labelCol";
            this.labelCol.Size = new System.Drawing.Size(35, 13);
            this.labelCol.TabIndex = 12;
            this.labelCol.Text = "Width";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonClear.Location = new System.Drawing.Point(3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(49, 34);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "New";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSaveImage.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonSaveImage.Location = new System.Drawing.Point(467, 7);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(50, 34);
            this.buttonSaveImage.TabIndex = 16;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = false;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // imageBoxGrid
            // 
            this.imageBoxGrid.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxGrid.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxGrid.Location = new System.Drawing.Point(110, 2);
            this.imageBoxGrid.Name = "imageBoxGrid";
            this.imageBoxGrid.Size = new System.Drawing.Size(500, 500);
            this.imageBoxGrid.TabIndex = 2;
            this.imageBoxGrid.TabStop = false;
            this.imageBoxGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseDown);
            this.imageBoxGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseMove);
            this.imageBoxGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxInputMouseUp);
            // 
            // imageBoxPreview
            // 
            this.imageBoxPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageBoxPreview.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxPreview.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxPreview.Location = new System.Drawing.Point(5, 3);
            this.imageBoxPreview.Name = "imageBoxPreview";
            this.imageBoxPreview.Size = new System.Drawing.Size(500, 500);
            this.imageBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxPreview.TabIndex = 17;
            this.imageBoxPreview.TabStop = false;
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.BackColor = System.Drawing.Color.Transparent;
            this.labelPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPreview.Location = new System.Drawing.Point(510, 147);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(45, 13);
            this.labelPreview.TabIndex = 18;
            this.labelPreview.Text = "Preview";
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.Color.Transparent;
            this.borderPanel1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.borderPanel1.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel1.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel1.Controls.Add(this.imageBoxPreview);
            this.borderPanel1.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.Location = new System.Drawing.Point(509, 163);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(250, 250);
            this.borderPanel1.TabIndex = 19;
            this.borderPanel1.UseInnerColor = false;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.borderPanel2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderPanel2.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel2.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel2.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel2.Location = new System.Drawing.Point(509, 405);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Size = new System.Drawing.Size(250, 10);
            this.borderPanel2.TabIndex = 20;
            this.borderPanel2.UseInnerColor = false;
            // 
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.borderPanel3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderPanel3.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel3.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel3.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel3.Location = new System.Drawing.Point(758, 163);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Size = new System.Drawing.Size(3, 251);
            this.borderPanel3.TabIndex = 21;
            this.borderPanel3.UseInnerColor = false;
            // 
            // colorPicked
            // 
            this.colorPicked.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorPicked.Location = new System.Drawing.Point(145, 16);
            this.colorPicked.Name = "colorPicked";
            this.colorPicked.Size = new System.Drawing.Size(29, 22);
            this.colorPicked.TabIndex = 22;
            this.colorPicked.UseVisualStyleBackColor = false;
            this.colorPicked.Click += new System.EventHandler(this.buttonPickColor_Click);
            // 
            // trackBarLineThickness
            // 
            this.trackBarLineThickness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.trackBarLineThickness.LargeChange = 1;
            this.trackBarLineThickness.Location = new System.Drawing.Point(299, 1);
            this.trackBarLineThickness.Maximum = 5;
            this.trackBarLineThickness.Minimum = 1;
            this.trackBarLineThickness.Name = "trackBarLineThickness";
            this.trackBarLineThickness.Size = new System.Drawing.Size(100, 45);
            this.trackBarLineThickness.TabIndex = 2;
            this.trackBarLineThickness.Value = 1;
            // 
            // labelLineThickness
            // 
            this.labelLineThickness.AutoSize = true;
            this.labelLineThickness.BackColor = System.Drawing.Color.Transparent;
            this.labelLineThickness.Location = new System.Drawing.Point(204, 6);
            this.labelLineThickness.Name = "labelLineThickness";
            this.labelLineThickness.Size = new System.Drawing.Size(79, 13);
            this.labelLineThickness.TabIndex = 24;
            this.labelLineThickness.Text = "Line Thickness";
            // 
            // checkBoxBlurredLine
            // 
            this.checkBoxBlurredLine.AutoSize = true;
            this.checkBoxBlurredLine.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBlurredLine.Checked = true;
            this.checkBoxBlurredLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBlurredLine.Location = new System.Drawing.Point(188, 22);
            this.checkBoxBlurredLine.Name = "checkBoxBlurredLine";
            this.checkBoxBlurredLine.Size = new System.Drawing.Size(98, 17);
            this.checkBoxBlurredLine.TabIndex = 25;
            this.checkBoxBlurredLine.Text = "Blurred Corners";
            this.checkBoxBlurredLine.ThreeState = true;
            this.checkBoxBlurredLine.UseVisualStyleBackColor = false;
            this.checkBoxBlurredLine.CheckedChanged += new System.EventHandler(this.checkBoxBlurredLine_CheckedChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // buttonSaveIco
            // 
            this.buttonSaveIco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSaveIco.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonSaveIco.Location = new System.Drawing.Point(411, 7);
            this.buttonSaveIco.Name = "buttonSaveIco";
            this.buttonSaveIco.Size = new System.Drawing.Size(50, 34);
            this.buttonSaveIco.TabIndex = 17;
            this.buttonSaveIco.Text = "Save Icon";
            this.buttonSaveIco.UseVisualStyleBackColor = false;
            this.buttonSaveIco.Click += new System.EventHandler(this.buttonSaveIco_Click);
            // 
            // borderPanel4
            // 
            this.borderPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.borderPanel4.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderPanel4.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel4.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel4.Controls.Add(this.labelLineThickness);
            this.borderPanel4.Controls.Add(this.trackBarLineThickness);
            this.borderPanel4.Controls.Add(this.buttonClear);
            this.borderPanel4.Controls.Add(this.buttonSaveFile);
            this.borderPanel4.Controls.Add(this.colorPicked);
            this.borderPanel4.Controls.Add(this.checkBoxInvert);
            this.borderPanel4.Controls.Add(this.textBoxRows);
            this.borderPanel4.Controls.Add(this.buttonSaveIco);
            this.borderPanel4.Controls.Add(this.textBoxColumns);
            this.borderPanel4.Controls.Add(this.labelRows);
            this.borderPanel4.Controls.Add(this.buttonOpenImage);
            this.borderPanel4.Controls.Add(this.buttonSaveImage);
            this.borderPanel4.Controls.Add(this.labelCol);
            this.borderPanel4.Controls.Add(this.checkBoxBlurredLine);
            this.borderPanel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.borderPanel4.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel4.Location = new System.Drawing.Point(1, 504);
            this.borderPanel4.Name = "borderPanel4";
            this.borderPanel4.Size = new System.Drawing.Size(771, 46);
            this.borderPanel4.TabIndex = 21;
            this.borderPanel4.UseInnerColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Draw Here";
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.BackColor = System.Drawing.Color.Transparent;
            this.labelThreshold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelThreshold.Location = new System.Drawing.Point(656, 486);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(54, 13);
            this.labelThreshold.TabIndex = 26;
            this.labelThreshold.Text = "Threshold";
            // 
            // maskedTextBoxThreshold
            // 
            this.maskedTextBoxThreshold.Location = new System.Drawing.Point(721, 476);
            this.maskedTextBoxThreshold.Mask = "000";
            this.maskedTextBoxThreshold.Name = "maskedTextBoxThreshold";
            this.maskedTextBoxThreshold.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxThreshold.TabIndex = 26;
            this.maskedTextBoxThreshold.Text = "122";
            // 
            // Image2Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(765, 630);
            this.Controls.Add(this.maskedTextBoxThreshold);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBoxInput);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.borderPanel2);
            this.Controls.Add(this.borderPanel3);
            this.Controls.Add(this.checkBoxBinary);
            this.Controls.Add(this.borderPanel4);
            this.Controls.Add(this.imageBoxGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Image2Text";
            this.Text = "Image2Text";
            this.Load += new System.EventHandler(this.Image2Text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxPreview)).EndInit();
            this.borderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).EndInit();
            this.borderPanel4.ResumeLayout(false);
            this.borderPanel4.PerformLayout();
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
        private System.Windows.Forms.Button buttonSaveImage;
        private Emgu.CV.UI.ImageBox imageBoxGrid;
        private Emgu.CV.UI.ImageBox imageBoxPreview;
        private System.Windows.Forms.Label labelPreview;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel1;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel2;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel3;
        private System.Windows.Forms.Button colorPicked;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TrackBar trackBarLineThickness;
        private System.Windows.Forms.Label labelLineThickness;
        private System.Windows.Forms.CheckBox checkBoxBlurredLine;
        private System.Windows.Forms.Button buttonSaveIco;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxThreshold;
    }
}

