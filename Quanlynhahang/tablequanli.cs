using Quanlynhahang.DAO;
using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class tablequanli : Form
    {
        private Account acclogin;//hàm dựng để có thể truyền account vào table quản lí

        public Account Acclogin
        {
            get { return acclogin; }
            set { acclogin = value; kiemtraaccount(Acclogin.Type); }
        }

        public tablequanli(Account acc)//truyền acc vào
        {
            InitializeComponent();
            this.Acclogin = acc;//truyền tài khoản đăng nhập vào 
            LoadTable();
            LoadCategory();
            string s = "Tài Khoản: " + acc.DisplayName + " Đang Online!";
            select.Text = s;
        }
        //hàm kiểm tra xem acc nào là admin
        void kiemtraaccount(int type)
        {
            admin.Enabled = type == 1;
        }
        void LoadCategory()  //load loại món ăn vào list
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();//tạo danh sách loại món ăn listcategory
            cbbdanhmuc.DataSource = listCategory;//thêm danh sách category  vào cbb
            cbbdanhmuc.DisplayMember = "Name";//do chỉ hiển thị 1 trường là Tên Loại món ăn foodcategory
        }

        void LoadFoodListByCategoryID(int id)//load các món ăn thuộc danh sánh loại món ăn đang chọn ở category vào list
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);//tạo danh sách món ăn với đầy đủ các thộc tính
            cbbtenmon.DataSource = listFood;//them vao cbb món ăn
            cbbtenmon.DisplayMember = "Name"; //hiển thị duy nhất 1 trường  tên món ăn ra cbb 
        }

        void LoadTable()
        {
            flbban.Controls.Clear();
            //lấy danh sácch table class table trong DAO
            List<Table> tableList = TableDAO.Instance.LoadtableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                #region designbutton show bàn ăn
                btn.BackColor = System.Drawing.Color.Black;
               
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(1)));
              //  btn.FlatAppearance.BorderSize = 1;
                btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                btn.Name = "btn";
                btn.TabIndex = 13;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.UseVisualStyleBackColor = true;
                #endregion
                btn.Click += btn_Click;//thêm sự kiện click( khi click vào button bàn ăn sẽ hiển thị các thông tin trong listview)
                btn.Tag = item;//lưu, đánh dấu btntable cần showbill
                if (item.Status == "Trống")
                {
                    btn.BackColor = Color.LightCyan;
                }
                else
                {
                    btn.BackColor = Color.Gold;
                }

                flbban.Controls.Add(btn);
            }
        }
        void showbill(int id) //đây là id của table để biết show bill cho table nào,lấy ra bill từ table hiện tại chưa checkout-->lấy id của bill-->>lấy ra id của billinfo show billinfo
        {//
            lsvBill.Items.Clear();
            float totalprice = 0;//tổng tiền
            List<Quanlynhahang.DTO.menu> ListbillInfo = menuDAO.Instance.GetListMenuByTable(id);
            foreach (Quanlynhahang.DTO.menu item in ListbillInfo)
            {

                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());// cột tên
                lsvItem.SubItems.Add(item.Count.ToString());// cột số lượng món
                lsvItem.SubItems.Add(item.Price.ToString());// cột giá 1 món
                lsvItem.SubItems.Add(item.TotalPrice.ToString());// cột  tổng giá các món
                totalprice += (item.TotalPrice);
                lsvBill.Items.Add(lsvItem);//thêm các dòng cho mỗi thức ăn và
            }
            CultureInfo ct = new CultureInfo("vi-VN");//convert qua định dạng tiếng việt để hiển thị tiền //" c"          
            tongtien.Text = totalprice.ToString("c", ct);//tính tổng tiền thanh toán


        }



        #region code cho các sự kiện
        void btn_Click(object sender, EventArgs e)
        {            
            int TableID = ((sender as Button).Tag as Table).ID;//tạo 1 biến tableid = id của table vừa đánh dấu trong  btn.Tag = item;      
            lsvBill.Tag = (sender as Button).Tag;
            showbill(TableID);//code cho sự kiện showbill cho tableid

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Admin a = new Admin();

            a.accnow = Acclogin; //đánh dấu để truyền qua form admin biết account nào đang  đăng nhập
            #region//thêm những even load dữ liệu khi inseert delete update vào admin          
            a.Themmonan+=a_Themmonan;
            a.Xoamonan += a_Xoamonan;
             a.Suamonan+=a_Suamonan;
            #endregion
            a.ShowDialog();
           
            }
        #region//code cho những even load dữ liệu khi inseert delete update vào admin


         void a_Themmonan(object sender, EventArgs e)
        {
             
            //load lại foodlist theo id món ăn vừa sửa đổi
            LoadFoodListByCategoryID((cbbdanhmuc.SelectedItem as Category).ID);
            //load lại hóa đơn trong bàn ăn ở bàn đã đánh dấu tag
            if (lsvBill.Tag != null)
            showbill((lsvBill.Tag as Table).ID);
        }

         void a_Xoamonan(object sender, EventArgs e)
        {
            //load lại foodlist theo id món ăn vừa sửa đổi
            LoadFoodListByCategoryID((cbbdanhmuc.SelectedItem as Category).ID);
            //load lại hóa đơn trong bàn ăn ở bàn đã đánh dấu tag
            if (lsvBill.Tag != null)
            showbill((lsvBill.Tag as Table).ID);
            //lòa lại table nếu có món bị xóa đi ->có thể có những bàn 0 có bill nên load lại table để xóa bill đó và set lại status là "Trống"
            LoadTable();

        }

         void a_Suamonan(object sender, EventArgs e)
        {
            if(lsvBill.Tag!= null)
            //load lại foodlist theo id món ăn vừa sửa đổi
            LoadFoodListByCategoryID((cbbdanhmuc.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
            //load lại hóa đơn trong bàn ăn ở bàn đã đánh dấu tag
            showbill((lsvBill.Tag as Table).ID);
        }
        #endregion
        private void tablequanli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion

        private void cbbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)//sự kiện khi chọn loại food trong cbb food category thì cbb tên food cũng bị thay đổi theo
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;//tên loại món ăn đang chọn = selected
            id = selected.ID; //gán giá trị ID của loại đang chọn =id để hiển thị duy nhất các món ăn thuộc loại đang chọn vào cbb
            LoadFoodListByCategoryID(id);//gọi hàm load food để show tên các món ăn lên cbb
        }

        private void addmon_Click_1(object sender, EventArgs e)
        {

            
            //thêm món vao bàn đã có bill (bàn đã có người)(add vào bill sẵn có của bàn đó chỉ cần thay đổi billinfo của bàn)
            //thêm món vào bàn chưa có bill"chưa có người"(cần tạo bill,billinfo mới để add món vào)
            //thêm món vào bill đã có món đó rồi /chỉ cần tăng số lượng lên thôi.
            Table table = lsvBill.Tag as Table;
            
            


            //LẤY RA ĐƯỢC TABLE ĐANG CHỌN
            if (table == null) { MessageBox.Show("Hãy chọn bàn trước", " Thông báo"); return; }
            //TIẾP THEO LẤY RA IDBILL theo id table
            //idbill cần tạo mới sẽ là id lớn nhất vì idbill tự tăng
            int idBill = billDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            //trường hợp 1 bill chưa tồn tại
            int foodID = (cbbtenmon.SelectedItem as Food).ID;//lấy ra được idfood
            int count = (int)nmmon.Value;

            if (idBill == -1)//==-1 laf chưa có cần thêm bill mới
            {
                billDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillinfo(billDAO.Instance.GetMaxIDBill(), foodID, count);//do bill chưa tồn tại nên idbill lấy id lớn nhất "id"
                showbill(table.ID);
            }

          // trường hợp bill đã tồn tại
            else
            {
                BillInfoDAO.Instance.InsertBillinfo(idBill, foodID, count);//bill đã tồn tại nên idbill = idbill của btntable đang chọn"idtable" 
                showbill(table.ID);


            }
            LoadTable();//load để cập nhật status

        }
        //sự kiện khi thanh toán hóa đơn click nút thanh toán

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {

            Table table = lsvBill.Tag as Table;//lấy ra được table hiện tại đang chọn
            if (table == null) { MessageBox.Show("Bạn phải chọn bàn cần thanh toán trước đã!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); return; }
            int idBill = billDAO.Instance.GetUncheckBillIDByTableID(table.ID);//lấy được id bill từ idtable 
            int discount = (int)nmgiamgia.Value;
            double TotalPrice = Convert.ToDouble(tongtien.Text.Split(',')[0]);//lấy được tổng tiền cắt chuỗi dạng vd:19,000 cắt theo dấu ,
            double TotalPricediscount = TotalPrice - (TotalPrice / 100) * discount;
            if (idBill == -1) { MessageBox.Show("Bàn ăn bạn đang chọn trống!, Bạn hãy chọn bàn cần thanh toán Khác!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); return; }
            else   if(idBill!=-1)
            //kiểm tra nếu != -1 nghĩa là bàn đó có bill and else
            {
                if (MessageBox.Show("Bạn muốn thanh toán hóa đơn cho : " + table.Name + "\n" + "Bạn được Giảm giá: " + discount + "%\n" + "Tổng tiền bạn cần thanh toán là: " + TotalPricediscount, "Thanh Toán Hóa Đơn", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    billDAO.Instance.Checkout(idBill, discount, (float)TotalPricediscount);
                    showbill(table.ID);//show lai bill khi da thanh toan
                    LoadTable();
                }
            }

        }   
        private void đăngXuấtToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
             account x = new account(acclogin);
             x.ShowDialog();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnthanhtoan_Click(this,new EventArgs());
        }

        private void thêmMónĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmon_Click_1(this, new EventArgs());
        }

        private void đóngChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
       
    }
}
