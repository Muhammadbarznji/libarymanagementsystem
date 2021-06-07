using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTEBXANA.PL
{
    public partial class MF : Form
    {
        string state;
        int ID;
        // var for CAT 
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
        public MF()
        {
            InitializeComponent();
        }

        private void sereky_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        { 
            PL.FLOGIN login = new FLOGIN();
            BLUSER.Logout();
            this.Hide();
            login.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            PL.FREPORT reports = new FREPORT();
            reports.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b7_Click(object sender, EventArgs e)
        {
            PM.Visible = false;
            PH.Visible = true;
            bunifuThinButton24.Visible = false;
            txtsearch.Visible = true;
            state = "CAT";
            sereky.Text = "بەشەکان";
            // Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "زنجیرە";
                dataGridView1.Columns[1].HeaderText = "ناوی بەش";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void b1_Click(object sender, EventArgs e)
        {
            PM.Visible = true;
            PH.Visible = false;            
            sereky.Text = "سەرەکی";
        }
        private void b2_Click(object sender, EventArgs e)
        {
            PM.Visible = false;
            PH.Visible = true;
            bunifuThinButton24.Visible = true;
            txtsearch.Visible = true;
            state = "BOOKS";
            sereky.Text = "کتێبەکان";
            // Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOK.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "زنجیرە";
                dataGridView1.Columns[1].HeaderText = "ناوی کتێب";
                dataGridView1.Columns[2].HeaderText = "نووسەر";
                dataGridView1.Columns[3].HeaderText = "جۆری کتێب";
                dataGridView1.Columns[4].HeaderText = "نرخ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b3_Click(object sender, EventArgs e)
        {
            PM.Visible = false;
            PH.Visible = true;
            bunifuThinButton24.Visible = true;
            txtsearch.Visible = true;
            state = "ST";
            sereky.Text = "قوتابیەکان";
            // Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "زنجیرە";
                dataGridView1.Columns[1].HeaderText = "ناوی قوتابی";
                dataGridView1.Columns[2].HeaderText = "ناونیشان";
                dataGridView1.Columns[3].HeaderText = "مۆبایل";
                dataGridView1.Columns[4].HeaderText = "ئیمەیڵ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b4_Click(object sender, EventArgs e)
        {
            PM.Visible = false;
            PH.Visible = true;
            bunifuThinButton24.Visible = true;
            txtsearch.Visible = true;
            state = "SELL";
            sereky.Text = "فرۆشتنەکان";
            // Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "زنجیرە";
                dataGridView1.Columns[1].HeaderText = "ناوی کتێب";
                dataGridView1.Columns[2].HeaderText = "ناوی کڕیار";
                dataGridView1.Columns[3].HeaderText = "نرخ";
                dataGridView1.Columns[4].HeaderText = "بەروار";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b5_Click(object sender, EventArgs e)
        {
            PM.Visible = false;
            PH.Visible = true;
            bunifuThinButton24.Visible = true;
            txtsearch.Visible = true;
            state = "BOR";
            sereky.Text = "داگرتنەکان";
            // Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOR.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "زنجیرە";
                dataGridView1.Columns[1].HeaderText = "ناوی کڕیار";
                dataGridView1.Columns[2].HeaderText = "ناوی کتێب";
                dataGridView1.Columns[3].HeaderText = "بردن";
                dataGridView1.Columns[4].HeaderText = "هێنانەوە";
                dataGridView1.Columns[5].HeaderText = " نرخ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b6_Click(object sender, EventArgs e)
        {
            PM.Visible = false;
            PH.Visible = true;
            bunifuThinButton24.Visible = true;
            txtsearch.Visible = false;
            state = "USER";
            sereky.Text = "بەکارهێنەران";
            // Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "زنجیرە";
                dataGridView1.Columns[1].HeaderText = "ناوی تەواو";
                dataGridView1.Columns[2].HeaderText = "ناوی بەکارهێنەر";
                dataGridView1.Columns[3].HeaderText = "ژمارەی نهێنی";
                dataGridView1.Columns[4].HeaderText = "پلە";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void b8_Click(object sender, EventArgs e)
        {
            // Add BOOK 
            if (state == "BOOKS")
            {
                PL.FADDBOOK fbook = new PL.FADDBOOK();
                fbook.btnaddbook.ButtonText = "زیادکردن";
                fbook.ID = 0;
                bunifuTransition1.ShowSync(fbook);
            }
        }
        private void b9_Click(object sender, EventArgs e)
        {
            if (state == "ST")
            {
                PL.FADDST fst = new PL.FADDST();
                fst.btnaddbook.ButtonText = "زیادکردن";
                fst.ID = 0;
                bunifuTransition1.ShowSync(fst);
            }
        }
        private void b10_Click(object sender, EventArgs e)
        {
            // Add SELL 
            if (state == "SELL")
            {
                PL.FADDSELL fsell = new PL.FADDSELL();
                fsell.btnaddbook.ButtonText = "زیادکردن";
                fsell.ID = 0;
                bunifuTransition1.ShowSync(fsell);
            }
        }
        private void b11_Click(object sender, EventArgs e)
        {
            // Add BOR 
            if (state == "BOR")
            {
                PL.FBRO fbor = new PL.FBRO();
                fbor.btnaddbook.ButtonText = "زیادکردن";
                fbor.ID = 0;
                bunifuTransition1.ShowSync(fbor);
            }
        }
        private void b12_Click(object sender, EventArgs e)
        {
            // Add category 
            if (state == "CAT")
            {
                PL.FADDCAT FCAT = new FADDCAT();
                FCAT.btnadd.ButtonText = "زیادکردن";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
            }
        }
        private void PB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (PB.Size.Width == 175)
            {
                PB.Width = 55;
                b1.RightToLeft = RightToLeft.Yes;
                b2.RightToLeft = RightToLeft.Yes;
                b3.RightToLeft = RightToLeft.Yes;
                b4.RightToLeft = RightToLeft.Yes;
                b5.RightToLeft = RightToLeft.Yes;
                b6.RightToLeft = RightToLeft.Yes;
                b7.RightToLeft = RightToLeft.Yes;
                lbname1.Visible = false;
                lbprem1.Visible = false;
            }
            else
            {
                PB.Width = 175;
                b1.RightToLeft = RightToLeft.No;
                b2.RightToLeft = RightToLeft.No;
                b3.RightToLeft = RightToLeft.No;
                b4.RightToLeft = RightToLeft.No;
                b5.RightToLeft = RightToLeft.No;
                b6.RightToLeft = RightToLeft.No;
                b7.RightToLeft = RightToLeft.No;
                lbname1.Visible = true;
                lbprem1.Visible = true;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            // SEARCH category 
            if (state == "CAT")
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Search(txtsearch.Text);
                dataGridView1.DataSource = dt;

            }
            // SEARCH BOOKS 
            if (state == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLBOOK.Search(txtsearch.Text);
                dataGridView1.DataSource = dt;

            }
            // SEARCH STUDENT 
            if (state == "ST")
            {
                DataTable dt = new DataTable();
                dt = BLST.Search(txtsearch.Text);
                dataGridView1.DataSource = dt;

            }
            // SEARCH SELL 
            if (state == "SELL")
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Search(txtsearch.Text);
                dataGridView1.DataSource = dt;

            }
            // SEARCH BORROW 
            if (state == "BOR")
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Search(txtsearch.Text);
                dataGridView1.DataSource = dt;

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            // DELETE category 
            if (state == "CAT")
            {
                BLCAT.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FDELETE fdel = new FDELETE();
                fdel.Show();
            }
            //DELETE BOOKS
            else if (state == "BOOKS")
            {
                BLBOOK.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FDELETE fdel = new FDELETE();
                fdel.Show();
            }
            //DELETE STUDENT

            else if (state == "ST")
            {
                BLST.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FDELETE fdel = new FDELETE();
                fdel.Show();
            }
             //DELETE SELL

            else if (state == "SELL")
            {
                BLSELL.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FDELETE fdel = new FDELETE();
                fdel.Show();
            }
            //DELETE BORROW

            else if (state == "BOR")
            {
                BLBOR.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FDELETE fdel = new FDELETE();
                fdel.Show();
            }
            //DELETE USER

            else if (state == "USER")
            {
                BLUSER.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FDELETE fdel = new FDELETE();
                fdel.Show();
            }
        }

        private void FMLOAD(object sender, EventArgs e)
        {
            PM.Visible = true;
            PH.Visible = false;
            sereky.Text = "سەرەکی";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Add category 
            if (state == "CAT")
            {
                PL.FADDCAT FCAT = new FADDCAT();
                FCAT.btnadd.ButtonText = "زیادکردن";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
            }
            // Add BOOK 
            if (state == "BOOKS")
            {
                PL.FADDBOOK fbook = new PL.FADDBOOK();
                fbook.btnaddbook.ButtonText = "زیادکردن";
                fbook.ID = 0;
                bunifuTransition1.ShowSync(fbook);
            }
            // Add STUDENT 
            if (state == "ST")
            {
                PL.FADDST fbook = new PL.FADDST();
                fbook.btnaddbook.ButtonText = "زیادکردن";
                fbook.ID = 0;
                bunifuTransition1.ShowSync(fbook);
            }
            // Add SELL 
            if (state == "SELL")
            {
                PL.FADDSELL fsell = new PL.FADDSELL();
                fsell.btnaddbook.ButtonText = "زیادکردن";
                fsell.ID = 0;
                bunifuTransition1.ShowSync(fsell);
            }
             // Add BOR 
            if (state == "BOR")
            {
                PL.FBRO fbor = new PL.FBRO();
                fbor.btnaddbook.ButtonText = "زیادکردن";
                fbor.ID = 0;
                bunifuTransition1.ShowSync(fbor);
            }
            // Add SELL 
            if (state == "USER")
            {
                PL.FADDUSER fuser = new PL.FADDUSER();
                fuser.btnaddbook.ButtonText = "زیادکردن";
                fuser.ID = 0;
                bunifuTransition1.ShowSync(fuser);
            }

        }

        private void MF_Activated(object sender, EventArgs e)
        {
            //FORM CHECK NUMBER 
            //BOOK
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOK.load();
                lbbook.Text = dt.Rows.Count.ToString();               
            }
            catch  { }
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


            //FORM PREM 
            if (lbprem1.Text == "بەرێوبەر")
            {
                bunifuThinButton23.Enabled = true;
                b6.Enabled = true;
            }
            else
            {
                bunifuThinButton23.Enabled = false;
                b6.Enabled = false;
            }

            if (state == "CAT")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "زنجیرە";
                    dataGridView1.Columns[1].HeaderText = "ناوی بەش";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (state == "BOOKS")
            {
                PM.Visible = false;
                PH.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "BOOKS";
                sereky.Text = "کتێبەکان";
                // Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOOK.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "زنجیرە";
                    dataGridView1.Columns[1].HeaderText = "ناوی کتێب";
                    dataGridView1.Columns[2].HeaderText = "نووسەر";
                    dataGridView1.Columns[3].HeaderText = "جۆری کتێب";
                    dataGridView1.Columns[4].HeaderText = "نرخ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (state == "ST")
            {
                PM.Visible = false;
                PH.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "ST";
                sereky.Text = "قوتابیەکان";
                // Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLST.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "زنجیرە";
                    dataGridView1.Columns[1].HeaderText = "ناوی قوتابی";
                    dataGridView1.Columns[2].HeaderText = "ناونیشان";
                    dataGridView1.Columns[3].HeaderText = "مۆبایل";
                    dataGridView1.Columns[4].HeaderText = "ئیمەیڵ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(state=="SELL")
            {
                PM.Visible = false;
                PH.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "SELL";
                sereky.Text = "فرۆشتنەکان";
                // Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSELL.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "زنجیرە";
                    dataGridView1.Columns[1].HeaderText = "ناوی کتێب";
                    dataGridView1.Columns[2].HeaderText = "ناوی کڕیار";
                    dataGridView1.Columns[3].HeaderText = "نرخ";
                    dataGridView1.Columns[4].HeaderText = "بەروار";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (state == "BOR")
            {
                PM.Visible = false;
                PH.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "BOR";
                sereky.Text = "خواستنەکان";
                // Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOR.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "زنجیرە";
                    dataGridView1.Columns[1].HeaderText = "ناوی کڕیار";
                    dataGridView1.Columns[2].HeaderText = "ناوی کتێب";
                    dataGridView1.Columns[3].HeaderText = "سەرەتای داگرتن";
                    dataGridView1.Columns[4].HeaderText = "کۆتایی داگرتن";
                    dataGridView1.Columns[5].HeaderText = " نرخ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if(state=="USER")
                {
                    PM.Visible = false;
                    PH.Visible = true;
                    bunifuThinButton24.Visible = true;
                    state = "USER";
                    sereky.Text = "بەکارهێنەران";
                    // Load data
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = BLUSER.load();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].HeaderText = "زنجیرە";
                        dataGridView1.Columns[1].HeaderText = "ناوی تەواو";
                        dataGridView1.Columns[2].HeaderText = "ناوی بەکارهێنەر";
                        dataGridView1.Columns[3].HeaderText = "ژمارەی نهێنی";
                        dataGridView1.Columns[4].HeaderText = "پلە";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // Edit category 
            if (state == "CAT")
            {
                PL.FADDCAT FCAT = new FADDCAT();
                FCAT.btnadd.ButtonText = "چاککردن";
                FCAT.txtcatname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);
            }

            //EDIT BOOKS
            else if (state == "BOOKS")
            {
                try
                {
                    PL.FADDBOOK FBOOK = new FADDBOOK();
                    FBOOK.btnaddbook.ButtonText = "چاککردن";
                    FBOOK.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLBOOK.loadedit(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHOR"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["PDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FBOOK.txttitle.Text = obj1.ToString();
                    FBOOK.txtauthor.Text = obj2.ToString();
                    FBOOK.comboBox1.Text = obj3.ToString();
                    FBOOK.txtprice.Text = obj4.ToString();
                    FBOOK.txtdate.Value = (DateTime)obj5;
                    FBOOK.txtrate.Value = (int)obj6;
                    // load image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FBOOK.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FBOOK);
                }
                catch (Exception ex)
                {

                }
            }
            //EDIT STUDENT
            else if (state == "ST")
            {
                try
                {
                    PL.FADDST FST = new FADDST();
                    FST.btnaddbook.ButtonText = "چاککردن";
                    FST.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLST.loadedit(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["NAME"];
                    object obj2 = dt.Rows[0]["TLOCATION"];
                    object obj3 = dt.Rows[0]["PHONE"];
                    object obj4 = dt.Rows[0]["EMAIL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEP"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FST.txtname.Text = obj1.ToString();
                    FST.txtlocation.Text = obj2.ToString();
                    FST.txtmobile.Text = obj3.ToString();
                    FST.txtemail.Text = obj4.ToString();
                    FST.txtsc.Text = obj5.ToString();
                    FST.txtdep.Text = obj6.ToString();
                    // load image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FST.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FST);
                }
                catch (Exception ex)
                {

                }
            }
            //EDIT SELL
            else if (state == "SELL")
            {
                try
                {
                    PL.FADDSELL FSELL = new FADDSELL();
                    FSELL.btnaddbook.ButtonText = "چاککردن";
                    FSELL.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                   
                    bunifuTransition1.ShowSync(FSELL);
                }
                catch (Exception ex)
                {

                }
            }
            //EDIT BOR
            else if (state == "BOR")
            {
                try
                {
                    PL.FBRO FBOR = new FBRO();
                    FBOR.btnaddbook.ButtonText = "چاککردن";
                    FBOR.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                    bunifuTransition1.ShowSync(FBOR);
                }
                catch (Exception ex)
                {

                }
            }
            //EDIT USER
            else if (state == "USER")
            {
                try
                {
                    PL.FADDUSER FUSER = new FADDUSER();
                    FUSER.btnaddbook.ButtonText = "چاککردن";
                    FUSER.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                    bunifuTransition1.ShowSync(FUSER);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            // detail book
            if (state == "BOOKS")
            {
                try
                {



                    DataTable dt = new DataTable();
                    dt = BLBOOK.loadedit(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHOR"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["PDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    PL.FDETAILBOOK DETBOOK = new FDETAILBOOK();
                    DETBOOK.txttitle.Text = obj1.ToString();
                    DETBOOK.txtauthor.Text = obj2.ToString();
                    DETBOOK.txtcat.Text = obj3.ToString();
                    DETBOOK.txtprice.Text = obj4.ToString();
                    DETBOOK.txtdate.Value = (DateTime)obj5;
                    DETBOOK.txtrate.Value = (int)obj6;
                    // load image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    DETBOOK.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(DETBOOK);
                }
                catch (Exception ex)
                {

                }
            }
            //EDIT STUDENT
            else if (state == "ST")
            {
                try
                {
                    PL.FDETAILST FST = new FDETAILST();                 
                    DataTable dt = new DataTable();
                    dt = BLST.loadedit(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["NAME"];
                    object obj2 = dt.Rows[0]["TLOCATION"];
                    object obj3 = dt.Rows[0]["PHONE"];
                    object obj4 = dt.Rows[0]["EMAIL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEP"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FST.txtname.Text = obj1.ToString();
                    FST.txtlocation.Text = obj2.ToString();
                    FST.txtmobile.Text = obj3.ToString();
                    FST.txtemail.Text = obj4.ToString();
                    FST.txtsc.Text = obj5.ToString();
                    FST.txtdep.Text = obj6.ToString();
                    // load image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FST.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FST);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbname1_Click(object sender, EventArgs e)
        {

        }
    }
}
