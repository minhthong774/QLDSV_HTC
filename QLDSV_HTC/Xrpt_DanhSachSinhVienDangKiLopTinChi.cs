﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC
{
    public partial class Xrpt_DanhSachSinhVienDangKiLopTinChi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachSinhVienDangKiLopTinChi(string nienKhoa, int hocKy, string monHoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = monHoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
        }

    }
}
