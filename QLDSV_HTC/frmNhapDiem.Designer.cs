
namespace QLDSV_HTC
{
    partial class frmNhapDiem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiDiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVAMAMHTableAdapter = new QLDSV_HTC.DSTableAdapters.TENVAMAMHTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbNhom);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.cmbMonHoc);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.btnUndo);
            this.panelControl1.Controls.Add(this.btnGhiDiem);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnBatDau);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1157, 142);
            this.panelControl1.TabIndex = 0;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.bdsMonHoc;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(96, 69);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(159, 21);
            this.cmbMonHoc.TabIndex = 21;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "TENVAMAMH";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2021-2022",
            "2020-2021",
            "2019-2020",
            "2018-2019",
            "",
            ""});
            this.cmbNienKhoa.Location = new System.Drawing.Point(96, 18);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(159, 21);
            this.cmbNienKhoa.TabIndex = 18;
            // 
            // btnUndo
            // 
            this.btnUndo.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Appearance.Options.UseFont = true;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Location = new System.Drawing.Point(863, 39);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(122, 34);
            this.btnUndo.TabIndex = 17;
            this.btnUndo.Text = "Phục hồi";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiDiem.Appearance.Options.UseFont = true;
            this.btnGhiDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiDiem.ImageOptions.SvgImage")));
            this.btnGhiDiem.Location = new System.Drawing.Point(1010, 39);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(122, 34);
            this.btnGhiDiem.TabIndex = 16;
            this.btnGhiDiem.Text = "Ghi điểm";
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(310, 68);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 17);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Nhóm:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 68);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Môn học:";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Appearance.Options.UseFont = true;
            this.btnBatDau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBatDau.ImageOptions.SvgImage")));
            this.btnBatDau.Location = new System.Drawing.Point(715, 39);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(122, 34);
            this.btnBatDau.TabIndex = 11;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Niên Khóa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(310, 16);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Học kỳ:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvND);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 142);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1157, 262);
            this.panelControl2.TabIndex = 5;
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            this.dgvND.AllowUserToDeleteRows = false;
            this.dgvND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test,
            this.Column1,
            this.colDiemCC,
            this.colDiemGK,
            this.colDiemCK,
            this.Column5});
            this.dgvND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvND.Location = new System.Drawing.Point(2, 2);
            this.dgvND.Name = "dgvND";
            this.dgvND.Size = new System.Drawing.Size(1153, 258);
            this.dgvND.TabIndex = 0;
            this.dgvND.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvND_CellEndEdit);
            this.dgvND.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvND_CellEnter);
            this.dgvND.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvND_CellValidating);
            // 
            // test
            // 
            this.test.HeaderText = "Mã SV";
            this.test.Name = "test";
            this.test.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ tên SV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colDiemCC
            // 
            this.colDiemCC.HeaderText = "Điểm chuyên cần";
            this.colDiemCC.Name = "colDiemCC";
            // 
            // colDiemGK
            // 
            this.colDiemGK.HeaderText = "Điểm giữa kỳ";
            this.colDiemGK.Name = "colDiemGK";
            // 
            // colDiemCK
            // 
            this.colDiemCK.HeaderText = "Điểm cuối kỳ";
            this.colDiemCK.Name = "colDiemCK";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm hết môn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TENVAMAMHTableAdapter
            // 
            this.TENVAMAMHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNhom.Location = new System.Drawing.Point(401, 67);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(121, 21);
            this.cmbNhom.TabIndex = 23;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(401, 18);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKy.TabIndex = 22;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 590);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvND;
        private DevExpress.XtraEditors.SimpleButton btnGhiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS dS;
        private DSTableAdapters.TENVAMAMHTableAdapter TENVAMAMHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.ComboBox cmbHocKy;
    }
}