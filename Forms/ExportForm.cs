using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        public void SetInChiTietCTDTData(DataTable dataTable)
        {
            inChiTietCTDTMaCTDTComboBox.DataSource = dataTable;

            inChiTietCTDTMaCTDTComboBox.DisplayMember = "MaCTDT";

            inChiTietCTDTMaCTDTComboBox.ValueMember = "MaCTDT";
        }

        public void SetInKeHoachDaoTaoTheoKhoaData(DataTable dataTable)
        {
            inKeHoachDaoTaoTheoKhoaKhoaComboBox.DataSource = dataTable;

            inKeHoachDaoTaoTheoKhoaKhoaComboBox.DisplayMember = "Khoa";

            inKeHoachDaoTaoTheoKhoaKhoaComboBox.ValueMember = "Khoa";
        }

        private void InChiTietCTDTInBaoCaoButton_Click(object sender, System.EventArgs e)
        {
            ChiTietCTDTReport chiTietCTDTReport = new ChiTietCTDTReport();

            string maCTDT = inChiTietCTDTMaCTDTComboBox.SelectedValue == null ? "" : inChiTietCTDTMaCTDTComboBox.SelectedValue.ToString();

            if (maCTDT.StartsWith("CD"))
                chiTietCTDTReport.titleXrLabel.Text = "TRÌNH ĐỘ CAO ĐẲNG NGHỀ CÔNG NGHỆ THÔNG TIN";

            if (maCTDT.StartsWith("TC"))
                chiTietCTDTReport.titleXrLabel.Text = "TRÌNH ĐỘ TRUNG CẤP NGHỀ CÔNG NGHỆ THÔNG TIN";

            if (maCTDT.Contains("1"))
                chiTietCTDTReport.titleXrLabel.Text = "TRÌNH ĐỘ CAO ĐẲNG LIÊN THÔNG NGHỀ CÔNG NGHỆ THÔNG TIN";

            var dataSource = DatabaseManager.LayDuLieuBangChiTietCTDTExport(maCTDT);

            foreach (DataRow row in dataSource.Rows)
            {
                string loaiMon = row["LoaiMon"].ToString();

                switch (loaiMon)
                {
                    case "Môn chung":
                        row["LoaiMon"] = "I. Các môn chung";
                        break;

                    case "Môn học cơ sở":
                        row["LoaiMon"] = "II. Các môn học cơ sở";
                        break;

                    case "Môn học chuyên nghề":
                        row["LoaiMon"] = "III. Các môn học chuyên môn nghề";
                        break;

                    case "Môn học chuyên nghề tự chọn":
                        row["LoaiMon"] = "IV. Các môn học chuyên môn nghề tự chọn";
                        break;
                }
            }

            chiTietCTDTReport.DataSource = dataSource;

            chiTietCTDTReport.SoTTxrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex] + 1"));

            chiTietCTDTReport.ShowPreviewDialog();
        }

        private void InKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
