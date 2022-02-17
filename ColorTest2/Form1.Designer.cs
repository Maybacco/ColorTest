namespace ColorTest2
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
            this.temperatureTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hslTb = new System.Windows.Forms.TextBox();
            this.rgbTb = new System.Windows.Forms.TextBox();
            this.minTempTb = new System.Windows.Forms.TextBox();
            this.maxTempTb = new System.Windows.Forms.TextBox();
            this.percentageTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // temperatureTb
            // 
            this.temperatureTb.Location = new System.Drawing.Point(97, 68);
            this.temperatureTb.Name = "temperatureTb";
            this.temperatureTb.Size = new System.Drawing.Size(100, 23);
            this.temperatureTb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConvertTemperature);
            // 
            // hslTb
            // 
            this.hslTb.Location = new System.Drawing.Point(97, 123);
            this.hslTb.Name = "hslTb";
            this.hslTb.Size = new System.Drawing.Size(100, 23);
            this.hslTb.TabIndex = 2;
            // 
            // rgbTb
            // 
            this.rgbTb.Location = new System.Drawing.Point(212, 123);
            this.rgbTb.Name = "rgbTb";
            this.rgbTb.Size = new System.Drawing.Size(100, 23);
            this.rgbTb.TabIndex = 3;
            // 
            // minTempTb
            // 
            this.minTempTb.Location = new System.Drawing.Point(100, 17);
            this.minTempTb.Name = "minTempTb";
            this.minTempTb.Size = new System.Drawing.Size(38, 23);
            this.minTempTb.TabIndex = 4;
            this.minTempTb.Text = "0";
            // 
            // maxTempTb
            // 
            this.maxTempTb.Location = new System.Drawing.Point(158, 17);
            this.maxTempTb.Name = "maxTempTb";
            this.maxTempTb.Size = new System.Drawing.Size(39, 23);
            this.maxTempTb.TabIndex = 5;
            this.maxTempTb.Text = "200";
            // 
            // percentageTb
            // 
            this.percentageTb.Location = new System.Drawing.Point(306, 68);
            this.percentageTb.Name = "percentageTb";
            this.percentageTb.Size = new System.Drawing.Size(38, 23);
            this.percentageTb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 222);
            this.Controls.Add(this.percentageTb);
            this.Controls.Add(this.maxTempTb);
            this.Controls.Add(this.minTempTb);
            this.Controls.Add(this.rgbTb);
            this.Controls.Add(this.hslTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temperatureTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox temperatureTb;
        private Button button1;
        private TextBox hslTb;
        private TextBox rgbTb;
        private TextBox minTempTb;
        private TextBox maxTempTb;
        private TextBox percentageTb;
    }
}