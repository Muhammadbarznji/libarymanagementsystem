using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTEBXANA.PL
{
    public partial class FADDST: Form
    {
        public int ID;
        public FADDST()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FADDBOOK_Load(object sender, EventArgs e)
        {
           

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                cover.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FADDCAT FCAT = new FADDCAT();
            FCAT.btnadd.ButtonText = "زیادکردن";
            FCAT.ID = 0;
            FCAT.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="" || txtlocation.Text=="" || txtemail.Text=="" )
            {
                PL.FERINS FERR = new FERINS();
                FERR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    
                    // Add
                    BL.clsst BLCAT = new BL.clsst();
                    BLCAT.Insert(txtname.Text, txtlocation.Text, txtmobile.Text, txtemail.Text, txtsc.Text, txtdep.Text,ma);
                    PL.FDADD Fadd = new FDADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // Edit
                    BL.clsst BLCAT = new BL.clsst();
                    BLCAT.Update(txtname.Text, txtlocation.Text, txtmobile.Text, txtemail.Text, txtsc.Text, txtdep.Text, ma, ID);
                    PL.FDGE fedit = new FDGE();
                    fedit.Show();
                    this.Close();
                }
            }
        }
    }
}
