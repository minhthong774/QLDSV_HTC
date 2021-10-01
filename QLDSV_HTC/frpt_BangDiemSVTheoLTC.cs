using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLDSV_HTC
{
    public partial class frpt_BangDiemSVTheoLTC : Form
    {
        string maMonHoc;
        public frpt_BangDiemSVTheoLTC()
        {
            InitializeComponent();
        }

        private void frpt_BangDiemSVTheoLTC_Load(object sender, EventArgs e)
        {
            this.TENVAMAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TENVAMAMHTableAdapter.Fill(this.dS.TENVAMAMH);

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

        private void tENMHComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void tENMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cmbHocKy.Text.ToString());
            Console.WriteLine(cmbNienKhoa.Text.ToString());
            Console.WriteLine(maMonHoc);
            Console.WriteLine(cmbNhom.Text.ToString());

            Xprt_BangDiemSVTheoLTC rpt = new Xprt_BangDiemSVTheoLTC(cmbNienKhoa.Text,  int.Parse(cmbHocKy.Text.ToString()),  maMonHoc,  int.Parse(cmbNhom.Text.ToString()));
            rpt.lblKhoa.Text = "KHOA: " + this.cmbKhoa.Text;
            rpt.lblNienKhoa.Text = "Niên khóa: " + cmbNienKhoa.Text + " Học kỳ: " + cmbHocKy.Text;
            rpt.lblMonHoc.Text = "Môn học: " + cmbMonHoc.Text + " - " + "Nhóm: " + cmbNhom.Text;

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
                this.TENVAMAMHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TENVAMAMHTableAdapter.Fill(this.dS.TENVAMAMH);
            }
        }

        private void tENMHLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void tENMHComboBoxEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbMonHoc.SelectedValue != null)
                {
                    maMonHoc = cmbMonHoc.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
