
namespace QLDSV_HTC
{
    partial class frpt_BangDiemTongKetCuoiKhoa
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dS = new QLDSV_HTC.DS();
            this.tENVAMALOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tENVAMALOPTableAdapter = new QLDSV_HTC.DSTableAdapters.TENVAMALOPTableAdapter();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVAMALOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Tag = "";
            this.labelControl1.Text = "Lớp học";
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
            // cmbLop
            // 
            this.cmbLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tENVAMALOPBindingSource, "TENLOP", true));
            this.cmbLop.DataSource = this.tENVAMALOPBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(156, 76);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 4;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(158, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(215, 21);
            this.cmbKhoa.TabIndex = 6;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khoa:";
            // 
            // frpt_BangDiemTongKetCuoiKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 149);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button1);
            this.Name = "frpt_BangDiemTongKetCuoiKhoa";
            this.Text = "frpt_BangDiemTongKetCuoiKhoa";
            this.Load += new System.EventHandler(this.frpt_BangDiemTongKetCuoiKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVAMALOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource tENVAMALOPBindingSource;
        private DSTableAdapters.TENVAMALOPTableAdapter tENVAMALOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
    }
}