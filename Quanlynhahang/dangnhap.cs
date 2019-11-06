using Quanlynhahang.DAO;
using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
       {
           string username = txbsign.Text;
           string password =txbpassword .Text;
           if (login(username,password))
           {//tạo 1 acc mới từ tt acc of username 
             Account acclogin = AccountDAO.Instance.GetAccountbyUserName(username);
             tablequanli f = new tablequanli(acclogin);//xuất tbql  theo acc truyền vào
               this.Hide();
               f.ShowDialog();
               this.Show();
           }
           else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu,Xin hãy nhập lại!", "Thông báo");
        }
        bool login(string username,string password)
        {
            return AccountDAO.Instance.login(username, password);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
      
    

    
  
    }
}
