using System;
using System.Drawing;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    public partial class KeHoachDaoTaoTheoKhoaReport : DevExpress.XtraReports.UI.XtraReport
    {
        public KeHoachDaoTaoTheoKhoaReport()
        {
            InitializeComponent();
        }

        public int namHoc = 0;

        private void Detail_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int namHocHienTai = Convert.ToInt32(GetCurrentColumnValue("NamHoc"));

            int hocKyHienTai = Convert.ToInt32(GetCurrentColumnValue("HocKy"));

            if (namHocHienTai == namHoc)
            {
                if (hocKyHienTai == 1)
                    Detail.BackColor = ColorTranslator.FromHtml("#c6e0b4");

                if (hocKyHienTai == 2)
                    Detail.BackColor = ColorTranslator.FromHtml("#ffe699");
            }

            if (namHocHienTai == namHoc + 1)
            {
                if (hocKyHienTai == 1)
                    Detail.BackColor = ColorTranslator.FromHtml("#f8cbad");

                if (hocKyHienTai == 2)
                    Detail.BackColor = ColorTranslator.FromHtml("#ddebf7");
            }

            if (namHocHienTai == namHoc + 2)
            {
                if (hocKyHienTai == 1)
                    Detail.BackColor = ColorTranslator.FromHtml("#c6e0b4");

                if (hocKyHienTai == 2)
                    Detail.BackColor = ColorTranslator.FromHtml("#ffff00");
            }
        }
    }
}