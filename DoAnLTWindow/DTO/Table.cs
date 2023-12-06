using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DTO
{
    public class Table
    {
        public Table()
        {
            ID = -1;
        }
        public Table(int id, string ten, string trangthai, int trangthai2)
        {
            ID = id;
            Name = ten;
            Status = trangthai;
            Status2 = trangthai2;
        }

        public Table(DataRow row)
        {   
            ID = (int)row["ID"];
            Name = row["TEN"].ToString();
            Status = row["TRANGTHAI"].ToString();
            Status2 = (int)row["TRANGTHAI2"];
        }
        private string status;
        private string name;
        private int iD;
        private int status2;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Status2 { get => status2; set => status2 = value; }
    }
}
