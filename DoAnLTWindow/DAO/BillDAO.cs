using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return BillDAO.instance;                
            }
            private set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO() { }
        //form QuanLy
        public int getUncheckBill(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BILL WHERE ID_TABLE = " + id + "  AND STATUS = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void insertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC INSERTBILL @idtable", new object[] { id });
        }
        public void checkOut(int id, float totalPrice)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE BILL SET DATECHECKOUT = GETDATE(), STATUS = 1, " + "TOTALPRICE = " + totalPrice + " WHERE ID = " + id);
        }
        public int getMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM BILL");
            }
            catch
            {
                return 1;
            }
        }       
        //form Admin
        public DataTable getBillListByDate(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GETLISTBILLBYDATE @checkin , @checkout", new object[] { checkin, checkout });
        }
        public DataTable loadPaidBills()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT BAN_AN.TEN AS [Bàn], BILL.TOTALPRICE AS [Tổng đơn], DATECHECKIN AS [Ngày lên đơn], DATECHECKOUT AS [Ngày thanh toán] FROM BILL, BAN_AN WHERE BILL.STATUS = 1 AND BAN_AN.ID = BILL.ID_TABLE");
        }
    }
}
