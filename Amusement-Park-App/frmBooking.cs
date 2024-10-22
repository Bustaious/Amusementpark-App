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

namespace Amusement_Park_App
{
    public partial class frmBooking : Form
    {

        Booking book = new Booking();
        AccountBooking acDb = new AccountBooking();
        

        public frmBooking()
        {
            InitializeComponent();
        }

        public enum ServiceType
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            firstForm form1 = new firstForm();
            form1.Show();
            this.Hide();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {

        }


        public static string frmVisittype;
        public static string frmDays;
        public static string frmWeeks;
        public static string frmExclusive;
        public static string frmDate;
       
        

        public void inputBooking()
        {
            frmVisittype = visittypeCombo.ValueMember;
            frmDays = daysCombo.ValueMember;
            frmWeeks = weeksCombo.ValueMember;
            frmExclusive = exclusiveCombo.ValueMember;
            DateTime frmDate = bookingDT.Value;
            

            if (frmVisittype == null || frmDays == null || frmWeeks == null || frmExclusive == null || frmDate == null)
            {
                MessageBox.Show("Certain input types are missing, Fill out the entire form to continue","Input error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


            if (frmVisittype != null ) 
            {
                book.service = frmVisittype;
                book.oTime = frmDays;
                book.oTime = frmWeeks;
                book.bType = frmExclusive;
                book.oDate = frmDate;
                book.excl = frmExclusive;
                book.BkCreate();

                MessageBox.Show("Booking order was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SubmitbookingBtn_Click(object sender, EventArgs e)
        {
            inputBooking();
        }
    }
}
