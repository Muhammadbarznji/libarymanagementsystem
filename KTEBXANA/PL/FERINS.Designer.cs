namespace KTEBXANA.PL
{
    partial class FERINS
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
            this.sereky = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sereky
            // 
            this.sereky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sereky.AutoSize = true;
            this.sereky.Font = new System.Drawing.Font("Rudaw", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sereky.ForeColor = System.Drawing.Color.Maroon;
            this.sereky.Location = new System.Drawing.Point(439, 329);
            this.sereky.Name = "sereky";
            this.sereky.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sereky.Size = new System.Drawing.Size(241, 40);
            this.sereky.TabIndex = 5;
            this.sereky.Text = "ناوی کتێب بنووسە !";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FERINS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1119, 699);
            this.Controls.Add(this.sereky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FERINS";
            this.Opacity = 0.85D;
            this.Text = "FERINS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sereky;
        private System.Windows.Forms.Timer timer1;
    }
}