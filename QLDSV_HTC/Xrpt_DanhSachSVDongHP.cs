using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC
{
    public partial class Xrpt_DanhSachSVDongHP : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachSVDongHP()
        {
            InitializeComponent();
        }

        public Xrpt_DanhSachSVDongHP(string maLop, string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocKy;

        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "không";

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " tỷ ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += ",";

                var unitsMap = new[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
                var tensMap = new[] { "không", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        private void calculatedField2_GetValue(object sender, GetValueEventArgs e)
        {
            if (!(e.GetColumnValue("TONGSOTIENDONG") is DBNull))
            {
                int tongSoTienDong = 0;
                Console.WriteLine(e.GetColumnValue("TONGSOTIENDONG"));

                tongSoTienDong += Convert.ToInt32(e.GetColumnValue("SUM([TONGSOTIENDONG])"));

                e.Value = "(" + NumberToWords(tongSoTienDong) + ")";
            }
        }
    }
}
