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
    public partial class frmChangeTablecs : Form
    {
        public frmChangeTablecs()
        {
            InitializeComponent();
            LoadChangeTable();
        }

        private void LoadChangeTable()
        {
            cbbFromTable.DataSource = TableDAO.Instance.loadTableList();
            cbbToTable.DataSource = TableDAO.Instance.loadTableList2();
            cbbFromTable.DisplayMember = "Name";
            cbbToTable.DisplayMember = "Name";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbbFromTable.Text != null && cbbToTable.Text != null)
            {
                int id_fromTable = (int)DataProvider.Instance.ExecuteScalar("SELECT ID FROM BAN_AN WHERE TEN = N'" + cbbFromTable.Text + "'");
                int id_toTable = (int)DataProvider.Instance.ExecuteScalar("SELECT ID FROM BAN_AN WHERE TEN = N'" + cbbToTable.Text + "'");
                int id_bill_toTable = BillDAO.Instance.getUncheckBill(id_toTable);
                int id_bill_fromTable = BillDAO.Instance.getUncheckBill(id_fromTable);
                if (id_bill_fromTable == -1)
                {
                    MessageBox.Show(cbbFromTable.Text + " trống !");
                }
                else if (id_bill_toTable != -1)
                {
                    double totalPrice = (double)DataProvider.Instance.ExecuteScalar("SELECT SUM(COUNT * PRICE) FROM BAN_AN p1, BILL p2, BILLDETAIL p3, FOOD p4 " +
                        " WHERE p1.ID = p2.ID_TABLE AND p2.ID = p3.ID_BILL AND p3.ID_FOOD = p4.ID " +
                        " AND STATUS = 0 AND p1.ID = " + id_toTable);
                    if (MessageBox.Show("Thanh toán hóa đơn cho bàn " + cbbToTable.Text, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.checkOut(id_bill_toTable, (float)totalPrice);
                    }
                    else
                    {
                        return;
                    }
                        
                }
                else
                {
                    DataProvider.Instance.ExecuteNonQuery("EXEC CHANGETABLE @old_id , @new_id", new object[] { id_fromTable, id_toTable });
                    MessageBox.Show("Đã chuyển thành công " + cbbFromTable.Text + " sang bàn " + cbbToTable.Text);
                }

                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
