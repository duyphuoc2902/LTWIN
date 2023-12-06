using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? datecheckin, DateTime? datecheckout, int status)
        {
            ID = id;
            DateCheckIn = datecheckin;
            DateCheckOut = datecheckout;
            Status = status;
            
        }
        public Bill(DataRow row)
        {
            ID = (int)row["ID"];
            DateCheckIn = (DateTime?)row["DATECHECKIN"];
            var DateCheckOutTemp = row["DATECHECKOUT"];
            if (DateCheckOutTemp.ToString() != "")
            {
                DateCheckOut = (DateTime?)DateCheckOutTemp;
            }
            
            Status = (int)row["STATUS"];
            
        }
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;
        
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
       
    }
}
