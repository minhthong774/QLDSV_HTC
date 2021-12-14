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
    public partial class frmGiangVien : Form
    {
        int vitri = 0;
        string macn = "";
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.LOPTINCHI' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);

            //TODO: check datarow exist
            if (DS!=null && bdsGV!=null && bdsGV.Count > 0)
            macn = ((DataRowView)bdsGV[0])["MAKHOA"].ToString();
            //cmbChiNhanh.DataSource = Program.bds_dspm;
            //cmbChiNhanh.DisplayMember = "TENCN"; 
            //cmbChiNhanh.ValueMember = "TENSERVER"; 
            //cmbChiNhanh.SelectedIndex = Program.mChinhanh; 
            //if (Program.mGroup == "CONGTY") cmbChiNhanh.Enabled = true;
            //else cmbChiNhanh.Enabled = false;

            //TODO: update status of button by user role ex:: btnThem.enable=true

            if (Program.mGroup == "KHOA")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;

            }

            btnGhi.Enabled = btnUndo.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            panelControl2.Enabled = true;
            bdsGV.AddNew();
            txtMaKhoa.Text = macn;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcGV.Enabled = false;
        }

        private void gcGV_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false) bdsGV.Position = vitri;
            gcGV.Enabled = true; 
            panelControl2.Enabled = false; 
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true; 
            btnGhi.Enabled = btnUndo.Enabled = false;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcGV.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.GIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            if(bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì giảng viên có lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có thật sự muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maGV = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
                    bdsGV.RemoveCurrent();
                    this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.GIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
                    bdsGV.Position = bdsGV.Find("MAGV", maGV);
                    return;
                }
            }

            if (bdsGV.Count == 0) btnXoa.Enabled = false;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Ma Giang Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Ho Giang Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Ten Giang Vien Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            //TODO: kiem tra thoa mien gia tri, check ma giao vien khong duoc trung tren cac phan manh, check cmb, dateEdit

            String strLenh1 = "SP_CHECK_MAGV";
            SqlCommand Sqlcmd1 = new SqlCommand(strLenh1, Program.conn);
            Sqlcmd1.CommandType = CommandType.StoredProcedure;
            Sqlcmd1.CommandTimeout = 600;
            Sqlcmd1.Parameters.AddWithValue("@MAGV", txtMaGV.Text);
            var returnParameter = Sqlcmd1.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                Sqlcmd1.ExecuteNonQuery();
                Program.conn.Close();
                int result = (int)returnParameter.Value;
                if (result == 1)
                {
                    MessageBox.Show("MA GIANG VIEN DA TON TAI", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn.Close();
                return;
            }

            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.GIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
            }catch(Exception ex)
            {
                this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                MessageBox.Show("Loi Ghi Giang Vien!\n"+ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcGV.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            panelControl2.Enabled = false;
        }
    }
}
