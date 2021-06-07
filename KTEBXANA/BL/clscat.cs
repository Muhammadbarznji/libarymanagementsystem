using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KTEBXANA.BL
{
    class clscat
    {
        DAL.clsdal DAL=new KTEBXANA.DAL.clsdal();
        //Load Data
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADCAT", pr);
            return dt;        
        }
        // SEARCH DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PRSEARCHCAT", pr);
            return dt;
        }
        //Insert data
        public void Insert(string CATNAME)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("CATNAME", CATNAME);
            DAL.open();
            DAL.execute("PRADDCAT", pr);
            DAL.close();
        }
        //update data
        public void Update(string CATNAME, int ID)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CATNAME", CATNAME);
            pr[1] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PREDITCAT", pr);
            DAL.close();
        }

        // DELETE DATA
        public void Delete( int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PRDELETECAT", pr);
            DAL.close();
        }
    }
}
