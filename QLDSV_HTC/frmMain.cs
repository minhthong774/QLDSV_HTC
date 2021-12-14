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
            MALOP.Text = "Mã Lớp = " + Program.mLop;
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                pageDanhMuc.Visible = true;
                pageNhapDiem.Visible = true;
                pageBaoCao.Visible = true;
            }
            if (Program.mGroup == "SV")
            {
                pageDK.Visible = true;
                MALOP.Visible = true;
            }
            if(Program.mGroup == "PKT")
            {
                pageDongHocPhi.Visible = true;
            }
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
            pageDK.Visible = false;
            pageDongHocPhi.Visible = false;

            MA.Text = "";
            HOTEN.Text = "";
            NHOM.Text = "";
            MALOP.Text = "";
            MALOP.Visible = false;

            foreach (Form f in this.MdiChildren)
                f.Close();

            this.btnDangNhap.Enabled = true;
            this.btnTaoTaiKhoan.Enabled = this.btnDangXuat.Enabled = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKi));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKi f = new frmDangKi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void PGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_BangDiemSVTheoLTC));
            if (frm != null) frm.Activate();
            else
            {
                frpt_BangDiemSVTheoLTC f = new frpt_BangDiemSVTheoLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptDanhSachLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frptDanhSachLopTinChi f = new frptDanhSachLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_DanhSachSinhVienDangKiLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frpt_DanhSachSinhVienDangKiLopTinChi f = new frpt_DanhSachSinhVienDangKiLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDongHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmDongHocPhi f = new frmDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_PhieuDiemSV));
            if (frm != null) frm.Activate();
            else
            {
                frpt_PhieuDiemSV f = new frpt_PhieuDiemSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemTongKetCuoiKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_BangDiemTongKetCuoiKhoa));
            if (frm != null) frm.Activate();
            else
            {
                frpt_BangDiemTongKetCuoiKhoa f = new frpt_BangDiemTongKetCuoiKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhSachDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_DanhSachSVDongHP));
            if (frm != null) frm.Activate();
            else
            {
                frpt_DanhSachSVDongHP f = new frpt_DanhSachSVDongHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSVLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_DanhSachSinhVienDangKiLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frpt_DanhSachSinhVienDangKiLopTinChi f = new frpt_DanhSachSinhVienDangKiLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiangVien));
            if (frm != null) frm.Activate();
            else
            {
                frmGiangVien f = new frmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
