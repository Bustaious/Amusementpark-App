using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Amusement_Park_App.classes
{
    class User : AccountBooking
    {
        public string uNam { get; set; }
        public string uPass { get; set; }
        public string uType { get; set; }
        public string id { get; set; }
        public string eAdd { get; set; }
        public string pNum { get; set; }



        //public DataTable 
        //private DataSet CustomerDS


        public void DbCreate()
        {
            dbCon.Open();
            using (MySqlCommand mycmd = new MySqlCommand())
            {
                mycmd.CommandText = "INSERT INTO users(userName,userPass,userType,eAddress) VALUES(@uNam, @uPass, @uType, @eAdd)";
                mycmd.CommandType = CommandType.Text;
                mycmd.Connection = dbCon;

                mycmd.Parameters.Add("@uNam", MySqlDbType.VarChar).Value = uNam;
                mycmd.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = uPass;
                mycmd.Parameters.Add("@uType", MySqlDbType.VarChar).Value = uType;
                mycmd.Parameters.Add("@eAdd", MySqlDbType.VarChar).Value = eAdd;


                mycmd.ExecuteNonQuery();
                dbCon.Close();
            };
        }

        public void DbRead()
        {
            dbCon.Open();
            dtbl.Clear();
            string queryText = "SELECT * FROM users";
            MySqlDataAdapter myDapt = new MySqlDataAdapter
                (queryText, dbCon);
            myDapt.Fill(dset);
            dtbl = dset.Tables[0];
        }

        public void DbUpdate()
        {
            dbCon.Open();
            using (MySqlCommand mycmd = new MySqlCommand())
            {
                mycmd.CommandText = "UPDATE users SET uNam=userName, uPass=userPass, uType=userType";
                mycmd.CommandType = CommandType.Text;
                mycmd.Connection = dbCon;

                mycmd.Parameters.Add("@userName", MySqlDbType.VarChar).Value = uNam;
                mycmd.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = uPass;
                mycmd.Parameters.Add("@userType", MySqlDbType.VarChar).Value = uType;

                mycmd.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public void DbDelete()
        {
            dbCon.Open();
            using (MySqlCommand mycmd = new MySqlCommand())
            {
                mycmd.CommandText = "DELETE FROM users WHERE userID=id";
                mycmd.CommandType = CommandType.Text;
                mycmd.Connection = dbCon;

                mycmd.Parameters.Add("@uID", MySqlDbType.VarChar).Value = id;


                mycmd.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public bool verifyUser()
        {
            dbCon.Open();
            MySqlDataReader drd;
            bool chk = false;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM users WHERE userName=@uNam AND userPass=@uPass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = dbCon;

                cmd.Parameters.Add("@uNam", MySqlDbType.VarChar).Value = uNam;
                cmd.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = uPass;

                drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    uType = drd.GetString("userType");
                    chk = true;
                }


                dbCon.Close();
            }
            return chk;

        }


        public string verifyEmail()
        {
            {
                dbCon.Open();
                MySqlDataReader drd;
                string dchk = "eAdd";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM users WHERE eAddress=@eAdd AND pNumber=@pNum";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = dbCon;

                    cmd.Parameters.Add("@eAdd", MySqlDbType.VarChar).Value = eAdd;
                    cmd.Parameters.Add("@pNum", MySqlDbType.VarChar).Value = pNum;

                    drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        pNum = drd.GetString("pNumber");
                        dchk = "pNumber";
                    }
                    dbCon.Close();
                }
                return dchk;
            }
        }
    }
}
