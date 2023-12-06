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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            dtOrderDate.Value = DateTime.Now;
            cbbTableName.DataSource = TableDAO.Instance.loadTableList();
            cbbTableName.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("SELECT ID FROM BAN_AN WHERE TEN = N'" + cbbTableName.Text + "'");
            string order_time = dtOrderDate.Text + " " + nbudHour.Value + ":" + nbudMinute.Value;
            if (txtOrderName.Text == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đặt bàn !");
            }
            else if (txtNumber.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ !");
            }
            else if (nbudHour.Value > 23 || nbudHour.Value < 7)
            {
                MessageBox.Show("Chỉ được đặt bàn trong thời gian hoạt động của nhà hàng ! (7:00 AM - 23:00 PM)");
            }
            else if (nbudMinute.Value > 59 || nbudMinute.Value < 0)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
            }
            else
            {
                try
                {
                    DataProvider.Instance.ExecuteNonQuery(String.Format("EXEC INSERT_ORDERED {0}, N'{1}', '{2}', '{3}'", id, txtOrderName.Text, txtNumber.Text, order_time));
                    MessageBox.Show("Đặt bàn thành công !");
                }
                catch
                {
                    MessageBox.Show("Thời gian không hợp lệ !");
                }
            }

        }

        private void cbbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable pTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM BAN_AN WHERE TEN = N'" + cbbTableName.Text + "'");
            txtNumber.Text = "";
            txtOrderName.Text = "";
            nbudHour.Text = "0";
            nbudMinute.Text = "0";
            dtOrderDate.MinDate = DateTime.Today.AddDays(0);
            if (pTable.Rows.Count > 0)
            {
                DataRow row = pTable.Rows[0];
                if ((int)row["TRANGTHAI2"] != 0)
                {
                    row = DataProvider.Instance.ExecuteQuery("EXEC GET_ORDERED_TABLE " + (int)row["ID"]).Rows[0];
                    txtNumber.Text = row["Number"].ToString();
                    txtOrderName.Text = row["ORDERS_NAME"].ToString();
                    string[] test0 = row["ORDER_TIME"].ToString().Split(' ');
                    txtAMPM.Text = test0[2];
                    dtOrderDate.Text = test0[0];
                    test0 = test0[1].Split(':');
                    nbudHour.Text = test0[0];
                    nbudMinute.Text = test0[1];
                }
                else
                {
                    txtAMPM.Text = "";
                }
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để tìm kiếm !");
            }
            else
            {

                DateTime datetime = DateTime.Now;
                DataTable pTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM ORDERED_TABLE WHERE Number = '" + txtNumber.Text + "' AND ORDER_TIME >= '" + datetime.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY ORDER_TIME ASC");
                if (pTable.Rows.Count > 0)
                {
                    DataRow row = pTable.Rows[0];
                    int status2 = TableDAO.Instance.getStatus2ByID((int)row["TABLE_ID"]);
                    if (status2 == 0)
                    {
                        MessageBox.Show("Không tìm thấy bàn được đặt");
                    }
                    else
                    {
                        string TableName = DataProvider.Instance.ExecuteScalar("SELECT TEN FROM BAN_AN WHERE ID = " + row["TABLE_ID"].ToString()).ToString();
                        cbbTableName.Text = TableName;
                        txtNumber.Text = row["Number"].ToString();
                        txtOrderName.Text = row["ORDERS_NAME"].ToString();
                        string[] test0 = row["ORDER_TIME"].ToString().Split(' ');
                        txtAMPM.Text = test0[2];
                        dtOrderDate.Text = test0[0];
                        test0 = test0[1].Split(':');
                        nbudHour.Text = test0[0];
                        nbudMinute.Text = test0[1];
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng số điện thoại đã đặt bàn !");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            int status2 = TableDAO.Instance.getStatus2(cbbTableName.Text);
            if (status2 == 0)
            {
                MessageBox.Show("Bàn chưa được đặt !");
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("UPDATE BAN_AN SET TRANGTHAI2 = 0 WHERE TEN = N'" + cbbTableName.Text + "'");
                string order_time = dtOrderDate.Text + " " + nbudHour.Value + ":" + nbudMinute.Value;
                DataProvider.Instance.ExecuteNonQuery("DELETE FROM ORDERED_TABLE WHERE Number = '" + txtNumber.Text + "' AND ORDER_TIME = '" + order_time + "'");
                MessageBox.Show("Đã Huỷ Bàn Thành Công");
            }
        }
        private void txtOrderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}