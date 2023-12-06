using DoAnLTWindow.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTWindow.DTO;

namespace DoAnLTWindow
{
    public partial class FrmReport : Form
    {
        public FrmReport(int idTable, Account acc, int customerMoney = 0)
        {
            InitializeComponent();

            lbTable.Text = DataProvider.Instance.ExecuteScalar("SELECT TEN FROM BAN_AN WHERE ID = " + idTable.ToString()).ToString();
            lbStaff.Text = acc.Displayname;
            lbDate.Text = DateTime.Now.ToString();

            loadBill(idTable, customerMoney);
        }
        private void loadBill(int idTable, int customerMoney)
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("vi-VN");

            lvReport.Items.Clear();
            List<Menu> listbilldetail = MenuDAO.Instance.getListMenu(idTable);
            float TotalPrice = 0;
            int stt = 1, cnt = 0;
            foreach (Menu item in listbilldetail)
            {
                ListViewItem lvwItem = new ListViewItem(stt.ToString());
                lvwItem.SubItems.Add(item.FoodName.ToString());
                lvwItem.SubItems.Add(item.Count.ToString());
                lvwItem.SubItems.Add(item.Price.ToString());
                lvwItem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lvReport.Items.Add(lvwItem);

                lvReport.Height += 18;
                this.Height += 18;
                ++stt;
                cnt += item.Count;

            }

            lbCnt.Text = cnt.ToString();
            lbTotal.Text = TotalPrice.ToString("#,###", culture.NumberFormat) + " đ";
            lbCustomMoney.Text = customerMoney.ToString("#,###", culture.NumberFormat) + " đ";
            if (customerMoney - TotalPrice != 0)
            {
                lbMoneyLeft.Text = (customerMoney - TotalPrice).ToString("#,###", culture.NumberFormat) + " đ";
            }
            else
            {
                lbMoneyLeft.Text = (customerMoney - TotalPrice).ToString() + " đ";
            }
                
        }
    }
}
