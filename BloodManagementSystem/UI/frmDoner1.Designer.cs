namespace BloodManagementSystem.UI
{
    partial class frmDoner1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFormTitle = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.labelFoemtitle = new System.Windows.Forms.Label();
            this.button_showdata = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.dgvDoners = new System.Windows.Forms.DataGridView();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_adresss = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.text_firstname = new System.Windows.Forms.TextBox();
            this.DonerId = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.Label();
            this.btnSelectIMG = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.LblprofilePicture = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.text_lastname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_BloodGroup = new System.Windows.Forms.ComboBox();
            this.labelbloodgroup = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.labelFormTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.BackColor = System.Drawing.Color.Salmon;
            this.labelFormTitle.Controls.Add(this.pictureBoxclose);
            this.labelFormTitle.Controls.Add(this.labelFoemtitle);
            this.labelFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormTitle.Location = new System.Drawing.Point(0, 0);
            this.labelFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(1401, 58);
            this.labelFormTitle.TabIndex = 2;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Image = global::BloodManagementSystem.Properties.Resources.cross;
            this.pictureBoxclose.Location = new System.Drawing.Point(1341, 9);
            this.pictureBoxclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(49, 44);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxclose.TabIndex = 1;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // labelFoemtitle
            // 
            this.labelFoemtitle.AutoSize = true;
            this.labelFoemtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoemtitle.Location = new System.Drawing.Point(571, 9);
            this.labelFoemtitle.Name = "labelFoemtitle";
            this.labelFoemtitle.Size = new System.Drawing.Size(197, 29);
            this.labelFoemtitle.TabIndex = 0;
            this.labelFoemtitle.Text = "Manage Doners";
            // 
            // button_showdata
            // 
            this.button_showdata.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_showdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showdata.ForeColor = System.Drawing.Color.White;
            this.button_showdata.Location = new System.Drawing.Point(1051, 569);
            this.button_showdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_showdata.Name = "button_showdata";
            this.button_showdata.Size = new System.Drawing.Size(160, 37);
            this.button_showdata.TabIndex = 53;
            this.button_showdata.Text = "Show Data";
            this.button_showdata.UseVisualStyleBackColor = false;
            this.button_showdata.Click += new System.EventHandler(this.button_showdata_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(611, 110);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(468, 22);
            this.textBox_Search.TabIndex = 51;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged_1);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(605, 87);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(68, 20);
            this.label_Search.TabIndex = 50;
            this.label_Search.Text = "Search";
            // 
            // dgvDoners
            // 
            this.dgvDoners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoners.Location = new System.Drawing.Point(507, 138);
            this.dgvDoners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoners.Name = "dgvDoners";
            this.dgvDoners.RowHeadersWidth = 51;
            this.dgvDoners.RowTemplate.Height = 24;
            this.dgvDoners.Size = new System.Drawing.Size(728, 423);
            this.dgvDoners.TabIndex = 49;
            this.dgvDoners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoners_CellContentClick);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(443, 569);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(101, 37);
            this.button_clear.TabIndex = 48;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Crimson;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(303, 569);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(101, 37);
            this.button_Delete.TabIndex = 47;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Teal;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(163, 569);
            this.button_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(101, 37);
            this.button_update.TabIndex = 46;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Green;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(40, 569);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(101, 37);
            this.button_add.TabIndex = 45;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_adresss
            // 
            this.textBox_adresss.Location = new System.Drawing.Point(205, 390);
            this.textBox_adresss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_adresss.Multiline = true;
            this.textBox_adresss.Name = "textBox_adresss";
            this.textBox_adresss.Size = new System.Drawing.Size(249, 73);
            this.textBox_adresss.TabIndex = 44;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(205, 346);
            this.textBox_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_contact.MaxLength = 15;
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(249, 22);
            this.textBox_contact.TabIndex = 43;
            this.textBox_contact.Text = " ";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adress.Location = new System.Drawing.Point(43, 390);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(68, 20);
            this.label_adress.TabIndex = 41;
            this.label_adress.Text = "Adress";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(36, 348);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(74, 20);
            this.label_contact.TabIndex = 39;
            this.label_contact.Text = "Contact";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(36, 268);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(70, 20);
            this.label_Gender.TabIndex = 40;
            this.label_Gender.Text = "Gender";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(205, 229);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(249, 22);
            this.textBox_Email.TabIndex = 37;
            // 
            // text_firstname
            // 
            this.text_firstname.Location = new System.Drawing.Point(205, 143);
            this.text_firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_firstname.Name = "text_firstname";
            this.text_firstname.Size = new System.Drawing.Size(249, 22);
            this.text_firstname.TabIndex = 36;
            // 
            // DonerId
            // 
            this.DonerId.Location = new System.Drawing.Point(205, 102);
            this.DonerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DonerId.Name = "DonerId";
            this.DonerId.ReadOnly = true;
            this.DonerId.Size = new System.Drawing.Size(249, 22);
            this.DonerId.TabIndex = 35;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(36, 231);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(56, 20);
            this.label_Email.TabIndex = 33;
            this.label_Email.Text = "Email";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(36, 143);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(102, 20);
            this.label_FirstName.TabIndex = 32;
            this.label_FirstName.Text = "First Name";
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(36, 103);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(85, 20);
            this.txtUserID.TabIndex = 31;
            this.txtUserID.Text = "Doner ID";
            // 
            // btnSelectIMG
            // 
            this.btnSelectIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectIMG.Location = new System.Drawing.Point(1255, 225);
            this.btnSelectIMG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectIMG.Name = "btnSelectIMG";
            this.btnSelectIMG.Size = new System.Drawing.Size(136, 34);
            this.btnSelectIMG.TabIndex = 30;
            this.btnSelectIMG.Text = "Select image";
            this.btnSelectIMG.UseVisualStyleBackColor = true;
            this.btnSelectIMG.Click += new System.EventHandler(this.btnSelectIMG_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(1269, 118);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(103, 101);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 29;
            this.profilePicture.TabStop = false;
            // 
            // LblprofilePicture
            // 
            this.LblprofilePicture.AutoSize = true;
            this.LblprofilePicture.Location = new System.Drawing.Point(1267, 87);
            this.LblprofilePicture.Name = "LblprofilePicture";
            this.LblprofilePicture.Size = new System.Drawing.Size(89, 16);
            this.LblprofilePicture.TabIndex = 28;
            this.LblprofilePicture.Text = "Profile PIcture";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // text_lastname
            // 
            this.text_lastname.Location = new System.Drawing.Point(205, 187);
            this.text_lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_lastname.Name = "text_lastname";
            this.text_lastname.Size = new System.Drawing.Size(249, 22);
            this.text_lastname.TabIndex = 55;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastname.Location = new System.Drawing.Point(36, 190);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(100, 20);
            this.labelLastname.TabIndex = 54;
            this.labelLastname.Text = "Last Name";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "others"});
            this.comboBox_gender.Location = new System.Drawing.Point(205, 263);
            this.comboBox_gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(249, 24);
            this.comboBox_gender.TabIndex = 56;
            // 
            // comboBox_BloodGroup
            // 
            this.comboBox_BloodGroup.FormattingEnabled = true;
            this.comboBox_BloodGroup.Items.AddRange(new object[] {
            "o+",
            "o-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBox_BloodGroup.Location = new System.Drawing.Point(205, 305);
            this.comboBox_BloodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BloodGroup.Name = "comboBox_BloodGroup";
            this.comboBox_BloodGroup.Size = new System.Drawing.Size(249, 24);
            this.comboBox_BloodGroup.TabIndex = 58;
            // 
            // labelbloodgroup
            // 
            this.labelbloodgroup.AutoSize = true;
            this.labelbloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbloodgroup.Location = new System.Drawing.Point(36, 309);
            this.labelbloodgroup.Name = "labelbloodgroup";
            this.labelbloodgroup.Size = new System.Drawing.Size(108, 20);
            this.labelbloodgroup.TabIndex = 57;
            this.labelbloodgroup.Text = "BloodGroup";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(-19, -18);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 59;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // frmDoner1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1401, 690);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.comboBox_BloodGroup);
            this.Controls.Add(this.labelbloodgroup);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.text_lastname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.button_showdata);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.dgvDoners);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_adresss);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.text_firstname);
            this.Controls.Add(this.DonerId);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnSelectIMG);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.LblprofilePicture);
            this.Controls.Add(this.labelFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDoner1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoner1";
            this.labelFormTitle.ResumeLayout(false);
            this.labelFormTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel labelFormTitle;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Label labelFoemtitle;
        private System.Windows.Forms.Button button_showdata;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.DataGridView dgvDoners;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_adresss;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox text_firstname;
        private System.Windows.Forms.TextBox DonerId;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.Button btnSelectIMG;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label LblprofilePicture;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox text_lastname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ComboBox comboBox_BloodGroup;
        private System.Windows.Forms.Label labelbloodgroup;
    }
}