using BloodBankManagementSystem.DAL;
using BloodManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //create and object Bll and Dal
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        //create a static string mothod to save the user name 
        static string loggedInUser;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_pasword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Write the Code to Login our Application
            //1. Get the username and password from login form
            l.username = textBox_Username.Text;
            l.Password = textBox_Password.Text;

            //Check the Login Credentials
            bool isSuccess = dal.loginCheck(l);

            //Check whehter the login is success or not
            //If login is success then isSuccess will be true else it will be false
            if (isSuccess == true)
            {
                //Login Success
                //Display Success Message
                MessageBox.Show("Login Successful.");

                //Save the username in loggedInuser Stattic MEthod
                loggedInUser = l.username;

                //Display home Form
                frmHome home = new frmHome();
                home.Show();
                this.Hide(); //To CLose Login Form
            }
            else
            {
                //Login Failed
                //Display the Error Message
                MessageBox.Show("Login Failed. Try Again.");
            }
        }
    }
}
