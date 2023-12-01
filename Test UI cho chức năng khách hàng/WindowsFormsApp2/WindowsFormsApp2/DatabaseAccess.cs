using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;
using Dapper;
using System.Data;

namespace WindowsFormsApp2
{
    internal class DatabaseAccess
    {
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
        public List<TAI_KHOAN> loginDB(string USERID, string PASSWORD)
        {
            Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", USERID, PASSWORD);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectionString))
            {
                var output = connection.Query<TAI_KHOAN>($"exec sp_KH_XemTTCaNhan").ToList();
                return output;
            }
        }
    }
}
