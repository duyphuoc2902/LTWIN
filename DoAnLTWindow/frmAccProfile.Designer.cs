
namespace DoAnLTWindow
{
    partial class frmAccProfile
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
            panel1 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            panel2 = new System.Windows.Forms.Panel();
            txtUsername = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txtDisplayName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            txtPass = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel5 = new System.Windows.Forms.Panel();
            txtNewPass = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            txtReEnterPass = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Bisque;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new System.Drawing.Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(414, 395);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel4);
            groupBox2.Location = new System.Drawing.Point(6, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(394, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin cá nhân";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(6, 22);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(379, 50);
            panel2.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.SystemColors.Control;
            txtUsername.Location = new System.Drawing.Point(138, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(238, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDisplayName);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(6, 78);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(379, 50);
            panel3.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new System.Drawing.Point(138, 13);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new System.Drawing.Size(238, 23);
            txtDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(4, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên Hiển Thị:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPass);
            panel4.Controls.Add(label3);
            panel4.Location = new System.Drawing.Point(6, 134);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(379, 50);
            panel4.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BackColor = System.Drawing.SystemColors.Window;
            txtPass.Location = new System.Drawing.Point(138, 13);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(238, 23);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(4, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 19);
            label3.TabIndex = 0;
            label3.Text = "Mật Khẩu Cũ:";
            
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.SandyBrown;
            btnExit.Location = new System.Drawing.Point(336, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 37);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = false;
           
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.SandyBrown;
            btnUpdate.Location = new System.Drawing.Point(255, 355);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            
            btnUpdate.Click += btnUpdate_Click;
            

            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Bisque;
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel6);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox1.Location = new System.Drawing.Point(6, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(394, 131);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi mật khẩu:";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Bisque;
            panel5.Controls.Add(txtNewPass);
            panel5.Controls.Add(label4);
            panel5.Location = new System.Drawing.Point(3, 22);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(382, 50);
            panel5.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new System.Drawing.Point(138, 13);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new System.Drawing.Size(241, 23);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(4, 17);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 19);
            label4.TabIndex = 0;
            label4.Text = "Mật Khẩu Mới:";
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.Bisque;
            panel6.Controls.Add(txtReEnterPass);
            panel6.Controls.Add(label5);
            panel6.Location = new System.Drawing.Point(3, 78);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(382, 50);
            panel6.TabIndex = 5;
            // 
            // txtReEnterPass
            // 
            txtReEnterPass.Location = new System.Drawing.Point(138, 13);
            txtReEnterPass.Name = "txtReEnterPass";
            txtReEnterPass.Size = new System.Drawing.Size(241, 23);
            txtReEnterPass.TabIndex = 1;
            txtReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(4, 17);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 19);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại:";
            // 
            // frmAccProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MintCream;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(437, 420);
            Controls.Add(panel1);
            Name = "frmAccProfile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thông Tin Cá Nhân";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}