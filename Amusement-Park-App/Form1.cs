using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amusement_Park_App
{
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin pagelogin = new frmLogin();
            pagelogin.Show();
            this.Hide();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmLogin.currUserType == "Customer")
            {
                DialogResult result = MessageBox.Show("You are already logged in. \nAre you sure you want to register another account?", "Enquiry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    firstForm pageback = new firstForm();
                    pageback.Show();
                    this.Close();
                }
                else
                {
                    frmRegister pageRegister = new frmRegister();
                    pageRegister.Show();
                    this.Hide();
                }



            }


            
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBooking newbooking = new frmBooking();
            newbooking.Show();
            this.Hide();
        }

        private void ProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmLogin.currUserType == "Customer")
            {
                accountDashboard newdash = new accountDashboard();
                newdash.Show();
                this.Hide();
            }
            
            if (frmLogin.currUserType == "")
            {
                MessageBox.Show("You are not logged in, \nSign-in to access your profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (frmLogin.currUserType == "Admin")
            {
                frmAdmin newdash = new frmAdmin();
                newdash.Show();
                this.Hide();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
