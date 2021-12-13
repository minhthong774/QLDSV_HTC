
namespace QLDSV_HTC
{
    partial class frmTaiKhoan
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
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoiXacNhan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(12, 12);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(158, 23);
            this.btnDoiMatKhau.TabIndex = 0;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(379, 12);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(186, 23);
            this.btnTaoTaiKhoan.TabIndex = 1;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.txtMatKhauMoi);
            this.panelControl1.Controls.Add(this.txtMatKhauMoiXacNhan);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(12, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(332, 173);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đổi Mật Khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(140, 35);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(187, 21);
            this.txtMatKhauMoi.TabIndex = 9;
            // 
            // txtMatKhauMoiXacNhan
            // 
            this.txtMatKhauMoiXacNhan.Location = new System.Drawing.Point(140, 62);
            this.txtMatKhauMoiXacNhan.Name = "txtMatKhauMoiXacNhan";
            this.txtMatKhauMoiXacNhan.PasswordChar = '*';
            this.txtMatKhauMoiXacNhan.Size = new System.Drawing.Size(187, 21);
            this.txtMatKhauMoiXacNhan.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(140, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(187, 21);
            this.txtMatKhau.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác nhận mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.button2);
            this.panelControl2.Controls.Add(this.cmbUsername);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.txtPassword);
            this.panelControl2.Controls.Add(this.txtRole);
            this.panelControl2.Controls.Add(this.txtTaiKhoan);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Location = new System.Drawing.Point(379, 41);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(389, 173);
            this.panelControl2.TabIndex = 3;
            this.panelControl2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm Tài Khoản";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbUsername
            // 
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(121, 59);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(263, 21);
            this.cmbUsername.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Role";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(263, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Location = new System.Drawing.Point(121, 86);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(263, 21);
            this.txtRole.TabIndex = 6;
            this.txtRole.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(121, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(263, 21);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài khoản";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoiXacNhan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbUsername;
    }
}