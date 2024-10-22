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

namespace Amusement_Park_App

{
    public partial class frmRegister : Form
    {
        AccountBooking acDb = new AccountBooking();
        User cust = new User();


        
        public frmRegister()
        {
            InitializeComponent();
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdRegisterCont_Click(object sender, EventArgs e)
        {
            registerUser();
        }

        private void CmdRegisterback_Click(object sender, EventArgs e)
        {
            firstForm pageback = new firstForm();
            pageback.Show();
            this.Hide();

        }

        private void PasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheck.Checked)
            {
                passwordRegister.PasswordChar = '\0';
                passwordRegister2.PasswordChar = '\0';
            }
            else
            {
                passwordRegister.PasswordChar = '*';
                passwordRegister2.PasswordChar = '*';
            }
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            usernameRegister.Text = "";
            passwordRegister.Text = "";
            passwordRegister2.Text = "";
            emailRegister.Text = "";
            pnumberRegister.Text = "";
        }

        private void PrelogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            usernameRegister.Focus();
        }

        public void registerUser()
        {
            string frmUname = usernameRegister.Text;
            string frmUpwd = passwordRegister.Text;
            string frmUpwd2 = passwordRegister2.Text;
            string frmUtype = userType.Text;
            string frmUemail = emailRegister.Text;
            string frmUphone = pnumberRegister.Text;

            if (frmUname == "" || frmUpwd == "" || frmUpwd2 == "" || frmUtype == null || frmUtype == "" || frmUphone == "" || frmUemail == "")
            {
                MessageBox.Show("Certain input types are missing");
            }

            if (frmUpwd != frmUpwd2)
            {
                MessageBox.Show("Your password confirmation is incorrect, try again", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (frmUname != "" || frmUpwd != "" || frmUpwd2 != "" || frmUtype == "Customer"|| frmUtype == "Admin" || frmUphone != "" || frmUemail != "")
            { 
            cust.uNam = frmUname;
            cust.uPass = frmUpwd;
            cust.uType = frmUtype;
            cust.eAdd = frmUemail;
            cust.DbCreate();

            MessageBox.Show("Registration was Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            firstForm main = new firstForm();
            main.Show();
            this.Close();
        }
            else
            {
                MessageBox.Show("User Type input is invalid, Try again", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cust.uname = frmUname;
            //cust.upwd = frmUpwd;
            //cust.utype = frmUtype;

            
        }

        private void EmailRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnumberRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
