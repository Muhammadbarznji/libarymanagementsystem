using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace KTEBXANA.PL
{
    public partial class FADDCAT : Form
    {
        public int ID;
        public FADDCAT()
        {
            InitializeComponent();
        }

        private void sereky_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text == "")
            {
                PL.FERINS FERR = new FERINS();
                FERR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    // Add
                    BL.clscat BLCAT = new BL.clscat();
                    BLCAT.Insert(txtcatname.Text);
                    PL.FDADD Fadd = new FDADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    BL.clscat BLCAT = new BL.clscat();
                    BLCAT.Update(txtcatname.Text,ID);
                    PL.FDGE fedit = new FDGE();
                    fedit.Show();
                    this.Close();
                }
                
            }
        }

        private void FADDCAT_Load(object sender, EventArgs e)
        {

        }
    }
}
