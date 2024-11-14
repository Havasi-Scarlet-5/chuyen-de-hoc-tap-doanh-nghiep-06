using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    partial class ExportForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.exportFormTabControl = new System.Windows.Forms.TabControl();
            this.inChiTietChuongTrinhDaoTaoTab = new System.Windows.Forms.TabPage();
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inChiTietCTDTInBaoCaoButton = new System.Windows.Forms.Button();
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inChiTietCTDTMaCTDTComboBox = new System.Windows.Forms.ComboBox();
            this.inChiTietCTDTMaCTDTLabel = new System.Windows.Forms.Label();
            this.inKeHoachDaoTaoTheoKhoaTab = new System.Windows.Forms.TabPage();
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton = new System.Windows.Forms.Button();
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox = new System.Windows.Forms.ComboBox();
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel = new System.Windows.Forms.Label();
            this.buttonIconList = new System.Windows.Forms.ImageList(this.components);
            this.exportFormTabControl.SuspendLayout();
            this.inChiTietChuongTrinhDaoTaoTab.SuspendLayout();
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.SuspendLayout();
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.SuspendLayout();
            this.inKeHoachDaoTaoTheoKhoaTab.SuspendLayout();
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.SuspendLayout();
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportFormTabControl
            // 
            this.exportFormTabControl.Controls.Add(this.inChiTietChuongTrinhDaoTaoTab);
            this.exportFormTabControl.Controls.Add(this.inKeHoachDaoTaoTheoKhoaTab);
            this.exportFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportFormTabControl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFormTabControl.Location = new System.Drawing.Point(0, 0);
            this.exportFormTabControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exportFormTabControl.Name = "exportFormTabControl";
            this.exportFormTabControl.SelectedIndex = 0;
            this.exportFormTabControl.Size = new System.Drawing.Size(622, 433);
            this.exportFormTabControl.TabIndex = 0;
            // 
            // inChiTietChuongTrinhDaoTaoTab
            // 
            this.inChiTietChuongTrinhDaoTaoTab.Controls.Add(this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2);
            this.inChiTietChuongTrinhDaoTaoTab.Controls.Add(this.inChiTietChuongTrinhDaoTaoTableLayoutPanel);
            this.inChiTietChuongTrinhDaoTaoTab.Location = new System.Drawing.Point(4, 32);
            this.inChiTietChuongTrinhDaoTaoTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inChiTietChuongTrinhDaoTaoTab.Name = "inChiTietChuongTrinhDaoTaoTab";
            this.inChiTietChuongTrinhDaoTaoTab.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inChiTietChuongTrinhDaoTaoTab.Size = new System.Drawing.Size(614, 397);
            this.inChiTietChuongTrinhDaoTaoTab.TabIndex = 0;
            this.inChiTietChuongTrinhDaoTaoTab.Text = "IN CHI TIẾT CHƯƠNG TRÌNH ĐÀO TẠO";
            this.inChiTietChuongTrinhDaoTaoTab.UseVisualStyleBackColor = true;
            // 
            // inChiTietChuongTrinhDaoTaoTableLayoutPanel2
            // 
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.ColumnCount = 1;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.Controls.Add(this.inChiTietCTDTInBaoCaoButton, 0, 0);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.Location = new System.Drawing.Point(5, 343);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.Name = "inChiTietChuongTrinhDaoTaoTableLayoutPanel2";
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.RowCount = 1;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.Size = new System.Drawing.Size(604, 50);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.TabIndex = 2;
            // 
            // inChiTietCTDTInBaoCaoButton
            // 
            this.inChiTietCTDTInBaoCaoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inChiTietCTDTInBaoCaoButton.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inChiTietCTDTInBaoCaoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inChiTietCTDTInBaoCaoButton.ImageKey = "in_bao_cao.png";
            this.inChiTietCTDTInBaoCaoButton.ImageList = this.buttonIconList;
            this.inChiTietCTDTInBaoCaoButton.Location = new System.Drawing.Point(3, 3);
            this.inChiTietCTDTInBaoCaoButton.Name = "inChiTietCTDTInBaoCaoButton";
            this.inChiTietCTDTInBaoCaoButton.Size = new System.Drawing.Size(598, 44);
            this.inChiTietCTDTInBaoCaoButton.TabIndex = 0;
            this.inChiTietCTDTInBaoCaoButton.Text = "IN BÁO CÁO";
            this.inChiTietCTDTInBaoCaoButton.UseVisualStyleBackColor = true;
            this.inChiTietCTDTInBaoCaoButton.Click += new System.EventHandler(this.InChiTietCTDTInBaoCaoButton_Click);
            // 
            // inChiTietChuongTrinhDaoTaoTableLayoutPanel
            // 
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.AutoScroll = true;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.ColumnCount = 2;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Controls.Add(this.inChiTietCTDTMaCTDTComboBox, 1, 0);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Controls.Add(this.inChiTietCTDTMaCTDTLabel, 0, 0);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Location = new System.Drawing.Point(5, 4);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Name = "inChiTietChuongTrinhDaoTaoTableLayoutPanel";
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.RowCount = 2;
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.Size = new System.Drawing.Size(604, 389);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.TabIndex = 1;
            // 
            // inChiTietCTDTMaCTDTComboBox
            // 
            this.inChiTietCTDTMaCTDTComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inChiTietCTDTMaCTDTComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inChiTietCTDTMaCTDTComboBox.FormattingEnabled = true;
            this.inChiTietCTDTMaCTDTComboBox.Location = new System.Drawing.Point(240, 3);
            this.inChiTietCTDTMaCTDTComboBox.MaxLength = 20;
            this.inChiTietCTDTMaCTDTComboBox.Name = "inChiTietCTDTMaCTDTComboBox";
            this.inChiTietCTDTMaCTDTComboBox.Size = new System.Drawing.Size(351, 42);
            this.inChiTietCTDTMaCTDTComboBox.TabIndex = 6;
            // 
            // inChiTietCTDTMaCTDTLabel
            // 
            this.inChiTietCTDTMaCTDTLabel.AutoSize = true;
            this.inChiTietCTDTMaCTDTLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inChiTietCTDTMaCTDTLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inChiTietCTDTMaCTDTLabel.ForeColor = System.Drawing.Color.Red;
            this.inChiTietCTDTMaCTDTLabel.Location = new System.Drawing.Point(3, 0);
            this.inChiTietCTDTMaCTDTLabel.Name = "inChiTietCTDTMaCTDTLabel";
            this.inChiTietCTDTMaCTDTLabel.Size = new System.Drawing.Size(231, 50);
            this.inChiTietCTDTMaCTDTLabel.TabIndex = 0;
            this.inChiTietCTDTMaCTDTLabel.Text = "CTDT:";
            this.inChiTietCTDTMaCTDTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inKeHoachDaoTaoTheoKhoaTab
            // 
            this.inKeHoachDaoTaoTheoKhoaTab.Controls.Add(this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2);
            this.inKeHoachDaoTaoTheoKhoaTab.Controls.Add(this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel);
            this.inKeHoachDaoTaoTheoKhoaTab.Location = new System.Drawing.Point(4, 32);
            this.inKeHoachDaoTaoTheoKhoaTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inKeHoachDaoTaoTheoKhoaTab.Name = "inKeHoachDaoTaoTheoKhoaTab";
            this.inKeHoachDaoTaoTheoKhoaTab.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inKeHoachDaoTaoTheoKhoaTab.Size = new System.Drawing.Size(614, 397);
            this.inKeHoachDaoTaoTheoKhoaTab.TabIndex = 1;
            this.inKeHoachDaoTaoTheoKhoaTab.Text = "IN KẾ HOẠCH ĐÀO TẠO THEO KHÓA";
            this.inKeHoachDaoTaoTheoKhoaTab.UseVisualStyleBackColor = true;
            // 
            // inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2
            // 
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.ColumnCount = 1;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.Controls.Add(this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton, 0, 0);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.Location = new System.Drawing.Point(5, 343);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.Name = "inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2";
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.RowCount = 1;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.Size = new System.Drawing.Size(604, 50);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.TabIndex = 3;
            // 
            // inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton
            // 
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.ImageKey = "in_bao_cao.png";
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.ImageList = this.buttonIconList;
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Location = new System.Drawing.Point(3, 3);
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Name = "inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton";
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Size = new System.Drawing.Size(598, 44);
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.TabIndex = 0;
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Text = "IN BÁO CÁO";
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.UseVisualStyleBackColor = true;
            this.inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton.Click += new System.EventHandler(this.InKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton_Click);
            // 
            // inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel
            // 
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.AutoScroll = true;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.ColumnCount = 2;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Controls.Add(this.inKeHoachDaoTaoTheoKhoaKhoaComboBox, 1, 0);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Controls.Add(this.inKeHoachDaoTaoTheoKhoaKhoaLabel, 0, 0);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Location = new System.Drawing.Point(5, 4);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Name = "inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel";
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.RowCount = 2;
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.Size = new System.Drawing.Size(604, 389);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.TabIndex = 2;
            // 
            // inKeHoachDaoTaoTheoKhoaKhoaComboBox
            // 
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.FormattingEnabled = true;
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.Location = new System.Drawing.Point(240, 3);
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.MaxLength = 20;
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.Name = "inKeHoachDaoTaoTheoKhoaKhoaComboBox";
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.Size = new System.Drawing.Size(351, 42);
            this.inKeHoachDaoTaoTheoKhoaKhoaComboBox.TabIndex = 6;
            // 
            // inKeHoachDaoTaoTheoKhoaKhoaLabel
            // 
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.AutoSize = true;
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.ForeColor = System.Drawing.Color.Red;
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.Location = new System.Drawing.Point(3, 0);
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.Name = "inKeHoachDaoTaoTheoKhoaKhoaLabel";
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.Size = new System.Drawing.Size(231, 50);
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.TabIndex = 0;
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.Text = "Khóa:";
            this.inKeHoachDaoTaoTheoKhoaKhoaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonIconList
            // 
            this.buttonIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonIconList.ImageStream")));
            this.buttonIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonIconList.Images.SetKeyName(0, "in_bao_cao.png");
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.exportFormTabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN CHƯƠNG TRÌNH ĐÀO TẠO";
            this.exportFormTabControl.ResumeLayout(false);
            this.inChiTietChuongTrinhDaoTaoTab.ResumeLayout(false);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel2.ResumeLayout(false);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.ResumeLayout(false);
            this.inChiTietChuongTrinhDaoTaoTableLayoutPanel.PerformLayout();
            this.inKeHoachDaoTaoTheoKhoaTab.ResumeLayout(false);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2.ResumeLayout(false);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.ResumeLayout(false);
            this.inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl exportFormTabControl;
        private TabPage inChiTietChuongTrinhDaoTaoTab;
        private TabPage inKeHoachDaoTaoTheoKhoaTab;
        private TableLayoutPanel inChiTietChuongTrinhDaoTaoTableLayoutPanel;
        private Label inChiTietCTDTMaCTDTLabel;
        private TableLayoutPanel inChiTietChuongTrinhDaoTaoTableLayoutPanel2;
        private Button inChiTietCTDTInBaoCaoButton;
        private TableLayoutPanel inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel2;
        private Button inKeHoachDaoTaoTheoKhoaKhoaInBaoCaoButton;
        private TableLayoutPanel inKeHoachDaoTaoTheoKhoaKhoaTableLayoutPanel;
        private Label inKeHoachDaoTaoTheoKhoaKhoaLabel;
        private ComboBox inChiTietCTDTMaCTDTComboBox;
        private ComboBox inKeHoachDaoTaoTheoKhoaKhoaComboBox;
        private ImageList buttonIconList;
    }
}