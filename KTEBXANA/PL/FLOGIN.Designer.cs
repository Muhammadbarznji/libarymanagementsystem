namespace KTEBXANA.PL
{
    partial class FLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLOGIN));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaddbook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtname.HintForeColor = System.Drawing.Color.Empty;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtname.LineThickness = 4;
            this.txtname.Location = new System.Drawing.Point(181, 279);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(421, 58);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Full Name";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(396, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ناوی بەکارهێنەر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpass.HintForeColor = System.Drawing.Color.Empty;
            this.txtpass.HintText = "";
            this.txtpass.isPassword = true;
            this.txtpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpass.LineThickness = 4;
            this.txtpass.Location = new System.Drawing.Point(181, 435);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(421, 58);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Password";
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(436, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "وشەی نهێنی";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(71, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 108);
            this.label3.TabIndex = 0;
            this.label3.Text = "چوونە ژوورەوە";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnaddbook
            // 
            this.btnaddbook.ActiveBorderThickness = 1;
            this.btnaddbook.ActiveCornerRadius = 20;
            this.btnaddbook.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnaddbook.ActiveForecolor = System.Drawing.Color.White;
            this.btnaddbook.ActiveLineColor = System.Drawing.Color.Black;
            this.btnaddbook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaddbook.BackColor = System.Drawing.Color.Black;
            this.btnaddbook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddbook.BackgroundImage")));
            this.btnaddbook.ButtonText = "چوونە ژوورەوە";
            this.btnaddbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbook.ForeColor = System.Drawing.Color.Black;
            this.btnaddbook.IdleBorderThickness = 1;
            this.btnaddbook.IdleCornerRadius = 20;
            this.btnaddbook.IdleFillColor = System.Drawing.Color.White;
            this.btnaddbook.IdleForecolor = System.Drawing.Color.Black;
            this.btnaddbook.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnaddbook.Location = new System.Drawing.Point(9, 455);
            this.btnaddbook.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnaddbook.Name = "btnaddbook";
            this.btnaddbook.Size = new System.Drawing.Size(421, 52);
            this.btnaddbook.TabIndex = 3;
            this.btnaddbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddbook.Click += new System.EventHandler(this.btnaddbook_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnaddbook);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(172, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 531);
            this.panel1.TabIndex = 0;
            // 
            // FLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(36F, 69F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.FLOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuThinButton2 btnaddbook;
        private System.Windows.Forms.Panel panel1;
    }
}