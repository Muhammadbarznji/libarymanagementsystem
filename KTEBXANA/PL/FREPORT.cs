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

    public partial class FREPORT : Form
    {
        BL.clscat BLCAT = new BL.clscat();

        // var for books 
        BL.clsbook BLBOOK = new BL.clsbook();

        // var for ستئدەنت 
        BL.clsst BLST = new BL.clsst();
        // var for SELL 
        BL.clssell BLSELL = new BL.clssell();
        // var for BORROW 
        BL.clsborrow BLBOR = new BL.clsborrow();
        // var for USER 
        BL.clsuser BLUSER = new BL.clsuser();
        public FREPORT()
        {
            InitializeComponent();
        }

        private void FREPORT_Load(object sender, EventArgs e)
        {
            PL.MF Home = new MF();
            lbname.Text = Home.lbname1.Text;
            lbprem.Text = Home.lbprem1.Text;
            lbdate.Text = DateTime.Now.ToString();

            //FORM CHECK NUMBER 
            
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOK.load();
                lbbook.Text = dt.Rows.Count.ToString();
            }
            catch { }
            //--------------
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOR.load();
                lbbor.Text = dt.Rows.Count.ToString();
            }
            catch { }
            //------------
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.load();
                lbcat.Text = dt.Rows.Count.ToString();
            }
            catch { }
            //---------------
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.load();
                lbsell.Text = dt.Rows.Count.ToString();
            }
            catch { }
            //-------------
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.load();
                lbst.Text = dt.Rows.Count.ToString();
            }
            catch { }
            //------------
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.load();
                lbusr.Text = dt.Rows.Count.ToString();
            }
            catch { }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img, 0, 0);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbprem_Click(object sender, EventArgs e)
        {

        }
    }
}
