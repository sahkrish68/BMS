using BloodBankManagementSystem.DAL;
using BloodBankManagementSystem.UI;
using BloodManagementSystem.BLL;
using BloodManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
           

        }

        DonorDAL dal = new DonorDAL();

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //open usersForm
            frmUsers Users = new frmUsers();
            Users.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DGVdoners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void allDonorCount()
        {
            //Get the Donor Count from DAtabase and SEt in respective label
            lblopositivecount.Text = dal.countDonors("O+");
            label0nagative.Text = dal.countDonors("O-");
            labelApositive.Text = dal.countDonors("A+");
            labelAnegative.Text = dal.countDonors("A-");
            labelbpositibe.Text = dal.countDonors("B+");
            labebenagative.Text = dal.countDonors("B-");
            labelabpositibe.Text = dal.countDonors("AB+");
            label11ABnagative.Text = dal.countDonors("AB-");
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            //Load all the Blood Donors Count When Form is Loaded
            //Call allDonorCountMethod
            allDonorCount();

            //Display all the Donors
            DataTable dt = dal.Select();
            DGVdoners.DataSource = dt;

            //Display the username of Logged In user
           // lblUser.Text = frmLogin.loggedInUser;
        }

        private void donerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // open Donors form
            frmDoner1 donors = new frmDoner1();
            donors.Show();

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywords from the SEarch TextBox
            string keywords = textSearch.Text;

            //Check whether the TextBox is Empty or Not
            if (keywords != null)
            {
                //Filter the Donors based on Keywords
                DataTable dt = dal.Search(keywords);
                DGVdoners.DataSource = dt;
            }
            else
            {
                //DIsplay all the Donors
                DataTable dt = dal.Select();
                DGVdoners.DataSource = dt;
            }
        }
    }
}
