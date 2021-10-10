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
    public partial class frpt_DanhSachSVDongHP : Form
    {
        public frpt_DanhSachSVDongHP()
        {
            InitializeComponent();
        }
        string maLop = "";

        private void frptDanhSachSVDongHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TENVAMALOP' table. You can move, or remove it, as needed.
            this.tENVAMALOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tENVAMALOPTableAdapter.Fill(this.dS.TENVAMALOP);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            maLop = cmbLop.SelectedValue.ToString();

            cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else cmbKhoa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nienKhoa = cmbNienKhoa.Text;
            string hocKy = cmbHocKy.Text;

            if (nienKhoa == "" || hocKy == "" || maLop == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            Xrpt_DanhSachSVDongHP rpt = new Xrpt_DanhSachSVDongHP(maLop, nienKhoa, int.Parse(hocKy));
            Console.WriteLine(this.cmbLop.SelectedValue.ToString());

            rpt.lblKhoa.Text = "KHOA: " + this.cmbKhoa.Text;
            rpt.lblMaLop.Text = "MÃ LỚP: " +  this.cmbLop.SelectedValue.ToString();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void tENLOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLop.SelectedValue != null)
                {
                    maLop = cmbLop.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
