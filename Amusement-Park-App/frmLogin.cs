using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amusement_Park_App.classes;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Amusement_Park_App
{
    public partial class frmLogin : Form
    {
        User user = new User();
        AccountBooking acBk = new AccountBooking();

        public static string currUname, currUserType;
        public static string currEmail, currPnumber;
        public frmLogin()
        {
            InitializeComponent();

        }

        
    

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            usernameLogin.Focus();
        }

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OlEDB.4.0;Data Source=accdb_Users.mdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();

        private void LoginNext_Click(object sender, EventArgs e)
        {
            user.uNam = usernameLogin.Text;
            user.uPass = passwordLogin.Text;
            user.uType = customerCheck.Text;
            user.eAdd = currEmail;
            user.pNum = currPnumber;

            bool approve = user.verifyUser();
            string improve = user.verifyEmail();
            

            if (approve == true)
            {
                currUname = user.uNam;
                currUserType = user.uType;
                

                if (currUserType != null)
                {
                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(currUserType == "Customer")
                    {
                        accountDashboard acc = new accountDashboard();
                        acc.Show();
                        this.Close();
                    }
                        if(currUserType == "Admin")
                    {
                        frmAdmin adm = new frmAdmin();
                        adm.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Login Failed. \nThe given details are invalid", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (improve == "pNumber")
            {
                currEmail = user.eAdd;
                currPnumber = user.pNum;
            }


            // string prove = user.verifyEmail();
            //if (prove == user.eAdd)
            // {
            //     currEmail = user.eAdd;
            //     currPnumber = user.pNum;
            // }
            //con.Open();
            //string login = "SELECT * FROM tbl_Users WHERE Username= '" + usernameLogin.Text + "' and Password= '" + passwordLogin.Text + "'";
            //cmd = new OleDbCommand(login, con);
            //OleDbDataReader dr = cmd.ExecuteReader();

            //if (approve == true)
            //{
            //   MessageBox.Show("Login Successful", "Login Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //accountDashboard account = new accountDashboard();
            //account.Show();
            //this.Hide();
            //}
            //else
            //{
            //MessageBox.Show("The given data is not recognised, try again");
            //usernameLogin.Text = "";
            //passwordLogin.Text = "";
            //usernameLogin.Focus();

            //}

            //if (usernameLogin.Text == "" && passwordLogin.Text == "")
            // {
            // MessageBox.Show("Both Criteria are empty");
            // }
            //MessageBox.Show("Login Successful", "Login Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginPrev_Click(object sender, EventArgs e)
        {
            firstForm pageback = new firstForm();
            pageback.Show();
            this.Hide();

        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister pageRegister = new frmRegister();
            pageRegister.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            usernameLogin.Text = "";
            passwordLogin.Text = "";
            usernameLogin.Focus();
        }

        private void LoginpassCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (loginpassCheck.Checked)
                {
                    passwordLogin.PasswordChar = '\0';
                    currUserType = "Customer";
                }
                else
                {
                    passwordLogin.PasswordChar = '*';
                currUserType = "Admin";
                }
            
                
        }
    }
}
