using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTEBXANA.PL
{
    public partial class FADDUSER : Form
    {
        public int ID;
        public FADDUSER()
        {
            InitializeComponent();
        }

        private void sereky_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txttimer.Text = DateTime.Now.ToString();
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" ||  txtuser.Text == "" ||  txtprem.Text == "")
            {
                PL.FERINS FERR = new FERINS();
                FERR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    
                    // Add
                    BL.clsuser BLUSER = new BL.clsuser();
                    BLUSER.Insert(txtname.Text, txtuser.Text, txtpass.Text, txtprem.Text, "False");
                    PL.FDADD Fadd = new FDADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    
                    // Edit
                    BL.clsuser BLUSER = new BL.clsuser();
                    BLUSER.Update(txtname.Text, txtuser.Text, txtpass.Text, txtprem.Text,   ID);
                    PL.FDGE fedit = new FDGE();
                    fedit.Show();
                    this.Close();
                }

            }
        }
    }
    
}
