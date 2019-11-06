using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance //singleton
        {
            get { if (instance == null)instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();//tạo list category tên list

            string query = "select*from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)//thên từn hàng dữ liệu vào list
            {
                Category category = new Category(item);
                list.Add(category);//thêm vào list
            }
            return list;
        }

        public Category GetCategoryById(int id)
        {
            Category category = null;

            List<Category> list = new List<Category>();//tạo list category tên list

            string query = "select*from FoodCategory where id=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)//thên từn hàng dữ liệu vào list
            {
                category = new Category(item);
                return category;
            }
            return category;

        }
        
    }
}
