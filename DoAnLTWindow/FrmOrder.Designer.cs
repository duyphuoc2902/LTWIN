namespace DoAnLTWindow
{
    partial class FrmOrder
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
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            cbbTableName = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txtOrderName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txtNumber = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            txtAMPM = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            nbudMinute = new System.Windows.Forms.NumericUpDown();
            nbudHour = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            dtOrderDate = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnFind = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            comboBox2 = new System.Windows.Forms.ComboBox();
            panel7 = new System.Windows.Forms.Panel();
            btn_Exit = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbudMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbudHour).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Bisque;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(445, 30);
            label1.TabIndex = 0;
            label1.Text = "ĐẶT BÀN";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SandyBrown;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(cbbTableName);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(20, 11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(326, 40);
            panel1.TabIndex = 1;
            // 
            // cbbTableName
            // 
            cbbTableName.FormattingEnabled = true;
            cbbTableName.Location = new System.Drawing.Point(106, 10);
            cbbTableName.Name = "cbbTableName";
            cbbTableName.Size = new System.Drawing.Size(207, 24);
            cbbTableName.TabIndex = 1;
            cbbTableName.SelectedIndexChanged += cbbTableName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(3, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên Bàn";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.SandyBrown;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(txtOrderName);
            panel2.Controls.Add(label3);
            panel2.Location = new System.Drawing.Point(20, 72);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(326, 40);
            panel2.TabIndex = 2;
            // 
            // txtOrderName
            // 
            txtOrderName.Location = new System.Drawing.Point(106, 11);
            txtOrderName.Name = "txtOrderName";
            txtOrderName.Size = new System.Drawing.Size(207, 22);
            txtOrderName.TabIndex = 1;
            txtOrderName.KeyPress += txtOrderName_KeyPress;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(3, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 22);
            label3.TabIndex = 0;
            label3.Text = "Họ Và Tên";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.SandyBrown;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(txtNumber);
            panel3.Controls.Add(label4);
            panel3.Location = new System.Drawing.Point(20, 133);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(326, 40);
            panel3.TabIndex = 2;
            // 
            // txtNumber
            // 
            txtNumber.Location = new System.Drawing.Point(106, 11);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new System.Drawing.Size(207, 22);
            txtNumber.TabIndex = 1;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(3, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 22);
            label4.TabIndex = 0;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Bisque;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Location = new System.Drawing.Point(34, 37);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(372, 292);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.SandyBrown;
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel6.Controls.Add(txtAMPM);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(nbudMinute);
            panel6.Controls.Add(nbudHour);
            panel6.Controls.Add(label6);
            panel6.Location = new System.Drawing.Point(20, 192);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(326, 40);
            panel6.TabIndex = 4;
            // 
            // txtAMPM
            // 
            txtAMPM.BackColor = System.Drawing.SystemColors.ScrollBar;
            txtAMPM.Location = new System.Drawing.Point(285, 7);
            txtAMPM.Name = "txtAMPM";
            txtAMPM.ReadOnly = true;
            txtAMPM.Size = new System.Drawing.Size(28, 22);
            txtAMPM.TabIndex = 6;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(162, 8);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(50, 22);
            label7.TabIndex = 5;
            label7.Text = "Phút";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nbudMinute
            // 
            nbudMinute.Location = new System.Drawing.Point(218, 8);
            nbudMinute.Name = "nbudMinute";
            nbudMinute.Size = new System.Drawing.Size(50, 22);
            nbudMinute.TabIndex = 3;
            // 
            // nbudHour
            // 
            nbudHour.Location = new System.Drawing.Point(106, 8);
            nbudHour.Name = "nbudHour";
            nbudHour.Size = new System.Drawing.Size(50, 22);
            nbudHour.TabIndex = 1;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(55, 8);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 22);
            label6.TabIndex = 0;
            label6.Text = "Giờ";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.SandyBrown;
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel5.Controls.Add(dtOrderDate);
            panel5.Controls.Add(label5);
            panel5.Location = new System.Drawing.Point(20, 247);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(326, 40);
            panel5.TabIndex = 3;
            // 
            // dtOrderDate
            // 
            dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtOrderDate.Location = new System.Drawing.Point(163, 10);
            dtOrderDate.MinDate = new System.DateTime(2020, 9, 4, 0, 0, 0, 0);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new System.Drawing.Size(150, 22);
            dtOrderDate.TabIndex = 1;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(106, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 22);
            label5.TabIndex = 0;
            label5.Text = "Ngày";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.SandyBrown;
            btnSave.Location = new System.Drawing.Point(54, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = System.Drawing.Color.SandyBrown;
            btnFind.Location = new System.Drawing.Point(219, 14);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(75, 40);
            btnFind.TabIndex = 5;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.SandyBrown;
            btnCancel.Location = new System.Drawing.Point(136, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(451, 317);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 24);
            comboBox2.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_Exit);
            panel7.Controls.Add(btnSave);
            panel7.Controls.Add(btnCancel);
            panel7.Controls.Add(btnFind);
            panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel7.Location = new System.Drawing.Point(0, 335);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(445, 70);
            panel7.TabIndex = 8;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.SandyBrown;
            btn_Exit.Location = new System.Drawing.Point(300, 14);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(75, 40);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FrmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(445, 405);
            Controls.Add(panel7);
            Controls.Add(comboBox2);
            Controls.Add(panel4);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Name = "FrmOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmOrder";
            Load += FrmOrder_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbudMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbudHour).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown nbudMinute;
        private System.Windows.Forms.NumericUpDown nbudHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbbTableName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtAMPM;
    }
}