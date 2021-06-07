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
    public partial class FLOGIN : Form
    {
        public FLOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Full Name")
            {           
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "Full Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {

            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Silver;
            }
        }

        private void FLOGIN_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            try
            {
                BL.clsuser CLSUSER = new BL.clsuser();
                DataTable dt = new DataTable();
                dt = CLSUSER.login(txtname.Text, txtpass.Text);
                if (dt.Rows.Count > 0)
                {
                    CLSUSER.Updatelogin(txtname.Text, txtpass.Text);
                    PL.MF FRMMAIN = new MF();
                    object lbname = dt.Rows[0]["CNAME"];
                    object lbprem = dt.Rows[0]["PREMISSION"];
                    FRMMAIN.lbname1.Text = lbname.ToString();
                    FRMMAIN.lbprem1.Text = lbprem.ToString();
                    FRMMAIN.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("زانیاری چوونەژورەوە هەڵەیە");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
