using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace KTEBXANA.BL
{
    class clsbook
    {
        DAL.clsdal DAL = new KTEBXANA.DAL.clsdal();
        //Load Data
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADBOOK", pr);
            return dt;
        }
        // combobox 
        public DataTable LOADCAT()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADCATCOMBOBOX", pr);
            return dt;
        }
        //Insert data
        public void Insert(string TITLE,string AUTHOR,string CAT,string PRICE,string PDATE, int RATE,MemoryStream COVER)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("TITLE", TITLE);
            pr[1] = new SqlParameter("AUTHOR", AUTHOR);
            pr[2] = new SqlParameter("CAT", CAT);
            pr[3] = new SqlParameter("PRICE", PRICE);
            pr[4] = new SqlParameter("PDATE", PDATE);
            pr[5] = new SqlParameter("RATE", RATE);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            DAL.open();
            DAL.execute("PINSERTBOOK", pr);
            DAL.close();
        }
        //Load Data FOR EDIT 
        public DataTable loadedit(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0]=new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PSELECTEDIT", pr);
            return dt;
        }
        //update data
        public void Update(string TITLE, string AUTHOR, string CAT, string PRICE, string PDATE, int RATE, MemoryStream COVER,int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("TITLE", TITLE);
            pr[1] = new SqlParameter("AUTHOR", AUTHOR);
            pr[2] = new SqlParameter("CAT", CAT);
            pr[3] = new SqlParameter("PRICE", PRICE);
            pr[4] = new SqlParameter("PDATE", PDATE);
            pr[5] = new SqlParameter("RATE", RATE);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PREDITBOOK", pr);
            DAL.close();
        }
        // DELETE DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PRDELETEBOOK", pr);
            DAL.close();
        }
        //SEARCH DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PRSEARCHBOOK", pr);
            return dt;
        }
    }
}
