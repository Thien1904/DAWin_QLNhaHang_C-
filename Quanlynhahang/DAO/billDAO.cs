using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lấy ra id của bill từ id table để từ id bill lấy được id của billinfo(mục đích xuất billinfo ra listview bill)
namespace Quanlynhahang.DAO
{
   public class billDAO
    {
        private static billDAO instance;//tạo singerthon
    

        public static billDAO Instance
        {
            get { if(instance==null) instance=new billDAO() ;return billDAO.instance; }
           private set { billDAO.instance = value; }
        }

       private billDAO(){}
       #region lấy idbill từ idtable
       public int GetUncheckBillIDByTableID(int id)//lấy trường thành công(số lượng ) thông qua ExecuteScalar sau đó chuyển thành 1 bill nếu thành công và sau đó lấy ra id bill, lấy tiếp ra idbillinfo
          {
              DataTable data = DataProvider.Instance.ExecuteQuery("SELECT* FROM dbo.Bill WHERE idtable = " + id +" AND status = 0");
              if (data.Rows.Count > 0)//Nếu số trường trả về >0
              {
                  Bill bill = new Bill(data.Rows[0]);//Tạo bill mới từ hàng đầu tiên
                  return bill.ID;//Đã lấy được id của bill, cần từ id bill lấy ra idbillinfo và xuất billinfo ra listview(tạo class billnfo để xử lí)
              }
              return -1;//k có
          }
        #endregion
       #region //tạo bil mới khi thêm món ăn vào bàn trống chưa có bill
       public void InsertBill(int id)//tạo bil mới khi thêm món ăn vào bàn trống chưa có bill
       {
           DataProvider.Instance.ExecuteNonQuery("exec USPInsertBill @idTable",new object[]{id});
       }
        #endregion 
      #region //hàm để lấy các bill đã thanh toán vào dtgv doanh thu
      public DataTable GetListBill(DateTime checkIn,DateTime checkOut)
       {
           return DataProvider.Instance.ExecuteQuery("exec USPGetListBill  @checkIn , @checkOut",new object[]{checkIn, checkOut});

       }
       #endregion

      #region lấy idbill lớn nhất
      public int GetMaxIDBill()
       {
           try
           {
               return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX (id) FROM dbo.Bill");
           }
               catch
           {
               return 1;
           }
       }//đã lấy được id lớn nhất
      #endregion

      #region update bàn khi đã thanh toán
      public void Checkout(int id,int discount,float totalPrice)//update lại khi đã thanh toán
       {
          
           string query = "UPDATE dbo.Bill SET dateCheckOut=GETDATE() , status =1," + " discount = " + discount +", totalPrice = " + totalPrice   + " WHERE id=" + id;
            DataProvider.Instance.ExecuteNonQuery(query);
       }
      #endregion

       public void  deletebiddbytableid(int idtable)
       {

           DataProvider.Instance.ExecuteQuery("Delete dbo.Bill where idtable=" + idtable);       
       
       }
   
   }
    
 
}
