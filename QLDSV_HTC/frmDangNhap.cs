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
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if(conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChinhanh.DataSource = Program.bds_dspm;
            cmbChinhanh.DisplayMember = "TENKHOA";
            cmbChinhanh.ValueMember = "TENSERVER";
        }

        public frmDangNhap() { InitializeComponent(); }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(!chbSinhVien.Checked)
            {
                if(txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;
                if(Program.KetNoi() == 0)
                    return;

                Program.mChinhanh = cmbChinhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "EXEC SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if(Program.myReader == null)
                    return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if(Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show(
                        "Login bạn nhập không có quyển truy cập dữ liệu\n Bạn xem lại username, password",
                        "",
                        MessageBoxButtons.OK);
                    return;
                }

                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();

                Program.conn.Close();

                Program.frmChinh.MA.Text = "Mã = " + Program.username;
                Program.frmChinh.HOTEN.Text = "Họ tên = " + Program.mHoten;
                Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
                Program.frmChinh.HienThiMenu();
                Program.frmChinh.btnDangNhap.Enabled = false;
                Program.frmChinh.btnTaoTaiKhoan.Enabled = Program.frmChinh.btnDangXuat.Enabled = true;
                this.Close();
                MessageBox.Show("Dang Nhap Thanh Cong", "", MessageBoxButtons.OK);
            }
            else
            {
                if (txtLogin.Text.Trim() == "")
                {
                    MessageBox.Show("Login name không được trống", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mlogin = "HTKN_SV";
                Program.password = "123456";
                if (Program.KetNoi() == 0)
                    return;
                Program.mChinhanh = cmbChinhanh.SelectedIndex;
                Program.mloginDN = txtLogin.Text;
                Program.passwordDN = txtPass.Text;

                String strLenh = "EXEC SP_LOGIN @Login='" + Program.mloginDN + "', @Pass='" + Program.passwordDN + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                if (!Program.myReader.HasRows)
                {
                    MessageBox.Show(
                        "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng!",
                        "",
                        MessageBoxButtons.OK);
                    return;
                }

                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mLop = Program.myReader.GetString(2);
                Program.mGroup = "SV";
                Program.myReader.Close();

                Program.conn.Close();

                Program.frmChinh.MA.Text = "Mã = " + Program.username;
                Program.frmChinh.HOTEN.Text = "Họ tên = " + Program.mHoten;
                Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
                Program.frmChinh.MALOP.Text = "Lớp = " + Program.mLop;

                Program.frmChinh.HienThiMenu();
                Program.frmChinh.btnDangNhap.Enabled = false;
                Program.frmChinh.btnTaoTaiKhoan.Enabled = Program.frmChinh.btnDangXuat.Enabled = true;
                this.Close();
                MessageBox.Show("Dang Nhap Thanh Cong", "", MessageBoxButtons.OK);
            }
        }

        private int KetNoi_CSDLGOC()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            } catch(Exception e)
            {
                MessageBox.Show(
                    "Lỗi kết nối về cơ sở dữ liệu gốc.\nBạn xem lại tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n " +
                        e.Message,
                    "",
                    MessageBoxButtons.OK);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if(KetNoi_CSDLGOC() == 0)
                return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbChinhanh.SelectedIndex = 1;
            cmbChinhanh.SelectedIndex = 0;

            txtLogin.Text = "ptl";
            txtPass.Text = "123456";
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChinhanh.SelectedValue.ToString();
            } catch(Exception)
            {
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
