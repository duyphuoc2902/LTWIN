using DoAnLTWindow.DAO;
using DoAnLTWindow.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnLTWindow
{
    public partial class frmcustomerMoney : Form
    {
        private Account Acc;
        private int TableId;
        private double TotalPrice;
        public frmcustomerMoney(int tableId, Account acc, double totalPrice)
        {
            InitializeComponent();
            Acc = acc;
            TableId = tableId;
            TotalPrice = totalPrice;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int idbill = BillDAO.Instance.getUncheckBill(TableId);
            if (txtCustomerMoney.Text == "")
            {
                return;
            }
            else if (idbill != -1 && double.Parse(txtCustomerMoney.Text) * 1000 >= TotalPrice)
            {
                int money = (int)double.Parse(txtCustomerMoney.Text) * 1000;
                FrmReport fReport = new FrmReport(TableId, Acc, money);
                this.Hide();
                fReport.ShowDialog();
                this.Close();
                BillDAO.Instance.checkOut(idbill, (float)TotalPrice);
                DataProvider.Instance.ExecuteNonQuery("UPDATE BAN_AN SET TRANGTHAI = N'Đã Thanh Toán' WHERE ID =" + TableId);
            }
            else
            {
                MessageBox.Show("Tiền khách trả không đủ !");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            txtCustomerMoney.Text += "000";
        }

        private void txtCustomerMoney_TextChanged(object sender, EventArgs e)
        {
            txtCustomerMoney.Text = string.Format("{0:#.00}", Convert.ToDecimal(txtCustomerMoney.Text) / 100);
        }
    }
}
