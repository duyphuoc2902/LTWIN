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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        bool Login(string username, string pass)
        {
            return AccDAO.Instance.Login(username, pass);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPass.Text;
            if (Login(username, pass))
            {
                Account loginAcc = AccDAO.Instance.getAccByUsername(username);

                this.Hide();

                frmQuanLy f = new frmQuanLy(loginAcc);
                
                f.ShowDialog();

                if (MessageBox.Show("Chọn Yes để đăng xuất / No để thoát khỏi chương trình !", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }


            } else if (username == "" || pass == "") {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống !");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        
    }
}
