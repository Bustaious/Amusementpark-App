using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amusement_Park_App.classes;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Amusement_Park_App
{
    public partial class frmAdmin : Form

  
    {

        frmLogin user = new frmLogin();
        Booking book = new Booking();
        AccountBooking acDb = new AccountBooking();

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            firstForm pageback = new firstForm();
            pageback.Show();
            this.Hide();
        }


        
        private void FrmAdmin_Load(object sender, EventArgs e)
        {

            adminuserTag.Text = frmLogin.currUname;
            adminemailTag.Text = frmLogin.currEmail;
            adminpnumberTag.Text = frmLogin.currPnumber;
            using (DataTable bookingDtb = new DataTable())
            {
                book.BkRead();

                bookingDtb.Columns.Add("custid", typeof(int));
                bookingDtb.Columns.Add("service", typeof(string));
                bookingDtb.Columns.Add("oDate", typeof(int));
                bookingDtb.Columns.Add("bType", typeof(int));

                
                bookingView.DataSource = bookingDtb;
            }
            
            
        }

        private void ReviewView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmLogin.currUserType == "Admin")
            {

                MessageBox.Show("Are you sure you want to log out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //dbcon.Open();
                firstForm newform = new firstForm();
                newform.Show();
                this.Hide();


                frmLogin.currUname = "";
                frmLogin.currEmail = "";
                frmLogin.currPnumber = "";
            }
            else
            {
                MessageBox.Show("You are not an Administrator", "Log-out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BookingView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
