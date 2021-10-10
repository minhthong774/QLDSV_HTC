
namespace QLDSV_HTC
{
    partial class frpt_BangDiemSVTheoLTC
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label tENMHLabel1;
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.TENVAMAMHTableAdapter = new QLDSV_HTC.DSTableAdapters.TENVAMAMHTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tENMHLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(341, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 9;
            label3.Text = "Học Kỳ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(341, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 10;
            label4.Text = "Nhóm:";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 8;
            label2.Text = "Niên Khóa:";
            // 
            // tENMHLabel1
            // 
            tENMHLabel1.AutoSize = true;
            tENMHLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bdsMonHoc, "MAMH", true));
            tENMHLabel1.Location = new System.Drawing.Point(31, 67);
            tENMHLabel1.Name = "tENMHLabel1";
            tENMHLabel1.Size = new System.Drawing.Size(52, 13);
            tENMHLabel1.TabIndex = 15;
            tENMHLabel1.Text = "Môn học:";
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
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(109, 15);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(215, 21);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khoa:";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(418, 61);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKy.TabIndex = 11;
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
            this.cmbNhom.Location = new System.Drawing.Point(418, 110);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(121, 21);
            this.cmbNhom.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2021-2022",
            "2020-2021",
            "2019-2020",
            "2018-2019",
            ""});
            this.cmbNienKhoa.Location = new System.Drawing.Point(109, 106);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbNienKhoa.TabIndex = 7;
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
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.cmbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bdsMonHoc, "MAMH", true));
            this.cmbMonHoc.DataSource = this.bdsMonHoc;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(109, 64);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cmbMonHoc.TabIndex = 16;
            this.cmbMonHoc.ValueMember = "MAMH";
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // frpt_BangDiemSVTheoLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 188);
            this.Controls.Add(tENMHLabel1);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frpt_BangDiemSVTheoLTC";
            this.Text = "frpt_BangDiemSVTheoLTC";
            this.Load += new System.EventHandler(this.frpt_BangDiemSVTheoLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.TENVAMAMHTableAdapter TENVAMAMHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMonHoc;
    }
}