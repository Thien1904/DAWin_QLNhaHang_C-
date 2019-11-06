using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillinfo(int id) //Tạo danh sách bill info từ id của bill id đưa vào là idbill
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select*From dbo.BillInfo Where idBill = " + id);
            foreach (DataRow item in data.Rows)//đối với mỗi datarow nằm trong data.row(của system)
            {
                BillInfo info = new BillInfo(item);//(tạo 1 billinfo mới từ item đưa vào và thêm nó vào listbillinfo)
                listBillInfo.Add(info);//khi đã có listbill rồi , show vào listview trong tablequanli
            }
            
            return listBillInfo;
        }

       public void InsertBillinfo(int idBill,int idFood,int Count)//tạo bilinfo mới khi thêm món ăn vào bàn trống chưa có bill
        {

            DataProvider.Instance.ExecuteNonQuery("USPInsertBillInfo @idBill , @idFood , @Count", new object[] { idBill, idFood, Count });
        }
      public void deletebillinfobyfoodid(int id)
            {
                DataProvider.Instance.ExecuteQuery("delete dbo.billinfo where idfood = " + id);
            }
        

   
    }
}
