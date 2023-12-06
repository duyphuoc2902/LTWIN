using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DTO
{
    public class Food
    {
        public Food(int id, string name, int idcategory, float price, string cat_name)
        {
            ID = id;
            Name = name;
            IdCategory = idcategory;
            Price = price;
        }
        public Food(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["NAME"].ToString();
            IdCategory = (int)row["ID_CAT"];
            Price = (float)Convert.ToDouble(row["PRICE"].ToString());
        }
        private float price;
        private int idCategory;
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }

        
    }
}
