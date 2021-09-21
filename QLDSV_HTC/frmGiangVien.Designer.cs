
namespace QLDSV_HTC
{
    partial class frmGiangVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label hOCHAMLabel;
            System.Windows.Forms.Label cHUYENMONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcGV = new DevExpress.XtraGrid.GridControl();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV_HTC.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCHAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYENMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANGVIENTableAdapter = new QLDSV_HTC.DSTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChuyenMon = new System.Windows.Forms.ComboBox();
            this.cmbHocHam = new System.Windows.Forms.ComboBox();
            this.cmbHocVi = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            hOCHAMLabel = new System.Windows.Forms.Label();
            cHUYENMONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(76, 21);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(76, 51);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(39, 13);
            mAKHOALabel.TabIndex = 2;
            mAKHOALabel.Text = "KHOA:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(76, 78);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(76, 105);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(76, 132);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(43, 13);
            hOCVILabel.TabIndex = 8;
            hOCVILabel.Text = "HOCVI:";
            // 
            // hOCHAMLabel
            // 
            hOCHAMLabel.AutoSize = true;
            hOCHAMLabel.Location = new System.Drawing.Point(76, 159);
            hOCHAMLabel.Name = "hOCHAMLabel";
            hOCHAMLabel.Size = new System.Drawing.Size(55, 13);
            hOCHAMLabel.TabIndex = 10;
            hOCHAMLabel.Text = "HOCHAM:";
            // 
            // cHUYENMONLabel
            // 
            cHUYENMONLabel.AutoSize = true;
            cHUYENMONLabel.Location = new System.Drawing.Point(76, 186);
            cHUYENMONLabel.Name = "cHUYENMONLabel";
            cHUYENMONLabel.Size = new System.Drawing.Size(74, 13);
            cHUYENMONLabel.TabIndex = 12;
            cHUYENMONLabel.Text = "CHUYENMON:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.barButtonItem5,
            this.btnThoat});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu Chỉnh";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcGV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1167, 188);
            this.panelControl1.TabIndex = 4;
            // 
            // gcGV
            // 
            this.gcGV.DataSource = this.bdsGV;
            this.gcGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGV.Location = new System.Drawing.Point(2, 2);
            this.gcGV.MainView = this.gridView1;
            this.gcGV.MenuManager = this.barManager1;
            this.gcGV.Name = "gcGV";
            this.gcGV.Size = new System.Drawing.Size(1163, 184);
            this.gcGV.TabIndex = 0;
            this.gcGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcGV.Click += new System.EventHandler(this.gcGV_Click);
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAKHOA,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colHOCHAM,
            this.colCHUYENMON});
            this.gridView1.GridControl = this.gcGV;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 1;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 4;
            // 
            // colHOCHAM
            // 
            this.colHOCHAM.FieldName = "HOCHAM";
            this.colHOCHAM.Name = "colHOCHAM";
            this.colHOCHAM.Visible = true;
            this.colHOCHAM.VisibleIndex = 5;
            // 
            // colCHUYENMON
            // 
            this.colCHUYENMON.FieldName = "CHUYENMON";
            this.colCHUYENMON.Name = "colCHUYENMON";
            this.colCHUYENMON.Visible = true;
            this.colCHUYENMON.VisibleIndex = 6;
            // 
            // GIANGVIENTableAdapter
            // 
            this.GIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.GIANGVIENTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(cHUYENMONLabel);
            this.panelControl2.Controls.Add(this.cmbChuyenMon);
            this.panelControl2.Controls.Add(hOCHAMLabel);
            this.panelControl2.Controls.Add(this.cmbHocHam);
            this.panelControl2.Controls.Add(hOCVILabel);
            this.panelControl2.Controls.Add(this.cmbHocVi);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Controls.Add(hOLabel);
            this.panelControl2.Controls.Add(this.txtHo);
            this.panelControl2.Controls.Add(mAKHOALabel);
            this.panelControl2.Controls.Add(this.txtMaKhoa);
            this.panelControl2.Controls.Add(mAGVLabel);
            this.panelControl2.Controls.Add(this.txtMaGV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 212);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1167, 270);
            this.panelControl2.TabIndex = 5;
            // 
            // cmbChuyenMon
            // 
            this.cmbChuyenMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "CHUYENMON", true));
            this.cmbChuyenMon.FormattingEnabled = true;
            this.cmbChuyenMon.Location = new System.Drawing.Point(156, 183);
            this.cmbChuyenMon.Name = "cmbChuyenMon";
            this.cmbChuyenMon.Size = new System.Drawing.Size(185, 21);
            this.cmbChuyenMon.TabIndex = 13;
            // 
            // cmbHocHam
            // 
            this.cmbHocHam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HOCHAM", true));
            this.cmbHocHam.FormattingEnabled = true;
            this.cmbHocHam.Location = new System.Drawing.Point(156, 156);
            this.cmbHocHam.Name = "cmbHocHam";
            this.cmbHocHam.Size = new System.Drawing.Size(185, 21);
            this.cmbHocHam.TabIndex = 11;
            // 
            // cmbHocVi
            // 
            this.cmbHocVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HOCVI", true));
            this.cmbHocVi.FormattingEnabled = true;
            this.cmbHocVi.Location = new System.Drawing.Point(156, 129);
            this.cmbHocVi.Name = "cmbHocVi";
            this.cmbHocVi.Size = new System.Drawing.Size(185, 21);
            this.cmbHocVi.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(156, 102);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(185, 21);
            this.txtTen.TabIndex = 7;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(156, 75);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(185, 21);
            this.txtHo.TabIndex = 5;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(156, 48);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(185, 21);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(156, 13);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(185, 21);
            this.txtMaGV.TabIndex = 1;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.DS;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 482);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsGV;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSTableAdapters.GIANGVIENTableAdapter GIANGVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCHAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYENMON;
        private System.Windows.Forms.ComboBox cmbChuyenMon;
        private System.Windows.Forms.ComboBox cmbHocHam;
        private System.Windows.Forms.ComboBox cmbHocVi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DSTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
    }
}