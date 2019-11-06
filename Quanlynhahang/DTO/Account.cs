using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
   public class Account
    {
       public Account(string userName,string displayName,string passWord, int type,string gioiTinh,string dienthoai, string diaChi, string ngaySinh)
       {
           this.DiaChi = diaChi;
           this.DienThoai = dienThoai;
           this.DisplayName = displayName;
           this.GioiTin = gioiTin;
        
           this.PassWord = passWord;
           this.Type = type;
           this.UserName = userName;
           this.NgaySinh = ngaySinh;

       }
       public Account(DataRow Rows)
       {
           this.DiaChi = Rows["diaChi"].ToString() ;
           this.DienThoai = Rows["dienThoai"].ToString();
           this.DisplayName = Rows["displayName"].ToString();
           this.GioiTin = Rows["gioiTinh"].ToString();
           this.NgaySinh = Rows["ngaySinh"].ToString();
           this.PassWord = Rows["passWord"].ToString();
           this.Type = (int)Rows["type"];
           this.UserName = Rows["userName"].ToString();
           
       }

        private string dienThoai;

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string gioiTin;

        public string GioiTin
        {
            get { return gioiTin; }
            set { gioiTin = value; }
        }
        private string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
           
           private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
       private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


    }
}
