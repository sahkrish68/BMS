namespace BloodBankManagementSystem.UI
{
    partial class frmUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.labelFoemtitle = new System.Windows.Forms.Label();
            this.LblprofilePicture = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.btnSelectIMG = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.Label();
            this.label_FullName = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.TextBox();
            this.text_fullname = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_adresss = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.button_showdata = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.pictureBoxclose);
            this.panel1.Controls.Add(this.labelFoemtitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 56);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Image = global::BloodManagementSystem.Properties.Resources.cross;
            this.pictureBoxclose.Location = new System.Drawing.Point(1073, 9);
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
            this.labelFoemtitle.Location = new System.Drawing.Point(389, 9);
            this.labelFoemtitle.Name = "labelFoemtitle";
            this.labelFoemtitle.Size = new System.Drawing.Size(181, 29);
            this.labelFoemtitle.TabIndex = 0;
            this.labelFoemtitle.Text = "Manage Users";
            // 
            // LblprofilePicture
            // 
            this.LblprofilePicture.AutoSize = true;
            this.LblprofilePicture.Location = new System.Drawing.Point(1009, 62);
            this.LblprofilePicture.Name = "LblprofilePicture";
            this.LblprofilePicture.Size = new System.Drawing.Size(89, 16);
            this.LblprofilePicture.TabIndex = 1;
            this.LblprofilePicture.Text = "Profile PIcture";
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(998, 87);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(103, 101);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // btnSelectIMG
            // 
            this.btnSelectIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectIMG.Location = new System.Drawing.Point(986, 204);
            this.btnSelectIMG.Name = "btnSelectIMG";
            this.btnSelectIMG.Size = new System.Drawing.Size(136, 35);
            this.btnSelectIMG.TabIndex = 3;
            this.btnSelectIMG.Text = "Select image";
            this.btnSelectIMG.UseVisualStyleBackColor = true;
            this.btnSelectIMG.Click += new System.EventHandler(this.btnSelectIMG_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(21, 87);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(80, 20);
            this.txtUserID.TabIndex = 4;
            this.txtUserID.Text = "Usert ID";
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FullName.Location = new System.Drawing.Point(21, 136);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(94, 20);
            this.label_FullName.TabIndex = 5;
            this.label_FullName.Text = "Full Name";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(21, 192);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(56, 20);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(21, 247);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(103, 20);
            this.Username.TabIndex = 6;
            this.Username.Text = "User Name";
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(190, 87);
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Size = new System.Drawing.Size(250, 22);
            this.UserId.TabIndex = 7;
            // 
            // text_fullname
            // 
            this.text_fullname.Location = new System.Drawing.Point(190, 136);
            this.text_fullname.Name = "text_fullname";
            this.text_fullname.Size = new System.Drawing.Size(250, 22);
            this.text_fullname.TabIndex = 8;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(190, 192);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(250, 22);
            this.textBox_Email.TabIndex = 9;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(190, 247);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(250, 22);
            this.textBox_username.TabIndex = 10;
            // 
            // textBox_adresss
            // 
            this.textBox_adresss.Location = new System.Drawing.Point(190, 414);
            this.textBox_adresss.Multiline = true;
            this.textBox_adresss.Name = "textBox_adresss";
            this.textBox_adresss.Size = new System.Drawing.Size(250, 73);
            this.textBox_adresss.TabIndex = 18;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(190, 367);
            this.textBox_contact.MaxLength = 15;
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(250, 22);
            this.textBox_contact.TabIndex = 17;
            this.textBox_contact.Text = " ";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(190, 311);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = 'X';
            this.textBox_password.Size = new System.Drawing.Size(250, 22);
            this.textBox_password.TabIndex = 16;
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adress.Location = new System.Drawing.Point(21, 437);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(68, 20);
            this.label_adress.TabIndex = 14;
            this.label_adress.Text = "Adress";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(21, 367);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(74, 20);
            this.label_contact.TabIndex = 12;
            this.label_contact.Text = "Contact";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(21, 311);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(91, 20);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Password";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Green;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(76, 525);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(102, 37);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Teal;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(209, 525);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(102, 37);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Crimson;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(338, 525);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(102, 37);
            this.button_Delete.TabIndex = 21;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(468, 525);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(102, 37);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(491, 129);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(477, 386);
            this.dgvUser.TabIndex = 23;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(558, 85);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(398, 22);
            this.textBox_Search.TabIndex = 25;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(487, 87);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(68, 20);
            this.label_Search.TabIndex = 24;
            this.label_Search.Text = "Search";
            // 
            // button_showdata
            // 
            this.button_showdata.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_showdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showdata.ForeColor = System.Drawing.Color.White;
            this.button_showdata.Location = new System.Drawing.Point(808, 525);
            this.button_showdata.Name = "button_showdata";
            this.button_showdata.Size = new System.Drawing.Size(160, 37);
            this.button_showdata.TabIndex = 27;
            this.button_showdata.Text = "Show Data";
            this.button_showdata.UseVisualStyleBackColor = false;
            this.button_showdata.Click += new System.EventHandler(this.button_showdata_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1140, 613);
            this.Controls.Add(this.button_showdata);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_adresss);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.text_fullname);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnSelectIMG);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.LblprofilePicture);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFoemtitle;
        private System.Windows.Forms.Label LblprofilePicture;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button btnSelectIMG;
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.TextBox text_fullname;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_adresss;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Button button_showdata;
    }
}