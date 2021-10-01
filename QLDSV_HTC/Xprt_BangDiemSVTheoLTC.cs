using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC
{
    public partial class Xprt_BangDiemSVTheoLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_BangDiemSVTheoLTC()
        {
            InitializeComponent();
        }

        public Xprt_BangDiemSVTheoLTC(string nienKhoa, int hocKy ,string maMonHoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maMonHoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }



    }
}
