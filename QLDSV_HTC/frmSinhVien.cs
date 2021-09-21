using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmSinhVien : Form
    {
        int vitri = 0;
        public frmSinhVien()
        {
            InitializeComponent();
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

            if (bdsLop.Count == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnPrint.Enabled = false;

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.bdsSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            panelControl3.Enabled = true;
            bdsLop.AddNew();
            string malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            txtMaLop.Text = malop;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcSinhVien.Enabled = false;
            gcLop.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            panelControl3.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
            gcSinhVien.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Ma Sinh Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if(txtHo.Text.Trim() == "")
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
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            if(txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Dia Chi Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }

            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.LOPTableAdapter.Update(this.DS.LOP);
            }
            catch (Exception ex)
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                MessageBox.Show("Loi Ghi Giang Vien!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLop.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            panelControl2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //String maLop = "";
            //if (bdsSV.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa lớp này vì lớp đã có sinh viên", "", MessageBoxButtons.OK);
            //    return;
            //}

            //if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    try
            //    {
            //        maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            //        bdsLop.RemoveCurrent();
            //        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //        this.LOPTableAdapter.Update(this.DS.LOP);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
            //        this.LOPTableAdapter.Fill(this.DS.LOP);
            //        bdsLop.Position = bdsLop.Find("MALOP", maLop);
            //        return;
            //    }
            //}

            //if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bdsLop.CancelEdit();
            //if (btnThem.Enabled == false) bdsLop.Position = vitri;
            //gcLop.Enabled = true;
            //panelControl2.Enabled = false;
            //btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            //btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    this.LOPTableAdapter.Fill(this.DS.LOP);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
            //    return;
            //}
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
