using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void HienThiMenu()
        {
            MA.Text = "Mã = " + Program.username;
            HOTEN.Text = "Họ tên = " + Program.mHoten;
            NHOM.Text = "Nhóm = " + Program.mGroup;
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA") pageDanhMuc.Visible = true;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mChinhanh = 0;
            Program.servername = "";
            Program.username = "";
            Program.mlogin = "";
            Program.password = "";
            Program.mloginDN = "";
            Program.passwordDN = "";
            Program.mGroup = "";
            Program.mHoten = "";
            pageDanhMuc.Visible = false;

            MA.Text = "";
            HOTEN.Text = "";
            NHOM.Text = "";
        }
    }
}
