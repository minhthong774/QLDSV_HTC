
namespace QLDSV_HTC
{
    partial class frpt_DanhSachSinhVienDangKiLopTinChi
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
            this.btnPreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHocKy = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNhom = new System.Windows.Forms.NumericUpDown();
            this.l = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.DS = new QLDSV_HTC.DS();
            this.bdsTenVaMaMH = new System.Windows.Forms.BindingSource(this.components);
            this.TENVAMAMHTableAdapter = new QLDSV_HTC.DSTableAdapters.TENVAMAMHTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.nudHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVaMaMH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(933, 15);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Học Kỳ:";
            // 
            // nudHocKy
            // 
            this.nudHocKy.Location = new System.Drawing.Point(723, 12);
            this.nudHocKy.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudHocKy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHocKy.Name = "nudHocKy";
            this.nudHocKy.Size = new System.Drawing.Size(120, 20);
            this.nudHocKy.TabIndex = 14;
            this.nudHocKy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Niên Khóa:";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(428, 12);
            this.txtNienKhoa.MaxLength = 9;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(207, 20);
            this.txtNienKhoa.TabIndex = 12;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(71, 12);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(240, 21);
            this.cmbKhoa.TabIndex = 11;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhóm: ";
            // 
            // nudNhom
            // 
            this.nudNhom.Location = new System.Drawing.Point(723, 44);
            this.nudNhom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNhom.Name = "nudNhom";
            this.nudNhom.Size = new System.Drawing.Size(120, 20);
            this.nudNhom.TabIndex = 19;
            this.nudNhom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(338, 46);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(54, 13);
            this.l.TabIndex = 18;
            this.l.Text = "Môn Học:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.bdsTenVaMaMH;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(428, 43);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(207, 21);
            this.cmbMonHoc.TabIndex = 21;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTenVaMaMH
            // 
            this.bdsTenVaMaMH.DataMember = "TENVAMAMH";
            this.bdsTenVaMaMH.DataSource = this.DS;
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
            // frpt_DanhSachSinhVienDangKiLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 116);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudNhom);
            this.Controls.Add(this.l);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNienKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frpt_DanhSachSinhVienDangKiLopTinChi";
            this.Text = "frpt_DanhSachSinhVienDangKiLopTinChi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frpt_DanhSachSinhVienDangKiLopTinChi_FormClosed);
            this.Load += new System.EventHandler(this.frpt_DanhSachSinhVienDangKiLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVaMaMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNhom;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsTenVaMaMH;
        private DSTableAdapters.TENVAMAMHTableAdapter TENVAMAMHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}