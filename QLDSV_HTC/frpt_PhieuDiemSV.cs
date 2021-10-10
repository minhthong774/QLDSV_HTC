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
    public partial class frpt_PhieuDiemSV : Form
    {
        public frpt_PhieuDiemSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xrpt_PhieuDiemSV rpt = new Xrpt_PhieuDiemSV(txtMaSV.Text.ToString().Trim());

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
