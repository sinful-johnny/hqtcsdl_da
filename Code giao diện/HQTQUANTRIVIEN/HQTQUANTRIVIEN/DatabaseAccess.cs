using HQTQUANTRIVIEN.Models;
using HQTQUANTRIVIEN.Properties;
using Dapper;
using HQTQUANTRIVIEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQTQUANTRIVIEN
{
    internal class DatabaseAccess
    {
        public string USERID { get; set; }
        public string PASSWORD { get; set; }

        public DatabaseAccess(string username, string password)
        {
            this.USERID = username;
            this.PASSWORD = password;
        }
        public List<TAI_KHOAN> GetTAI_KHOANs()
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", "sa", "123");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"select * from TAI_KHOAN").ToList();
                return output;
            }
        }

        public List<THUOC> GetTHUOCs()
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", "sa", "123");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<THUOC>($"exec sp_XEM_NHIEU_THUOC").ToList();
                return output;
            }
        }
        public List<TAI_KHOAN> loginDB()
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"exec sp_KH_XemTTCaNhan").ToList();
                return output;
            }
        }

        public void register(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_DangKyTaiKhoan N'"   + tk.HOTEN + "' ,'" 
                                                                        + tk.SDT + "' ,'" 
                                                                        + tk.NGAYSINH.ToShortDateString() + "' ,'" 
                                                                        + tk.EMAIL + "' ,'" 
                                                                        + tk.MATKHAU + "'");
                return;
            }
        }

        //QUẢN LÝ TÀI KHOẢN
        public void ThemTaiKhoan_QuanTriVien(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_THEM_TAIKHOAN_NGUOIDUNG N'"  + tk.HOTEN + "' ,'" 
                                                                                + tk.SDT + "' ,'" 
                                                                                + tk.NGAYSINH.ToShortDateString() + "' ,'" 
                                                                                + tk.EMAIL + "' ,'"
                                                                                + tk.MATKHAU + "' ,'"
                                                                                + tk.LOAITK + "'");
                return;
            }
        }

        public void XoaTaiKhoan_QuanTriVien(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_XOA_TAIKHOAN N'" + tk.ID_TAIKHOAN + "'");
                return;
            }
        }

        public void CapNhatTaiKhoan_QuanTriVien(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_CAPNHAT_TAIKHOAN_NGUOIDUNG N'"   + tk.ID_TAIKHOAN + "' ,'"
                                                                                    + tk.HOTEN + "' ,'"
                                                                                    + tk.NGAYSINH.ToShortDateString() + "' ,'"
                                                                                    + tk.EMAIL + "' ,'"
                                                                                    + tk.LOAITK + "'");
                return;
            }
        }

        public List<TAI_KHOAN> Xem_1TK_QuanTriVien(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"sp_XEM_1TAIKHOAN_NGUOIDUNG N'" + tk.ID_TAIKHOAN + "'").ToList();
                return output;
            }
        }

        public List<TAI_KHOAN> Xem_DANHSACHTK_QuanTriVien()
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = this.GetTAI_KHOANs();
                return output;
            }
        }

        public void KhoaTaiKhoan_QuanTriVien(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_KHOA_TAIKHOAN_NGUOIDUNG N'" + tk.ID_TAIKHOAN + "'");
                return;
            }
        }

        public void MoKhoaTaiKhoan_QuanTriVien(TAI_KHOAN tk)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_MOKHOA_TAIKHOAN_NGUOIDUNG N'" + tk.ID_TAIKHOAN + "'");
                return;
            }
        }


        //QUẢN LÝ THUỐC
        public void ThemThongTin_Thuoc(THUOC t)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_THEM_TT_THUOC N'" + t.TENTHUOC + "' ,N'"
                                                                     + t.CHIDINH + "' ,'"
                                                                     + t.NGAYHETHAN.ToShortDateString() + "' ,'"
                                                                     + t.GIATIEN.ToString() + "' ,'"
                                                                     + t.SOLUONG + "'");
                return;
            }
        }

        public void XoaThongTin_Thuoc(THUOC t)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_XOA_TT_THUOC N'" + t.ID_THUOC + "'");
                return;
            }
        }

        public void CapNhatThongTin_Thuoc(THUOC t)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query($"sp_CAPNHAT_TT_THUOC N'" + t.ID_THUOC + "' ,'"
                                                                        + t.TENTHUOC + "' ,N'"
                                                                        + t.CHIDINH + "' ,'"
                                                                        + t.NGAYHETHAN.ToShortDateString() + "' ,'"
                                                                        + t.GIATIEN.ToString() + "' ,'"
                                                                        + t.SOLUONG + "'");
                return;
            }
        }

        public List<THUOC> Xem_TT1Loai_Thuoc(THUOC t)
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<THUOC>($"sp_XEM_1TT_THUOC N'" + t.ID_THUOC + "'").ToList();
                return output;
            }
        }

        public List<THUOC> Xem_TTDanhSach_Thuoc()
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = this.GetTHUOCs();
                return output;
            }
        }

    }
}