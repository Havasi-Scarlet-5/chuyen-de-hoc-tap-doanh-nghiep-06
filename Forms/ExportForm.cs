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

            chiTietCTDTReport.DataSource = DatabaseManager.LayDuLieuBangChiTietCTDTExport(maCTDT);

            chiTietCTDTReport.SoTTxrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex] + 1"));

            chiTietCTDTReport.ShowPreviewDialog();
        }

        private void InKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
