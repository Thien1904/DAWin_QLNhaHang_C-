using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
    public class menu
    {
        public  menu (string name, int count, float price, float totalPrice=0 )
            {
                this.Name = name;
                this.Count = count;
                this.Price = price;
                this.TotalPrice = totalPrice;
            }
        public menu(DataRow Row)
        {
            Name = Row["name"].ToString();
            Count = (int)Row["count"];
            Price =  (float) Convert.ToDouble( Row["price"]);
            TotalPrice =  (float) Convert.ToDouble( Row["TotalPrice"]);
        }

        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
     
        
        
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }


        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
