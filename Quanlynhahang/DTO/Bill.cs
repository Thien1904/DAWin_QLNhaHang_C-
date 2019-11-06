using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    //class dùng để lưu thông tin bill sau từ đó lấy được idbill và suy ra idbillinfo để xuất billinfo ra listview trong tablequanli mỗi khi nhấn bào btnban
  public  class Bill
    {

      public Bill(int id, int status, DateTime? dateCheckIn, DateTime? dateCheckOut, int discount)
      {
          this.ID = id;
          this.Status = status;
          this.DateCheckIn = dateCheckIn;
          this.DateCheckOut = dateCheckOut;
          this.Discount = discount;
       

      }
      public Bill(DataRow Row)//;lấy ra các thuộc tính riêng
      {
          this.ID =(int)Row["id"];
          
          this.DateCheckIn =(DateTime?)Row["dateCheckIn"];       
          var DateCheckOutTemp = Row["DateCheckOut"];
          if (DateCheckOutTemp.ToString() != "")
              this.DateCheckOut = (DateTime?)DateCheckOutTemp;
          this.Status = (int)Row["status"];
          this.Discount = (int)Row["discount"];
         
      }

      
      private int discount;

      public int Discount
      {
          get { return discount; }
          set { discount = value; }
      }
        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

  
    }
}
