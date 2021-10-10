using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC
{
    public partial class Xrpt_BangDiemTongKetCuoiKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemTongKetCuoiKhoa()
        {
            InitializeComponent();
        }
        public Xrpt_BangDiemTongKetCuoiKhoa(String maLop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Fill();
        }

    }
}
