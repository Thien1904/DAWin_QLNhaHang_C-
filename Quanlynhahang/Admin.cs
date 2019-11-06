using Quanlynhahang.DAO;
using Quanlynhahang.DTO;
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class Admin : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource foodList = new BindingSource();
        BindingSource tablelist = new BindingSource();
       
        public Account accnow;
        public Admin()
        {

            InitializeComponent();
            load();
        }
        void load()
        {
           
            dtgvtaikhoan.DataSource = accountList;
            dtgvfood.DataSource = foodList;
            dtgvtablefood.DataSource = tablelist;
            loadlistfood();
            Loadtablefood();
            LoadAccount();
            loadcategory(cbbcategory);

            loadlistbill(dtpf.Value, dtpt.Value);
            foodbiding();
            tablefoodbiding();
            accountbiding();
        }



        #region loadtable food,Loadtablefood
        private void Loadtablefood()
        {
            tablelist.DataSource = TableDAO.Instance.LoadtableList();
            dtgvtablefood.Columns[0].HeaderText = "Mã Bàn Ăn";
            dtgvtablefood.Columns[1].HeaderText = "Tên Bàn Ăn";
            dtgvtablefood.Columns[2].HeaderText = "Trạng Thái";
            dtgvtablefood.Columns[0].Width = 180;
            dtgvtablefood.Columns[1].Width = 225;
            dtgvtablefood.Columns[2].Width = 230;

        }

        void loadlistfood()//danh sách món ăn
        {
            foodList.DataSource = FoodDAO.Instance.Getlistfood();

            dtgvfood.Columns[0].HeaderText = "Số Thứ Tự";
            dtgvfood.Columns[1].HeaderText = "Tên Món Ăn";
            dtgvfood.Columns[2].HeaderText = "Loại Món Ăn";
            dtgvfood.Columns[3].HeaderText = "Giá";
            dtgvfood.Columns[0].Width = 80;
            dtgvfood.Columns[1].Width = 420;
            dtgvfood.Columns[2].Width = 80;
            dtgvfood.Columns[3].Width = 130;

        }
        void loadcategory(ComboBox cbb)
        {
            cbb.DataSource = CategoryDAO.Instance.GetListCategory();
            cbb.DisplayMember = "Name";
        }
        /* void LoadAccountList()
         {

             string query = "EXEC dbo.accountshow";


             // DataProvider provider = new DataProvider();// nếu đã dung instance thì không cần phải tạo ra 1 nguồn lấy dữ liệu mối khi cần lấy dữ liệu nữa

             dtgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "admin" });
             dtgvtaikhoan.Columns[1].Width = 160;
             dtgvtaikhoan.Columns[2].Width = 90;
             dtgvtaikhoan.Columns[3].Width = 90;
             dtgvtaikhoan.Columns[4].Width = 250;
             dtgvtaikhoan.Columns[5].Width = 100;
             dtgvtaikhoan.Columns[7].Width = 40;
         }*/
        #endregion

        #region load account
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListaccount();

            dtgvtaikhoan.Columns[0].HeaderText = "Tên Đăng Nhập";
            dtgvtaikhoan.Columns[1].HeaderText = "Họ Và Tên";
            dtgvtaikhoan.Columns[2].HeaderText = "Mật Khẩu";
            dtgvtaikhoan.Columns[3].HeaderText = "Ngày Sinh";
            dtgvtaikhoan.Columns[4].HeaderText = "Địa Chỉ";
            dtgvtaikhoan.Columns[5].HeaderText = "Giới Tính";
            dtgvtaikhoan.Columns[6].HeaderText = "Điện Thoại";
            dtgvtaikhoan.Columns[7].HeaderText = "Loại";
            
            dtgvtaikhoan.Columns[1].Width = 160;        
            dtgvtaikhoan.Columns[3].Width = 110;
            dtgvtaikhoan.Columns[4].Width = 250;
            dtgvtaikhoan.Columns[5].Width = 80;
            dtgvtaikhoan.Columns[6].Width = 120;           
            dtgvtaikhoan.Columns[7].Width = 40;
            dtgvtaikhoan.Columns[0].Width = 120;



        }
        #endregion
       
        #region hàm binding
        //binding food
        void foodbiding()//tạo biding để load các  thuộc tính của food từ dtgv vào các txbox
        {
            //,true,DataSourceUpdateMode.Never ĐỂ KHI THAY ĐỔI dữ liệu TRONG Txb trong datagrv  không bị thay đổi (true: tự ép kiểu trong dtgv vàt txb,DataSourceUpdateMode.Never: k thay đổi gtrij 2 bên )
            txbtenmon.DataBindings.Add(new Binding("Text", dtgvfood.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbid.DataBindings.Add(new Binding("Text", dtgvfood.DataSource, "id", true, DataSourceUpdateMode.Never));
            nmgia.DataBindings.Add(new Binding("Value", dtgvfood.DataSource, "price", true, DataSourceUpdateMode.Never));
           //

        }
        //binding tablefood
        void tablefoodbiding()
        {
            txbtentablefood.DataBindings.Add(new Binding("Text", dtgvtablefood.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbidtablefood.DataBindings.Add(new Binding("Text", dtgvtablefood.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbstatustablefood.DataBindings.Add(new Binding("Text", dtgvtablefood.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        //binding account
        void accountbiding()
        {   
            txbgioitinh.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "gioitinh", true, DataSourceUpdateMode.Never)); 
            txbtentaikhoan.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbmatkhau.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "password", true, DataSourceUpdateMode.Never)); 
            txbtenhienthi.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txbngaysinh.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "Ngaysinh", true, DataSourceUpdateMode.Never));  
            txbsodienthoai.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "DienThoai", true, DataSourceUpdateMode.Never)); 
            txbloaitaikhoan.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "Type", true, DataSourceUpdateMode.Never));            
            txbdiachi.DataBindings.Add(new Binding("Text", dtgvtaikhoan.DataSource, "Diachi", true, DataSourceUpdateMode.Never));         
        }
    

        #endregion


        #region MessageBoxFormClosing

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;


            }
        }
        #endregion

        #region xuất doanh thu
        #region load những bill đã thanh toán rồi
        void loadlistbill(DateTime checkin, DateTime checkout)//load những bill đã thanh toán rồi
        {         
            dtgvdoanhthu.DataSource = billDAO.Instance.GetListBill(checkin, checkout);
            dtgvdoanhthu.Columns[0].Width = 115;
            dtgvdoanhthu.Columns[1].Width = 120;
            dtgvdoanhthu.Columns[2].Width = 120;
            dtgvdoanhthu.Columns[3].Width = 140;
            dtgvdoanhthu.Columns[4].Width = 390;



        }
        #endregion

        #region khi click button xuat doanhthu
        private void buttonxuat_Click(object sender, EventArgs e)
        {
            loadlistbill(dtpf.Value, dtpt.Value);
        }
        #endregion
        #endregion

        #region sự kiện khi idfood thay đổi hiển thị category tương ứng
        private void txbid_TextChanged(object sender, EventArgs e)
        {

            //khi id mon an thay doi cartegory thay doi theo
            try
            {
                if (dtgvfood.SelectedCells.Count > 0)
                {

                    int id = (int)dtgvfood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;//từ 1 ô đang  chọn trong dtgv lấy dòng, lấy dòng đang chứa ô đó và lấy ra thuộc tính idcategory từ dòng đó

                    Category category = CategoryDAO.Instance.GetCategoryById(id);
                    cbbcategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbbcategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i; break;
                        }

                        i++;

                    }
                    cbbcategory.SelectedIndex = index;
                }

            }
            catch { }
        }
        #endregion




        #region Mẫu xuẩt trong dtgv
        /*
            string ConnectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyQuanan;Integrated Security=True";
            //string ConnectionSTR alà chuỗi kết nối để biết cấn kết nối đến cơ sở dữ liệu nào
            SqlConnection connection = new SqlConnection(ConnectionSTR);//tạo 1 kết nối qua sql(2)
            connection.Open();
            string query = "SELECT*FROM dbo.Account";//chạy câu truy vấn để biết lấy cái gì từ data base
            //Nếu xuất * là xuất toàn bộ thông tin muốn xuất đơn lẻ thay "*" = tenthongtin1,tenthongtin2
           //  Vd:string query = "SELECT UserName,DisplayName FROM dbo.Account";
            // thay đổi tiêu đề cột: string query = "SELECT UserName as [tên đăng nhập] FROM dbo.Account"; 
            SqlCommand command = new SqlCommand(query, connection);// (3)chỉ định thực hiện cau query từ kết nố       
            SqlDataAdapter adapter = new SqlDataAdapter(command);//(trung gian đê lấy dữ liệu ra( thực thi câu truy vấn số (3)))
            DataTable data = new DataTable();//(4)khai báo 1 dât table để đổ dữ liệu vào
            adapter.Fill(data);//đổ dữ liệu đã lấy ra vào data số (4)
            connection.Close();

            dgvtaikhoan.DataSource = data;//chỉnh kích thước các cột trong dgvtaikhoan
            dgvtaikhoan.Columns[0].Width = 200;
            dgvtaikhoan.Columns[1].Width = 213;
            dgvtaikhoan.Columns[2].Width = 120;
            //dgvtaikhoan.AutoResizeRows();//(xuất thông tin đã được lấy ra ở dgvtaikhoan(AutoResizeRows:tự động đổi kích cỡ hàng ) )
            */
        #endregion
        #region thêm sửa xóa món ăn
        #region Hàm thêm món ăn
        private void btnadd_Click(object sender, EventArgs e)
        {
            string name = txbtenmon.Text;
            int idcategory = (cbbcategory.SelectedItem as Category).ID;
            float gia = (float)nmgia.Value;

            if (FoodDAO.Instance.InsertFood(name, idcategory, gia) && (name != "") && (gia > 0))
            {
                MessageBox.Show("Bạn Đã Thêm Món Thành Công." + "\n" + "Thông Tin Chi Tiết Món Bạn Vừa Thêm Là: " + "\n\n" + "Tên Món Ăn: " + name + "\n" + "Giá Của Món Ăn: " + gia + " VNd", "Thông báo Thêm Món Mới Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistfood();
                if (themmonan != null)//kiểm tra nếu có thay đổi dữ liệu thì load lại ngay
                {
                    themmonan(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm Món, Hãy Chắc Chắn Bạn Đã Điền Đầy Đủ Thông Tin", "Thông Báo Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning );

            }

        }
        #endregion
        #region Hàm sửa thông tin món ăn
        private void btnsua_Click(object sender, EventArgs e)
        {

            string name = txbtenmon.Text;
            int idcategory = (cbbcategory.SelectedItem as Category).ID;
            float gia = (float)nmgia.Value;
            int id = Convert.ToInt32(txbid.Text);
            if (FoodDAO.Instance.updatefood(name, idcategory, gia, id) && (name != "") && (gia > 0))
            {
                MessageBox.Show("Bạn Đã Sửa Món Ăn Thành Công." + "\n" + "Thông Tin Chi Tiết Món Bạn Vừa Sửa Thành: " + "\n\n" + "Tên Món Ăn: " + name + "\n" + "Giá Của Món Ăn: " + gia + " VNd", "Thông báo Sửa Món Ăn Thành Công", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                loadlistfood();
                if (suamonan != null)//kiểm tra nếu có thay đổi dữ liệu thì load lại ngay
                    suamonan(this, new EventArgs());
            }

            else
            {
                MessageBox.Show("Có Lỗi Khi Sửa Thông Tin Món Ăn, Hãy Chắc Chắn Bạn Đã Điền Đầy Đủ Thông Tin", "Thông Báo Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }
        #endregion
        #region hàm xóa món ăn
        private void btnxoa_Click(object sender, EventArgs e)
        {
            int idcategory = (cbbcategory.SelectedItem as Category).ID;
            int id = Convert.ToInt32(txbid.Text);
            string name = txbtenmon.Text;
            float gia = (float)nmgia.Value;
            if (FoodDAO.Instance.deletefood(id) && (name != "") && (gia > 0))
            {
                MessageBox.Show("Bạn Đã Xóa Món Ăn Thành Công." + "\n" + "Thông Tin Chi Tiết Món Bạn Vừa Xóa là: " + "\n\n" + "Tên Món Ăn: " + name + "\n" + "Giá Của Món Ăn: " + gia + " VNd", "Thông báo Xóa Món Ăn Thành Công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                loadlistfood();
                if (xoamonan != null)//kiểm tra nếu có thay đổi dữ liệu thì load lại ngay
                    xoamonan(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa Món Ăn, Các Thuộc Tính Không Được Để Trống", "Thông Báo Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }
        #endregion
        #region load lại dtgv
        private void btnxem_Click(object sender, EventArgs e)
        {
            buit();
        }
        #endregion
        #region nút load lại trang
        public void buit()
        {
            loadlistfood();
        }

        #endregion
        #endregion
        #region các event cập nhật tức thời thêm xóa sửa
        private event EventHandler themmonan;
        public event EventHandler Themmonan
        {
            add { themmonan += value; }
            remove { themmonan -= value; }
        }
        private event EventHandler suamonan;
        public event EventHandler Suamonan
        {
            add { suamonan += value; }
            remove { suamonan -= value; }
        }
        private event EventHandler xoamonan;
        public event EventHandler Xoamonan
        {
            add { xoamonan += value; }
            remove { xoamonan -= value; }
        }

        #endregion
        #region Tìm kiếm món ăn


        public List<Food> timfoodtheoten(string name)
        {
            List<Food> list = new List<Food>();
            #region rb
            if (rdbtnchinhxac.Checked)
            {
                list = FoodDAO.Instance.timfoodtheotenchinhxac(name);
            }
            else if (rdbttuongdoi.Checked)
            {
                list = FoodDAO.Instance.timfoodtheotentuongdoi(name);
            }
            else if (rdbtngandung.Checked)
            {
                list = FoodDAO.Instance.timfoodtheotengandung(name);
            }
            #endregion
            return list;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            foodList.DataSource = timfoodtheoten(txbtimfood.Text);
        }
        #endregion
        #region tìm Account
        public List<Account> timaccounttheoten(string name)
        {
            List<Account> list = new List<Account>();         
                list = AccountDAO.Instance.timaccounttheoten(name);
                return list;
        }
        private void btntimaccount_Click_1(object sender, EventArgs e)
        {

            dtgvtaikhoan.DataSource = timaccounttheoten(txbtimaccount.Text);
    
        }
    
        #endregion


        #region maxidtablefood
        public int GetMaxIDTableFood()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX (id) FROM dbo.TableFood");
            }
            catch
            {
                return 1;
            }
        }//đã lấy được idmaxtablefood
        #endregion

        private void btnload_Click(object sender, EventArgs e)
        {
            Loadtablefood();
        }
        // if (FoodDAO.Instance.InsertFood(name, idcategory, gia) && (name != "") && (gia > 0))
        private void btnthembanan_Click(object sender, EventArgs e)
        {
            int id = GetMaxIDTableFood(); id++;
            string name = txbtentablefood.Text;
            string status = txbstatustablefood.Text;
            if ((TableDAO.Instance.InserttableFood(name, status)) && (name != "") && ((status == "Trống") || (status == "Có người")))
            {
                MessageBox.Show("Bạn Đã Thêm Bàn Ăn Thành Công." + "\n" + "Thông Tin Chi Tiết Bàn Ăn Bạn Vừa Thêm Là: " + "\n\n" + "Tên Bàn Ăn: " + name + "\n" + "Trạng Thái: " + status + "\n\n" + "Mã bàn là: " + id + "\n", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Loadtablefood();
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm bàn Ăn, Hãy Chắc Chắn Bạn Đã Điền Đầy Đủ Thông Tin", "Thông Báo Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            }

        }


        #region Hàm sửa thông tin bàn ĂN
        private void btnsuatablefood_Click(object sender, EventArgs e)
        {
            string name = txbtentablefood.Text;
            string status = txbstatustablefood.Text;
            int idtablefood = Convert.ToInt32(txbidtablefood.Text);
            if ((TableDAO.Instance.updatetablefood(name, status, idtablefood)) && (name != "") && ((status == "Trống") || (status == "Có người")))
            {
                MessageBox.Show("Bạn Đã Sửa Bàn Ăn Thành Công." + "\n" + "Thông Tin Chi Tiết Bàn Ăn Bạn Vừa Sửa Thành: " + "\n" + "Tên Bàn Ăn: " + name + "\n" + "Trạng Thái: " + status, "Thông báo Sửa Món Ăn Thành Công", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Loadtablefood();

            }

            else
            {
                MessageBox.Show("Có Lỗi Khi Sửa Thông bàn, Hãy Chắc Chắn Bạn Đã Điền Đầy Đủ Thông Tin", "Thông Báo Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        #endregion
        private void btnxemaccount_Click(object sender, EventArgs e)//load lisaccount
        {
            LoadAccount();

        }
        private void btnxoabanan_Click(object sender, EventArgs e)
        {
            string name = txbtentablefood.Text;
            int idtablefood = Convert.ToInt32(txbidtablefood.Text);
            if (TableDAO.Instance.deletetablefood(idtablefood))
            {
                MessageBox.Show("Bạn Đã Xóa Bàn Ăn Thành Công." + "\n" + "Thông Tin Chi Tiết Bàn Ăn Bạn Vừa Xóa là: " + "\n\n" + "Tên Bàn Ăn: " + name + "\n", "Thông báo Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadtablefood();

            }

            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa Bàn Ăn, Hãy Chắc Chắn Bạn Đã Điền Đầy Đủ Thông Tin", "Thông Báo Lỗi",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        #region thêm xóa sửa account

        #region thêm account
        void themaccount(string UserName, string DisplayName, int Type, string Ngaysinh, string Diachi, string Gioitinh, string DienThoai)
        {
            if ((UserName != "") && (DisplayName != "") && (Type == 0 || Type == 1) && (Ngaysinh != "") && (Diachi != "") && (Gioitinh == "Nam" || Gioitinh == "Nữ") && (DienThoai != ""))
            {
                if (AccountDAO.Instance.insertaccount(UserName, DisplayName, Type, Ngaysinh, Diachi, Gioitinh, DienThoai))
                {
                    MessageBox.Show("Thêm tài khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadAccount();
            }
            else
            {

                if ((Type != 0 || Type == 1) && (UserName == "" || DisplayName == "" || Diachi == "" || DienThoai == "" || Gioitinh == ""))
                {
                    MessageBox.Show("Thêm Tài Khoản Thất bại" + "\n" + "Bạn chỉ được chọn loại tài khoản là Người dùng hoặc Quản trị viên! Và Cũng không được bỏ trống thông tin nào!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information );
                
                }
                else
                    if ((Type != 0 || Type == 1))
                    {

                        MessageBox.Show("Thêm Tài Khoản Thất bại" + "\n" + "Bạn chỉ được chọn loại tài khoản là Người dùng hoặc Quản trị viên!", "Thông báo! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (UserName == "" || DisplayName == "" || Diachi == "" || DienThoai == "" || Gioitinh == "")
                        {
                            if ((Type != 0 || Type == 1))
                            {
                                MessageBox.Show("Thêm Tài Khoản Thất bại" + "\n" + "Bạn chỉ được chọn loại tài khoản là Người dùng hoặc Quản trị viên!", "Thông báo! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Thêm Tài Khoản Thất bại" + "\n" + "Bạn phải nhập đầy đủ thông tin mới có thể thêm tài khoản mới được!", "Thông báo! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
            }
        }


        private void buttontaikhoanThem_Click(object sender, EventArgs e)
        {

            string username = txbtentaikhoan.Text;
            string fullname = txbtenhienthi.Text;
            string ngaysinh = txbngaysinh.Text;
            string diachi = txbdiachi.Text;
            int loai;
            //int loai = Convert.ToInt32(txbloaitaikhoan.Text);
            string loaitx = txbloaitaikhoan.Text;
            if (loaitx == "Quản trị viên") loai = 1; else if (loaitx == "Người dùng") loai = 0; else loai = -1;
            string gioitinh = txbgioitinh.Text;
            string dienthoai = txbsodienthoai.Text;
            themaccount(username, fullname, loai, ngaysinh, diachi, gioitinh, dienthoai);
        }
        #endregion



        #region Sửa account
        void suaaccount(string UserName, string DisplayName, int Type, string Ngaysinh, string Diachi, string Gioitinh, string DienThoai)
        {
            if ((UserName != "") && (DisplayName != "") && (Type == 0 || Type == 1) && (Ngaysinh != "") && (Diachi != "") && (Gioitinh == "Nam" || Gioitinh == "Nữ") && (DienThoai != ""))
            {
                if (AccountDAO.Instance.suaaccount(DisplayName, Type, Ngaysinh, Diachi, Gioitinh, DienThoai, UserName))
                {
                    MessageBox.Show("Cập nhật thông tin tài khoản Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                LoadAccount();
            }
            else
            {
                if ((Type != 0 || Type == 1) && (UserName == "" || DisplayName == "" || Diachi == "" || DienThoai == "" || Gioitinh == ""))
                {
                    MessageBox.Show("Cập nhật thông tin Tài Khoản Thất bại" + "\n" + "Bạn chỉ được chọn loại tài khoản là Người dùng hoặc Quản trị viên! Và Cũng không được bỏ trống thông tin nào!", "Thông báo! ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if ((Type != 0 || Type == 1))
                    {
                        MessageBox.Show("Cập nhật thông tin Tài Khoản Thất bại" + "\n" + "Bạn chỉ được chọn loại tài khoản là Người dùng hoặc Quản trị viên!", "Thông báo! ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (UserName == "" || DisplayName == "" || Diachi == "" || DienThoai == "" || Gioitinh == "")
                        {
                            if ((Type != 0 || Type == 1))
                            {
                                MessageBox.Show("Cập nhật thông tin Tài Khoản Thất bại" + "\n" + "Bạn chỉ được chọn loại tài khoản là Người dùng hoặc Quản trị viên!", "Thông báo! ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                                MessageBox.Show("Cập nhật thông tin Tài Khoản Thất bại" + "\n" + "Bạn phải nhập đầy đủ thông tin mới có thể thêm tài khoản mới được!", "Thông báo! ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void buttontaikhoanSua_Click(object sender, EventArgs e)
        {

            string username = txbtentaikhoan.Text;
            string fullname = txbtenhienthi.Text;
            string ngaysinh = txbngaysinh.Text;
            string diachi = txbdiachi.Text;
            int loai;
            //int loai = Convert.ToInt32(txbloaitaikhoan.Text);
            string loaitx = txbloaitaikhoan.Text;
            if (loaitx == "Quản trị viên") loai = 1; else if (loaitx == "Người dùng") loai = 0; else loai = -1;
            string gioitinh = txbgioitinh.Text;
            string dienthoai = txbsodienthoai.Text;
            suaaccount(username, fullname, loai, ngaysinh, diachi, gioitinh, dienthoai);
        }



        #endregion


   
        #region Xóa account
        void xoaaccount(string UserName)
        {
            if (accnow.UserName.Equals(UserName))
            {
                MessageBox.Show("Bạn Đang Xóa Chính Tài Khoản Của Mình, Vui Lòng Hoàn Tác!!! ", "Thông Báo: Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;
            }
            if (AccountDAO.Instance.xoaaccount(UserName))
            {
                MessageBox.Show("Đã Xóa Tài khoản: " + UserName + " Thành Công" + "\n" + "Thông tin: Tên tài khoản: " + txbtenhienthi.Text + "\n" + "Loại Tài Khoản: " + txbloaitaikhoan.Text + "\n" + "Ngày Sinh: " + txbngaysinh.Text + "\n" + txbsodienthoai.Text + "\n" + "Địa chỉ: " + txbdiachi.Text + "\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao Tác Xóa Tài Khoản Thất bại! ", "Thông Báo: Lỗi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            LoadAccount();
        }
        private void buttontaikhoanxoa_Click(object sender, EventArgs e)
        {

            string UserName = txbtentaikhoan.Text;
            xoaaccount(UserName);
        }


        #endregion


        #endregion e_n_d_themsuaxoa



        private void dtgvtaikhoan_SelectionChanged(object sender, EventArgs e)
        {
            string s = txbloaitaikhoan.Text;
            if (s == "1") txbloaitaikhoan.Text = "Quản trị viên";
            else txbloaitaikhoan.Text = "Người dùng";
            string t = txbgioitinh.Text;
          
        }

       

    }
}
