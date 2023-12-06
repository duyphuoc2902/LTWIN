using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DTO
{
    public class Menu
    {
        public Menu(string foodname, int count, float price, float totalprice = 0)
        {
            FoodName = foodname;
            Count = count;
            Price = price;
            TotalPrice = totalprice;
        }
        public Menu(DataRow row)
        {
            FoodName = row["NAME"].ToString();
            Count = (int)row["COUNT"];
            Price = (float)Convert.ToDouble(row["PRICE"].ToString());
            TotalPrice = (float)Convert.ToDouble(row["TOTALPRICE"].ToString());
        }
        private float totalPrice;
        private float price; 
        private int count;
        private string foodName;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
