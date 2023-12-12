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
        public List<TAI_KHOAN> loginDB()
        {
            Helper helper = new Helper("KYLES-LAPTOP", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"exec sp_KH_XemTTCaNhan").ToList();
                return output;
            }
        }
    }
}