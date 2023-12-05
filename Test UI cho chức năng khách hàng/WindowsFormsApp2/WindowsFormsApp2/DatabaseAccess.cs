using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;
using Dapper;
using System.Data;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    internal class DatabaseAccess
    {
        public string USERID { get; set; }
        public string PASSWORD { get; set; }
        
        public DatabaseAccess(string username, string password)
        {
            this.USERID= username;  
            this.PASSWORD = password;
        }
        public List<TAI_KHOAN> GetTAI_KHOANs()
        {
            Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", "sa", "123");
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MyDB")))
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"select * from TAI_KHOAN").ToList();
                return output;
            }
        }
        public List<TAI_KHOAN> loginDB()
        {
            Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"exec sp_KH_XemTTCaNhan").ToList();
                return output;
            }
        }
        public List<BENH_AN> getBENH_ANs()
        {
            Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<BENH_AN>($"exec sp_KH_XemBenhAn").ToList();
                return output;
            }
        }

         //public List<DON_THUOC> GetDON_THUOCs(string ID_BA)
        //{
         //
         //   Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
         //   using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
         //   {
         //       var output = connection.Query<DON_THUOC>($"exec sp_KH_XemDonThuoc '" + ID_BA + "'").ToList();
         //       return output;
         //   }
        //}
        public List<DICHVU_SD> GetDICHVU_SDs(string ID_BA)
        {

            Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<DICHVU_SD>($"exec sp_KH_XemDVSD '"+ ID_BA + "'").ToList();
                return output;
            }
        }

        //public List<THUOC> GetTHUOCs(string ID_DONTHUOC)
        //{
        //    Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
        //    {
        //        var output = connection.Query<THUOC>($"sp_KH_XemChiTietThuoc '" + ID_DONTHUOC + "'").ToList();
        //        return output;
        //    }
        //}
        public List<LOAI_DV> GetLOAI_DVs(string ID_LOAIDV)
        {
            Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<LOAI_DV>($"sp_KH_XemChiTietDV '" + ID_LOAIDV + "'").ToList();
                return output;
            }
        }
    }
}
