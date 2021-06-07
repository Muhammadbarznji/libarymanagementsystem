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
    public partial class FADDBOOK : Form
    {
        public int ID;
        public FADDBOOK()
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
            try
            {
                BL.clsbook BLBOOK = new BL.clsbook();
                DataTable dt = new DataTable();
                dt = BLBOOK.LOADCAT();
                object[] obj = new object[dt.Rows.Count];
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    obj[i] = dt.Rows[i]["catname"];
                }
                comboBox1.Items.AddRange(obj);
            }
            catch (Exception ex)
            {

            }

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
            if (txttitle.Text=="" || txtauthor.Text=="" || txtprice.Text=="" )
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
                    BL.clsbook BLCAT = new BL.clsbook();
                    BLCAT.Insert(txttitle.Text, txtauthor.Text, comboBox1.Text, txtprice.Text, txtdate.Value.ToString(), txtrate.Value, ma);
                    PL.FDADD Fadd = new FDADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // Edit
                    BL.clsbook BLCAT = new BL.clsbook();
                    BLCAT.Update(txttitle.Text, txtauthor.Text, comboBox1.Text, txtprice.Text, txtdate.Value.ToString(), txtrate.Value, ma,ID);
                    PL.FDGE fedit = new FDGE();
                    fedit.Show();
                    this.Close();
                }
            }
        }
    }
}
