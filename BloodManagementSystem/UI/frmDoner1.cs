using BloodBankManagementSystem.DAL;
using BloodManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BloodManagementSystem.UI
{
    public partial class frmDoner1 : Form
    {
        public frmDoner1()
        {
            InitializeComponent();

            dgvDoners.CellClick += dgvDoners_CellContentClick;



        }
        //CREATE AN OBJECT OF DONOR BLL
        DonorDAL dal = new DonorDAL();
        donorBLL d = new donorBLL();

        // create a globle vairable for image
         string imageName = "";
         string sourcePath="";
         string destinationPath="";


         string rowHeaderImage;

        private void labelFoemtitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Search_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            // close this formS
            this.Hide();
        }

        private void button_showdata_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvDoners.DataSource = dt;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label_adress_Click(object sender, EventArgs e)
        {

        }





        private void clear()
        {
            text_firstname.Text = "";
            text_lastname.Text = "";
            textBox_Email.Text = "";
            comboBox_gender.Text = "";
            comboBox_BloodGroup.Text = "";
            textBox_contact.Text = "";
            textBox_adresss.Text = "";


        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Check if profile picture is not selected
            if (string.IsNullOrEmpty(imageName))
            {
                MessageBox.Show("Please select a profile picture.", "Profile Picture Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }

            // Proceed with adding the donor
            d.first_name = text_firstname.Text;
            d.last_name = text_lastname.Text;
            d.email = textBox_Email.Text;
            d.gender = comboBox_gender.Text;
            d.blood_group = comboBox_BloodGroup.Text;
            d.contact = textBox_contact.Text;
            d.address = textBox_adresss.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1; // this is only for now we will add login function by tomorrow
            d.image_name = imageName;

            bool isSuccess = dal.Insert(d);

            //Step 3: Check whether the Data is Inserted Successfully or Not
            if (isSuccess == true)
            {
                //Data or User Added Successfully
                MessageBox.Show("New User added Successfully.");

                //Display the user in DataGrid View
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
                clear();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            d.donor_id = int.Parse(DonerId.Text);

            bool success = dal.Delete(d);

            //Let's check whteher the user is Deleted or Not
            if (success == true)
            {
                //User Deleted Successfully
                MessageBox.Show("User Deleted Successfully");

                //Refresh DataGrid View
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;

                //Clear the TextBoxes
                clear();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(DonerId.Text);
            d.first_name = text_firstname.Text;
            d.last_name = text_lastname.Text;
            d.email = textBox_Email.Text;
            d.gender = comboBox_gender.Text;
            d.blood_group = comboBox_BloodGroup.Text;
            d.contact = textBox_contact.Text;
            d.address = textBox_adresss.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1; // this is only for now we will add login function by tommorrow
            d.image_name = imageName;

            bool success = dal.Update(d);

            if (success == true)
            {
                MessageBox.Show("use updated sucessfully");

                //Display the user in DataGrid View
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
                clear();
            }
        }

        private void dgvDoners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Get the selected row
                DataGridViewRow row = dgvDoners.Rows[e.RowIndex];

                // Populate the text boxes with the data from the selected row
                DonerId.Text = row.Cells["donor_id"].Value.ToString();
                text_firstname.Text = row.Cells["first_name"].Value.ToString();
                text_lastname.Text = row.Cells["last_name"].Value.ToString();
                textBox_Email.Text = row.Cells["email"].Value.ToString();
                comboBox_gender.Text = row.Cells["gender"].Value.ToString();
                comboBox_BloodGroup.Text = row.Cells["blood_group"].Value.ToString();
                textBox_contact.Text = row.Cells["contact"].Value.ToString();
                textBox_adresss.Text = row.Cells["address"].Value.ToString();
                string imageName = row.Cells["image_name"].Value.ToString();

                //profilePicture.Image = Image.FromFile(imageName)
                    ;

                //Update the VAlue of rowHeaderImage
                rowHeaderImage = imageName;

                //Display The image of Selected Donor
                //Get the image path
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
                string imagePath = paths + "\\images\\" + imageName;
                //Display the Image of SElected User
                ////profilePicture.Image = new Bitmap(imagePath);
            }

        }
    

        private void btnSelectIMG_Click(object sender, EventArgs e)
        {
            //Code to Select Image and Upload
            //1. Open the Dialog Box to SElect Image
            OpenFileDialog open = new OpenFileDialog();

            //2. FIlter the File Type (allow only image files)
            open.Filter = "Image Files Only (*.jpg; *.jpeg; *.png; *.gif| *.jpg; *.jpeg; *.png; *.gif)";

            //3. Check whether the image is selected or not
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Check if the file exists or not
                if (open.CheckFileExists)
                {
                    //Display the Selected Image in PictureBox
                    profilePicture.Image = new Bitmap(open.FileName);

                    //Rename the selected image 
                    //1. Get the Extension of SElected Image
                    string ext = Path.GetExtension(open.FileName);

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    //Generate Random but Globally Unique Identifier
                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    //Finally REname our Image
                    imageName = "Blood_Bank_MS_" + name + g + ext;

                    //Get the Source Path (Path of Image)
                    sourcePath = open.FileName;

                    //Get the Destination Path
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    //Path to Desitnation 
                    destinationPath = paths + "\\images\\" + imageName;

                    //Upload the Image to Destination Folder
                    //File.Copy(sourcePath, destinationPath);

                    //Display Message after the image is uploaded successfully
                    //MessageBox.Show("Image successfully uploaded.");
                }
            }
        }

        private void textBox_Search_TextChanged_1(object sender, EventArgs e)
        {
            // Write the Code to Get the users BAsed on Keywords
            //1. Get the Keywords from the TExtBox
            String keywords = textBox_Search.Text;

            //Check whether the textbox is empty or not
            if (keywords != null)
            {
                //TextBox is not empty, display users on DAta Grid View based on the keywords
                DataTable dt = dal.Search(keywords);
                dgvDoners.DataSource = dt;
            }
            else
            {
                //TExtbox is Empty and display all the users on DAta Grid View
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
            }
        }
    }
}

    