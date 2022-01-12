namespace MMS_Lab1_15719
{
    partial class Lab1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.tbBrightness = new System.Windows.Forms.TextBox();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnGamma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(63, 336);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 49);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(407, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(365, 336);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(110, 49);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = "Pic 2 Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnBrightness
            // 
            this.btnBrightness.Location = new System.Drawing.Point(210, 336);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(110, 49);
            this.btnBrightness.TabIndex = 4;
            this.btnBrightness.Text = "Pic Brightness";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(327, 21);
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(100, 20);
            this.tbBrightness.TabIndex = 5;
            // 
            // btnContrast
            // 
            this.btnContrast.Location = new System.Drawing.Point(519, 336);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(110, 49);
            this.btnContrast.TabIndex = 6;
            this.btnContrast.Text = "Contrast";
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // btnGamma
            // 
            this.btnGamma.Location = new System.Drawing.Point(658, 336);
            this.btnGamma.Name = "btnGamma";
            this.btnGamma.Size = new System.Drawing.Size(110, 49);
            this.btnGamma.TabIndex = 7;
            this.btnGamma.Text = "Gamma";
            this.btnGamma.UseVisualStyleBackColor = true;
            this.btnGamma.Click += new System.EventHandler(this.btnGamma_Click);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGamma);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lab1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.TextBox tbBrightness;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnGamma;
    }
}

