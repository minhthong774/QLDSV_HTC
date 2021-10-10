using DevExpress.DataAccess.Sql;
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
    public partial class frpt_BangDiemTongKetCuoiKhoa : Form
    {
        public frpt_BangDiemTongKetCuoiKhoa()
        {
            InitializeComponent();
        }

        private void frpt_BangDiemTongKetCuoiKhoa_Load(object sender, EventArgs e)
        {
            this.tENVAMALOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tENVAMALOPTableAdapter.Fill(this.dS.TENVAMALOP);

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



        private void button1_Click_1(object sender, EventArgs e)
        {
            string maLop = cmbLop.SelectedValue.ToString();

            if (maLop == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }
            Console.WriteLine(maLop);

            Xrpt_BangDiemTongKetCuoiKhoa rpt = new Xrpt_BangDiemTongKetCuoiKhoa(maLop);
            rpt.lblLopKhoaHoc.Text = "LỚP: " + cmbLop.Text + "– KHÓA HỌC: " ;
            rpt.lblKhoa.Text = "KHOA: " + cmbKhoa.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();


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
            else
            {
                this.tENVAMALOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.tENVAMALOPTableAdapter.Fill(this.dS.TENVAMALOP);
            }
        }
    }
}
