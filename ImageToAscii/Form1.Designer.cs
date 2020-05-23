namespace ImageToAscii
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseImageButton = new System.Windows.Forms.Button();
            this.initialPictureBox = new System.Windows.Forms.PictureBox();
            this.asciiPictureBox = new System.Windows.Forms.PictureBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.convertImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.initialPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asciiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // browseImageButton
            // 
            this.browseImageButton.Location = new System.Drawing.Point(146, 12);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(170, 29);
            this.browseImageButton.TabIndex = 0;
            this.browseImageButton.Text = "Browse Image";
            this.browseImageButton.UseVisualStyleBackColor = true;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // initialPictureBox
            // 
            this.initialPictureBox.Location = new System.Drawing.Point(13, 63);
            this.initialPictureBox.Name = "initialPictureBox";
            this.initialPictureBox.Size = new System.Drawing.Size(481, 471);
            this.initialPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.initialPictureBox.TabIndex = 1;
            this.initialPictureBox.TabStop = false;
            // 
            // asciiPictureBox
            // 
            this.asciiPictureBox.Location = new System.Drawing.Point(550, 63);
            this.asciiPictureBox.Name = "asciiPictureBox";
            this.asciiPictureBox.Size = new System.Drawing.Size(481, 471);
            this.asciiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asciiPictureBox.TabIndex = 1;
            this.asciiPictureBox.TabStop = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(742, 12);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(128, 29);
            this.saveImageButton.TabIndex = 0;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // convertImageButton
            // 
            this.convertImageButton.Location = new System.Drawing.Point(435, 12);
            this.convertImageButton.Name = "convertImageButton";
            this.convertImageButton.Size = new System.Drawing.Size(170, 29);
            this.convertImageButton.TabIndex = 0;
            this.convertImageButton.Text = "Convert Image";
            this.convertImageButton.UseVisualStyleBackColor = true;
            this.convertImageButton.Click += new System.EventHandler(this.convertImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.convertImageButton);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.asciiPictureBox);
            this.Controls.Add(this.initialPictureBox);
            this.Controls.Add(this.browseImageButton);
            this.Name = "Form1";
            this.Text = "ImageToAscii Converter";
            ((System.ComponentModel.ISupportInitialize)(this.initialPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asciiPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.PictureBox initialPictureBox;
        private System.Windows.Forms.PictureBox asciiPictureBox;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button convertImageButton;
    }
}

