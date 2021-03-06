using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmDangKi : Form
    {
        List<int> ltc_Da_DANG_KI = new List<int>();
        public frmDangKi()
        {
            InitializeComponent();
            dgvLTC.AutoGenerateColumns = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtNienKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "", MessageBoxButtons.OK);
                return;
            }

            dgvLTC.Rows.Clear();
            dgvDK.Rows.Clear();

            try
            {
                DataTable dt = new DataTable();
                string query = "EXEC GET_LOP_TIN_CHI_BY_NIEN_KHOA_AND_HOC_KY_AND_MASV @NIENKHOA = N'" + txtNienKhoa.Text + "', @HOCKY=" + nudHocKi.Value + ", @MASV = N'" + Program.mloginDN +"'";
                dt = Program.ExecSqlDataTable(query);

                foreach(DataRow dtr in dt.Rows)
                {
                    dgvLTC.Rows.Add(dtr[0], dtr[1], dtr[2], dtr[3], dtr[4], dtr[5], dtr[6]);
                    if((bool)dtr[0] == true)
                    {
                        dgvDK.Rows.Add(dtr[1], dtr[2], dtr[3], dtr[4], dtr[5]);
                        ltc_Da_DANG_KI.Add(int.Parse(dtr["MALTC"].ToString()));
                    }
                }
                this.dgvLTC.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối CSDL!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void dgvLTC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0) return;
            DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)dgvLTC.Rows[e.RowIndex].Cells[0];
            if (cb.Value.ToString() == "True")
            {
                DataGridViewRow row = dgvLTC.Rows[e.RowIndex];
                foreach (DataGridViewRow c in dgvLTC.Rows)
                {
                    if (c.Cells[2].Value.ToString() == dgvLTC.Rows[e.RowIndex].Cells[2].Value.ToString() &&
                        c.Cells[4].Value.ToString() != dgvLTC.Rows[e.RowIndex].Cells[4].Value.ToString() && c.Cells[0].Value.ToString() =="True")
                    {
                        MessageBox.Show("Môn học đã chọn, vui lòng chọn môn học khác", "", MessageBoxButtons.OK);
                        cb.Value = false;
                        return;
                    }
                }
                dgvDK.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
            }
            else
            {
                foreach (DataGridViewRow c in dgvDK.Rows)
                {
                    if (c.Cells[0].Value.ToString() == dgvLTC.Rows[e.RowIndex].Cells[1].Value.ToString())
                    {
                        dgvDK.Rows.Remove(c);
                        return;
                    }
                }
            }
        }

        private void dgvLTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLTC.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //var senderGrid = (DataGridView)sender;
            //senderGrid.EndEdit();

            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
            //    e.RowIndex >= 0)
            //{

            //    var cbxCell = (DataGridViewCheckBoxCell)senderGrid.Rows[e.RowIndex].Cells["check"];
            //    if ((bool)cbxCell.Value)
            //    {
            //        DataGridViewRow row = senderGrid.Rows[e.RowIndex];
            //        dgvDK.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
            //    }
            //    else
            //    {
            //        foreach (DataGridViewRow c in dgvDK.Rows)
            //        {
            //            if (c.Cells[0].Value.ToString() == senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString())
            //            {
            //                dgvDK.Rows.Remove(c);
            //                return;
            //            }
            //        }
            //    }
            //}
        }

        private void dgvDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dgvDK.Rows[e.RowIndex];
            if(e.ColumnIndex == 5)
            {
                foreach (DataGridViewRow c in dgvLTC.Rows)
                {
                    if (c.Cells[1].Value.ToString() == r.Cells[0].Value.ToString())
                    {
                        c.Cells[0].Value = false;
                        return;
                    }
                }
                dgvDK.Rows.Remove(r);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(!(MessageBox.Show("Thao Tác Này Sẽ Cập Nhật CSDL\nĐồng Ý Thực Hiện Lưu?", "Lưu Ý!", MessageBoxButtons.YesNoCancel)==DialogResult.Yes))
            {
                return;
            }
            DataTable dtDangKi = new DataTable();
            DataTable dtHuy = new DataTable();
            String maSV = Program.mloginDN;

            dtDangKi.Clear();
            dtDangKi.Columns.Add("MALTC");
            dtDangKi.Columns.Add("MASV");

            dtHuy.Clear();
            dtHuy.Columns.Add("MALTC");
            dtHuy.Columns.Add("MASV");

            foreach (DataGridViewRow c in dgvDK.Rows)
            {
                int maLTC = (int)c.Cells[0].Value;
                if (!ltc_Da_DANG_KI.Contains(maLTC))
                {
                    DataRow dtr = dtDangKi.NewRow();
                    dtr["MALTC"] = maLTC;
                    dtr["MASV"] = maSV;
                    dtDangKi.Rows.Add(dtr);
                }
                else
                {
                    ltc_Da_DANG_KI.Remove(maLTC);
                }
            }
            foreach(int maltc in ltc_Da_DANG_KI)
            {
                DataRow dtr = dtHuy.NewRow();
                dtr["MALTC"] = maltc;
                dtr["MASV"] = maSV;
                dtHuy.Rows.Add(dtr);
            }

            String strLenh = "DANG_KI_LTC";
            SqlCommand Sqlcmd = new SqlCommand(strLenh, Program.conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandTimeout = 600;
            Sqlcmd.Parameters.AddWithValue("@DS", dtDangKi);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn.Close();
                return;
            }

            String strLenh1 = "HUY_DANG_KI_LTC";
            SqlCommand Sqlcmd1 = new SqlCommand(strLenh1, Program.conn);
            Sqlcmd1.CommandType = CommandType.StoredProcedure;
            Sqlcmd1.CommandTimeout = 600;
            Sqlcmd1.Parameters.AddWithValue("@DS", dtHuy);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {

                Sqlcmd1.ExecuteNonQuery();
                Program.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn.Close();
                return;
            }

            MessageBox.Show("DANG KY THANH CONG", "", MessageBoxButtons.OK);
            ltc_Da_DANG_KI.Clear();
            dgvLTC.Rows.Clear();
            dgvDK.Rows.Clear();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
