using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class Accountlogin
    {
        private static Accountlogin instance;

        public static Accountlogin Instance
        {
            get { if (instance == null) instance = new Accountlogin(); return instance; }
            private set { instance = value; }
        }

        private Accountlogin() { }

        public bool login(string userName, string passWord)
        {
            string query = "USP_login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[]{userName , passWord});

            return result.Rows.Count > 0;
        }
    }
}
