using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmSinhVien : Form
    {
        int vitri = 0;
        int vitriLop = 0;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOCPHITableAdapter.Fill(this.DS.HOCPHI);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;

                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

            btnGhi.Enabled = false;

            if (bdsLop.Count == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSinhVien.Position;
            vitriLop = bdsLop.Position;
            panelControl3.Enabled = true;
            bdsSinhVien.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcSinhVien.Enabled = false;
            gcLop.Enabled = false;
            string maLop = ((DataRowView)bdsLop[vitriLop])["MALOP"].ToString();
            txtMaLop.Text = maLop;
            ckePhai.Checked = false;
            ckeDaNghiHoc.Checked = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSinhVien.Position;
            vitriLop = bdsLop.Position;
            panelControl3.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
            gcSinhVien.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSV = txtMaSV.Text.Trim();
            if (maSV == "")
            {
                MessageBox.Show("Ma Sinh Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }

            string maSV_Prev = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            if (maSV != maSV_Prev)
            {
                String strLenh = "EXEC Get_SV_By_MaSV @MASV = '" + maSV + "'";

                SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader.HasRows)
                {
                    MessageBox.Show("Mã SV Đã Tồn Tại", "", MessageBoxButtons.OK);
                    myReader.Close();
                    return;
                }
                myReader.Close();
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Ho Sinh Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Ten Sinh Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Dia Chi Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }

            try
            {
                bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);

                Program.ExecSqlNonQuery("update sinhvien set password = '' where masv = N'" + maSV + "'");

            }
            catch (Exception ex)
            {
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                MessageBox.Show("Loi Ghi Sinh Vien!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Them Thanh Cong!", "", MessageBoxButtons.OK);
            gcLop.Enabled = true;
            gcSinhVien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            panelControl3.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSinhVien = "";
            if (bdsHocPhi.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSinhVien = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                    bdsSinhVien.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSinhVien);
                    return;
                }
            }

            if (bdsSinhVien.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.CancelEdit();
            if (btnThem.Enabled == false) bdsSinhVien.Position = vitri;
            gcLop.Enabled = true;
            gcSinhVien.Enabled = true;
            panelControl3.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ckePhai_CheckedChanged(object sender, EventArgs e)
        {

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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.DS.DANGKY);
                this.HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOCPHITableAdapter.Fill(this.DS.HOCPHI);
            }
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cmbKhoa.DataSource = null;
        }
    }
}
