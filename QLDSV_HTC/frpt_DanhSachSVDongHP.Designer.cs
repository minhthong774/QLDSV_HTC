
namespace QLDSV_HTC
{
    partial class frpt_DanhSachSVDongHP
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label tENLOPLabel;
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV_HTC.DS();
            this.tENVAMALOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tENVAMALOPTableAdapter = new QLDSV_HTC.DSTableAdapters.TENVAMALOPTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVAMALOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(320, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 16;
            label3.Text = "Học Kỳ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 15;
            label2.Text = "Niên Khóa:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(44, 119);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(46, 13);
            tENLOPLabel.TabIndex = 18;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(397, 92);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKy.TabIndex = 17;
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
            this.cmbNienKhoa.Location = new System.Drawing.Point(122, 79);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbNienKhoa.TabIndex = 14;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(122, 28);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(215, 21);
            this.cmbKhoa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khoa:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tENVAMALOPBindingSource
            // 
            this.tENVAMALOPBindingSource.DataMember = "TENVAMALOP";
            this.tENVAMALOPBindingSource.DataSource = this.dS;
            // 
            // tENVAMALOPTableAdapter
            // 
            this.tENVAMALOPTableAdapter.ClearBeforeFill = true;
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
            // cmbLop
            // 
            this.cmbLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENVAMALOPBindingSource, "TENLOP", true));
            this.cmbLop.DataSource = this.tENVAMALOPBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(122, 116);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 19;
            this.cmbLop.ValueMember = "MALOP";
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.tENLOPComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frpt_DanhSachSVDongHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frpt_DanhSachSVDongHP";
            this.Text = "frptDanhSachSVDongHP";
            this.Load += new System.EventHandler(this.frptDanhSachSVDongHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVAMALOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource tENVAMALOPBindingSource;
        private DSTableAdapters.TENVAMALOPTableAdapter tENVAMALOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Button button1;
    }
}