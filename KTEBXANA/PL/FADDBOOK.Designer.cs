namespace KTEBXANA.PL
{
    partial class FADDBOOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FADDBOOK));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtauthor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sereky = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtrate = new Bunifu.Framework.UI.BunifuRating();
            this.txtdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnaddbook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cover = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtauthor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Controls.Add(this.sereky);
            this.groupBox1.Location = new System.Drawing.Point(576, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 705);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "زانیاری سەرەکی";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(0, 508);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(107, 34);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "زیادکردن";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1, 465);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(486, 40);
            this.comboBox1.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtprice.HintText = "";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtprice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtprice.LineThickness = 4;
            this.txtprice.Location = new System.Drawing.Point(0, 621);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(492, 46);
            this.txtprice.TabIndex = 8;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(354, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "نرخی کتێب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(367, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "ناوی بەش";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtauthor
            // 
            this.txtauthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtauthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtauthor.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtauthor.HintForeColor = System.Drawing.Color.Empty;
            this.txtauthor.HintText = "";
            this.txtauthor.isPassword = false;
            this.txtauthor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtauthor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtauthor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtauthor.LineThickness = 4;
            this.txtauthor.Location = new System.Drawing.Point(0, 295);
            this.txtauthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(491, 46);
            this.txtauthor.TabIndex = 8;
            this.txtauthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtauthor.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(351, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "ناوی نوسەر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttitle
            // 
            this.txttitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttitle.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttitle.HintForeColor = System.Drawing.Color.Empty;
            this.txttitle.HintText = "";
            this.txttitle.isPassword = false;
            this.txttitle.LineFocusedColor = System.Drawing.Color.Blue;
            this.txttitle.LineIdleColor = System.Drawing.Color.Gray;
            this.txttitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txttitle.LineThickness = 4;
            this.txttitle.Location = new System.Drawing.Point(0, 132);
            this.txttitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(491, 46);
            this.txttitle.TabIndex = 8;
            this.txttitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sereky
            // 
            this.sereky.AutoSize = true;
            this.sereky.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sereky.ForeColor = System.Drawing.Color.Black;
            this.sereky.Location = new System.Drawing.Point(367, 68);
            this.sereky.Name = "sereky";
            this.sereky.Size = new System.Drawing.Size(123, 34);
            this.sereky.TabIndex = 7;
            this.sereky.Text = "ناوی کتێب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(296, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 34);
            this.label7.TabIndex = 7;
            this.label7.Text = "بەرواری دەرچوون";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(394, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "ڕەیتینگ";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(340, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "بەرگی کتێب";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.cover);
            this.groupBox2.Controls.Add(this.txtrate);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(59, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 705);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "زانیاری لاوەکی";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(166, 654);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 34);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ئەپلۆدی بەرگ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtrate
            // 
            this.txtrate.BackColor = System.Drawing.Color.Transparent;
            this.txtrate.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtrate.Location = new System.Drawing.Point(9, 260);
            this.txtrate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(474, 46);
            this.txtrate.TabIndex = 9;
            this.txtrate.Value = 0;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.SeaGreen;
            this.txtdate.BorderRadius = 0;
            this.txtdate.ForeColor = System.Drawing.Color.White;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdate.FormatCustom = null;
            this.txtdate.Location = new System.Drawing.Point(10, 123);
            this.txtdate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(482, 44);
            this.txtdate.TabIndex = 8;
            this.txtdate.Value = new System.DateTime(2020, 5, 5, 22, 5, 30, 693);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnaddbook
            // 
            this.btnaddbook.ActiveBorderThickness = 1;
            this.btnaddbook.ActiveCornerRadius = 20;
            this.btnaddbook.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.btnaddbook.ActiveForecolor = System.Drawing.Color.White;
            this.btnaddbook.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.btnaddbook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaddbook.BackColor = System.Drawing.Color.White;
            this.btnaddbook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddbook.BackgroundImage")));
            this.btnaddbook.ButtonText = "زیادکردن";
            this.btnaddbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddbook.Font = new System.Drawing.Font("Rudaw", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbook.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnaddbook.IdleBorderThickness = 1;
            this.btnaddbook.IdleCornerRadius = 20;
            this.btnaddbook.IdleFillColor = System.Drawing.Color.White;
            this.btnaddbook.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnaddbook.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnaddbook.Location = new System.Drawing.Point(293, 729);
            this.btnaddbook.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnaddbook.Name = "btnaddbook";
            this.btnaddbook.Size = new System.Drawing.Size(481, 59);
            this.btnaddbook.TabIndex = 8;
            this.btnaddbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddbook.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // cover
            // 
            this.cover.Image = global::KTEBXANA.Properties.Resources.icons8_books_60;
            this.cover.Location = new System.Drawing.Point(123, 400);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(232, 251);
            this.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover.TabIndex = 10;
            this.cover.TabStop = false;
            // 
            // FADDBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 793);
            this.Controls.Add(this.btnaddbook);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Rudaw", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FADDBOOK";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FADDBOOK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sereky;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtauthor;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txttitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public Bunifu.Framework.UI.BunifuThinButton2 btnaddbook;
        public System.Windows.Forms.PictureBox cover;
        public Bunifu.Framework.UI.BunifuRating txtrate;
        public Bunifu.Framework.UI.BunifuDatepicker txtdate;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}