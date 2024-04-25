namespace OhShot_Pos
{
    partial class FrmLoading
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.PrgLoading = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OhShot_Pos.Properties.Resources.Logo1;
            this.picLogo.Location = new System.Drawing.Point(37, 36);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1257, 516);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // PrgLoading
            // 
            this.PrgLoading.Location = new System.Drawing.Point(75, 628);
            this.PrgLoading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrgLoading.Name = "PrgLoading";
            this.PrgLoading.Size = new System.Drawing.Size(1192, 29);
            this.PrgLoading.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(371, 576);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "OH Shot 포스기 프로그램 준비중 . . .";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 701);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrgLoading);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLoading";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ProgressBar PrgLoading;
        private System.Windows.Forms.TextBox textBox1;
    }
}