using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class menuDAO
    {

        private static menuDAO instance;

        public static menuDAO Instance
        {
            get { if (instance == null) instance = new menuDAO(); return menuDAO.instance; }
          private  set { menuDAO.instance = value; }

        }

        private menuDAO() { }

       public List<menu> GetListMenuByTable(int id)
        {
            List<menu> listmenu = new List<menu>();
            string query = "SELECT f.name,bi.count,f.price,f.price*bi.count AS totalprice FROM dbo.BillInfo AS bi,bill AS b,dbo.Food AS f WHERE bi.idBill=b.id AND  b.status=0 AND  bi.idFood= f.id AND b.idTable=" + id;
            DataTable data= DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                menu Menu = new menu(item);
                listmenu.Add(Menu);
            }
            return listmenu;//tạo song sách menu với các thuộc tính trong class menu
        }
        //xuất menu ra listview ở tablequanli



    }
}
