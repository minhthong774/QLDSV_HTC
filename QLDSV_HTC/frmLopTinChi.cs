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
    public partial class frmLopTinChi : Form
    {
        int vitri = 0;
        string maKhoa = "";
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLopTinChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            try
            {
                String strLenh = "EXEC SP_Lay_Ma_Khoa_Tu_Ten_Khoa N'" + cmbKhoa.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Read();
                maKhoa = Program.myReader.GetString(0);
                Program.myReader.Close();

                strLenh = "SELECT MAGV FROM GIANGVIEN";
                DataTable dtGiangVien = Program.ExecSqlDataTable(strLenh);
                if (dtGiangVien == null) return;
                cmbMaGV.DataSource = dtGiangVien;
                cmbMaGV.DisplayMember = "MAGV";
                cmbMaGV.ValueMember = "MAGV";

                strLenh = "SELECT MAMH FROM MONHOC";
                DataTable dtMonHoc = Program.ExecSqlDataTable(strLenh);
                if (dtMonHoc == null) return;
                cmbMaMH.DataSource = dtMonHoc;
                cmbMaMH.DisplayMember = "TENMH";
                cmbMaMH.ValueMember = "MAMH";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối Cơ Sở Dữ Liệu!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            if (Program.mGroup == "PGV")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;

                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

        }

        private void nHOMSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nHOMLabel_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLopTinChi.Position;
            panelControl2.Enabled = true;
            bdsLopTinChi.AddNew();
            txtMaKhoa.Text = maKhoa;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcLopTinChi.Enabled = false;

            speHocKy.Value = 1;
            speNhom.Value = 1;
            speMinSV.Value = 0;
            ckeHuyLop.Checked = false;
            cmbMaMH.SelectedIndex = 1;
            if(cmbMaMH.Items.Count>0)cmbMaMH.SelectedIndex = 0;
            cmbMaGV.SelectedIndex = 1;
            if (cmbMaGV.Items.Count > 0) cmbMaGV.SelectedIndex = 0;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLopTinChi.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcLopTinChi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Nien Khoa Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }

            String strLenh1 = "SP_CHECKLOPTINCHI";
            SqlCommand Sqlcmd1 = new SqlCommand(strLenh1, Program.conn);
            Sqlcmd1.CommandType = CommandType.StoredProcedure;
            Sqlcmd1.CommandTimeout = 600;
            Sqlcmd1.Parameters.AddWithValue("@NIENKHOA", txtNienKhoa.Text);
            Sqlcmd1.Parameters.AddWithValue("@HOCKY", speHocKy.Value);
            Sqlcmd1.Parameters.AddWithValue("@MAMH", cmbMaMH.Text);
            Sqlcmd1.Parameters.AddWithValue("@NHOM", speNhom.Value);
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
                    MessageBox.Show("LOP TIN CHI DA TON TAI", "", MessageBoxButtons.OK);
                    return;
                }else if(result == 2) {
                    MessageBox.Show("LOP TIN CHI DA TON TAI TREN SERVER KHAC", "", MessageBoxButtons.OK);
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
                bdsLopTinChi.EndEdit();
                bdsLopTinChi.ResetCurrentItem();
                this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
            }
            catch(SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Lớp đã tồn tại!", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                MessageBox.Show("Loi Ghi Giang Vien!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLopTinChi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            panelControl2.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLop = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLopTinChi[bdsLopTinChi.Position])["MALTC"].ToString();
                    bdsLopTinChi.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                    bdsLopTinChi.Position = bdsLopTinChi.Find("MALOP", maLop);
                    return;
                }
            }

            if (bdsLopTinChi.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLopTinChi.CancelEdit();
            if (btnThem.Enabled == false) bdsLopTinChi.Position = vitri;
            gcLopTinChi.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            reload();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void reload()
        {
            try
            {
                this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);

                String strLenh = "EXEC SP_Lay_Ma_Khoa_Tu_Ten_Khoa N'" + cmbKhoa.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Read();
                maKhoa = Program.myReader.GetString(0);
            }
        }

        private void frmLopTinChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cmbKhoa.DataSource = null;
        }
    }
}
