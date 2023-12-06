using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuDAO();
                }
                return MenuDAO.instance;
            }
            private set
            {
                MenuDAO.instance = value;
            }
        }
        private MenuDAO() { }
        //form QuanLy
        public List<Menu> getListMenu(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT FOOD.NAME, BILLDETAIL.COUNT, FOOD.PRICE, FOOD.PRICE*BILLDETAIL.COUNT AS TOTALPRICE FROM BILLDETAIL, BILL, FOOD WHERE BILLDETAIL.ID_BILL = BILL.ID AND BILLDETAIL.ID_FOOD = FOOD.ID AND BILL.STATUS = 0 AND BILL.ID_TABLE = " + id);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
    }
}
