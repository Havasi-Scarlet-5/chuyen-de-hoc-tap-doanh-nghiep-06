using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    public partial class ExportForm : Form
    {
        private readonly Random random = new Random();

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

            if (dataSource.Rows.Count > 0)
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
            KeHoachDaoTaoTheoKhoaReport keHoachDaoTaoTheoKhoaReport = new KeHoachDaoTaoTheoKhoaReport();

            DateTime ngayThangNam = DateTime.Now;

            int ngay = ngayThangNam.Day;

            int thang = ngayThangNam.Month;

            int nam = ngayThangNam.Year;

            keHoachDaoTaoTheoKhoaReport.topTitleXrLabel.Text = $"Phụ lục 14A: Ban hành theo quyết định số 1 / QĐ-CĐKT ngày {ngay} tháng {thang} năm {nam}";

            string khoa = inKeHoachDaoTaoTheoKhoaKhoaComboBox.SelectedValue == null ? "" : inKeHoachDaoTaoTheoKhoaKhoaComboBox.SelectedValue.ToString();

            var dataSource = DatabaseManager.LayDuLieuBangKeHoachDaoTaoTheoKhoaExport(khoa);

            int namHoc = dataSource.Rows.Count > 0 ? Convert.ToInt32(dataSource.Rows[0]["NamHoc"]) : 0;

            keHoachDaoTaoTheoKhoaReport.titleXrLabel.Text = "KẾ HOẠCH ĐÀO TẠO - TRÌNH ĐỘ " + (khoa.Contains("CD") ? "CAO ĐẲNG" : "TRUNG CẤP") + $" KHÓA {namHoc}";

            string nghe = dataSource.Rows.Count > 0 ? dataSource.Rows[0]["TenNghe"].ToString() : "";

            string lop = dataSource.Rows.Count > 0 ? dataSource.Rows[0]["MaCTDT"].ToString().Split('_')[0] : "";

            string namPhatHanh = dataSource.Rows.Count > 0 ? dataSource.Rows[0]["NamPhatHanh"].ToString() : "";

            string maNghe = dataSource.Rows.Count > 0 ? dataSource.Rows[0]["MaNghe"].ToString() : "";

            keHoachDaoTaoTheoKhoaReport.bottomTitleXrLabel.Text = $"Nghề: {nghe} {lop}; Chương trình đào tạo năm {namPhatHanh} (Mã nghề: {maNghe})";

            // Begin custom table

            // Thêm 4 cột để tính số tuần LT và TH cho các môn học

            dataSource.Columns.Add("SoTuanBoTriLyThuyet", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyet", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanh", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanh", typeof(float));

            // Sau đó thêm 24 cột nữa ối dồi ôi!!!!

            // Năm 1

            dataSource.Columns.Add("SoTuanBoTriLyThuyetHK1Nam1", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyetHK1Nam1", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanhHK1Nam1", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanhHK1Nam1", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriLyThuyetHK2Nam1", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyetHK2Nam1", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanhHK2Nam1", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanhHK2Nam1", typeof(float));

            // Năm 2

            dataSource.Columns.Add("SoTuanBoTriLyThuyetHK1Nam2", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyetHK1Nam2", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanhHK1Nam2", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanhHK1Nam2", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriLyThuyetHK2Nam2", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyetHK2Nam2", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanhHK2Nam2", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanhHK2Nam2", typeof(float));

            // Năm 3

            dataSource.Columns.Add("SoTuanBoTriLyThuyetHK1Nam3", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyetHK1Nam3", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanhHK1Nam3", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanhHK1Nam3", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriLyThuyetHK2Nam3", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeLyThuyetHK2Nam3", typeof(float));

            dataSource.Columns.Add("SoTuanBoTriThucHanhHK2Nam3", typeof(int));

            dataSource.Columns.Add("SoTuanThucTeThucHanhHK2Nam3", typeof(float));

            // Tiếp tục thêm 12 cột nữa để tính tổng

            // Năm 1

            dataSource.Columns.Add("LyThuyetHK1Nam1", typeof(int));

            dataSource.Columns.Add("LyThuyetHK2Nam1", typeof(int));

            dataSource.Columns.Add("ThucHanhHK1Nam1", typeof(int));

            dataSource.Columns.Add("ThucHanhHK2Nam1", typeof(int));

            // Năm 2

            dataSource.Columns.Add("LyThuyetHK1Nam2", typeof(int));

            dataSource.Columns.Add("LyThuyetHK2Nam2", typeof(int));

            dataSource.Columns.Add("ThucHanhHK1Nam2", typeof(int));

            dataSource.Columns.Add("ThucHanhHK2Nam2", typeof(int));

            // Năm 3

            dataSource.Columns.Add("LyThuyetHK1Nam3", typeof(int));

            dataSource.Columns.Add("LyThuyetHK2Nam3", typeof(int));

            dataSource.Columns.Add("ThucHanhHK1Nam3", typeof(int));

            dataSource.Columns.Add("ThucHanhHK2Nam3", typeof(int));

            // Lấy năm học làm chuẩn cho năm thứ 1 sử dụng biến namHoc

            if (dataSource.Rows.Count > 0)
                foreach (DataRow row in dataSource.Rows)
                {
                    int lyThuyet = Convert.ToInt32(row["LyThuyet"]);

                    int thucHanh = Convert.ToInt32(row["ThucHanh"]);

                    int kiemTra = Convert.ToInt32(row["KiemTra"]);

                    float randomRange = (float)(0.9 + (random.NextDouble() * 0.1));

                    row["SoTuanBoTriLyThuyet"] = (lyThuyet / 48) + 1;

                    row["SoTuanThucTeLyThuyet"] = ((int)row["SoTuanBoTriLyThuyet"] - 1) + randomRange;

                    row["SoTuanBoTriThucHanh"] = ((thucHanh + kiemTra) / 48) + 1;

                    row["SoTuanThucTeThucHanh"] = ((int)row["SoTuanBoTriThucHanh"] - 1) + randomRange;

                    int soTuanBoTriLyThuyet = Convert.ToInt32(row["SoTuanBoTriLyThuyet"]);

                    float soTuanThucTeLyThuyet = (float)Math.Round(Convert.ToSingle(row["SoTuanThucTeLyThuyet"]), 1);

                    int soTuanBoTriThucHanh = Convert.ToInt32(row["SoTuanBoTriThucHanh"]);

                    float soTuanThucTeThucHanh = (float)Math.Round(Convert.ToSingle(row["SoTuanThucTeThucHanh"]), 1);

                    int namHocHienTai = Convert.ToInt32(row["NamHoc"]);

                    int hocKyHienTai = Convert.ToInt32(row["HocKy"]);

                    if (namHocHienTai == namHoc)
                    {
                        row[$"LyThuyetHK{hocKyHienTai}Nam1"] = lyThuyet;

                        row[$"ThucHanhHK{hocKyHienTai}Nam1"] = thucHanh + kiemTra;

                        row[$"SoTuanBoTriLyThuyetHK{hocKyHienTai}Nam1"] = soTuanBoTriLyThuyet;

                        row[$"SoTuanThucTeLyThuyetHK{hocKyHienTai}Nam1"] = soTuanThucTeLyThuyet;

                        row[$"SoTuanBoTriThucHanhHK{hocKyHienTai}Nam1"] = soTuanBoTriThucHanh;

                        row[$"SoTuanThucTeThucHanhHK{hocKyHienTai}Nam1"] = soTuanThucTeThucHanh;
                    }

                    if (namHocHienTai == namHoc + 1)
                    {
                        row[$"LyThuyetHK{hocKyHienTai}Nam2"] = lyThuyet;

                        row[$"ThucHanhHK{hocKyHienTai}Nam2"] = thucHanh + kiemTra;

                        row[$"SoTuanBoTriLyThuyetHK{hocKyHienTai}Nam2"] = soTuanBoTriLyThuyet;

                        row[$"SoTuanThucTeLyThuyetHK{hocKyHienTai}Nam2"] = soTuanThucTeLyThuyet;

                        row[$"SoTuanBoTriThucHanhHK{hocKyHienTai}Nam2"] = soTuanBoTriThucHanh;

                        row[$"SoTuanThucTeThucHanhHK{hocKyHienTai}Nam2"] = soTuanThucTeThucHanh;
                    }

                    if (namHocHienTai == namHoc + 2)
                    {
                        row[$"LyThuyetHK{hocKyHienTai}Nam3"] = lyThuyet;

                        row[$"ThucHanhHK{hocKyHienTai}Nam3"] = thucHanh + kiemTra;

                        row[$"SoTuanBoTriLyThuyetHK{hocKyHienTai}Nam3"] = soTuanBoTriLyThuyet;

                        row[$"SoTuanThucTeLyThuyetHK{hocKyHienTai}Nam3"] = soTuanThucTeLyThuyet;

                        row[$"SoTuanBoTriThucHanhHK{hocKyHienTai}Nam3"] = soTuanBoTriThucHanh;

                        row[$"SoTuanThucTeThucHanhHK{hocKyHienTai}Nam3"] = soTuanThucTeThucHanh;
                    }
                }

            // End custom table

            keHoachDaoTaoTheoKhoaReport.DataSource = dataSource;

            keHoachDaoTaoTheoKhoaReport.SoTTXrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex] + 1"));

            keHoachDaoTaoTheoKhoaReport.namHoc = namHoc;

            keHoachDaoTaoTheoKhoaReport.ShowPreviewDialog();
        }
    }
}