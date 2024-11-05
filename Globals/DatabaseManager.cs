using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    internal static class DatabaseManager
    {
        private static SqlConnection connection = null;

        public static void Connect()
        {
            if (connection == null)
                try
                {
                    string connectionString = "Data Source=DESKTOP-76LF2SC;Initial Catalog=CTDT_CDKTDN;Persist Security Info=True;User ID=sa;Password=1;TrustServerCertificate=True;";
                    connection = new SqlConnection(connectionString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Có lỗi xảy ra khi đang thực hiện kết nối vào cơ sở dữ liệu!.\n" + e.Message, "KẾT NỐI THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
        }
    }
}