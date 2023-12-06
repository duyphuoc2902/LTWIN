using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTWindow.DAO;
using System;
using DoAnLTWindow.DTO;
using System.Drawing;
using System.Security.Cryptography;

namespace DoAnLTWindow
{
    public partial class frmAdmin : Form
    {
        BindingSource FoodList = new BindingSource();
        BindingSource AccountList = new BindingSource();
        public Account LoginAccount;
        frmQuanLy pQL;
        
        public frmAdmin(frmQuanLy QL)
        {
            
            pQL = QL;
            InitializeComponent();
            dtgvAccount.DataSource = AccountList;
            dtgvFood.DataSource = FoodList;
            
            //load data
            loadDateTimePickerBill();
            loadBillList(dtpFromDate.Value, dtpToDate.Value);
            loadListFood();
            loadAcc();
            //binding data
            loadFoodCategoryToComboBox(cboFoodCategory);
            addFoodBinding();
            addAccBinding();
            //cbb account type
            updAccType.Items.Add("ADMIN");
            updAccType.Items.Add("STAFF");
        }
        #region Food
        void loadListFood()
        {
            FoodList.DataSource = FoodDAO.Instance.showFood();
        }
        void addFoodBinding()
        {
            txtFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "NAME", true, DataSourceUpdateMode.Never));
            txtFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            updFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "PRICE", true, DataSourceUpdateMode.Never));
        }
        void loadFoodCategoryToComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.getListCategory();
            cb.DisplayMember = "NAME";
        }
        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvFood.TabIndex = 0;
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                    Category category = CategoryDAO.Instance.getCategoryByID(id);
                    cboFoodCategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cboFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cboFoodCategory.SelectedIndex = index;
                }
            }
            catch
            {
                return;
            }
        }
        List<Food> searchFood(string name)
        {
            List<Food> listFood = FoodDAO.Instance.searchFoodByName(name);
            return listFood;
        }
        private void btnSearghFood_Click(object sender, EventArgs e)
        {
            List<Food> pData = searchFood(txtSearchFoodName.Text);
            if (pData.Count > 0)
                FoodList.DataSource = pData;
            else
                MessageBox.Show("Không Tìm Thấy Món!");

        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadListFood();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Tên món ăn không được để trống !");
                return;
            }
            else
            {
                string name = txtFoodName.Text;
                int categoryID = (cboFoodCategory.SelectedItem as Category).ID;
                float price = (float)updFoodPrice.Value;
                int tmp = FoodDAO.Instance.insertFood(name, categoryID, price);
                if (tmp == 1)
                {
                    MessageBox.Show("Đã thêm món ăn");
                    loadListFood();
                    if (insertFood != null)
                    {
                        insertFood(this, new EventArgs());
                    }
                }
                else if (tmp == 0)
                {
                    MessageBox.Show("Món Ăn Đã Tồn Tại !");
                }
                else
                {
                    MessageBox.Show("Lỗi ! Vui lòng thử lại");
                }
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add
            {
                insertFood += value;
            }
            remove
            {
                insertFood -= value;
            }
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Tên món ăn không được để trống !");
                return;
            }
            else
            {
                string name = txtFoodName.Text;
                int categoryID = (cboFoodCategory.SelectedItem as Category).ID;
                float price = (float)updFoodPrice.Value;
                int id = Convert.ToInt32(txtFoodID.Text);
                if (FoodDAO.Instance.updateFood(id, name, categoryID, price))
                {
                    MessageBox.Show("Đã sửa món ăn");
                    loadListFood();
                    if (updateFood != null)
                    {
                        updateFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi ! Vui lòng thử lại");
                }
            }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add
            {
                updateFood += value;
            }
            remove
            {
                updateFood -= value;
            }
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFoodID.Text);
            if (FoodDAO.Instance.deleteFood(id))
            {
                MessageBox.Show("Đã xóa món ăn");
                loadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Lỗi ! Vui lòng thử lại");
            }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add
            {
                deleteFood += value;
            }
            remove
            {
                deleteFood -= value;
            }
        }
        #endregion
        #region Account
        void loadAcc()
        {
            AccountList.DataSource = AccDAO.Instance.getListAcc();
        }
        void addAccBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "USERNAME", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DISPLAYNAME", true, DataSourceUpdateMode.Never));
            updAccType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TYPE", true, DataSourceUpdateMode.Never));
        }
        void addAcc(string username, string displayname, int type)
        {
            if (AccDAO.Instance.insertAcc(username, displayname, type))
            {
                MessageBox.Show("Thêm tài khoản thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi ! Vui lòng thử lại");
            }
            loadAcc();

        }
        void editAcc(string username, string displayname, int type)
        {
            if (AccDAO.Instance.updateAcc(username, displayname, type))
            {
                MessageBox.Show("Sửa tài khoản thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi ! Vui lòng thử lại");
            }
            loadAcc();

        }
        void deleteAccount(string username)
        {
            if (LoginAccount.Username.Equals(username))
            {
                MessageBox.Show("Tài khoản đang được sử dụng !");
                return;
            }
            if (AccDAO.Instance.deleteAcc(username))
            {
                MessageBox.Show("Xóa tài khoản thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi ! Vui lòng thử lại");
            }
            loadAcc();

        }
        void resetPassword(string username)
        {
            if (AccDAO.Instance.resetPass(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi ! Vui lòng thử lại");
            }

        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            loadAcc();
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string displayname = txtDisplayName.Text;
            int type = updAccType.Text == "ADMIN" ? 1 : 0;
            int checkUsername = (int)DataProvider.Instance.ExecuteScalar(string.Format("SELECT COUNT(USERNAME) FROM ACCOUNT WHERE USERNAME = N'{0}'", username));
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống !");
            }
            else if (txtDisplayName.Text == "")
            {
                MessageBox.Show("Tên hiển thị không được để trống !");
            }
            else if (checkUsername == 0)
            {
                addAcc(username, displayname, type);
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại !");
            }
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string displayname = txtDisplayName.Text;
            int type = updAccType.Text == "ADMIN" ? 1 : 0;
            if (txtUserName.Text != "" && txtDisplayName.Text != "")
            {
                editAcc(username, displayname, type);
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống !");
            }
            else if (txtDisplayName.Text == "")
            {
                MessageBox.Show("Tên hiển thị không được để trống !");
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            deleteAccount(username);
        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            resetPassword(username);
        }
        #endregion
        #region Bill
        private void btnViewBill_Click(object sender, System.EventArgs e)
        {
            loadBillList(dtpFromDate.Value, dtpToDate.Value);
        }
        void loadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void loadBillList(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = BillDAO.Instance.getBillListByDate(checkin, checkout);
        }
        void loadPaidBills()
        {
            dtgvBill.DataSource = BillDAO.Instance.loadPaidBills();
        }
        #endregion
    }
}
    
      
        
