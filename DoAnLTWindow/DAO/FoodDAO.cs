using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTWindow.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return FoodDAO.instance;
            }
            private set
            {
                FoodDAO.instance = value;
            }

        }
        private FoodDAO() { }
        //form QuanLy
        public List<Food> getFoodList(int id)
        {
            List<Food> list = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM FOOD WHERE ID_CAT = " + id);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;    
        }
        //form Admin
        public List<Food> showFood()
        {
            List<Food> list = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT p.* FROM FOOD p");
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public int insertFood(string name, int idcategory, float price)
        {
            int result = (int)DataProvider.Instance.ExecuteScalar(string.Format("THEMMONAN N'{0}', {1}, {2}", name, idcategory, price));
            return result;
        }
        public bool updateFood(int id, string name, int idcategory, float price)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE FOOD SET NAME = N'{0}', ID_CAT = {1}, PRICE = {2} WHERE ID = {3}", name, idcategory, price, id));
            return result > 0;
        }
        public bool deleteFood(int id)
        {
            BillDetailDAO.Instance.deleteBillDetailByIDFood(id);
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FOOD WHERE ID = {0}", id));
            return result > 0;
        }
        public List<Food> searchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM FOOD WHERE dbo.fuConvertToUnsign1(NAME) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name));
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
