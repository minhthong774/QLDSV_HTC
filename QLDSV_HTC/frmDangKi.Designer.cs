
namespace QLDSV_HTC
{
    partial class frmDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.nudHocKi = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvLTC = new System.Windows.Forms.DataGridView();
            this.DANGKY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MALTC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHOM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN_GV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_SV_DANG_KI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvDK = new System.Windows.Forms.DataGridView();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Huy = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudHocKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Niên Khóa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(328, 17);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Học Kì:";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Location = new System.Drawing.Point(132, 13);
            this.txtNienKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNienKhoa.MaxLength = 9;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(159, 25);
            this.txtNienKhoa.TabIndex = 3;
            this.txtNienKhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nudHocKi
            // 
            this.nudHocKi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHocKi.Location = new System.Drawing.Point(445, 14);
            this.nudHocKi.Margin = new System.Windows.Forms.Padding(4);
            this.nudHocKi.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudHocKi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHocKi.Name = "nudHocKi";
            this.nudHocKi.Size = new System.Drawing.Size(160, 25);
            this.nudHocKi.TabIndex = 4;
            this.nudHocKi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(672, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Find";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvLTC);
            this.panelControl1.Controls.Add(this.txtNienKhoa);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.nudHocKi);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1067, 293);
            this.panelControl1.TabIndex = 7;
            // 
            // dgvLTC
            // 
            this.dgvLTC.AllowUserToAddRows = false;
            this.dgvLTC.AllowUserToDeleteRows = false;
            this.dgvLTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DANGKY,
            this.MALTC1,
            this.MAMH1,
            this.TENMH1,
            this.NHOM1,
            this.HOTEN_GV1,
            this.SO_SV_DANG_KI});
            this.dgvLTC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLTC.Location = new System.Drawing.Point(2, 46);
            this.dgvLTC.Name = "dgvLTC";
            this.dgvLTC.Size = new System.Drawing.Size(1063, 245);
            this.dgvLTC.TabIndex = 7;
            this.dgvLTC.Visible = false;
            this.dgvLTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLTC_CellContentClick);
            this.dgvLTC.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLTC_CellValueChanged);
            // 
            // DANGKY
            // 
            this.DANGKY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DANGKY.HeaderText = "DANGKY";
            this.DANGKY.Name = "DANGKY";
            this.DANGKY.Width = 53;
            // 
            // MALTC1
            // 
            this.MALTC1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MALTC1.HeaderText = "MALTC";
            this.MALTC1.Name = "MALTC1";
            this.MALTC1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MALTC1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MALTC1.Visible = false;
            // 
            // MAMH1
            // 
            this.MAMH1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAMH1.HeaderText = "MAMH";
            this.MAMH1.Name = "MAMH1";
            this.MAMH1.Width = 62;
            // 
            // TENMH1
            // 
            this.TENMH1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TENMH1.HeaderText = "TENMH";
            this.TENMH1.Name = "TENMH1";
            this.TENMH1.Width = 66;
            // 
            // NHOM1
            // 
            this.NHOM1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NHOM1.HeaderText = "NHOM";
            this.NHOM1.Name = "NHOM1";
            this.NHOM1.Width = 62;
            // 
            // HOTEN_GV1
            // 
            this.HOTEN_GV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HOTEN_GV1.HeaderText = "HOTEN_GV";
            this.HOTEN_GV1.Name = "HOTEN_GV1";
            this.HOTEN_GV1.Width = 85;
            // 
            // SO_SV_DANG_KI
            // 
            this.SO_SV_DANG_KI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SO_SV_DANG_KI.HeaderText = "SO_SV_DANG_KI";
            this.SO_SV_DANG_KI.Name = "SO_SV_DANG_KI";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(897, 249);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(158, 34);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Lưu Đăng Kí";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvDK);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 293);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1067, 295);
            this.panelControl2.TabIndex = 9;
            // 
            // dgvDK
            // 
            this.dgvDK.AllowUserToAddRows = false;
            this.dgvDK.AllowUserToDeleteRows = false;
            this.dgvDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC,
            this.MAMH,
            this.TENMH,
            this.NHOM,
            this.HOTEN_GV,
            this.Huy});
            this.dgvDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDK.Location = new System.Drawing.Point(2, 2);
            this.dgvDK.Name = "dgvDK";
            this.dgvDK.Size = new System.Drawing.Size(1063, 241);
            this.dgvDK.TabIndex = 9;
            this.dgvDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDK_CellContentClick);
            // 
            // MALTC
            // 
            this.MALTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MALTC.HeaderText = "MALTC";
            this.MALTC.Name = "MALTC";
            this.MALTC.Visible = false;
            // 
            // MAMH
            // 
            this.MAMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAMH.HeaderText = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Width = 62;
            // 
            // TENMH
            // 
            this.TENMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TENMH.HeaderText = "TENMH";
            this.TENMH.Name = "TENMH";
            this.TENMH.Width = 66;
            // 
            // NHOM
            // 
            this.NHOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NHOM.HeaderText = "NHOM";
            this.NHOM.Name = "NHOM";
            this.NHOM.Width = 62;
            // 
            // HOTEN_GV
            // 
            this.HOTEN_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN_GV.HeaderText = "HOTEN_GV";
            this.HOTEN_GV.Name = "HOTEN_GV";
            // 
            // Huy
            // 
            this.Huy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Huy.HeaderText = "Huy";
            this.Huy.Name = "Huy";
            this.Huy.Text = "";
            this.Huy.UseColumnTextForButtonValue = true;
            this.Huy.Width = 32;
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKi";
            this.Text = "frmDangKi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHocKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.NumericUpDown nudHocKi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dgvLTC;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN_GV;
        private System.Windows.Forms.DataGridViewButtonColumn Huy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DANGKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHOM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN_GV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_SV_DANG_KI;
    }
}