using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
           
        }
        int beforeEditDiemCC = 0;
        float beforeEditDiemGK = 0;
        float beforeEditDiemCK = 0;
        int MALTC = 0;

        public class CustomDataGridViewCell
        {
            public CustomDataGridViewCell(DataGridViewCell dgvc, float oldValue, float newValue)
            {
                this.dgvc = dgvc;
                this.oldValue = oldValue;
                this.newValue = newValue;
            }

          public  DataGridViewCell dgvc { get; set; }

           public float oldValue { get; set; }

            public float newValue { get; set; }

        
        }

        Stack<CustomDataGridViewCell> undoStack = new Stack<CustomDataGridViewCell>();

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            string nienKhoa = cmbNienKhoa.Text;
            decimal hocKy = nudHocKi.Value;
            string monHoc = cmbMonHoc.SelectedValue.ToString();
            decimal nhom = nudNhom.Value;

            dgvND.Rows.Clear();

            try
            {
                DataTable dt = new DataTable();
                string query = "EXEC GET_DS_SINHVIEN_LTC @NIENKHOA = N'" + nienKhoa + "', @HOCKY=" + hocKy + ", @MAMH = N'" + monHoc + "', @NHOM = " + nhom;
                if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
                dt = Program.ExecSqlDataTable(query);

                foreach (DataRow dtr in dt.Rows)
                {
                    int diemCC = int.Parse(dtr[2].ToString());
                    float diemGK = float.Parse(dtr[3].ToString());
                    float diemCK = float.Parse(dtr[4].ToString());
                    float diemHetMon = (float)Math.Round(diemCC*0.1 + diemGK*0.3 + diemCK*0.6, 2, MidpointRounding.ToEven);

                    dgvND.Rows.Add(dtr[0], dtr[1], dtr[2], dtr[3], dtr[4], diemHetMon);
                }
                DataRow dr = dt.Rows[0];
                MALTC = int.Parse(dr[5].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối CSDL!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            this.TENVAMAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TENVAMAMHTableAdapter.Fill(this.dS.TENVAMAMH);
            //if(Program.mGroup == "PGV")
            //{
            //    cmbKhoa.Visible = true;
            //    cmbKhoa.DataSource = Program.bds_dspm;
            //    cmbKhoa.DisplayMember = "TENKHOA";
            //    cmbKhoa.ValueMember = "TENSERVER";
            //    cmbKhoa.SelectedIndex = Program.mChinhanh;
            //}
        }

        private void dgvND_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvND.CurrentCell.ColumnIndex;
            int rowIndex = dgvND.CurrentCell.RowIndex;
            DataGridViewRow currentRow = dgvND.Rows[rowIndex];
            string edittingCell = currentRow.Cells[columnIndex].Value.ToString();
            string columnName = dgvND.Columns[columnIndex].Name;
            Console.WriteLine("column name:" + columnName);

            int diemCC = 0;
            float diemGK = 0;
            float diemCK = 0;
            string cDiemCC = currentRow.Cells[2].Value.ToString();
            string cDiemGK = currentRow.Cells[3].Value.ToString();
            string cDiemCK = currentRow.Cells[4].Value.ToString();

            if(columnName == "colDiemCC")
            {
                if (!Regex.IsMatch(edittingCell, @"^[0-9]$|^10$"))
                {
                    MessageBox.Show("Vui lòng nhập trong khoảng 1 - 10");
                    currentRow.Cells[2].Value = beforeEditDiemCC;
                    return;
                }
            }
            else if(columnName == "colDiemGK") {
                if (!Regex.IsMatch(edittingCell, @"^[0-9]([.][0-9]{1,2})?$|^10$"))
                {
                    MessageBox.Show("Vui lòng nhập trong khoảng 1 - 10");
                    currentRow.Cells[3].Value = beforeEditDiemGK;
                    return;
                }
            } else if(columnName == "colDiemCK")
            {
                if (!Regex.IsMatch(edittingCell, @"^[0-9]([.][0-9]{1,2})?$|^10$"))
                {
                    MessageBox.Show("Vui lòng nhập trong khoảng 1 - 10");
                    currentRow.Cells[4].Value = beforeEditDiemCK;
                    return;
                }
           
            }
            Int32.TryParse(cDiemCC, out diemCC);
            float.TryParse(cDiemGK, out diemGK);
            float.TryParse(cDiemCK, out diemCK);

            Console.WriteLine("diemCC:" + diemCC);
            Console.WriteLine("diemGK:" + diemGK);
            Console.WriteLine("diemCK:" + diemCK);
             
                currentRow.Cells[5].Value = Math.Round(diemCC * 0.1 + diemGK * 0.3 + diemCK * 0.6, 2, MidpointRounding.ToEven);

        }

        private void dgvND_CellEnter(object sender, DataGridViewCellEventArgs e)
        {     
            var selectedCell = dgvND.CurrentCell;
            string columnName = dgvND.Columns[selectedCell.ColumnIndex].Name;
            if (columnName == "colDiemCC")
            {
                beforeEditDiemCC = int.Parse(dgvND.Rows[selectedCell.RowIndex].Cells[2].Value.ToString());
            } else if(columnName == "colDiemGK")
            {
                beforeEditDiemGK = float.Parse(dgvND.Rows[selectedCell.RowIndex].Cells[3].Value.ToString());
            } else if(columnName == "colDiemCK")
            {
                beforeEditDiemCK = float.Parse(dgvND.Rows[selectedCell.RowIndex].Cells[4].Value.ToString());
            }         
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            SqlCommand Sqlcmd = Program.conn.CreateCommand();
            Sqlcmd.CommandText = "dbo.SP_GHI_DIEM";
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandTimeout = 600;
            DataTable dt = new DataTable();
            dt.Columns.Add("MASV");
            dt.Columns.Add("DIEM_CC");
            dt.Columns.Add("DIEM_GK");
            dt.Columns.Add("DIEM_CK");

            foreach (DataGridViewRow dgvr in dgvND.Rows)
            {
                dt.Rows.Add(dgvr.Cells[0].Value, dgvr.Cells[2].Value, dgvr.Cells[3].Value, dgvr.Cells[4].Value);
            }

            Sqlcmd.Parameters.AddWithValue("@MALTC", MALTC);
            Sqlcmd.Parameters.AddWithValue("@ListDSV", dt).SqlDbType = SqlDbType.Structured; ;
   
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); 
                Program.conn.Close();
                MessageBox.Show("Ghi điểm thành công.");
                undoStack.Clear();
                return;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn.Close();
                return;
            }

        }

        private void dgvND_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewCell oldValue = dgvND[e.ColumnIndex, e.RowIndex];
            var newValue = e.FormattedValue;

            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                CustomDataGridViewCell cdgvc = new CustomDataGridViewCell(oldValue, float.Parse(oldValue.Value.ToString()), float.Parse(newValue.ToString()));
                undoStack.Push(cdgvc);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(undoStack.Count > 0 && undoStack.Peek() != null)
            {
                CustomDataGridViewCell cdgvc = undoStack.Pop();
                dgvND[cdgvc.dgvc.ColumnIndex, cdgvc.dgvc.RowIndex].Value = cdgvc.oldValue;
                //dgvND.CurrentCell = dgvND[cdgvc.dgvc.ColumnIndex, cdgvc.dgvc.RowIndex];
            }
        }
    }
}
