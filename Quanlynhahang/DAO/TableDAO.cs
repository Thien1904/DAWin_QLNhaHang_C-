using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }//tạo  Singleton  đảm bảo chỉ tạo ra một thể hiện của một lớp và, có thể được truy cập từ bất cứ đâu.
        #region tạo kích thước & thuộc tính cho các bàn ăn dạng những button
        //tạo kích thước & thuộc tính cho các bàn ăn dạng những button
        public static int TableWidth = 162;//chiều rộng
        public static int TableHeight = 90;//chiều cao
        public string Name;//ten
        #endregion
        private TableDAO() { }

        public List<Table> LoadtableList()
        {
            List<Table> tableList = new List<Table>();//tạo 1 danh sách bảng để lưu các bảng(--mỗi bảng tượng trưng cho thông tin của 1 bàn)

            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USPGetTableList");//lấy dữ liệu dưới dạng bảng từ database lưu vào data

            foreach (DataRow item in data.Rows)// thực hiện với mỗi dòng trong  bảng data(là 1 thông tin của 1 bàn) 
            {
                Table table = new Table(item);//lưu thông tin của từng bàn đó vào bảng(table)--mỗi bảng tượng trưng cho thông tin của 1 bàn
                tableList.Add(table);//thêm từng bảng trên vào danh sách bảng
            }

            return tableList;//thực hiện song hết return về danh sách bàn
        }

        #region hàm thêm tablefood
        public bool InserttableFood(string name, string status )
        {      
            string query = string.Format(" INSERT dbo.TableFood ( name, status )VALUES ( N'{0}',N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region hàm sửa tablefood

        public bool updatetablefood(string name, string status,int idtablefood)
        {
            string query = string.Format("UPDATE dbo.TableFood set name= N'{0}' ,status =  N'{1}'  where id= {2}", name, status, idtablefood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion    }
        #region hàm xóa tablefood
       
        public bool deletetablefood(int idtablefood)
        {
            BillInfoDAO.Instance.deletebillinfobyfoodid(idtablefood);
            string query = string.Format("delete dbo.Bill where idTable= {0}", idtablefood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
    }
}
