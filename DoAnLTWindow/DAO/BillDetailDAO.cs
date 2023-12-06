using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;
        public static BillDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDetailDAO();
                }
                return BillDetailDAO.instance;
            }
            private set
            {
                BillDetailDAO.instance = value;
            }
        }
        private BillDetailDAO() { }
        public List<BillDetail> getListBillDetail(int id)
        {
            List<BillDetail> listbilldetail = new List<BillDetail>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BILLDETAIL WHERE ID_BILL = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillDetail detail = new BillDetail(item);
                listbilldetail.Add(detail);
            }
            return listbilldetail;
        }
        //form QuanLy
        public void insertBillDetail(int idbill, int idfood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC INSERTBILLDETAIL @idbill , @idfood , @count ", new object[] { idbill, idfood, count });
        }
        //foodDAO
        public void deleteBillDetailByIDFood(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE BILLDETAIL WHERE ID_FOOD = " + id);
        }
    }
}
