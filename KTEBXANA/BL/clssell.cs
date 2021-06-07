using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KTEBXANA.BL
{
    class clssell
    {
        DAL.clsdal DAL = new KTEBXANA.DAL.clsdal();
        //Load Data
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADSELL", pr);
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
        public void Insert(string SNAME,string BTITLE,int PRICE,string BDATE)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("PRICE", PRICE);
            pr[3] = new SqlParameter("BDATE", BDATE);
            
            DAL.open();
            DAL.execute("PRINSERTSELL", pr);
            DAL.close();
        }
        //UPDATE data
        public void update(string SNAME, string BTITLE, int PRICE, string BDATE,int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("PRICE", PRICE);
            pr[3] = new SqlParameter("BDATE", BDATE);
            pr[4] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.execute("PRUPDATESELL", pr);
            DAL.close();
        }
        // DELETE DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PRDELETESELL", pr);
            DAL.close();
        }
        //SEARCH DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PRSEARCHSELL", pr);
            return dt;
        }

    }
}
