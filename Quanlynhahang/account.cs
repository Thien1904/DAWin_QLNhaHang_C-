using Quanlynhahang.DAO;
using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class account : Form
    {
        private Account acclogin;

        public Account Acclogin
        {
            get { return acclogin; }
            set { acclogin = value; kiemtraacc(acclogin); }
        }
        private DataRow item;

        public account(Account acc)
        {
            InitializeComponent();
            Acclogin = acc;
        }
        void kiemtraacc(Account acc)
        {
            txbdiachi.Text = Acclogin.DiaChi;
            txbgioitinh.Text = Acclogin.GioiTin;
            txbngaysinh.Text = Acclogin.NgaySinh;
            txpdienthoai.Text = Acclogin.DienThoai;
            txbtendangnhap.Text = Acclogin.UserName;
            txbtenhienthi.Text = Acclogin.DisplayName;
            if(Acclogin.Type==1)
            {
                txbtype.Text = "Quản Trị Viên";
            }
            else txbtype.Text = "Người Dùng";
        }
        public account(DataRow item)
        {
            // TODO: Complete member initialization
            this.item = item;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void labtendangnhap_Click(object sender, EventArgs e)
        {

        }

        private void account_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void account_Load(object sender, EventArgs e)
        {

        }


        private void btncapnhat_Click(object sender, EventArgs e)
        {

            string displayName = txbtenhienthi.Text;
            string diaChi = txbdiachi.Text;        
            string gioiTinh= txbgioitinh.Text;
            string userName = txbtendangnhap.Text;
            string dienThoai = txpdienthoai.Text;
            string passWord = txbmatkhau.Text;
            string newPass = txbnewpass.Text;
            string repass = txbnewpassagain.Text;
            string ngaySinh = txbngaysinh.Text;      
            if(!newPass.Equals(repass))
            { MessageBox.Show("Hãy nhập mật khẩu đúng với mật khẩu mới", "Thông Báo"); }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, diaChi, newPass, passWord,  gioiTinh, dienThoai))
                {
                    MessageBox.Show("Đã Cập Nhật", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Mật khẩu bạn điền chưa chính xác", "Thông Báo");
                }
            }
            
        }
        }
    }

