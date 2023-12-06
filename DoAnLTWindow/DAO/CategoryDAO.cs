using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return CategoryDAO.instance;
            }
            private set
            {
                CategoryDAO.instance = value;
            }
        }
        private CategoryDAO() { }
        //form QuanLy, Admin
        public List<Category> getListCategory()
        {
            List<Category> list = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATEGORY");
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;        
        }
        
        //form Admin
        public Category getCategoryByID(int id)
        {
            Category category = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATEGORY WHERE ID = " + id);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }  
    }
}
