using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Amusement_Park_App.classes
{
    class AccountBooking
    {
        public MySqlConnection dbCon;

        public DataTable dtbl = new DataTable();
        public DataSet dset = new DataSet();

        public AccountBooking()
        {
            string host = "localhost";
            string user = "root";
            string pass = "monkeyquest";
            string db = "user_booking";
            string port = "3305";
            string conString = $"datasource = {host}; database = {db}; port = {port}; username = {user}; password = {pass}; SslMode = None";
            dbCon = new MySqlConnection(conString);
        }
    }
}


