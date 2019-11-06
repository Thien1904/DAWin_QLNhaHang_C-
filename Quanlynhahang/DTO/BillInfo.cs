using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tạo cấu trúc của 1 billinfo
namespace Quanlynhahang.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billId,int foodId,int count)
        {
            this.ID = id;
            this.BillId = billId;
            this.FoodId = foodId;
            this.Count = count;
        }
         public BillInfo(DataRow Row)
        {
            this.ID =(int)Row["id"];
            this.BillId = (int)Row["idbill"];
            this.FoodId = (int)Row["idfood"];
            this.Count = (int)Row["count"];

        }
        private int count;//Số lượng food

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int foodId;

        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
        private int billId;

        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
