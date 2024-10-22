using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Amusement_Park_App.classes
{
    class Booking : AccountBooking
    {
        public string service { get; set; }
        public DateTime oDate { get; set; }
        public string oTime { get; set; }
        public int id { get; set; }
        public int orderId { get; set; }
        public string bType { get; set; }
        public string excl { get; set; }
        public int custId { get; set; }


        public DataTable bookingDtb = new DataTable();

        public void BkCreate()
        {
            dbCon.Open();
            using (MySqlCommand mycmd = new MySqlCommand())
            {
                mycmd.CommandText = "INSERT INTO book_orders(orderID,serviceID,oDate,exclusive,custID) VALUES(@orderId, @service, @oDate, @excl, @custId)";
                mycmd.CommandType = CommandType.Text;
                mycmd.Connection = dbCon;

                mycmd.Parameters.Add("@orderId", MySqlDbType.VarChar).Value = orderId;
                mycmd.Parameters.Add("@service", MySqlDbType.VarChar).Value = service;
                mycmd.Parameters.Add("@oDate", MySqlDbType.VarChar).Value = oDate;
                mycmd.Parameters.Add("@excl", MySqlDbType.VarChar).Value = excl;
                mycmd.Parameters.Add("@custId", MySqlDbType.VarChar).Value = custId;

                mycmd.ExecuteNonQuery();
                dbCon.Close();
            };


        }

       public void BkRead()
        {
            dbCon.Open();
            dtbl.Clear();
            string queryText = "SELECT * FROM book_orders";
            MySqlDataAdapter myDapt = new MySqlDataAdapter
                (queryText, dbCon);
            myDapt.Fill(dset);
            dtbl = dset.Tables[0];
        }


        public void BkUpdate()
        {
            dbCon.Open();
            using (MySqlCommand mycmd = new MySqlCommand())
            {
                mycmd.CommandText = "UPDATE book_orders SET orderId=orderID, service=serviceID, id=custID";
                mycmd.CommandType = CommandType.Text;
                mycmd.Connection = dbCon;

                mycmd.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderId;
                mycmd.Parameters.Add("@serviceID", MySqlDbType.VarChar).Value = service;
                mycmd.Parameters.Add("@custID", MySqlDbType.VarChar).Value = custId;

                mycmd.ExecuteNonQuery();
                dbCon.Close();
            }
        }


        public void BkDelete()
        {
            dbCon.Open();
            using (MySqlCommand mycmd = new MySqlCommand())
            {
                mycmd.CommandText = "DELETE FROM book_orders WHERE orderID=id";
                mycmd.CommandType = CommandType.Text;
                mycmd.Connection = dbCon;

                mycmd.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = id;

                mycmd.ExecuteNonQuery();
                dbCon.Close();
            }
        }


        public void loadBooking()
        {

            dbCon.Open();
            MySqlDataReader bkrd;
            using (MySqlCommand bkcmd = new MySqlCommand())
            {
                string queryText = "SELECT * FROM book_orders";
                MySqlDataAdapter bkDapt = new MySqlDataAdapter
                    (queryText, dbCon);
                bkDapt.Fill(dset);
                dtbl = dset.Tables[0];

                bkrd = bkcmd.ExecuteReader();

            }


            dbCon.Close();
        }
      

    }

    

}
