﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    internal static class DatabaseManager
    {
        // Kết nổi thủ công bằng tay, không sử dụng dataset!

        // Tự thiết lập lại connection string bằng tay

        public const string connectionString = "Data Source=DESKTOP-76LF2SC;Initial Catalog=CTDT_CDKTDN;Persist Security Info=True;User ID=sa;Password=1;TrustServerCertificate=True;";

        public static SqlConnection connection = null;

        public static void Connect()
        {
            if (connection == null)
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Có lỗi xảy ra khi đang thực hiện kết nối vào cơ sở dữ liệu!.\nVui lòng kiểm tra lại connection string trong mục Globals/DatabaseManager.cs/connectionString.\n" + e.Message, "KẾT NỐI THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        // các phương thức & logic hoàn toàn được xử lý bằng code

        // sắp xếp thông qua #region

        #region KHOA

        public static DataTable LayDuLieuBangKhoa()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Khoa ORDER BY MaKhoa ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static bool ThemKhoa(string maKhoa, string tenKhoa)
        {
            if (connection == null || maKhoa.Equals(string.Empty) || tenKhoa.Equals(string.Empty))
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO Khoa VALUES (@MaKhoa, @TenKhoa);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool SuaKhoa(string maKhoa, string tenKhoa, string keyCheck)
        {
            if (connection == null || maKhoa.Equals(string.Empty) || tenKhoa.Equals(string.Empty))
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maKhoa != keyCheck)
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool XoaKhoa(string maKhoa)
        {
            if (connection == null || maKhoa.Equals(string.Empty))
            {
                MessageBox.Show("Xóa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        #endregion

        #region NGHE

        public static DataTable LayDuLieuBangNghe()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Nghe N JOIN Khoa K ON N.MaKhoa = K.MaKhoa ORDER BY MaNghe ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static bool ThemNghe(string maNghe, string tenNghe, string maKhoa, string moTa)
        {
            if (connection == null || maNghe.Equals(string.Empty) || tenNghe.Equals(string.Empty) || maKhoa.Equals(string.Empty) || moTa.Equals(string.Empty))
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO Nghe VALUES (@MaNghe, @TenNghe, @MaKhoa, @MoTa);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNghe", maNghe);

                command.Parameters.AddWithValue("@TenNghe", tenNghe);

                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                command.Parameters.AddWithValue("@MoTa", moTa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool SuaNghe(string maNghe, string tenNghe, string maKhoa, string moTa, string keyCheck)
        {
            if (connection == null || maNghe.Equals(string.Empty) || tenNghe.Equals(string.Empty) || maKhoa.Equals(string.Empty) || moTa.Equals(string.Empty))
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maNghe != keyCheck)
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "UPDATE Nghe SET TenNghe = @TenNghe, MaKhoa = @MaKhoa, MoTa = @MoTa WHERE MaNghe = @MaNghe;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNghe", maNghe);

                command.Parameters.AddWithValue("@TenNghe", tenNghe);

                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                command.Parameters.AddWithValue("@MoTa", moTa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool XoaNghe(string maNghe)
        {
            if (connection == null || maNghe.Equals(string.Empty))
            {
                MessageBox.Show("Xóa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM Nghe WHERE MaNghe = @MaNghe;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNghe", maNghe);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        #endregion

        #region MON HOC

        public static DataTable LayDuLieuBangMonHoc()
        {
            string query = "SELECT *, (LyThuyet + ThucHanh + KiemTra) AS Tong FROM MonHoc MH JOIN Nghe N ON MH.MaNghe = N.MaNghe ORDER BY MaMon ASC;";

            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static bool ThemMonHoc
        (
            string maMon,
            string kieuMa,
            string loaiMon,
            string tenMon,
            string maNghe,
            int soTinChi,
            int lyThuyet,
            int thucHanh,
            int kiemTra,
            int thuongXuyen,
            int dinhKy,
            int thiHetMon,
            string ghiChu
        )
        {
            if (
                connection == null
                || maMon.Equals(string.Empty)
                || kieuMa.Equals(string.Empty)
                || loaiMon.Equals(string.Empty)
                || tenMon.Equals(string.Empty)
                || maNghe.Equals(string.Empty)
            )
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = @"INSERT INTO MonHoc VALUES (
                @MaMon,
                @KieuMa,
                @LoaiMon,
                @TenMon,
                @MaNghe,
                @SoTinChi,
                @LyThuyet,
                @ThucHanh,
                @KiemTra,
                @ThuongXuyen,
                @DinhKy,
                @ThiHetMon,
                @GhiChu
            );";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@KieuMa", kieuMa);

                command.Parameters.AddWithValue("@LoaiMon", loaiMon);

                command.Parameters.AddWithValue("@TenMon", tenMon);

                command.Parameters.AddWithValue("@MaNghe", maNghe);

                command.Parameters.AddWithValue("@SoTinChi", soTinChi);

                command.Parameters.AddWithValue("@LyThuyet", lyThuyet);

                command.Parameters.AddWithValue("@ThucHanh", thucHanh);

                command.Parameters.AddWithValue("@KiemTra", kiemTra);

                command.Parameters.AddWithValue("@ThuongXuyen", thuongXuyen);

                command.Parameters.AddWithValue("@DinhKy", dinhKy);

                command.Parameters.AddWithValue("@ThiHetMon", thiHetMon);

                command.Parameters.AddWithValue("@GhiChu", ghiChu);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool SuaMonHoc
        (
            string maMon,
            string kieuMa,
            string loaiMon,
            string tenMon,
            string maNghe,
            int soTinChi,
            int lyThuyet,
            int thucHanh,
            int kiemTra,
            int thuongXuyen,
            int dinhKy,
            int thiHetMon,
            string ghiChu,
            string keyCheck
        )
        {
            if (
                connection == null
                || maMon.Equals(string.Empty)
                || kieuMa.Equals(string.Empty)
                || loaiMon.Equals(string.Empty)
                || tenMon.Equals(string.Empty)
                || maNghe.Equals(string.Empty)
            )
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maMon != keyCheck)
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = @"UPDATE MonHoc SET
                KieuMa = @KieuMa,
                LoaiMon = @LoaiMon,
                TenMon = @TenMon,
                MaNghe = @MaNghe,
                SoTinChi = @SoTinChi, 
                LyThuyet = @LyThuyet, 
                ThucHanh = @ThucHanh,
                KiemTra = @KiemTra,
                ThuongXuyen = @ThuongXuyen,
                DinhKy = @DinhKy,
                ThiHetMon = @ThiHetMon,
                GhiChu = @GhiChu
            WHERE MaMon = @MaMon;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@KieuMa", kieuMa);

                command.Parameters.AddWithValue("@LoaiMon", loaiMon);

                command.Parameters.AddWithValue("@TenMon", tenMon);

                command.Parameters.AddWithValue("@MaNghe", maNghe);

                command.Parameters.AddWithValue("@SoTinChi", soTinChi);

                command.Parameters.AddWithValue("@LyThuyet", lyThuyet);

                command.Parameters.AddWithValue("@ThucHanh", thucHanh);

                command.Parameters.AddWithValue("@KiemTra", kiemTra);

                command.Parameters.AddWithValue("@ThuongXuyen", thuongXuyen);

                command.Parameters.AddWithValue("@DinhKy", dinhKy);

                command.Parameters.AddWithValue("@ThiHetMon", thiHetMon);

                command.Parameters.AddWithValue("@GhiChu", ghiChu);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool XoaMonHoc(string maMon)
        {
            if (connection == null || maMon.Equals(string.Empty))
            {
                MessageBox.Show("Xóa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM MonHoc WHERE MaMon = @MaMon;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaMon", maMon);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        #endregion

        #region CTDT

        public static DataTable LayDuLieuBangCTDT()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM CTDT ORDER BY MaCTDT ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static bool ThemCTDT(string maCTDT, int namPhatHanh, string moTa)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || moTa.Equals(string.Empty))
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO CTDT VALUES (@MaCTDT, @NamPhatHanh, @Mota);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@NamPhatHanh", namPhatHanh);

                command.Parameters.AddWithValue("@MoTa", moTa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool SuaCTDT(string maCTDT, int namPhatHanh, string moTa, string keyCheck)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || moTa.Equals(string.Empty))
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maCTDT != keyCheck)
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "UPDATE CTDT SET NamPhatHanh = @NamPhatHanh, MoTa = @MoTa WHERE MaCTDT = @MaCTDT;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@NamPhatHanh", namPhatHanh);

                command.Parameters.AddWithValue("@MoTa", moTa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool XoaCTDT(string maCTDT)
        {
            if (connection == null || maCTDT.Equals(string.Empty))
            {
                MessageBox.Show("Xóa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM CTDT WHERE MaCTDT = @MaCTDT;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        #endregion

        #region CT_CTDT

        public static DataTable LayDuLieuBangChiTietCTDT()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM ChiTietCTDT ctCTDT JOIN MonHoc MH ON MH.MaMon = ctCTDT.MaMon ORDER BY MaCTDT ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static DataTable LayDuLieuBangChiTietCTDTExport(string maCTDT)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand($"SELECT *, (LyThuyet + ThucHanh + KiemTra) AS Tong FROM ChiTietCTDT ctCTDT JOIN MonHoc MH ON MH.MaMon = ctCTDT.MaMon WHERE MaCTDT = '{maCTDT}' ORDER BY MaCTDT ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static bool ThemChiTietCTDT(string maCTDT, string maMon, int hocKy)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || maMon.Equals(string.Empty))
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO ChiTietCTDT VALUES (@MaCTDT, @MaMon, @HocKy);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@HocKy", hocKy);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool SuaChiTietCTDT(string maCTDT, string maMon, int hocKy, string[] keysCheck)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || maMon.Equals(string.Empty))
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maCTDT != keysCheck[0] || maMon != keysCheck[1])
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "UPDATE ChiTietCTDT SET HocKy = @HocKy WHERE MaCTDT = @MaCTDT AND MaMon = @MaMon;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@HocKy", hocKy);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool XoaChiTietCTDT(string maCTDT, string maMon)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || maMon.Equals(string.Empty))
            {
                MessageBox.Show("Xóa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM ChiTietCTDT WHERE MaCTDT = @MaCTDT AND MaMon = @MaMon;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@MaMon", maMon);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        #endregion

        #region KeHoachDaoTaoTheoKhoa

        public static DataTable LayDuLieuBangKeHoachDaoTaoTheoKhoa()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM KeHoachDaoTaoTheoKhoa KHDTTK JOIN MonHoc MH ON MH.MaMon = KHDTTK.MaMon ORDER BY MaCTDT ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static DataTable LayDuLieuBangKeHoachDaoTaoTheoKhoaExport(string khoa)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(
                $@"
                    SELECT
                        *,
                        (LyThuyet + ThucHanh + KiemTra) AS Tong
                    FROM
                        KeHoachDaoTaoTheoKhoa AS KHDTTK
	                    JOIN CTDT AS CD ON CD.MaCTDT = KHDTTK.MaCTDT
                        JOIN MonHoc AS MH ON MH.MaMon = KHDTTK.MaMon
                        JOIN Nghe AS N ON MH.MaNghe = N.MaNghe
                    WHERE
                        Khoa = '{khoa}'
                    ORDER BY
                        NamHoc ASC,
	                    HocKy ASC;
                ",
                connection
            )))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static DataTable LayDanhSachKhoaBangKeHoachDaoTaoTheoKhoa()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT DISTINCT Khoa FROM KeHoachDaoTaoTheoKhoa ORDER BY Khoa ASC;", connection)))
            {
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static bool ThemKeHoachDaoTaoTheoKhoa(string maCTDT, string maMon, string khoa, int hocKy, int namHoc)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || maMon.Equals(string.Empty) || khoa.Equals(string.Empty))
            {
                MessageBox.Show("Thêm dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO KeHoachDaoTaoTheoKhoa VALUES (@MaCTDT, @MaMon, @Khoa, @HocKy, @NamHoc);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@Khoa", khoa);

                command.Parameters.AddWithValue("@HocKy", hocKy);

                command.Parameters.AddWithValue("@NamHoc", namHoc);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool SuaKeHoachDaoTaoTheoKhoa(string maCTDT, string maMon, string khoa, int hocKy, int namHoc, string[] keysCheck)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || maMon.Equals(string.Empty) || khoa.Equals(string.Empty))
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (maCTDT != keysCheck[0] || maMon != keysCheck[1] || khoa != keysCheck[2])
            {
                MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "UPDATE KeHoachDaoTaoTheoKhoa SET HocKy = @HocKy, NamHoc = @NamHoc WHERE MaCTDT = @MaCTDT AND MaMon = @MaMon AND Khoa = @Khoa;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@Khoa", khoa);

                command.Parameters.AddWithValue("@HocKy", hocKy);

                command.Parameters.AddWithValue("@NamHoc", namHoc);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static bool XoaKeHoachDaoTaoTheoKhoa(string maCTDT, string maMon, string khoa)
        {
            if (connection == null || maCTDT.Equals(string.Empty) || maMon.Equals(string.Empty) || khoa.Equals(string.Empty))
            {
                MessageBox.Show("Xóa dữ liệu thất bại!.\nCơ sở dữ liệu chưa kết nối hoặc 1 trong các ô nhập dữ liệu đang để trống.", "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM KeHoachDaoTaoTheoKhoa WHERE MaCTDT = @MaCTDT AND MaMon = @MaMon AND Khoa = @Khoa;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaCTDT", maCTDT);

                command.Parameters.AddWithValue("@MaMon", maMon);

                command.Parameters.AddWithValue("@Khoa", khoa);

                try
                {
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "THAO TÁC THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại!.\nViệc sửa hoặc xóa dữ liệu cần phụ thuộc vào các ô có thuộc tính khóa nếu thay đổi hoặc chỉnh sửa các ô này sẽ làm thao tác không có hiệu lực.", "THAO TÁC BỊ GIÁN ĐOẠN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!.\n" + ex.Message, "THAO TÁC THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        #endregion
    }
}