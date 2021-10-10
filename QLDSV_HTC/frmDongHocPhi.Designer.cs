
namespace QLDSV_HTC
{
    partial class frmDongHocPhi
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nGAYDONG1Label;
            System.Windows.Forms.Label sOTIENDONGLabel;
            this.DS = new QLDSV_HTC.DS();
            this.bdsNKHK = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOAVAHOCKYTableAdapter = new QLDSV_HTC.DSTableAdapters.NIENKHOAVAHOCKYTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.gcNKHK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTDHPByNKHK = new System.Windows.Forms.BindingSource(this.components);
            this.CTDHPByNKHKTableAdapter = new QLDSV_HTC.DSTableAdapters.GET_CHI_TIET_DONG_HOC_PHI_BY_NK_HKTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV_HTC.DSTableAdapters.SINHVIENTableAdapter();
            this.gcCTDHPByNKHK = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcThongTinDongHocPhiSV = new DevExpress.XtraGrid.GridControl();
            this.bdsTTDHPSV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENCANDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gET_THONG_TIN_DONG_HOC_PHI_SVTableAdapter = new QLDSV_HTC.DSTableAdapters.GET_THONG_TIN_DONG_HOC_PHI_SVTableAdapter();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.btnDHP = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDHP = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTienDong = new DevExpress.XtraEditors.SpinEdit();
            this.deNgayDong = new DevExpress.XtraEditors.DateEdit();
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoten = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSVDHP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtHocPhi = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nGAYDONG1Label = new System.Windows.Forms.Label();
            sOTIENDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNKHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNKHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDHPByNKHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDHPByNKHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinDongHocPhiSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTDHPSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDHP)).BeginInit();
            this.pnlDHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSVDHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 13;
            label2.Text = "Niên Khóa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 13);
            label3.TabIndex = 14;
            label3.Text = "Học Kỳ:";
            // 
            // nGAYDONG1Label
            // 
            nGAYDONG1Label.AutoSize = true;
            nGAYDONG1Label.Location = new System.Drawing.Point(558, 31);
            nGAYDONG1Label.Name = "nGAYDONG1Label";
            nGAYDONG1Label.Size = new System.Drawing.Size(63, 13);
            nGAYDONG1Label.TabIndex = 34;
            nGAYDONG1Label.Text = "Ngày đóng:";
            // 
            // sOTIENDONGLabel
            // 
            sOTIENDONGLabel.AutoSize = true;
            sOTIENDONGLabel.Location = new System.Drawing.Point(558, 71);
            sOTIENDONGLabel.Name = "sOTIENDONGLabel";
            sOTIENDONGLabel.Size = new System.Drawing.Size(71, 13);
            sOTIENDONGLabel.TabIndex = 35;
            sOTIENDONGLabel.Text = "Số tiền đóng:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNKHK
            // 
            this.bdsNKHK.DataMember = "NIENKHOAVAHOCKY";
            this.bdsNKHK.DataSource = this.DS;
            // 
            // nIENKHOAVAHOCKYTableAdapter
            // 
            this.nIENKHOAVAHOCKYTableAdapter.ClearBeforeFill = true;
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
            // gcNKHK
            // 
            this.gcNKHK.DataSource = this.bdsNKHK;
            this.gcNKHK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNKHK.Location = new System.Drawing.Point(0, 0);
            this.gcNKHK.MainView = this.gridView1;
            this.gcNKHK.Name = "gcNKHK";
            this.gcNKHK.Size = new System.Drawing.Size(1212, 158);
            this.gcNKHK.TabIndex = 5;
            this.gcNKHK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcNKHK.MouseEnter += new System.EventHandler(this.gcNKHK_MouseEnter);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY});
            this.gridView1.DetailHeight = 377;
            this.gridView1.GridControl = this.gcNKHK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // bdsCTDHPByNKHK
            // 
            this.bdsCTDHPByNKHK.DataMember = "GET_CHI_TIET_DONG_HOC_PHI_BY_NK_HK";
            this.bdsCTDHPByNKHK.DataSource = this.DS;
            // 
            // CTDHPByNKHKTableAdapter
            // 
            this.CTDHPByNKHKTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.DS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDHPByNKHK
            // 
            this.gcCTDHPByNKHK.DataSource = this.bdsCTDHPByNKHK;
            this.gcCTDHPByNKHK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTDHPByNKHK.Location = new System.Drawing.Point(0, 158);
            this.gcCTDHPByNKHK.MainView = this.gridView2;
            this.gcCTDHPByNKHK.Name = "gcCTDHPByNKHK";
            this.gcCTDHPByNKHK.Size = new System.Drawing.Size(1212, 183);
            this.gcCTDHPByNKHK.TabIndex = 16;
            this.gcCTDHPByNKHK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcCTDHPByNKHK.Click += new System.EventHandler(this.gcCTDHPByNKHK_Click);
            this.gcCTDHPByNKHK.MouseEnter += new System.EventHandler(this.gcCTDHPByNKHK_MouseEnter);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA1,
            this.colHOCKY1,
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridView2.DetailHeight = 377;
            this.gridView2.GridControl = this.gcCTDHPByNKHK;
            this.gridView2.Name = "gridView2";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colNIENKHOA1
            // 
            this.colNIENKHOA1.FieldName = "NIENKHOA";
            this.colNIENKHOA1.Name = "colNIENKHOA1";
            this.colNIENKHOA1.Visible = true;
            this.colNIENKHOA1.VisibleIndex = 1;
            // 
            // colHOCKY1
            // 
            this.colHOCKY1.FieldName = "HOCKY";
            this.colHOCKY1.Name = "colHOCKY1";
            this.colHOCKY1.Visible = true;
            this.colHOCKY1.VisibleIndex = 2;
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 3;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.DisplayFormat.FormatString = "#,###";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.OptionsColumn.AllowEdit = false;
            this.colSOTIENDONG.OptionsColumn.AllowFocus = false;
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcThongTinDongHocPhiSV);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Controls.Add(this.txtMASV);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 341);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1212, 119);
            this.panelControl1.TabIndex = 17;
            // 
            // gcThongTinDongHocPhiSV
            // 
            this.gcThongTinDongHocPhiSV.DataSource = this.bdsTTDHPSV;
            this.gcThongTinDongHocPhiSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcThongTinDongHocPhiSV.Location = new System.Drawing.Point(2, 44);
            this.gcThongTinDongHocPhiSV.MainView = this.gridView3;
            this.gcThongTinDongHocPhiSV.Name = "gcThongTinDongHocPhiSV";
            this.gcThongTinDongHocPhiSV.Size = new System.Drawing.Size(1208, 73);
            this.gcThongTinDongHocPhiSV.TabIndex = 3;
            this.gcThongTinDongHocPhiSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // bdsTTDHPSV
            // 
            this.bdsTTDHPSV.DataMember = "GET_THONG_TIN_DONG_HOC_PHI_SV";
            this.bdsTTDHPSV.DataSource = this.DS;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA2,
            this.colHOCKY2,
            this.colHOCPHI,
            this.colSOTIENDADONG,
            this.colSOTIENCANDONG});
            this.gridView3.DetailHeight = 377;
            this.gridView3.GridControl = this.gcThongTinDongHocPhiSV;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colNIENKHOA2
            // 
            this.colNIENKHOA2.FieldName = "NIENKHOA";
            this.colNIENKHOA2.Name = "colNIENKHOA2";
            this.colNIENKHOA2.Visible = true;
            this.colNIENKHOA2.VisibleIndex = 0;
            // 
            // colHOCKY2
            // 
            this.colHOCKY2.FieldName = "HOCKY";
            this.colHOCKY2.Name = "colHOCKY2";
            this.colHOCKY2.Visible = true;
            this.colHOCKY2.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.DisplayFormat.FormatString = "#,###";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.DisplayFormat.FormatString = "#,###";
            this.colSOTIENDADONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.AllowEdit = false;
            this.colSOTIENDADONG.OptionsColumn.AllowFocus = false;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // colSOTIENCANDONG
            // 
            this.colSOTIENCANDONG.DisplayFormat.FormatString = "#,###";
            this.colSOTIENCANDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENCANDONG.FieldName = "SOTIENCANDONG";
            this.colSOTIENCANDONG.Name = "colSOTIENCANDONG";
            this.colSOTIENCANDONG.OptionsColumn.AllowEdit = false;
            this.colSOTIENCANDONG.OptionsColumn.AllowFocus = false;
            this.colSOTIENCANDONG.Visible = true;
            this.colSOTIENCANDONG.VisibleIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(286, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(135, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(94, 13);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(173, 20);
            this.txtMASV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sinh viên:";
            // 
            // gET_THONG_TIN_DONG_HOC_PHI_SVTableAdapter
            // 
            this.gET_THONG_TIN_DONG_HOC_PHI_SVTableAdapter.ClearBeforeFill = true;
            // 
            // btnDHP
            // 
            this.btnDHP.Location = new System.Drawing.Point(900, 55);
            this.btnDHP.Name = "btnDHP";
            this.btnDHP.Size = new System.Drawing.Size(142, 36);
            this.btnDHP.TabIndex = 18;
            this.btnDHP.Text = "Ghi ";
            this.btnDHP.UseVisualStyleBackColor = true;
            this.btnDHP.Click += new System.EventHandler(this.btnDHP_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Họ tên:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(286, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Mã lớp:";
            // 
            // pnlDHP
            // 
            this.pnlDHP.Controls.Add(this.txtSoTienDong);
            this.pnlDHP.Controls.Add(this.deNgayDong);
            this.pnlDHP.Controls.Add(sOTIENDONGLabel);
            this.pnlDHP.Controls.Add(nGAYDONG1Label);
            this.pnlDHP.Controls.Add(this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl);
            this.pnlDHP.Controls.Add(this.cmbHocKy);
            this.pnlDHP.Controls.Add(this.cmbNienKhoa);
            this.pnlDHP.Controls.Add(this.txtHoten);
            this.pnlDHP.Controls.Add(this.txtMaSVDHP);
            this.pnlDHP.Controls.Add(this.txtMaLop);
            this.pnlDHP.Controls.Add(this.txtHocPhi);
            this.pnlDHP.Controls.Add(this.labelControl5);
            this.pnlDHP.Controls.Add(this.labelControl4);
            this.pnlDHP.Controls.Add(this.labelControl3);
            this.pnlDHP.Controls.Add(this.btnDHP);
            this.pnlDHP.Controls.Add(this.labelControl2);
            this.pnlDHP.Controls.Add(label3);
            this.pnlDHP.Controls.Add(label2);
            this.pnlDHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDHP.Location = new System.Drawing.Point(0, 460);
            this.pnlDHP.Name = "pnlDHP";
            this.pnlDHP.Size = new System.Drawing.Size(1212, 313);
            this.pnlDHP.TabIndex = 22;
            // 
            // txtSoTienDong
            // 
            this.txtSoTienDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTTDHPSV, "SOTIENCANDONG", true));
            this.txtSoTienDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTienDong.Location = new System.Drawing.Point(649, 71);
            this.txtSoTienDong.Name = "txtSoTienDong";
            this.txtSoTienDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienDong.Properties.DisplayFormat.FormatString = "#,###";
            this.txtSoTienDong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienDong.Size = new System.Drawing.Size(121, 20);
            this.txtSoTienDong.TabIndex = 39;
            // 
            // deNgayDong
            // 
            this.deNgayDong.EditValue = null;
            this.deNgayDong.Location = new System.Drawing.Point(649, 29);
            this.deNgayDong.Name = "deNgayDong";
            this.deNgayDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayDong.Size = new System.Drawing.Size(121, 20);
            this.deNgayDong.TabIndex = 37;
            // 
            // gET_THONG_TIN_DONG_HOC_PHI_SVGridControl
            // 
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.DataSource = this.bdsTTDHPSV;
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.Location = new System.Drawing.Point(2, 153);
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.MainView = this.gridView4;
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.Name = "gET_THONG_TIN_DONG_HOC_PHI_SVGridControl";
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.Size = new System.Drawing.Size(1208, 158);
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.TabIndex = 34;
            this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG11,
            this.colSOTIENDONG1});
            this.gridView4.GridControl = this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colNGAYDONG11
            // 
            this.colNGAYDONG11.FieldName = "NGAYDONG1";
            this.colNGAYDONG11.Name = "colNGAYDONG11";
            this.colNGAYDONG11.Visible = true;
            this.colNGAYDONG11.VisibleIndex = 0;
            // 
            // colSOTIENDONG1
            // 
            this.colSOTIENDONG1.DisplayFormat.FormatString = "#,###";
            this.colSOTIENDONG1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG1.FieldName = "SOTIENDONG";
            this.colSOTIENDONG1.Name = "colSOTIENDONG1";
            this.colSOTIENDONG1.Visible = true;
            this.colSOTIENDONG1.VisibleIndex = 1;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTTDHPSV, "HOCKY", true));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(104, 71);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKy.TabIndex = 34;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTTDHPSV, "NIENKHOA", true));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(104, 28);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbNienKhoa.TabIndex = 33;
            // 
            // txtHoten
            // 
            this.txtHoten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTTDHPSV, "HOTEN", true));
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(104, 113);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(121, 20);
            this.txtHoten.TabIndex = 31;
            // 
            // txtMaSVDHP
            // 
            this.txtMaSVDHP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTTDHPSV, "MASV", true));
            this.txtMaSVDHP.Enabled = false;
            this.txtMaSVDHP.Location = new System.Drawing.Point(378, 73);
            this.txtMaSVDHP.Name = "txtMaSVDHP";
            this.txtMaSVDHP.Size = new System.Drawing.Size(121, 20);
            this.txtMaSVDHP.TabIndex = 30;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTTDHPSV, "MALOP", true));
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(378, 113);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 29;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTTDHPSV, "HOCPHI", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtHocPhi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHocPhi.Location = new System.Drawing.Point(378, 29);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocPhi.Properties.DisplayFormat.FormatString = "#,###";
            this.txtHocPhi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHocPhi.Size = new System.Drawing.Size(121, 20);
            this.txtHocPhi.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(286, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Mã sinh viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(286, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Học phí:";
            // 
            // frmDongHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 760);
            this.Controls.Add(this.pnlDHP);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcCTDHPByNKHK);
            this.Controls.Add(this.gcNKHK);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDongHocPhi";
            this.Text = "frmDongHocPhi";
            this.Load += new System.EventHandler(this.frmDongHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNKHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNKHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDHPByNKHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDHPByNKHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinDongHocPhiSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTDHPSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDHP)).EndInit();
            this.pnlDHP.ResumeLayout(false);
            this.pnlDHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_THONG_TIN_DONG_HOC_PHI_SVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSVDHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsNKHK;
        private DS DS;
        private DSTableAdapters.NIENKHOAVAHOCKYTableAdapter nIENKHOAVAHOCKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNKHK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private System.Windows.Forms.BindingSource bdsCTDHPByNKHK;
        private DSTableAdapters.GET_CHI_TIET_DONG_HOC_PHI_BY_NK_HKTableAdapter CTDHPByNKHKTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTDHPByNKHK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource bdsTTDHPSV;
        private DSTableAdapters.GET_THONG_TIN_DONG_HOC_PHI_SVTableAdapter gET_THONG_TIN_DONG_HOC_PHI_SVTableAdapter;
        private DevExpress.XtraGrid.GridControl gcThongTinDongHocPhiSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private System.Windows.Forms.Button btnDHP;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl pnlDHP;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA2;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY2;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENCANDONG;
        private DevExpress.XtraEditors.TextEdit txtHoten;
        private DevExpress.XtraEditors.TextEdit txtMaSVDHP;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.SpinEdit txtHocPhi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraGrid.GridControl gET_THONG_TIN_DONG_HOC_PHI_SVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG11;
        private DevExpress.XtraEditors.DateEdit deNgayDong;
        private DevExpress.XtraEditors.SpinEdit txtSoTienDong;
    }
}