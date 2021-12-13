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
    public partial class frmTaiKhoan : Form
    {
        private SqlConnection conn = new SqlConnection();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.mGroup != "SV")
            {
                DataTable dt = new DataTable();
                conn.ConnectionString = Program.connstr;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("EXEC GET_GV", conn);
                da.Fill(dt);
                conn.Close();
                cmbUsername.DataSource = dt;
                cmbUsername.DisplayMember = "TENGIANGVIEN";
                cmbUsername.ValueMember = "MAGIANGVIEN";
                txtRole.Text = Program.mGroup;
                btnDoiMatKhau.Visible = false;
            }
            else
            {
                btnTaoTaiKhoan.Visible = false;
            }



            
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            panelControl2.Visible = true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            panelControl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Ten Tai Khoan Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Mat Khau Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }

            String strLenh1 = "SP_TAOLOGIN";
            SqlCommand Sqlcmd1 = new SqlCommand(strLenh1, Program.conn);
            Sqlcmd1.CommandType = CommandType.StoredProcedure;
            Sqlcmd1.CommandTimeout = 600;
            Sqlcmd1.Parameters.AddWithValue("@LGNAME", txtTaiKhoan.Text);
            Sqlcmd1.Parameters.AddWithValue("@PASS", txtPassword.Text);
            Sqlcmd1.Parameters.AddWithValue("@USERNAME", cmbUsername.SelectedValue);
            Sqlcmd1.Parameters.AddWithValue("@ROLE", txtRole.Text);
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

            MessageBox.Show("THEM THANH CONG", "", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Mat Khau Moi Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtMatKhauMoi.Focus();
                return;
            }

            if (txtMatKhauMoiXacNhan.Text == "")
            {
                MessageBox.Show("Xac Nhan Mat Khau Moi Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtMatKhauMoiXacNhan.Focus();
                return;
            }

            if(txtMatKhau.Text!=Program.passwordDN)
            {
                MessageBox.Show("Mat Khau Bi Sai!", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }

            if(txtMatKhauMoi.Text !=txtMatKhauMoiXacNhan.Text)
            {
                MessageBox.Show("Xac Nhan Mat Khau Moi Bi Sai Khong Duoc Thieu!", "", MessageBoxButtons.OK);
                txtMatKhauMoiXacNhan.Focus();
                return;
            }

            String strLenh1 = "SP_DOI_MAT_KHAU_SINH_VIEN";
            SqlCommand Sqlcmd1 = new SqlCommand(strLenh1, Program.conn);
            Sqlcmd1.CommandType = CommandType.StoredProcedure;
            Sqlcmd1.CommandTimeout = 600;
            Sqlcmd1.Parameters.AddWithValue("@MATKHAU", txtMatKhauMoi.Text);
            Sqlcmd1.Parameters.AddWithValue("@MASV", Program.mloginDN);
            Program.passwordDN = txtMatKhauMoi.Text;
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

            MessageBox.Show("Doi Thanh Cong", "", MessageBoxButtons.OK);
        }
    }
}
