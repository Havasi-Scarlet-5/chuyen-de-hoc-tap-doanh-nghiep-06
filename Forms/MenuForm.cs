using System.Drawing;
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
            //foreach (TabPage tabPage in tabControl1.TabPages)
            //{
            //    foreach (Control control in tabPage.Controls)
            //    {
            //        if (control is SplitContainer splitContainer)
            //        {
            //            ConfigureSplitContainer(splitContainer, Color.Black, 4);
            //            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
            //        }
            //    }
            //}

            InitTables();
        }

        //private void ConfigureSplitContainer(SplitContainer splitContainer, Color splitterColor, int splitterWidth)
        //{
        //    // Set the splitter width
        //    splitContainer.SplitterWidth = splitterWidth;

        //    // Attach the Paint event with a lambda to draw the splitter in the specified color
        //    splitContainer.Paint += (s, e) =>
        //    {
        //        using (SolidBrush brush = new SolidBrush(splitterColor))
        //        {
        //            Rectangle splitterRect = new Rectangle(
        //                splitContainer.SplitterDistance, 0,
        //                splitContainer.SplitterWidth, splitContainer.Height);
        //            e.Graphics.FillRectangle(brush, splitterRect);
        //        }
        //    };
        //}

        private void InitTables()
        {
            // Khoa table

            UpdateKhoaTable();

            // Nghe table

            UpdateNgheTable();

            // MonHoc table

            monHocKieuMaComboBox.Items.Add("MH");

            monHocKieuMaComboBox.Items.Add("MĐ");

            monHocKieuMaComboBox.SelectedIndex = 0;

            UpdateMonHocTable();
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

            ngheDataGridView.Columns["TenKhoa"].HeaderText = "Tên khoa";

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

                ngheKhoaComboBox.Text = ngheDataGridView.CurrentRow.Cells["TenKhoa"].Value.ToString();

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

        private void UpdateMonHocTable()
        {

        }
    }
}