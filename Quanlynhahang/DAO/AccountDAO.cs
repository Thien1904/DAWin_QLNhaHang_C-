using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool login(string userName, string passWord)
        {
            string query = "USP_login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[]{userName , passWord});

            return result.Rows.Count > 0;
        }
        //tạo account mới(lấy các thuộc tính của acc đưa vào) từ username để xử lí đăngnhập
         public List<Account> Getlistfood()
        {


            List<Account> list = new List<Account>();
            string query = "select*from dbo.Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
             }
        public Account GetAccountbyUserName(string UserName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT*FROM dbo.Account WHERE UserName = '" + UserName+"'");
            foreach( DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName , string diaChi , string newPass , string pass, string gioiTinh, string dienThoai)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USPUpdateAccount @useName , @displayName , @diaChi , @newPass , @pass ,  @gioiTinh , @dienThoai", new object[] { userName, displayName, diaChi, newPass , pass, gioiTinh, dienThoai });
            return result > 0;
        }
        #region loadaccount
        public DataTable GetListaccount()
            {
                return DataProvider.Instance.ExecuteQuery("select*from dbo.account");
            }
        #endregion
        #region theem xóa sửa account


        #region hàm thêm account 
                                                                      
        public bool insertaccount(string UserName ,string DisplayName ,int Type  ,string Ngaysinh ,string Diachi ,string Gioitinh ,string DienThoai)
        {
            string query = string.Format(" INSERT dbo.account( UserName , DisplayName , Type , Ngaysinh , Diachi , Gioitinh , DienThoai )VALUES  ( N'{0}' , N'{1}' , {2} , N'{3}' , N'{4}' , N'{5}', N'{6}')", UserName, DisplayName, Type, Ngaysinh, Diachi, Gioitinh, DienThoai);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        #endregion
        #region hàm sửa account
        public bool suaaccount(  string DisplayName, int Type, string Ngaysinh, string Diachi, string Gioitinh, string DienThoai,string UserName)
        {
            string query = string.Format("update dbo.account set DisplayName =  N'{0}' , Type ={1} , Ngaysinh =  N'{2}' , Diachi = N'{3}'  ,  Gioitinh= N'{4}' , DienThoai = N'{5}'   where UserName  = N'{6}'",  DisplayName, Type, Ngaysinh, Diachi, Gioitinh, DienThoai,UserName);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion    }
       
        
        #region hàm xóa account

        public bool xoaaccount(string name)
        {
            string query = string.Format("delete dbo.account where username = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion


        #endregion 


    
        internal void insertaccount(string DisplayName, string Type, string Ngaysinh, string Diachi, string Gioitinh, string DienThoai)
        {
            throw new NotImplementedException();
        }
    
         public List<Account> timaccounttheoten(string name)
        {
            List<Account> list = new List<Account>();


            string query = string.Format("  SELECT *FROM dbo.account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%'+ dbo.fuConvertToUnsign1(N'{0}')+'%'", name);


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

    
    
    
    }
}
