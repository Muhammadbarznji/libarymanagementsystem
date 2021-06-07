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
    public partial class FSTART : Form
    {
        public FSTART()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.clsuser USRFRM = new BL.clsuser();
            DataTable dt = new DataTable();
            dt = USRFRM.STARTLOAD();
            if(dt.Rows.Count > 0)
            {
                PL.MF FRMMAIN = new MF();
                object lbname = dt.Rows[0]["CNAME"];
                object lbprem = dt.Rows[0]["PREMISSION"];
                FRMMAIN.lbname1.Text = lbname.ToString();
                FRMMAIN.lbprem1.Text = lbprem.ToString();
                FRMMAIN.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            else
            {
                PL.FLOGIN FRMLOGIN = new FLOGIN();
                FRMLOGIN.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
