using Quanlynhahang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DTO
{
  public  class Food
    {

      public Food(int id,string name, int idCategory,float price)
      {
          this.ID = id;
          this.Name = name;
          
          this.IdCategory = idCategory;
          this.Price = price;
      }
      public Food(DataRow Row)
      {
          this.ID = (int)Row["id"];
          this.Name = Row["name"].ToString();        
         this.IdCategory =(int)Row["idCategory"];
         this.Price = (float)Convert.ToDouble (Row["price"].ToString());
      }
      private int iD;

      public int ID
      {
          get { return iD; }
          set { iD = value; }
      }
      private string name;

      public string Name
      {
          get { return name; }
          set { name = value; }
      }  
     

        private int idCategory;

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }
    
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }


     


    }
}
