using System.Windows.Forms;

namespace SIMS.LearnerModule
{
    partial class AddLearner
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
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DateAdmission = new System.Windows.Forms.DateTimePicker();
            this.AdminDateLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxAdminNumber = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxIDNumber = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxLastName = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.ComboBoxCentre = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxGender = new MetroFramework.Controls.MetroComboBox();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.contactNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.idNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.guardianGroupBox = new System.Windows.Forms.GroupBox();
            this.TextBoxCity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxZipCode = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxAddressLine1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxAddressLine2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxSuburb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.addDetailsTile = new MetroFramework.Controls.MetroTile();
            this.cancelTile = new MetroFramework.Controls.MetroTile();
            this.clearTile = new MetroFramework.Controls.MetroTile();
            this.detailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guardianGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsGroupBox.Controls.Add(this.DateAdmission);
            this.detailsGroupBox.Controls.Add(this.AdminDateLabel);
            this.detailsGroupBox.Controls.Add(this.groupBox1);
            this.detailsGroupBox.Controls.Add(this.TextBoxAdminNumber);
            this.detailsGroupBox.Controls.Add(this.TextBoxContactNumber);
            this.detailsGroupBox.Controls.Add(this.TextBoxIDNumber);
            this.detailsGroupBox.Controls.Add(this.TextBoxLastName);
            this.detailsGroupBox.Controls.Add(this.TextBoxFirstName);
            this.detailsGroupBox.Controls.Add(this.ComboBoxCentre);
            this.detailsGroupBox.Controls.Add(this.metroLabel2);
            this.detailsGroupBox.Controls.Add(this.metroLabel1);
            this.detailsGroupBox.Controls.Add(this.ComboBoxGender);
            this.detailsGroupBox.Controls.Add(this.genderLabel);
            this.detailsGroupBox.Controls.Add(this.contactNumberLabel);
            this.detailsGroupBox.Controls.Add(this.idNumberLabel);
            this.detailsGroupBox.Controls.Add(this.lastNameLabel);
            this.detailsGroupBox.Controls.Add(this.firstNameLabel);
            this.detailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGroupBox.Location = new System.Drawing.Point(17, 84);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(521, 409);
            this.detailsGroupBox.TabIndex = 0;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Student Details";
            // 
            // DateAdmission
            // 
            this.DateAdmission.Location = new System.Drawing.Point(150, 264);
            this.DateAdmission.Name = "DateAdmission";
            this.DateAdmission.Size = new System.Drawing.Size(163, 21);
            this.DateAdmission.TabIndex = 30;
            this.DateAdmission.Value = new System.DateTime(2015, 5, 28, 23, 53, 38, 0);
            // 
            // AdminDateLabel
            // 
            this.AdminDateLabel.AutoSize = true;
            this.AdminDateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AdminDateLabel.Location = new System.Drawing.Point(6, 266);
            this.AdminDateLabel.Name = "AdminDateLabel";
            this.AdminDateLabel.Size = new System.Drawing.Size(116, 19);
            this.AdminDateLabel.TabIndex = 29;
            this.AdminDateLabel.Text = "Adminssion Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(533, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardian Details";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.White;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(6, 26);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "First Name:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(164, 21);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(329, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox1.TabIndex = 21;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            // 
            // TextBoxAdminNumber
            // 
            this.TextBoxAdminNumber.Lines = new string[0];
            this.TextBoxAdminNumber.Location = new System.Drawing.Point(150, 207);
            this.TextBoxAdminNumber.MaxLength = 32767;
            this.TextBoxAdminNumber.Name = "TextBoxAdminNumber";
            this.TextBoxAdminNumber.PasswordChar = '\0';
            this.TextBoxAdminNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAdminNumber.SelectedText = "";
            this.TextBoxAdminNumber.Size = new System.Drawing.Size(329, 23);
            this.TextBoxAdminNumber.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxAdminNumber.TabIndex = 25;
            this.TextBoxAdminNumber.UseSelectable = true;
            this.TextBoxAdminNumber.UseStyleColors = true;
            // 
            // TextBoxContactNumber
            // 
            this.TextBoxContactNumber.Lines = new string[0];
            this.TextBoxContactNumber.Location = new System.Drawing.Point(150, 157);
            this.TextBoxContactNumber.MaxLength = 32767;
            this.TextBoxContactNumber.Name = "TextBoxContactNumber";
            this.TextBoxContactNumber.PasswordChar = '\0';
            this.TextBoxContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxContactNumber.SelectedText = "";
            this.TextBoxContactNumber.Size = new System.Drawing.Size(329, 23);
            this.TextBoxContactNumber.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxContactNumber.TabIndex = 24;
            this.TextBoxContactNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxContactNumber.UseSelectable = true;
            this.TextBoxContactNumber.UseStyleColors = true;
            // 
            // TextBoxIDNumber
            // 
            this.TextBoxIDNumber.Lines = new string[0];
            this.TextBoxIDNumber.Location = new System.Drawing.Point(150, 108);
            this.TextBoxIDNumber.MaxLength = 32767;
            this.TextBoxIDNumber.Name = "TextBoxIDNumber";
            this.TextBoxIDNumber.PasswordChar = '\0';
            this.TextBoxIDNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIDNumber.SelectedText = "";
            this.TextBoxIDNumber.Size = new System.Drawing.Size(329, 23);
            this.TextBoxIDNumber.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxIDNumber.TabIndex = 23;
            this.TextBoxIDNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxIDNumber.UseSelectable = true;
            this.TextBoxIDNumber.UseStyleColors = true;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Lines = new string[0];
            this.TextBoxLastName.Location = new System.Drawing.Point(150, 63);
            this.TextBoxLastName.MaxLength = 32767;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.PasswordChar = '\0';
            this.TextBoxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxLastName.SelectedText = "";
            this.TextBoxLastName.Size = new System.Drawing.Size(329, 23);
            this.TextBoxLastName.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxLastName.TabIndex = 22;
            this.TextBoxLastName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxLastName.UseSelectable = true;
            this.TextBoxLastName.UseStyleColors = true;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Lines = new string[0];
            this.TextBoxFirstName.Location = new System.Drawing.Point(150, 21);
            this.TextBoxFirstName.MaxLength = 32767;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.PasswordChar = '\0';
            this.TextBoxFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxFirstName.SelectedText = "";
            this.TextBoxFirstName.Size = new System.Drawing.Size(329, 23);
            this.TextBoxFirstName.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxFirstName.TabIndex = 21;
            this.TextBoxFirstName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxFirstName.UseSelectable = true;
            this.TextBoxFirstName.UseStyleColors = true;
            // 
            // ComboBoxCentre
            // 
            this.ComboBoxCentre.DisplayFocus = true;
            this.ComboBoxCentre.FormattingEnabled = true;
            this.ComboBoxCentre.ItemHeight = 23;
            this.ComboBoxCentre.Items.AddRange(new object[] {
            "Durban"});
            this.ComboBoxCentre.Location = new System.Drawing.Point(150, 360);
            this.ComboBoxCentre.Name = "ComboBoxCentre";
            this.ComboBoxCentre.Size = new System.Drawing.Size(132, 29);
            this.ComboBoxCentre.Style = MetroFramework.MetroColorStyle.Green;
            this.ComboBoxCentre.TabIndex = 20;
            this.ComboBoxCentre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComboBoxCentre.UseSelectable = true;
            this.ComboBoxCentre.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 370);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Centre:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Admission Number:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.DisplayFocus = true;
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.ItemHeight = 23;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboBoxGender.Location = new System.Drawing.Point(150, 313);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(132, 29);
            this.ComboBoxGender.Style = MetroFramework.MetroColorStyle.Green;
            this.ComboBoxGender.TabIndex = 15;
            this.ComboBoxGender.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComboBoxGender.UseSelectable = true;
            this.ComboBoxGender.UseStyleColors = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.White;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.genderLabel.Location = new System.Drawing.Point(6, 323);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(57, 19);
            this.genderLabel.TabIndex = 14;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.BackColor = System.Drawing.Color.White;
            this.contactNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.contactNumberLabel.Location = new System.Drawing.Point(6, 161);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(114, 19);
            this.contactNumberLabel.TabIndex = 12;
            this.contactNumberLabel.Text = "Contact Number:";
            this.contactNumberLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.BackColor = System.Drawing.Color.White;
            this.idNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.idNumberLabel.Location = new System.Drawing.Point(6, 112);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(80, 19);
            this.idNumberLabel.TabIndex = 10;
            this.idNumberLabel.Text = "ID Number:";
            this.idNumberLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.White;
            this.lastNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 19);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.White;
            this.firstNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(78, 19);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // guardianGroupBox
            // 
            this.guardianGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guardianGroupBox.Controls.Add(this.TextBoxCity);
            this.guardianGroupBox.Controls.Add(this.metroLabel6);
            this.guardianGroupBox.Controls.Add(this.TextBoxEmailAddress);
            this.guardianGroupBox.Controls.Add(this.metroLabel12);
            this.guardianGroupBox.Controls.Add(this.TextBoxZipCode);
            this.guardianGroupBox.Controls.Add(this.TextBoxAddressLine1);
            this.guardianGroupBox.Controls.Add(this.metroLabel11);
            this.guardianGroupBox.Controls.Add(this.TextBoxAddressLine2);
            this.guardianGroupBox.Controls.Add(this.metroLabel10);
            this.guardianGroupBox.Controls.Add(this.metroLabel14);
            this.guardianGroupBox.Controls.Add(this.TextBoxSuburb);
            this.guardianGroupBox.Controls.Add(this.metroLabel13);
            this.guardianGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianGroupBox.Location = new System.Drawing.Point(550, 84);
            this.guardianGroupBox.Name = "guardianGroupBox";
            this.guardianGroupBox.Size = new System.Drawing.Size(521, 332);
            this.guardianGroupBox.TabIndex = 1;
            this.guardianGroupBox.TabStop = false;
            this.guardianGroupBox.Text = "Address Details";
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Lines = new string[0];
            this.TextBoxCity.Location = new System.Drawing.Point(164, 207);
            this.TextBoxCity.MaxLength = 32767;
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.PasswordChar = '\0';
            this.TextBoxCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCity.SelectedText = "";
            this.TextBoxCity.Size = new System.Drawing.Size(329, 23);
            this.TextBoxCity.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxCity.TabIndex = 28;
            this.TextBoxCity.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxCity.UseSelectable = true;
            this.TextBoxCity.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(6, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Email Address:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxEmailAddress
            // 
            this.TextBoxEmailAddress.Lines = new string[0];
            this.TextBoxEmailAddress.Location = new System.Drawing.Point(164, 21);
            this.TextBoxEmailAddress.MaxLength = 32767;
            this.TextBoxEmailAddress.Name = "TextBoxEmailAddress";
            this.TextBoxEmailAddress.PasswordChar = '\0';
            this.TextBoxEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxEmailAddress.SelectedText = "";
            this.TextBoxEmailAddress.Size = new System.Drawing.Size(329, 23);
            this.TextBoxEmailAddress.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxEmailAddress.TabIndex = 21;
            this.TextBoxEmailAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxEmailAddress.UseSelectable = true;
            this.TextBoxEmailAddress.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.White;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(6, 67);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(102, 19);
            this.metroLabel12.TabIndex = 8;
            this.metroLabel12.Text = "Address Line 1:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxZipCode
            // 
            this.TextBoxZipCode.Lines = new string[0];
            this.TextBoxZipCode.Location = new System.Drawing.Point(164, 262);
            this.TextBoxZipCode.MaxLength = 32767;
            this.TextBoxZipCode.Name = "TextBoxZipCode";
            this.TextBoxZipCode.PasswordChar = '\0';
            this.TextBoxZipCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxZipCode.SelectedText = "";
            this.TextBoxZipCode.Size = new System.Drawing.Size(132, 23);
            this.TextBoxZipCode.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxZipCode.TabIndex = 27;
            this.TextBoxZipCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxZipCode.UseSelectable = true;
            this.TextBoxZipCode.UseStyleColors = true;
            // 
            // TextBoxAddressLine1
            // 
            this.TextBoxAddressLine1.Lines = new string[0];
            this.TextBoxAddressLine1.Location = new System.Drawing.Point(164, 63);
            this.TextBoxAddressLine1.MaxLength = 32767;
            this.TextBoxAddressLine1.Name = "TextBoxAddressLine1";
            this.TextBoxAddressLine1.PasswordChar = '\0';
            this.TextBoxAddressLine1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAddressLine1.SelectedText = "";
            this.TextBoxAddressLine1.Size = new System.Drawing.Size(329, 23);
            this.TextBoxAddressLine1.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxAddressLine1.TabIndex = 22;
            this.TextBoxAddressLine1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxAddressLine1.UseSelectable = true;
            this.TextBoxAddressLine1.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.White;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(6, 112);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(102, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "Address Line 2:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxAddressLine2
            // 
            this.TextBoxAddressLine2.Lines = new string[0];
            this.TextBoxAddressLine2.Location = new System.Drawing.Point(164, 108);
            this.TextBoxAddressLine2.MaxLength = 32767;
            this.TextBoxAddressLine2.Name = "TextBoxAddressLine2";
            this.TextBoxAddressLine2.PasswordChar = '\0';
            this.TextBoxAddressLine2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAddressLine2.SelectedText = "";
            this.TextBoxAddressLine2.Size = new System.Drawing.Size(329, 23);
            this.TextBoxAddressLine2.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxAddressLine2.TabIndex = 23;
            this.TextBoxAddressLine2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxAddressLine2.UseSelectable = true;
            this.TextBoxAddressLine2.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.White;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(6, 161);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(56, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Suburb:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.White;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(6, 266);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(67, 19);
            this.metroLabel14.TabIndex = 26;
            this.metroLabel14.Text = "Zip Code:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxSuburb
            // 
            this.TextBoxSuburb.Lines = new string[0];
            this.TextBoxSuburb.Location = new System.Drawing.Point(164, 157);
            this.TextBoxSuburb.MaxLength = 32767;
            this.TextBoxSuburb.Name = "TextBoxSuburb";
            this.TextBoxSuburb.PasswordChar = '\0';
            this.TextBoxSuburb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSuburb.SelectedText = "";
            this.TextBoxSuburb.Size = new System.Drawing.Size(329, 23);
            this.TextBoxSuburb.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxSuburb.TabIndex = 24;
            this.TextBoxSuburb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxSuburb.UseSelectable = true;
            this.TextBoxSuburb.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.White;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(6, 211);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "City:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // addDetailsTile
            // 
            this.addDetailsTile.ActiveControl = null;
            this.addDetailsTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addDetailsTile.Location = new System.Drawing.Point(550, 461);
            this.addDetailsTile.Name = "addDetailsTile";
            this.addDetailsTile.Size = new System.Drawing.Size(159, 32);
            this.addDetailsTile.Style = MetroFramework.MetroColorStyle.Green;
            this.addDetailsTile.TabIndex = 2;
            this.addDetailsTile.Text = "Add Details";
            this.addDetailsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDetailsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.addDetailsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.addDetailsTile.UseSelectable = true;
            this.addDetailsTile.UseStyleColors = true;
            this.addDetailsTile.Click += new System.EventHandler(this.addDetailsTile_Click);
            // 
            // cancelTile
            // 
            this.cancelTile.ActiveControl = null;
            this.cancelTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelTile.Location = new System.Drawing.Point(912, 461);
            this.cancelTile.Name = "cancelTile";
            this.cancelTile.Size = new System.Drawing.Size(159, 32);
            this.cancelTile.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelTile.TabIndex = 3;
            this.cancelTile.Text = "Cancel";
            this.cancelTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cancelTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.cancelTile.UseSelectable = true;
            this.cancelTile.UseStyleColors = true;
            this.cancelTile.Click += new System.EventHandler(this.cancelTile_Click);
            // 
            // clearTile
            // 
            this.clearTile.ActiveControl = null;
            this.clearTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearTile.Location = new System.Drawing.Point(731, 461);
            this.clearTile.Name = "clearTile";
            this.clearTile.Size = new System.Drawing.Size(159, 32);
            this.clearTile.TabIndex = 4;
            this.clearTile.Text = "Clear";
            this.clearTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.clearTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.clearTile.UseSelectable = true;
            this.clearTile.Click += new System.EventHandler(this.clearTile_Click);
            // 
            // AddLearner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 588);
            this.Controls.Add(this.clearTile);
            this.Controls.Add(this.cancelTile);
            this.Controls.Add(this.addDetailsTile);
            this.Controls.Add(this.guardianGroupBox);
            this.Controls.Add(this.detailsGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLearner";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add New Learner";
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guardianGroupBox.ResumeLayout(false);
            this.guardianGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /*
         * Disable close button
         */
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private GroupBox detailsGroupBox;
        private GroupBox guardianGroupBox;
        private MetroFramework.Controls.MetroComboBox ComboBoxGender;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel contactNumberLabel;
        private MetroFramework.Controls.MetroLabel idNumberLabel;
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroLabel firstNameLabel;
        private MetroFramework.Controls.MetroComboBox ComboBoxCentre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxFirstName;
        private MetroFramework.Controls.MetroTextBox TextBoxLastName;
        private MetroFramework.Controls.MetroTextBox TextBoxAdminNumber;
        private MetroFramework.Controls.MetroTextBox TextBoxContactNumber;
        private MetroFramework.Controls.MetroTextBox TextBoxIDNumber;
        private MetroFramework.Controls.MetroLabel AdminDateLabel;
        private MetroFramework.Controls.MetroTile addDetailsTile;
        private MetroFramework.Controls.MetroTile cancelTile;
        private GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TextBoxEmailAddress;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox TextBoxZipCode;
        private MetroFramework.Controls.MetroTextBox TextBoxAddressLine1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox TextBoxAddressLine2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox TextBoxSuburb;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTile clearTile;
        private DateTimePicker DateAdmission;
        private MetroFramework.Controls.MetroTextBox TextBoxCity;
    
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 
    }
}