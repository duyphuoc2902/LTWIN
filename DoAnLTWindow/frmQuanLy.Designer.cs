
namespace DoAnLTWindow
{
    partial class frmQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            mnuThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            đặtBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel2 = new System.Windows.Forms.Panel();
            lvwBill = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            updFoodCount = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            cboFood = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            btnAddFood = new System.Windows.Forms.Button();
            txtTotalPrice = new System.Windows.Forms.TextBox();
            btnThanhToan = new System.Windows.Forms.Button();
            flpTable = new System.Windows.Forms.FlowLayoutPanel();
            btnLuu = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuAdmin, mnuTaiKhoan, đặtBànToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(621, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new System.Drawing.Size(55, 20);
            mnuAdmin.Text = "Admin";
            mnuAdmin.Click += adminToolStripMenuItem_Click;
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuThongTinTaiKhoan, mnuDangXuat });
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuThongTinTaiKhoan
            // 
            mnuThongTinTaiKhoan.Name = "mnuThongTinTaiKhoan";
            mnuThongTinTaiKhoan.Size = new System.Drawing.Size(170, 22);
            mnuThongTinTaiKhoan.Text = "Thông Tin";
            mnuThongTinTaiKhoan.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new System.Drawing.Size(170, 22);
            mnuDangXuat.Text = "Đăng Xuất / Thoát";
            mnuDangXuat.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // đặtBànToolStripMenuItem
            // 
            đặtBànToolStripMenuItem.Name = "đặtBànToolStripMenuItem";
            đặtBànToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            đặtBànToolStripMenuItem.Text = "Đặt Bàn";
            đặtBànToolStripMenuItem.Click += đặtBànToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvwBill);
            panel2.Location = new System.Drawing.Point(12, 42);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(292, 345);
            panel2.TabIndex = 2;
            // 
            // lvwBill
            // 
            lvwBill.BackColor = System.Drawing.Color.White;
            lvwBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvwBill.GridLines = true;
            lvwBill.HideSelection = false;
            lvwBill.Location = new System.Drawing.Point(0, -1);
            lvwBill.Name = "lvwBill";
            lvwBill.Size = new System.Drawing.Size(292, 346);
            lvwBill.TabIndex = 0;
            lvwBill.UseCompatibleStateImageBehavior = false;
            lvwBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng ";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tổng tiền";
            columnHeader4.Width = 120;
            // 
            // updFoodCount
            // 
            updFoodCount.Location = new System.Drawing.Point(444, 27);
            updFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            updFoodCount.Name = "updFoodCount";
            updFoodCount.Size = new System.Drawing.Size(67, 23);
            updFoodCount.TabIndex = 3;
            updFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(116, 399);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Tổng đơn:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(309, 27);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(129, 23);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cboFood
            // 
            cboFood.FormattingEnabled = true;
            cboFood.Location = new System.Drawing.Point(309, 56);
            cboFood.Name = "cboFood";
            cboFood.Size = new System.Drawing.Size(202, 23);
            cboFood.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 430);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 15);
            label1.TabIndex = 5;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = System.Drawing.Color.SandyBrown;
            btnAddFood.Location = new System.Drawing.Point(524, 28);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new System.Drawing.Size(86, 52);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotalPrice.Location = new System.Drawing.Point(183, 393);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new System.Drawing.Size(121, 26);
            txtTotalPrice.TabIndex = 1;
            txtTotalPrice.Text = "0";
            txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = System.Drawing.Color.SandyBrown;
            btnThanhToan.Location = new System.Drawing.Point(524, 369);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new System.Drawing.Size(86, 51);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.BackColor = System.Drawing.SystemColors.Info;
            flpTable.Location = new System.Drawing.Point(310, 86);
            flpTable.Name = "flpTable";
            flpTable.Size = new System.Drawing.Size(300, 277);
            flpTable.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = System.Drawing.Color.SandyBrown;
            btnLuu.Location = new System.Drawing.Point(310, 368);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(86, 51);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu Bàn";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = System.Drawing.Color.SandyBrown;
            btnChange.Location = new System.Drawing.Point(416, 368);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(86, 51);
            btnChange.TabIndex = 8;
            btnChange.Text = "Chuyển Bàn";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // frmQuanLy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(621, 429);
            Controls.Add(btnChange);
            Controls.Add(btnThanhToan);
            Controls.Add(btnLuu);
            Controls.Add(label2);
            Controls.Add(updFoodCount);
            Controls.Add(label1);
            Controls.Add(txtTotalPrice);
            Controls.Add(flpTable);
            Controls.Add(panel2);
            Controls.Add(cboCategory);
            Controls.Add(cboFood);
            Controls.Add(menuStrip1);
            Controls.Add(btnAddFood);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmQuanLy";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản Lý";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwBill;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.NumericUpDown updFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ToolStripMenuItem đặtBànToolStripMenuItem;
    }
}