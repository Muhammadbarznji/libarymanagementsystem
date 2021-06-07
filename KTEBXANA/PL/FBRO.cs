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
    public partial class FBRO : Form
    {
        public int ID;
        public FBRO()
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
            BL.clssell BLSELL = new BL.clssell();
            //LOAD BOOKS 
            DataTable dt1 = new DataTable();
            dt1 = BLSELL.loadBOOK();
            dataGridView2.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = BLSELL.loadST();
            dataGridView1.DataSource = dt2;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            if (txttitle.Text == "")
            {
                PL.FERINS FERR = new FERINS();
                FERR.Show();
            }
            else
            {
                if (ID == 0)
                {

                    // Add
                    BL.clsborrow BLBOR = new BL.clsborrow();
                    BLBOR.Insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txtdate.Value), Convert.ToString(txtdate2.Value), Convert.ToInt32(txttitle.Text));
                    PL.FDADD Fadd = new FDADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    BL.clsborrow BLBOR = new BL.clsborrow();
                    BLBOR.Update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txtdate.Value), Convert.ToString(txtdate2.Value), Convert.ToInt32(txttitle.Text),ID);

                    //// Edit

                    PL.FDGE fedit = new FDGE();
                    fedit.Show();
                    this.Close();
                }
            }
        }
    }
}
