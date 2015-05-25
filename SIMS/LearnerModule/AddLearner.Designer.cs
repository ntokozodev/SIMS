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
            this.AdminDateLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxZipCode = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxCity = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxSuburb = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxAddressLine2 = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxAddressLine1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.addressLine2Label = new MetroFramework.Controls.MetroLabel();
            this.addressLineLabel = new MetroFramework.Controls.MetroLabel();
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxGFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxGEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxGLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxGIdNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxGContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxGGender = new MetroFramework.Controls.MetroComboBox();
            this.addDetailsTile = new MetroFramework.Controls.MetroTile();
            this.cancelTile = new MetroFramework.Controls.MetroTile();
            this.clearTile = new MetroFramework.Controls.MetroTile();
            this.DateAdmission = new System.Windows.Forms.DateTimePicker();
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
            this.detailsGroupBox.Controls.Add(this.TextBoxEmailAddress);
            this.detailsGroupBox.Controls.Add(this.TextBoxZipCode);
            this.detailsGroupBox.Controls.Add(this.TextBoxCity);
            this.detailsGroupBox.Controls.Add(this.TextBoxSuburb);
            this.detailsGroupBox.Controls.Add(this.TextBoxAddressLine2);
            this.detailsGroupBox.Controls.Add(this.TextBoxAddressLine1);
            this.detailsGroupBox.Controls.Add(this.metroLabel5);
            this.detailsGroupBox.Controls.Add(this.metroLabel);
            this.detailsGroupBox.Controls.Add(this.metroLabel4);
            this.detailsGroupBox.Controls.Add(this.metroLabel3);
            this.detailsGroupBox.Controls.Add(this.addressLine2Label);
            this.detailsGroupBox.Controls.Add(this.addressLineLabel);
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
            this.detailsGroupBox.Size = new System.Drawing.Size(521, 481);
            this.detailsGroupBox.TabIndex = 0;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Student Details";
            // 
            // AdminDateLabel
            // 
            this.AdminDateLabel.AutoSize = true;
            this.AdminDateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AdminDateLabel.Location = new System.Drawing.Point(9, 240);
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
            // TextBoxEmailAddress
            // 
            this.TextBoxEmailAddress.Lines = new string[0];
            this.TextBoxEmailAddress.Location = new System.Drawing.Point(150, 272);
            this.TextBoxEmailAddress.MaxLength = 32767;
            this.TextBoxEmailAddress.Name = "TextBoxEmailAddress";
            this.TextBoxEmailAddress.PasswordChar = '\0';
            this.TextBoxEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxEmailAddress.SelectedText = "";
            this.TextBoxEmailAddress.Size = new System.Drawing.Size(329, 23);
            this.TextBoxEmailAddress.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxEmailAddress.TabIndex = 27;
            this.TextBoxEmailAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxEmailAddress.UseSelectable = true;
            this.TextBoxEmailAddress.UseStyleColors = true;
            // 
            // TextBoxZipCode
            // 
            this.TextBoxZipCode.Lines = new string[0];
            this.TextBoxZipCode.Location = new System.Drawing.Point(150, 437);
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
            // TextBoxCity
            // 
            this.TextBoxCity.Lines = new string[0];
            this.TextBoxCity.Location = new System.Drawing.Point(150, 408);
            this.TextBoxCity.MaxLength = 32767;
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.PasswordChar = '\0';
            this.TextBoxCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCity.SelectedText = "";
            this.TextBoxCity.Size = new System.Drawing.Size(329, 23);
            this.TextBoxCity.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxCity.TabIndex = 27;
            this.TextBoxCity.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxCity.UseSelectable = true;
            this.TextBoxCity.UseStyleColors = true;
            // 
            // TextBoxSuburb
            // 
            this.TextBoxSuburb.Lines = new string[0];
            this.TextBoxSuburb.Location = new System.Drawing.Point(150, 379);
            this.TextBoxSuburb.MaxLength = 32767;
            this.TextBoxSuburb.Name = "TextBoxSuburb";
            this.TextBoxSuburb.PasswordChar = '\0';
            this.TextBoxSuburb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSuburb.SelectedText = "";
            this.TextBoxSuburb.Size = new System.Drawing.Size(329, 23);
            this.TextBoxSuburb.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxSuburb.TabIndex = 27;
            this.TextBoxSuburb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxSuburb.UseSelectable = true;
            this.TextBoxSuburb.UseStyleColors = true;
            // 
            // TextBoxAddressLine2
            // 
            this.TextBoxAddressLine2.Lines = new string[0];
            this.TextBoxAddressLine2.Location = new System.Drawing.Point(150, 350);
            this.TextBoxAddressLine2.MaxLength = 32767;
            this.TextBoxAddressLine2.Name = "TextBoxAddressLine2";
            this.TextBoxAddressLine2.PasswordChar = '\0';
            this.TextBoxAddressLine2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAddressLine2.SelectedText = "";
            this.TextBoxAddressLine2.Size = new System.Drawing.Size(329, 23);
            this.TextBoxAddressLine2.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxAddressLine2.TabIndex = 27;
            this.TextBoxAddressLine2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxAddressLine2.UseSelectable = true;
            this.TextBoxAddressLine2.UseStyleColors = true;
            // 
            // TextBoxAddressLine1
            // 
            this.TextBoxAddressLine1.Lines = new string[0];
            this.TextBoxAddressLine1.Location = new System.Drawing.Point(150, 321);
            this.TextBoxAddressLine1.MaxLength = 32767;
            this.TextBoxAddressLine1.Name = "TextBoxAddressLine1";
            this.TextBoxAddressLine1.PasswordChar = '\0';
            this.TextBoxAddressLine1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAddressLine1.SelectedText = "";
            this.TextBoxAddressLine1.Size = new System.Drawing.Size(329, 23);
            this.TextBoxAddressLine1.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxAddressLine1.TabIndex = 27;
            this.TextBoxAddressLine1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxAddressLine1.UseSelectable = true;
            this.TextBoxAddressLine1.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(9, 274);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Email Address";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.BackColor = System.Drawing.Color.White;
            this.metroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel.Location = new System.Drawing.Point(9, 441);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(64, 19);
            this.metroLabel.TabIndex = 26;
            this.metroLabel.Text = "Zip Code";
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(9, 412);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "City";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(9, 383);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Suburb";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.BackColor = System.Drawing.Color.White;
            this.addressLine2Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.addressLine2Label.Location = new System.Drawing.Point(9, 354);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(99, 19);
            this.addressLine2Label.TabIndex = 26;
            this.addressLine2Label.Text = "Address Line 2";
            this.addressLine2Label.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // addressLineLabel
            // 
            this.addressLineLabel.AutoSize = true;
            this.addressLineLabel.BackColor = System.Drawing.Color.White;
            this.addressLineLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.addressLineLabel.Location = new System.Drawing.Point(9, 325);
            this.addressLineLabel.Name = "addressLineLabel";
            this.addressLineLabel.Size = new System.Drawing.Size(99, 19);
            this.addressLineLabel.TabIndex = 26;
            this.addressLineLabel.Text = "Address Line 1";
            this.addressLineLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxAdminNumber
            // 
            this.TextBoxAdminNumber.Lines = new string[0];
            this.TextBoxAdminNumber.Location = new System.Drawing.Point(150, 172);
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
            this.TextBoxContactNumber.Location = new System.Drawing.Point(150, 108);
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
            this.TextBoxIDNumber.Location = new System.Drawing.Point(150, 79);
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
            this.TextBoxLastName.Location = new System.Drawing.Point(150, 50);
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
            this.ComboBoxCentre.Location = new System.Drawing.Point(150, 201);
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
            this.metroLabel2.Location = new System.Drawing.Point(9, 211);
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
            this.metroLabel1.Location = new System.Drawing.Point(9, 176);
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
            this.ComboBoxGender.Location = new System.Drawing.Point(150, 137);
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
            this.genderLabel.Location = new System.Drawing.Point(9, 147);
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
            this.contactNumberLabel.Location = new System.Drawing.Point(9, 112);
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
            this.idNumberLabel.Location = new System.Drawing.Point(6, 83);
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
            this.lastNameLabel.Location = new System.Drawing.Point(6, 54);
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
            this.guardianGroupBox.Controls.Add(this.metroLabel6);
            this.guardianGroupBox.Controls.Add(this.TextBoxGFirstName);
            this.guardianGroupBox.Controls.Add(this.metroLabel12);
            this.guardianGroupBox.Controls.Add(this.TextBoxGEmailAddress);
            this.guardianGroupBox.Controls.Add(this.metroLabel8);
            this.guardianGroupBox.Controls.Add(this.TextBoxGLastName);
            this.guardianGroupBox.Controls.Add(this.metroLabel11);
            this.guardianGroupBox.Controls.Add(this.metroLabel9);
            this.guardianGroupBox.Controls.Add(this.TextBoxGIdNumber);
            this.guardianGroupBox.Controls.Add(this.metroLabel10);
            this.guardianGroupBox.Controls.Add(this.metroLabel14);
            this.guardianGroupBox.Controls.Add(this.TextBoxGContactNumber);
            this.guardianGroupBox.Controls.Add(this.metroLabel13);
            this.guardianGroupBox.Controls.Add(this.ComboBoxGGender);
            this.guardianGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianGroupBox.Location = new System.Drawing.Point(550, 84);
            this.guardianGroupBox.Name = "guardianGroupBox";
            this.guardianGroupBox.Size = new System.Drawing.Size(521, 402);
            this.guardianGroupBox.TabIndex = 1;
            this.guardianGroupBox.TabStop = false;
            this.guardianGroupBox.Text = "Parent or Guardian Details";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(6, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "First Name:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxGFirstName
            // 
            this.TextBoxGFirstName.Lines = new string[0];
            this.TextBoxGFirstName.Location = new System.Drawing.Point(164, 21);
            this.TextBoxGFirstName.MaxLength = 32767;
            this.TextBoxGFirstName.Name = "TextBoxGFirstName";
            this.TextBoxGFirstName.PasswordChar = '\0';
            this.TextBoxGFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxGFirstName.SelectedText = "";
            this.TextBoxGFirstName.Size = new System.Drawing.Size(329, 23);
            this.TextBoxGFirstName.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxGFirstName.TabIndex = 21;
            this.TextBoxGFirstName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxGFirstName.UseSelectable = true;
            this.TextBoxGFirstName.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.White;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(6, 54);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(77, 19);
            this.metroLabel12.TabIndex = 8;
            this.metroLabel12.Text = "Last Name:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxGEmailAddress
            // 
            this.TextBoxGEmailAddress.Lines = new string[0];
            this.TextBoxGEmailAddress.Location = new System.Drawing.Point(164, 172);
            this.TextBoxGEmailAddress.MaxLength = 32767;
            this.TextBoxGEmailAddress.Name = "TextBoxGEmailAddress";
            this.TextBoxGEmailAddress.PasswordChar = '\0';
            this.TextBoxGEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxGEmailAddress.SelectedText = "";
            this.TextBoxGEmailAddress.Size = new System.Drawing.Size(329, 23);
            this.TextBoxGEmailAddress.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxGEmailAddress.TabIndex = 27;
            this.TextBoxGEmailAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxGEmailAddress.UseSelectable = true;
            this.TextBoxGEmailAddress.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.White;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(12, 54);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Last Name:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxGLastName
            // 
            this.TextBoxGLastName.Lines = new string[0];
            this.TextBoxGLastName.Location = new System.Drawing.Point(164, 50);
            this.TextBoxGLastName.MaxLength = 32767;
            this.TextBoxGLastName.Name = "TextBoxGLastName";
            this.TextBoxGLastName.PasswordChar = '\0';
            this.TextBoxGLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxGLastName.SelectedText = "";
            this.TextBoxGLastName.Size = new System.Drawing.Size(329, 23);
            this.TextBoxGLastName.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxGLastName.TabIndex = 22;
            this.TextBoxGLastName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxGLastName.UseSelectable = true;
            this.TextBoxGLastName.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.White;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(6, 83);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(80, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "ID Number:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.White;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(12, 83);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "ID Number:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxGIdNumber
            // 
            this.TextBoxGIdNumber.Lines = new string[0];
            this.TextBoxGIdNumber.Location = new System.Drawing.Point(164, 79);
            this.TextBoxGIdNumber.MaxLength = 32767;
            this.TextBoxGIdNumber.Name = "TextBoxGIdNumber";
            this.TextBoxGIdNumber.PasswordChar = '\0';
            this.TextBoxGIdNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxGIdNumber.SelectedText = "";
            this.TextBoxGIdNumber.Size = new System.Drawing.Size(329, 23);
            this.TextBoxGIdNumber.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxGIdNumber.TabIndex = 23;
            this.TextBoxGIdNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxGIdNumber.UseSelectable = true;
            this.TextBoxGIdNumber.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.White;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(6, 112);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(114, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Contact Number:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.White;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(6, 176);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(94, 19);
            this.metroLabel14.TabIndex = 26;
            this.metroLabel14.Text = "Email Address";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextBoxGContactNumber
            // 
            this.TextBoxGContactNumber.Lines = new string[0];
            this.TextBoxGContactNumber.Location = new System.Drawing.Point(164, 108);
            this.TextBoxGContactNumber.MaxLength = 32767;
            this.TextBoxGContactNumber.Name = "TextBoxGContactNumber";
            this.TextBoxGContactNumber.PasswordChar = '\0';
            this.TextBoxGContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxGContactNumber.SelectedText = "";
            this.TextBoxGContactNumber.Size = new System.Drawing.Size(329, 23);
            this.TextBoxGContactNumber.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxGContactNumber.TabIndex = 24;
            this.TextBoxGContactNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxGContactNumber.UseSelectable = true;
            this.TextBoxGContactNumber.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.White;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(6, 147);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(57, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "Gender:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ComboBoxGGender
            // 
            this.ComboBoxGGender.DisplayFocus = true;
            this.ComboBoxGGender.FormattingEnabled = true;
            this.ComboBoxGGender.ItemHeight = 23;
            this.ComboBoxGGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboBoxGGender.Location = new System.Drawing.Point(164, 137);
            this.ComboBoxGGender.Name = "ComboBoxGGender";
            this.ComboBoxGGender.Size = new System.Drawing.Size(132, 29);
            this.ComboBoxGGender.Style = MetroFramework.MetroColorStyle.Green;
            this.ComboBoxGGender.TabIndex = 15;
            this.ComboBoxGGender.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComboBoxGGender.UseSelectable = true;
            this.ComboBoxGGender.UseStyleColors = true;
            // 
            // addDetailsTile
            // 
            this.addDetailsTile.ActiveControl = null;
            this.addDetailsTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addDetailsTile.Location = new System.Drawing.Point(550, 533);
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
            // 
            // cancelTile
            // 
            this.cancelTile.ActiveControl = null;
            this.cancelTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelTile.Location = new System.Drawing.Point(912, 533);
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
            this.clearTile.Location = new System.Drawing.Point(729, 533);
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
            // DateAdmission
            // 
            this.DateAdmission.Location = new System.Drawing.Point(150, 237);
            this.DateAdmission.Name = "DateAdmission";
            this.DateAdmission.Size = new System.Drawing.Size(163, 21);
            this.DateAdmission.TabIndex = 30;
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
        private MetroFramework.Controls.MetroTextBox TextBoxAddressLine1;
        private MetroFramework.Controls.MetroLabel addressLineLabel;
        private MetroFramework.Controls.MetroTextBox TextBoxSuburb;
        private MetroFramework.Controls.MetroTextBox TextBoxAddressLine2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel addressLine2Label;
        private MetroFramework.Controls.MetroTextBox TextBoxCity;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TextBoxEmailAddress;
        private MetroFramework.Controls.MetroTextBox TextBoxZipCode;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroLabel AdminDateLabel;
        private MetroFramework.Controls.MetroTile addDetailsTile;
        private MetroFramework.Controls.MetroTile cancelTile;
        private GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TextBoxGFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox TextBoxGEmailAddress;
        private MetroFramework.Controls.MetroTextBox TextBoxGLastName;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox TextBoxGIdNumber;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox TextBoxGContactNumber;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox ComboBoxGGender;
        private MetroFramework.Controls.MetroTile clearTile;
        private DateTimePicker DateAdmission;
    
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