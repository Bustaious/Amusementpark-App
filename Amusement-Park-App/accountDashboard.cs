using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amusement_Park_App.classes;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Amusement_Park_App
{


    public partial class accountDashboard : Form 
    {

        User user = new User();

        public accountDashboard()
        {
            InitializeComponent();


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserIcon_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firstForm newform = new firstForm();
            newform.Show();
            this.Hide();
        }

        

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (frmLogin.currUserType == "Customer")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    accountDashboard pageback = new accountDashboard();
                    pageback.Show();
                    this.Close();
                }
                else
                {
                    firstForm newform = new firstForm();
                    newform.Show();
                    this.Hide();

                    frmLogin.currUname = "";
                    frmLogin.currEmail = "";
                    frmLogin.currPnumber = "";
                }


                //dbcon.Open();
                
            }
            else
            {
                MessageBox.Show("You are not logged-in", "Log-out Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void UsernameTag_Click(object sender, EventArgs e)
        {

        }

        private void AccountDashboard_Load(object sender, EventArgs e)
        {
            
            usernameTag.Text = frmLogin.currUname;
            user.eAdd = frmLogin.currEmail;
            user.pNum = frmLogin.currPnumber;
                
            }

            
        

        private void EmailTag_Click(object sender, EventArgs e)
        {

        }
    }
}
