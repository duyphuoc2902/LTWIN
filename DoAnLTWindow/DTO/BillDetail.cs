using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DTO
{
    public class BillDetail
    {
        public BillDetail(int id, int idbill, int idfood, int count)
        {
            ID = id;
            IdBill = idbill;
            IdFood = idfood;
            Count = count;
        }
        public BillDetail(DataRow row)
        {
            ID = (int) row["ID"];
            IdBill = (int)row["ID_BILL"];
            IdFood = (int)row["ID_FOOD"];
            Count = (int)row["COUNT"];
        }
        private int count;
        private int idFood;
        private int idBill;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
