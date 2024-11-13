using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            DatabaseManager.Connect();

            InitTables();
        }

        private void InitTables()
        {
            // Khoa table

            UpdateKhoaTable();

            // Nghe table

            UpdateNgheTable();

            // MonHoc table

            UpdateMonHocTable();

            // CTDT table

            UpdateCTDTTable();

            // ChiTietCTDT table

            UpdateChiTietCTDTTable();

            // KeHoachDaoTaoTheoKhoa table

            UpdateKetHoachDaoTaoTheoKhoaTable();
        }

        private void UpdateKhoaTable()
        {
            khoaDataGridView.DataSource = DatabaseManager.LayDuLieuBangKhoa();

            khoaDataGridView.Columns["MaKhoa"].HeaderText = "Mã khoa";

            khoaDataGridView.Columns["TenKhoa"].HeaderText = "Tên khoa";

            ngheKhoaComboBox.DataSource = khoaDataGridView.DataSource;

            ngheKhoaComboBox.DisplayMember = "TenKhoa";

            ngheKhoaComboBox.ValueMember = "MaKhoa";
        }

        private void KhoaDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            if (khoaDataGridView.CurrentRow != null)
            {
                maKhoaTextBox.Text = khoaDataGridView.CurrentRow.Cells["MaKhoa"].Value.ToString();
                tenKhoaTextBox.Text = khoaDataGridView.CurrentRow.Cells["TenKhoa"].Value.ToString();
            }
        }

        private void KhoaThemButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.ThemKhoa(maKhoaTextBox.Text, tenKhoaTextBox.Text))
                UpdateKhoaTable();
        }

        private void KhoaSuaButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.SuaKhoa(maKhoaTextBox.Text, tenKhoaTextBox.Text))
                UpdateKhoaTable();
        }

        private void KhoaXoaButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.XoaKhoa(maKhoaTextBox.Text))
                UpdateKhoaTable();
        }

        private void UpdateNgheTable()
        {
            ngheDataGridView.DataSource = DatabaseManager.LayDuLieuBangNghe();

            ngheDataGridView.AutoGenerateColumns = false;

            ngheDataGridView.Columns["MaNghe"].HeaderText = "Mã nghề";

            ngheDataGridView.Columns["MaNghe"].DisplayIndex = 0;

            ngheDataGridView.Columns["TenNghe"].HeaderText = "Tên nghề";

            ngheDataGridView.Columns["TenNghe"].DisplayIndex = 1;

            ngheDataGridView.Columns["TenKhoa"].HeaderText = "Khoa";

            ngheDataGridView.Columns["TenKhoa"].DisplayIndex = 2;

            ngheDataGridView.Columns["MoTa"].HeaderText = "Mô tả";

            ngheDataGridView.Columns["MoTa"].DisplayIndex = 3;

            ngheDataGridView.Columns["MaKhoa"].Visible = false;

            ngheDataGridView.Columns["MaKhoa1"].Visible = false;

            monHocNgheComboBox.DataSource = ngheDataGridView.DataSource;

            monHocNgheComboBox.DisplayMember = "TenNghe";

            monHocNgheComboBox.ValueMember = "MaNghe";
        }

        private void NgheDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            if (ngheDataGridView.CurrentRow != null)
            {
                maNgheTextBox.Text = ngheDataGridView.CurrentRow.Cells["MaNghe"].Value.ToString();

                tenNgheTextBox.Text = ngheDataGridView.CurrentRow.Cells["TenNghe"].Value.ToString();

                ngheMoTaRichTextBox.Text = ngheDataGridView.CurrentRow.Cells["MoTa"].Value.ToString();

                ngheKhoaComboBox.SelectedValue = ngheDataGridView.CurrentRow.Cells["MaKhoa"].Value.ToString();
            }
        }

        private void NgheThemButton_Click(object sender, System.EventArgs e)
        {
            string ngheKhoa = ngheKhoaComboBox.SelectedValue == null ? string.Empty : ngheKhoaComboBox.SelectedValue.ToString();

            if (DatabaseManager.ThemNghe(maNgheTextBox.Text, tenNgheTextBox.Text, ngheKhoa, ngheMoTaRichTextBox.Text))
                UpdateNgheTable();
        }

        private void NgheSuaButton_Click(object sender, System.EventArgs e)
        {
            string ngheKhoa = ngheKhoaComboBox.SelectedValue == null ? string.Empty : ngheKhoaComboBox.SelectedValue.ToString();

            if (DatabaseManager.SuaNghe(maNgheTextBox.Text, tenNgheTextBox.Text, ngheKhoa, ngheMoTaRichTextBox.Text))
                UpdateNgheTable();
        }

        private void NgheXoaButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.XoaNghe(maNgheTextBox.Text))
                UpdateNgheTable();
        }

        private void UpdateMonHocTable()
        {
            monHocDataGridView.DataSource = DatabaseManager.LayDuLieuBangMonHoc();

            monHocDataGridView.AutoGenerateColumns = false;

            monHocDataGridView.Columns["MaMon"].DisplayIndex = 0;

            monHocDataGridView.Columns["MaMon"].HeaderText = "Mã môn";

            monHocDataGridView.Columns["KieuMa"].DisplayIndex = 1;

            monHocDataGridView.Columns["KieuMa"].HeaderText = "Kiểu mã";

            monHocDataGridView.Columns["LoaiMon"].DisplayIndex = 2;

            monHocDataGridView.Columns["LoaiMon"].HeaderText = "Loại môn";

            monHocDataGridView.Columns["TenMon"].DisplayIndex = 3;

            monHocDataGridView.Columns["TenMon"].HeaderText = "Tên môn";

            monHocDataGridView.Columns["TenNghe"].DisplayIndex = 4;

            monHocDataGridView.Columns["TenNghe"].HeaderText = "Nghề";

            monHocDataGridView.Columns["SoTinChi"].DisplayIndex = 5;

            monHocDataGridView.Columns["SoTinChi"].HeaderText = "Số tín chỉ";

            monHocDataGridView.Columns["Tong"].DisplayIndex = 6;

            monHocDataGridView.Columns["Tong"].HeaderText = "Tổng cộng";

            monHocDataGridView.Columns["LyThuyet"].DisplayIndex = 7;

            monHocDataGridView.Columns["LyThuyet"].HeaderText = "Lý thuyết";

            monHocDataGridView.Columns["ThucHanh"].DisplayIndex = 8;

            monHocDataGridView.Columns["ThucHanh"].HeaderText = "Thực hành";

            monHocDataGridView.Columns["KiemTra"].DisplayIndex = 9;

            monHocDataGridView.Columns["KiemTra"].HeaderText = "Kiểm tra";

            monHocDataGridView.Columns["ThuongXuyen"].DisplayIndex = 10;

            monHocDataGridView.Columns["ThuongXuyen"].HeaderText = "Thường xuyên";

            monHocDataGridView.Columns["DinhKy"].DisplayIndex = 11;

            monHocDataGridView.Columns["DinhKy"].HeaderText = "Định kỳ";

            monHocDataGridView.Columns["ThiHetMon"].DisplayIndex = 12;

            monHocDataGridView.Columns["ThiHetMon"].HeaderText = "Thi hết môn";

            monHocDataGridView.Columns["GhiChu"].DisplayIndex = 13;

            monHocDataGridView.Columns["GhiChu"].HeaderText = "Ghi chú";

            monHocDataGridView.Columns["MaNghe"].Visible = false;

            monHocDataGridView.Columns["MaNghe1"].Visible = false;

            monHocDataGridView.Columns["MaKhoa"].Visible = false;

            monHocDataGridView.Columns["MoTa"].Visible = false;

            ctCTDTMonHocComboBox.DataSource = monHocDataGridView.DataSource;

            ctCTDTMonHocComboBox.DisplayMember = "TenMon";

            ctCTDTMonHocComboBox.ValueMember = "MaMon";

            keHoachDaoTaoTheoKhoaMonComboBox.DataSource = monHocDataGridView.DataSource;

            keHoachDaoTaoTheoKhoaMonComboBox.DisplayMember = "TenMon";

            keHoachDaoTaoTheoKhoaMonComboBox.ValueMember = "MaMon";
        }

        private void MonHocDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            if (monHocDataGridView.CurrentRow != null)
            {
                monHocMaMonTextBox.Text = monHocDataGridView.CurrentRow.Cells["MaMon"].Value.ToString();

                monHocKieuMaTextBox.Text = monHocDataGridView.CurrentRow.Cells["KieuMa"].Value.ToString();

                monHocLoaiMonTextBox.Text = monHocDataGridView.CurrentRow.Cells["LoaiMon"].Value.ToString();

                monHocTenMonTextBox.Text = monHocDataGridView.CurrentRow.Cells["TenMon"].Value.ToString();

                monHocNgheComboBox.SelectedValue = monHocDataGridView.CurrentRow.Cells["MaNghe"].Value.ToString();

                monHocSoTinChiNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["SoTinChi"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["SoTinChi"].Value;

                monHocThucHanhNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["ThucHanh"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["ThucHanh"].Value;

                monHocLyThuyetNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["LyThuyet"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["LyThuyet"].Value;

                monHocKiemTraNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["KiemTra"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["KiemTra"].Value;

                monHocThuongXuyenNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["ThuongXuyen"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["ThuongXuyen"].Value;

                monHocDinhKyNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["DinhKy"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["DinhKy"].Value;

                monHocThiHetMonNumericUpDown.Value = monHocDataGridView.CurrentRow.Cells["ThiHetMon"].Value is DBNull
                    ? 0
                    : (int)monHocDataGridView.CurrentRow.Cells["ThiHetMon"].Value;

                monHocGhiChuTextBox.Text = monHocDataGridView.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
        }

        private void MonHocThemButton_Click(object sender, System.EventArgs e)
        {
            string monHocNghe = monHocNgheComboBox.SelectedValue == null ? string.Empty : monHocNgheComboBox.SelectedValue.ToString();

            if (DatabaseManager.ThemMonHoc(
                monHocMaMonTextBox.Text,
                monHocKieuMaTextBox.Text,
                monHocLoaiMonTextBox.Text,
                monHocTenMonTextBox.Text,
                monHocNghe,
                (int)monHocSoTinChiNumericUpDown.Value,
                (int)monHocLyThuyetNumericUpDown.Value,
                (int)monHocThucHanhNumericUpDown.Value,
                (int)monHocKiemTraNumericUpDown.Value,
                (int)monHocThuongXuyenNumericUpDown.Value,
                (int)monHocDinhKyNumericUpDown.Value,
                (int)monHocThiHetMonNumericUpDown.Value,
                monHocGhiChuTextBox.Text
            ))
                UpdateMonHocTable();
        }

        private void MonHocSuaButton_Click(object sender, System.EventArgs e)
        {
            string monHocNghe = monHocNgheComboBox.SelectedValue == null ? string.Empty : monHocNgheComboBox.SelectedValue.ToString();

            if (DatabaseManager.SuaMonHoc(
                monHocMaMonTextBox.Text,
                monHocKieuMaTextBox.Text,
                monHocLoaiMonTextBox.Text,
                monHocTenMonTextBox.Text,
                monHocNghe,
                (int)monHocSoTinChiNumericUpDown.Value,
                (int)monHocLyThuyetNumericUpDown.Value,
                (int)monHocThucHanhNumericUpDown.Value,
                (int)monHocKiemTraNumericUpDown.Value,
                (int)monHocThuongXuyenNumericUpDown.Value,
                (int)monHocDinhKyNumericUpDown.Value,
                (int)monHocThiHetMonNumericUpDown.Value,
                monHocGhiChuTextBox.Text
            ))
                UpdateMonHocTable();
        }

        private void MonHocXoaButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.XoaMonHoc(monHocMaMonTextBox.Text))
                UpdateMonHocTable();
        }

        private void UpdateCTDTTable()
        {
            ctdtDataGridView.DataSource = DatabaseManager.LayDuLieuBangCTDT();

            ctdtDataGridView.AutoGenerateColumns = false;

            ctdtDataGridView.Columns["MaCTDT"].DisplayIndex = 0;

            ctdtDataGridView.Columns["MaCTDT"].HeaderText = "Mã chường trình đào đạo";

            ctdtDataGridView.Columns["NamPhatHanh"].DisplayIndex = 1;

            ctdtDataGridView.Columns["NamPhatHanh"].HeaderText = "Năm phát hành";

            ctdtDataGridView.Columns["MoTa"].DisplayIndex = 2;

            ctdtDataGridView.Columns["MoTa"].HeaderText = "Mô tả";

            ctCTDTMaCTDTComboBox.DataSource = ctdtDataGridView.DataSource;

            ctCTDTMaCTDTComboBox.DisplayMember = "MaCTDT";

            ctCTDTMaCTDTComboBox.ValueMember = "MaCTDT";

            keHoachDaoTaoTheoKhoaMaCTDTComboBox.DataSource = ctdtDataGridView.DataSource;

            keHoachDaoTaoTheoKhoaMaCTDTComboBox.DisplayMember = "MaCTDT";

            keHoachDaoTaoTheoKhoaMaCTDTComboBox.ValueMember = "MaCTDT";

            Program.exportForm.SetInChiTietCTDTData((DataTable)ctdtDataGridView.DataSource);
        }

        private void CtdtDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ctdtDataGridView.CurrentRow != null)
            {
                ctdtMaCTDTTextBox.Text = ctdtDataGridView.CurrentRow.Cells["MaCTDT"].Value.ToString();

                ctdtNamPhatHanhNumericUpDown.Value = ctdtDataGridView.CurrentRow.Cells["NamPhatHanh"].Value is DBNull
                    ? 0
                    : (int)ctdtDataGridView.CurrentRow.Cells["NamPhatHanh"].Value;

                ctdtMoTaRichTextBox.Text = ctdtDataGridView.CurrentRow.Cells["MoTa"].Value.ToString();
            }
        }

        private void CtdtThemButton_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.ThemCTDT(ctdtMaCTDTTextBox.Text, (int)ctdtNamPhatHanhNumericUpDown.Value, ctdtMoTaRichTextBox.Text))
                UpdateCTDTTable();
        }

        private void CtdtSuaButton_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.SuaCTDT(ctdtMaCTDTTextBox.Text, (int)ctdtNamPhatHanhNumericUpDown.Value, ctdtMoTaRichTextBox.Text))
                UpdateCTDTTable();
        }

        private void CtdtXoaButton_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.XoaCTDT(ctdtMaCTDTTextBox.Text))
                UpdateCTDTTable();
        }

        private void UpdateChiTietCTDTTable()
        {
            ctCTDTDataGridView.DataSource = DatabaseManager.LayDuLieuBangChiTietCTDT();

            ctCTDTDataGridView.AutoGenerateColumns = false;

            foreach (DataGridViewColumn column in ctCTDTDataGridView.Columns)
            {
                switch (column.Name)
                {
                    case "MaCTDT":
                        column.DisplayIndex = 0;
                        column.HeaderText = "Mã chường trình đào đạo";
                        break;
                    case "TenMon":
                        column.DisplayIndex = 1;
                        column.HeaderText = "Môn học";
                        break;
                    case "HocKy":
                        column.DisplayIndex = 2;
                        column.HeaderText = "Học kỳ";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void CtCTDTDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ctCTDTDataGridView.CurrentRow != null)
            {
                ctCTDTMaCTDTComboBox.SelectedValue = ctCTDTDataGridView.CurrentRow.Cells["MaCTDT"].Value.ToString();

                ctCTDTMonHocComboBox.SelectedValue = ctCTDTDataGridView.CurrentRow.Cells["MaMon"].Value.ToString();

                ctCTDTHocKyNumericUpDown.Value = ctCTDTDataGridView.CurrentRow.Cells["HocKy"].Value is DBNull
                    ? 0
                    : (int)ctCTDTDataGridView.CurrentRow.Cells["HocKy"].Value;
            }
        }

        private void CtCTDTThemButton_Click(object sender, EventArgs e)
        {
            string maCTDT = ctCTDTMaCTDTComboBox.SelectedValue == null ? string.Empty : ctCTDTMaCTDTComboBox.SelectedValue.ToString();

            string maMon = ctCTDTMonHocComboBox.SelectedValue == null ? string.Empty : ctCTDTMonHocComboBox.SelectedValue.ToString();

            if (DatabaseManager.ThemChiTietCTDT(maCTDT, maMon, (int)ctCTDTHocKyNumericUpDown.Value))
                UpdateChiTietCTDTTable();
        }

        private void CtCTDTSuaButton_Click(object sender, EventArgs e)
        {
            string maCTDT = ctCTDTMaCTDTComboBox.SelectedValue == null ? string.Empty : ctCTDTMaCTDTComboBox.SelectedValue.ToString();

            string maMon = ctCTDTMonHocComboBox.SelectedValue == null ? string.Empty : ctCTDTMonHocComboBox.SelectedValue.ToString();

            if (DatabaseManager.SuaChiTietCTDT(maCTDT, maMon, (int)ctCTDTHocKyNumericUpDown.Value))
                UpdateChiTietCTDTTable();
        }

        private void CtCTDTXoaButton_Click(object sender, EventArgs e)
        {
            string maCTDT = ctCTDTMaCTDTComboBox.SelectedValue == null ? string.Empty : ctCTDTMaCTDTComboBox.SelectedValue.ToString();

            string maMon = ctCTDTMonHocComboBox.SelectedValue == null ? string.Empty : ctCTDTMonHocComboBox.SelectedValue.ToString();

            if (DatabaseManager.XoaChiTietCTDT(maCTDT, maMon))
                UpdateChiTietCTDTTable();
        }

        private void UpdateKetHoachDaoTaoTheoKhoaTable()
        {
            keHoachDaoTaoTheoKhoaDataGridView.DataSource = DatabaseManager.LayDuLieuBangKeHoachDaoTaoTheoKhoa();

            keHoachDaoTaoTheoKhoaDataGridView.AutoGenerateColumns = false;

            foreach (DataGridViewColumn column in keHoachDaoTaoTheoKhoaDataGridView.Columns)
            {
                switch (column.Name)
                {
                    case "MaCTDT":
                        column.DisplayIndex = 0;
                        column.HeaderText = "Mã chường trình đào đạo";
                        break;
                    case "TenMon":
                        column.DisplayIndex = 1;
                        column.HeaderText = "Môn học";
                        break;
                    case "Khoa":
                        column.DisplayIndex = 2;
                        column.HeaderText = "Khóa";
                        break;
                    case "HocKy":
                        column.DisplayIndex = 3;
                        column.HeaderText = "Học kỳ";
                        break;
                    case "NamHoc":
                        column.DisplayIndex = 4;
                        column.HeaderText = "Năm học";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }

            Program.exportForm.SetInKeHoachDaoTaoTheoKhoaData(DatabaseManager.LayDanhSachKhoaBangKeHoachDaoTaoTheoKhoa());
        }

        private void KeHoachDaoTaoTheoKhoaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (keHoachDaoTaoTheoKhoaDataGridView.CurrentRow != null)
            {
                keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue = keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["MaCTDT"].Value.ToString();

                keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue = keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["MaMon"].Value.ToString();

                keHoachDaoTaoTheoKhoaKhoaTextBox.Text = keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["Khoa"].Value.ToString();

                keHoachDaoTaoTheoKhoaHocKyNumericUpDown.Value = keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["HocKy"].Value is DBNull
                    ? 0
                    : (int)keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["HocKy"].Value;

                keHoachDaoTaoTheoKhoaNamHocNumericUpDown.Value = keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["NamHoc"].Value is DBNull
                    ? 0
                    : (int)keHoachDaoTaoTheoKhoaDataGridView.CurrentRow.Cells["NamHoc"].Value;
            }
        }

        private void KeHoachDaoTaoTheoKhoaThemButton_Click(object sender, EventArgs e)
        {
            string maCTDT = keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue == null ? string.Empty : keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue.ToString();

            string maMon = keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue == null ? string.Empty : keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue.ToString();

            if (DatabaseManager.ThemKeHoachDaoTaoTheoKhoa(maCTDT, maMon, keHoachDaoTaoTheoKhoaKhoaTextBox.Text, (int)keHoachDaoTaoTheoKhoaHocKyNumericUpDown.Value, (int)keHoachDaoTaoTheoKhoaNamHocNumericUpDown.Value))
                UpdateKetHoachDaoTaoTheoKhoaTable();
        }

        private void KeHoachDaoTaoTheoKhoaSuaButton_Click(object sender, EventArgs e)
        {
            string maCTDT = keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue == null ? string.Empty : keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue.ToString();

            string maMon = keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue == null ? string.Empty : keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue.ToString();

            if (DatabaseManager.SuaKeHoachDaoTaoTheoKhoa(maCTDT, maMon, keHoachDaoTaoTheoKhoaKhoaTextBox.Text, (int)keHoachDaoTaoTheoKhoaHocKyNumericUpDown.Value, (int)keHoachDaoTaoTheoKhoaNamHocNumericUpDown.Value))
                UpdateKetHoachDaoTaoTheoKhoaTable();
        }

        private void KeHoachDaoTaoTheoKhoaXoaButton_Click(object sender, EventArgs e)
        {
            string maCTDT = keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue == null ? string.Empty : keHoachDaoTaoTheoKhoaMaCTDTComboBox.SelectedValue.ToString();

            string maMon = keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue == null ? string.Empty : keHoachDaoTaoTheoKhoaMonComboBox.SelectedValue.ToString();

            if (DatabaseManager.XoaKeHoachDaoTaoTheoKhoa(maCTDT, maMon, keHoachDaoTaoTheoKhoaKhoaTextBox.Text))
                UpdateKetHoachDaoTaoTheoKhoaTable();
        }

        private void XuatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.exportForm.ShowDialog();
        }
    }
}