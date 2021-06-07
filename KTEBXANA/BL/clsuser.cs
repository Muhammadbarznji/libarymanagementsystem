using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KTEBXANA.BL
{
    class clsuser
    {
        DAL.clsdal DAL = new KTEBXANA.DAL.clsdal();
        //Load Data
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOADUSER", pr);
            return dt;
        }
        //INSERT 
        public void Insert(string CNAME, string CUSER, string CPASSWORD, string PREMISSION, string STATES)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("PREMISSION", PREMISSION);
            pr[4] = new SqlParameter("STATES", STATES);

            DAL.open();
            DAL.execute("PRINSERTUSER", pr);
            DAL.close();
        }
        //UPDATE 
        public void Update(string CNAME, string CUSER, string CPASSWORD, string PREMISSION, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("PREMISSION", PREMISSION);
            pr[4] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.execute("PREDITUSER", pr);
            DAL.close();
        }
        // DELETE DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.execute("PRDELETEUSER", pr);
            DAL.close();
        }
        // LOGOUT
        public void Logout()
        {
            SqlParameter[] pr = null;
           
            DAL.open();
            DAL.execute("PRLOGOUT", pr);
            DAL.close();
        }
        //Load Data LOGIN
        public DataTable login(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];         
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PRLOGIN", pr);
            return dt;
        }
        //UPDATE  LOGIN
        public void Updatelogin(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);

            DAL.open();
            DAL.execute("PRUPDATELOGIN", pr);
            DAL.close();
        }
        //Load Data FOR START
        public DataTable STARTLOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PRSTART", pr);
            return dt;
        }
    }
}
