using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frpt_DanhSachSinhVienDangKiLopTinChi : Form
    {
        public frpt_DanhSachSinhVienDangKiLopTinChi()
        {
            InitializeComponent();
        }

        private void frpt_DanhSachSinhVienDangKiLopTinChi_Load(object sender, EventArgs e)
        {
            this.TENVAMAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TENVAMAMHTableAdapter.Fill(this.DS.TENVAMAMH);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else cmbKhoa.Enabled = false;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.DataSource == null) return;
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về Khoa mới", "", MessageBoxButtons.OK);
                cmbKhoa.SelectedIndex = Program.mChinhanh;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_DanhSachSinhVienDangKiLopTinChi rpt = new Xrpt_DanhSachSinhVienDangKiLopTinChi(txtNienKhoa.Text, (int)nudHocKy.Value, cmbMonHoc.SelectedValue.ToString(), (int)nudNhom.Value); ;
            rpt.xrlblbKhoa.Text = "KHOA: " + cmbKhoa.Text;
            rpt.xrlblNienKhoa.Text = "Niên khóa: " + txtNienKhoa.Text;
            rpt.xrlblHocKi.Text = "Học kỳ: " + nudHocKy.Value;
            rpt.xrlblMonHoc.Text = "Môn Học: " + cmbMonHoc.Text;
            rpt.xrlblNhom.Text = "Nhóm: " + nudNhom.Value;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void frpt_DanhSachSinhVienDangKiLopTinChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cmbKhoa.DataSource = null;
        }
    }
}
