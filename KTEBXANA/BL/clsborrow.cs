using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KTEBXANA.BL
{
    class clsborrow
    {
        DAL.clsdal DAL = new KTEBXANA.DAL.clsdal();
        //Load Data
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADBOR", pr);
            return dt;
        }
        //Load Data BOOK
        public DataTable loadBOOK()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADBOOKSELL", pr);
            return dt;
        }
        //Load Data ST
        public DataTable loadST()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADSTSELL", pr);
            return dt;
        }
        //Insert data
        public void Insert(string BNAME, string BTITLE, string BDATE1, string BDATE2, int PRICE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("BNAME", BNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("BDATE1", BDATE1);
            pr[3] = new SqlParameter("BDATE2", BDATE2);
            pr[4] = new SqlParameter("PRICE", PRICE);
            

            DAL.open();
            DAL.execute("PRINSERTBOR", pr);
            DAL.close();
        }
        //UPDATE data
        public void Update(string BNAME, string BTITLE, string BDATE1, string BDATE2, int PRICE,int ID)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("BNAME", BNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("BDATE1", BDATE1);
            pr[3] = new SqlParameter("BDATE2", BDATE2);
            pr[4] = new SqlParameter("PRICE", PRICE);
            pr[5] = new SqlParameter("ID", ID);


            DAL.open();
            DAL.execute("PREDITBOR", pr);
            DAL.close();
        }
        // DELETE DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PRDELETEBOR", pr);
            DAL.close();
        }
        //SEARCH DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PRSEARCHBOR", pr);
            return dt;
        }
    }
}
