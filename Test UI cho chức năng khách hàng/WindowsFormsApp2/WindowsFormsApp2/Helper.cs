using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Helper
    {
#pragma warning disable IDE0044 // Add readonly modifier
        private string _Server { get; set; }
        private string _Database { get; set; }
        private string _UserId { get; set; }
        private string _Password { get; set; }

        public Helper(string server, string database, string userid, string password) {
            _Database = database;
            _UserId = userid;
            _Password = password;  
            _Server = server;
        }

        public string connectionString
        {
            get { return $"Server={_Server};Database={_Database}; User Id={_UserId};Password={_Password};"; }
        }
#pragma warning restore IDE0044 // Add readonly modifier
        //public static string CnnVal(string name)
        //{
        //    return ;
        //}
    }
}
