using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance//singerton
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }

        }

        private FoodDAO() { }

        #region // tạo list food đưa lên dtgv //
        public List<Food> Getlistfood()
        {


            List<Food> list = new List<Food>();
            string query = "select*from dbo.Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        #endregion
        }


        #region tạo list món ăn theo danh sách loại món ăn
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select*from dbo.Food where idCategory=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {

                Food food = new Food(item);
                list.Add(food);


            }
            return list;//tạo được list món ăn theo danh sách loại món ăn
        }
        #endregion
        #region hàm thêm food
        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Food( name, idCategory, price )VALUES  ( N'{0}',{1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
        #region hàm sửa food

        public bool updatefood(string name, int id, float price, int idfood)
        {

            string query = string.Format("UPDATE dbo.Food set name= N'{0}' , idCategory = {1}, price = {2}  where id= {3}", name, id, price, idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion    }
        #region hàm xóa food

        public bool deletefood(int idfood)
        {
            BillInfoDAO.Instance.deletebillinfobyfoodid(idfood);
            string query = string.Format("delete dbo.Food where id= {0}", idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
        
        
        #region tìm món ăn
        #region tìm món ăn theo tên tương đối

        public List<Food> timfoodtheotentuongdoi(string name)
        {
            List<Food> list = new List<Food>();


            string query = string.Format(" SELECT *FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name) LIKE N'%'+ dbo.fuConvertToUnsign1(N'{0}')+'%'", name);


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        #endregion
        #region Tìm món ăn theo tên chính xác
        //  string query = string.Format("SELECT * FROM dbo.Food WHERE name = N'{0}'", name);     /*tìm chính xác*/
        public List<Food> timfoodtheotenchinhxac(string name)
        {
            List<Food> list = new List<Food>();


            string query = string.Format("SELECT * FROM dbo.Food WHERE name = N'{0}'", name);     /*tìm chính xác*/



            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        #endregion
        #region Tìm món ăn theo tên Gần đúng
        //  string query = string.Format("SELECT * FROM dbo.Food WHERE name = N'{0}'", name);     /*tìm chính xác*/
        public List<Food> timfoodtheotengandung(string name)
        {
            List<Food> list = new List<Food>();


            string query = string.Format("SELECT * FROM dbo.Food WHERE name like N'%{0}%'", name);     /*tìm chính xác*/



            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        #endregion
        #endregion
    }
}
