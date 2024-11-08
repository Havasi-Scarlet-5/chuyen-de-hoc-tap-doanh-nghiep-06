using System;
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
            InitTables();
        }

        private void InitTables()
        {
            // Khoa table

            UpdateKhoaTable();

            // Nghe table

            UpdateNgheTable();

            // MonHoc table

            UpdateTableMonHoc();
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
            if (ngheKhoaComboBox.SelectedValue == null)
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nÔ khoa không được để trống.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseManager.ThemNghe(maNgheTextBox.Text, tenNgheTextBox.Text, ngheKhoaComboBox.SelectedValue.ToString(), ngheMoTaRichTextBox.Text))
                UpdateNgheTable();
        }

        private void NgheSuaButton_Click(object sender, System.EventArgs e)
        {
            if (ngheKhoaComboBox.SelectedValue == null)
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nÔ khoa không được để trống.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseManager.SuaNghe(maNgheTextBox.Text, tenNgheTextBox.Text, ngheKhoaComboBox.SelectedValue.ToString(), ngheMoTaRichTextBox.Text))
                UpdateNgheTable();
        }

        private void NgheXoaButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.XoaNghe(maNgheTextBox.Text))
                UpdateNgheTable();
        }

        private void UpdateTableMonHoc()
        {
            monHocDataGridView.DataSource = DatabaseManager.LayDuLieuBangMonHoc();

            monHocDataGridView.AutoGenerateColumns = false;

            monHocDataGridView.Columns["MaMon"].DisplayIndex = 0;

            monHocDataGridView.Columns["MaMon"].HeaderText = "Mã môn";

            monHocDataGridView.Columns["TenMon"].DisplayIndex = 1;

            monHocDataGridView.Columns["TenMon"].HeaderText = "Tên môn";

            monHocDataGridView.Columns["TenNghe"].DisplayIndex = 2;

            monHocDataGridView.Columns["TenNghe"].HeaderText = "Nghề";

            monHocDataGridView.Columns["SoTinChi"].DisplayIndex = 3;

            monHocDataGridView.Columns["SoTinChi"].HeaderText = "Số tín chỉ";

            monHocDataGridView.Columns["Tong"].DisplayIndex = 4;

            monHocDataGridView.Columns["Tong"].HeaderText = "Tổng cộng";

            monHocDataGridView.Columns["LyThuyet"].DisplayIndex = 5;

            monHocDataGridView.Columns["LyThuyet"].HeaderText = "Lý thuyết";

            monHocDataGridView.Columns["ThucHanh"].DisplayIndex = 6;

            monHocDataGridView.Columns["ThucHanh"].HeaderText = "Thực hành";

            monHocDataGridView.Columns["KiemTra"].DisplayIndex = 7;

            monHocDataGridView.Columns["KiemTra"].HeaderText = "Kiểm tra";

            monHocDataGridView.Columns["ThuongXuyen"].DisplayIndex = 8;

            monHocDataGridView.Columns["ThuongXuyen"].HeaderText = "Thường xuyên";

            monHocDataGridView.Columns["DinhKy"].DisplayIndex = 9;

            monHocDataGridView.Columns["DinhKy"].HeaderText = "Định kỳ";

            monHocDataGridView.Columns["ThiHetMon"].DisplayIndex = 10;

            monHocDataGridView.Columns["ThiHetMon"].HeaderText = "Thi hết môn";

            monHocDataGridView.Columns["GhiChu"].DisplayIndex = 11;

            monHocDataGridView.Columns["GhiChu"].HeaderText = "Ghi chú";

            monHocDataGridView.Columns["MaNghe"].Visible = false;

            monHocDataGridView.Columns["MaNghe1"].Visible = false;

            monHocDataGridView.Columns["MaKhoa"].Visible = false;

            monHocDataGridView.Columns["MoTa"].Visible = false;
        }

        private void MonHocDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            if (monHocDataGridView.CurrentRow != null)
            {
                monHocMaMonTextBox.Text = monHocDataGridView.CurrentRow.Cells["MaMon"].Value.ToString();

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
            if (monHocNgheComboBox.SelectedValue == null)
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nÔ nghề không được để trống.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseManager.ThemMonHoc(
                monHocMaMonTextBox.Text,
                monHocTenMonTextBox.Text,
                monHocNgheComboBox.SelectedValue.ToString(),
                (int)monHocSoTinChiNumericUpDown.Value,
                (int)monHocLyThuyetNumericUpDown.Value,
                (int)monHocThucHanhNumericUpDown.Value,
                (int)monHocKiemTraNumericUpDown.Value,
                (int)monHocThuongXuyenNumericUpDown.Value,
                (int)monHocDinhKyNumericUpDown.Value,
                (int)monHocThiHetMonNumericUpDown.Value,
                monHocGhiChuTextBox.Text
            ))
                UpdateTableMonHoc();
        }

        private void MonHocSuaButton_Click(object sender, System.EventArgs e)
        {
            if (monHocNgheComboBox.SelectedValue == null)
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nÔ nghề không được để trống.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseManager.SuaMonHoc(
                monHocMaMonTextBox.Text,
                monHocTenMonTextBox.Text,
                monHocNgheComboBox.SelectedValue.ToString(),
                (int)monHocSoTinChiNumericUpDown.Value,
                (int)monHocLyThuyetNumericUpDown.Value,
                (int)monHocThucHanhNumericUpDown.Value,
                (int)monHocKiemTraNumericUpDown.Value,
                (int)monHocThuongXuyenNumericUpDown.Value,
                (int)monHocDinhKyNumericUpDown.Value,
                (int)monHocThiHetMonNumericUpDown.Value,
                monHocGhiChuTextBox.Text
            ))
                UpdateTableMonHoc();
        }

        private void MonHocXoaButton_Click(object sender, System.EventArgs e)
        {
            if (DatabaseManager.XoaMonHoc(monHocMaMonTextBox.Text))
                UpdateTableMonHoc();
        }
    }
}