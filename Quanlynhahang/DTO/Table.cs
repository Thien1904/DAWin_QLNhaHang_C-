using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
   public class Table
    {
       public Table(int id, string name, string status)//hàm dựng cho mối bảng là đại diện 1 bàn ăn
         {
             this.ID = id;
             this.Name = name;
             this.Status = status;
        }
       public Table(DataRow row)//lấy ra từng trường của table
       {    
           this.ID = (int)row["id"];
           this.Name = row["name"].ToString();
           this.Status = row["status"].ToString();
       }
       private int iD;

       public int ID
       {
           get { return iD; }
           set { iD = value; }
       }
       private string name;            //Tên
       public string Name
       {
           get { return name; }
           set { name = value; }
       } 
       private string status;        //Ghi chú    
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        
    }
}
