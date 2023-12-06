using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DAO
{
    public class AccDAO
    {
        private static AccDAO instance;

        public static AccDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccDAO() { }
        //form login
        public bool Login(string username, string pass)
        {
            string query = "LOG_IN @username , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, pass }); 
            return result.Rows.Count > 0;
        }
        public Account getAccByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT p.USERNAME, p.DISPLAYNAME, p.PASS, TYPE = CASE WHEN TYPE = 1 THEN 'ADMIN' ELSE 'STAFF' END FROM ACCOUNT p WHERE USERNAME = '" + username +"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        //form accprofile
        public bool updateAccountInfo(string username, string displayname, string pass, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UPDATEACCOUNT @username , @displayname , @pass , @newpass", new object[] { username, displayname, pass, newpass });
            return result > 0;
        }
        //form admin
        public DataTable getListAcc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT USERNAME, DISPLAYNAME,( " +
                "CASE WHEN TYPE = 1 THEN 'ADMIN' ELSE 'STAFF' END) AS TYPE FROM ACCOUNT");
        }        
        public bool insertAcc(string name, string displayname, int type)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("INSERT ACCOUNT (USERNAME, DISPLAYNAME, TYPE) VALUES (N'{0}', N'{1}' , {2} )", name, displayname, type));
            return result > 0;
        }
        public bool updateAcc(string name, string displayname, int type)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE ACCOUNT SET DISPLAYNAME = N'{0}', TYPE = {1} WHERE USERNAME = N'{2}'", displayname, type, name));
            return result > 0;
        }
        public bool deleteAcc(string name)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE ACCOUNT WHERE USERNAME = N'{0}'", name));
            return result > 0;
        }
        public bool resetPass(string name)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE ACCOUNT SET PASS = N'0' WHERE USERNAME = N'{0}'", name));
            return result > 0;
        }
    }
}

