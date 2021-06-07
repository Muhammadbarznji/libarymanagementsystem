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
    class clsst
    {
        DAL.clsdal DAL = new KTEBXANA.DAL.clsdal();
        //Load Data
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADST", pr);
            return dt;
        }
        //Insert data
        public void Insert(string NAME,string TLOCATION,string PHONE,string EMAIL,string SCHOOL,string DEP,MemoryStream COVER)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            DAL.open();
            DAL.execute("PRINSERTST", pr);
            DAL.close();
        }
        //Load Data FOR EDIT 
        public DataTable loadedit(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PSELECTEDITST", pr);
            return dt;
        }
        //update data
        public void Update(string NAME,string TLOCATION,string PHONE,string EMAIL,string SCHOOL,string DEP,MemoryStream COVER, int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PREDITST", pr);
            DAL.close();
        }
        // DELETE DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PRDELETEST", pr);
            DAL.close();
        }
        //SEARCH DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PRSEARCHST", pr);
            return dt;
        }
    }
}