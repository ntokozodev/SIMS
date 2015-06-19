namespace SIMS.EmployeeModule
{
    partial class AddStaffMember
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroComboBoxGrade = new MetroFramework.Controls.MetroComboBox();
            this.gRADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.metroDateTimeAddStaff = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBoxJob = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxContact = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCitizenID = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxEAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxZipCode = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSuburb = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAddressLine2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAddressLine1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroTileClear = new MetroFramework.Controls.MetroTile();
            this.metroTileAdd = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.metroComboBoxGender);
            this.groupBox1.Controls.Add(this.metroComboBoxGrade);
            this.groupBox1.Controls.Add(this.metroTextBoxJob);
            this.groupBox1.Controls.Add(this.metroTextBoxContact);
            this.groupBox1.Controls.Add(this.metroTextBoxCitizenID);
            this.groupBox1.Controls.Add(this.metroTextBoxLastName);
            this.groupBox1.Controls.Add(this.metroTextBoxFirstName);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // metroComboBoxGrade
            // 
            this.metroComboBoxGrade.DataSource = this.gRADEBindingSource;
            this.metroComboBoxGrade.DisplayMember = "GRADE_NAME";
            this.metroComboBoxGrade.FormattingEnabled = true;
            this.metroComboBoxGrade.ItemHeight = 23;
            this.metroComboBoxGrade.Location = new System.Drawing.Point(154, 347);
            this.metroComboBoxGrade.Name = "metroComboBoxGrade";
            this.metroComboBoxGrade.Size = new System.Drawing.Size(129, 29);
            this.metroComboBoxGrade.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxGrade.TabIndex = 13;
            this.metroComboBoxGrade.UseSelectable = true;
            this.metroComboBoxGrade.UseStyleColors = true;
            // 
            // gRADEBindingSource
            // 
            this.gRADEBindingSource.DataMember = "GRADE";
            this.gRADEBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroDateTimeAddStaff
            // 
            this.metroDateTimeAddStaff.Location = new System.Drawing.Point(144, 347);
            this.metroDateTimeAddStaff.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeAddStaff.Name = "metroDateTimeAddStaff";
            this.metroDateTimeAddStaff.Size = new System.Drawing.Size(129, 29);
            this.metroDateTimeAddStaff.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTimeAddStaff.TabIndex = 12;
            this.metroDateTimeAddStaff.UseStyleColors = true;
            // 
            // metroTextBoxJob
            // 
            this.metroTextBoxJob.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxJob.Lines = new string[0];
            this.metroTextBoxJob.Location = new System.Drawing.Point(154, 234);
            this.metroTextBoxJob.MaxLength = 32767;
            this.metroTextBoxJob.Name = "metroTextBoxJob";
            this.metroTextBoxJob.PasswordChar = '\0';
            this.metroTextBoxJob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxJob.SelectedText = "";
            this.metroTextBoxJob.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxJob.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxJob.TabIndex = 11;
            this.metroTextBoxJob.UseSelectable = true;
            this.metroTextBoxJob.UseStyleColors = true;
            // 
            // metroTextBoxContact
            // 
            this.metroTextBoxContact.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxContact.Lines = new string[0];
            this.metroTextBoxContact.Location = new System.Drawing.Point(154, 178);
            this.metroTextBoxContact.MaxLength = 32767;
            this.metroTextBoxContact.Name = "metroTextBoxContact";
            this.metroTextBoxContact.PasswordChar = '\0';
            this.metroTextBoxContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxContact.SelectedText = "";
            this.metroTextBoxContact.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxContact.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxContact.TabIndex = 10;
            this.metroTextBoxContact.UseSelectable = true;
            this.metroTextBoxContact.UseStyleColors = true;
            // 
            // metroTextBoxCitizenID
            // 
            this.metroTextBoxCitizenID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCitizenID.Lines = new string[0];
            this.metroTextBoxCitizenID.Location = new System.Drawing.Point(154, 122);
            this.metroTextBoxCitizenID.MaxLength = 32767;
            this.metroTextBoxCitizenID.Name = "metroTextBoxCitizenID";
            this.metroTextBoxCitizenID.PasswordChar = '\0';
            this.metroTextBoxCitizenID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCitizenID.SelectedText = "";
            this.metroTextBoxCitizenID.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxCitizenID.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxCitizenID.TabIndex = 9;
            this.metroTextBoxCitizenID.UseSelectable = true;
            this.metroTextBoxCitizenID.UseStyleColors = true;
            // 
            // metroTextBoxLastName
            // 
            this.metroTextBoxLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxLastName.Lines = new string[0];
            this.metroTextBoxLastName.Location = new System.Drawing.Point(154, 67);
            this.metroTextBoxLastName.MaxLength = 32767;
            this.metroTextBoxLastName.Name = "metroTextBoxLastName";
            this.metroTextBoxLastName.PasswordChar = '\0';
            this.metroTextBoxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLastName.SelectedText = "";
            this.metroTextBoxLastName.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxLastName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxLastName.TabIndex = 8;
            this.metroTextBoxLastName.UseSelectable = true;
            this.metroTextBoxLastName.UseStyleColors = true;
            // 
            // metroTextBoxFirstName
            // 
            this.metroTextBoxFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFirstName.Lines = new string[0];
            this.metroTextBoxFirstName.Location = new System.Drawing.Point(154, 12);
            this.metroTextBoxFirstName.MaxLength = 32767;
            this.metroTextBoxFirstName.Name = "metroTextBoxFirstName";
            this.metroTextBoxFirstName.PasswordChar = '\0';
            this.metroTextBoxFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFirstName.SelectedText = "";
            this.metroTextBoxFirstName.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxFirstName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxFirstName.TabIndex = 7;
            this.metroTextBoxFirstName.UseSelectable = true;
            this.metroTextBoxFirstName.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(77, 357);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(54, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Grade:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(37, 357);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Hire Date:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(94, 238);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Job:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(7, 182);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Contact Number:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(55, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Citizen ID:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(52, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Last Name";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(46, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "First Name:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.metroTextBoxEAddress);
            this.groupBox2.Controls.Add(this.metroDateTimeAddStaff);
            this.groupBox2.Controls.Add(this.metroTextBoxZipCode);
            this.groupBox2.Controls.Add(this.metroTextBoxCity);
            this.groupBox2.Controls.Add(this.metroTextBoxSuburb);
            this.groupBox2.Controls.Add(this.metroTextBoxAddressLine2);
            this.groupBox2.Controls.Add(this.metroTextBoxAddressLine1);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Location = new System.Drawing.Point(487, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // metroTextBoxEAddress
            // 
            this.metroTextBoxEAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxEAddress.Lines = new string[0];
            this.metroTextBoxEAddress.Location = new System.Drawing.Point(144, 294);
            this.metroTextBoxEAddress.MaxLength = 32767;
            this.metroTextBoxEAddress.Name = "metroTextBoxEAddress";
            this.metroTextBoxEAddress.PasswordChar = '\0';
            this.metroTextBoxEAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEAddress.SelectedText = "";
            this.metroTextBoxEAddress.Size = new System.Drawing.Size(255, 23);
            this.metroTextBoxEAddress.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxEAddress.TabIndex = 11;
            this.metroTextBoxEAddress.UseSelectable = true;
            this.metroTextBoxEAddress.UseStyleColors = true;
            // 
            // metroTextBoxZipCode
            // 
            this.metroTextBoxZipCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxZipCode.Lines = new string[0];
            this.metroTextBoxZipCode.Location = new System.Drawing.Point(144, 233);
            this.metroTextBoxZipCode.MaxLength = 32767;
            this.metroTextBoxZipCode.Name = "metroTextBoxZipCode";
            this.metroTextBoxZipCode.PasswordChar = '\0';
            this.metroTextBoxZipCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxZipCode.SelectedText = "";
            this.metroTextBoxZipCode.Size = new System.Drawing.Size(255, 23);
            this.metroTextBoxZipCode.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxZipCode.TabIndex = 10;
            this.metroTextBoxZipCode.UseSelectable = true;
            this.metroTextBoxZipCode.UseStyleColors = true;
            // 
            // metroTextBoxCity
            // 
            this.metroTextBoxCity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCity.Lines = new string[0];
            this.metroTextBoxCity.Location = new System.Drawing.Point(144, 177);
            this.metroTextBoxCity.MaxLength = 32767;
            this.metroTextBoxCity.Name = "metroTextBoxCity";
            this.metroTextBoxCity.PasswordChar = '\0';
            this.metroTextBoxCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCity.SelectedText = "";
            this.metroTextBoxCity.Size = new System.Drawing.Size(255, 23);
            this.metroTextBoxCity.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxCity.TabIndex = 9;
            this.metroTextBoxCity.UseSelectable = true;
            this.metroTextBoxCity.UseStyleColors = true;
            // 
            // metroTextBoxSuburb
            // 
            this.metroTextBoxSuburb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxSuburb.Lines = new string[0];
            this.metroTextBoxSuburb.Location = new System.Drawing.Point(144, 121);
            this.metroTextBoxSuburb.MaxLength = 32767;
            this.metroTextBoxSuburb.Name = "metroTextBoxSuburb";
            this.metroTextBoxSuburb.PasswordChar = '\0';
            this.metroTextBoxSuburb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSuburb.SelectedText = "";
            this.metroTextBoxSuburb.Size = new System.Drawing.Size(255, 23);
            this.metroTextBoxSuburb.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxSuburb.TabIndex = 8;
            this.metroTextBoxSuburb.UseSelectable = true;
            this.metroTextBoxSuburb.UseStyleColors = true;
            // 
            // metroTextBoxAddressLine2
            // 
            this.metroTextBoxAddressLine2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAddressLine2.Lines = new string[0];
            this.metroTextBoxAddressLine2.Location = new System.Drawing.Point(144, 66);
            this.metroTextBoxAddressLine2.MaxLength = 32767;
            this.metroTextBoxAddressLine2.Name = "metroTextBoxAddressLine2";
            this.metroTextBoxAddressLine2.PasswordChar = '\0';
            this.metroTextBoxAddressLine2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAddressLine2.SelectedText = "";
            this.metroTextBoxAddressLine2.Size = new System.Drawing.Size(255, 23);
            this.metroTextBoxAddressLine2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxAddressLine2.TabIndex = 7;
            this.metroTextBoxAddressLine2.UseSelectable = true;
            this.metroTextBoxAddressLine2.UseStyleColors = true;
            // 
            // metroTextBoxAddressLine1
            // 
            this.metroTextBoxAddressLine1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAddressLine1.Lines = new string[0];
            this.metroTextBoxAddressLine1.Location = new System.Drawing.Point(144, 11);
            this.metroTextBoxAddressLine1.MaxLength = 32767;
            this.metroTextBoxAddressLine1.Name = "metroTextBoxAddressLine1";
            this.metroTextBoxAddressLine1.PasswordChar = '\0';
            this.metroTextBoxAddressLine1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAddressLine1.SelectedText = "";
            this.metroTextBoxAddressLine1.Size = new System.Drawing.Size(255, 23);
            this.metroTextBoxAddressLine1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxAddressLine1.TabIndex = 6;
            this.metroTextBoxAddressLine1.UseSelectable = true;
            this.metroTextBoxAddressLine1.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(7, 298);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(107, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Email Address:";
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(21, 238);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(93, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "Postal Code:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(75, 182);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "City:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(53, 126);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(61, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Suburb:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(4, 71);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(110, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Address Line 2:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(6, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Address Line 1:";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(825, 509);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(107, 23);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 2;
            this.metroTileClose.Text = "Close Window";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // metroTileClear
            // 
            this.metroTileClear.ActiveControl = null;
            this.metroTileClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClear.Location = new System.Drawing.Point(713, 509);
            this.metroTileClear.Name = "metroTileClear";
            this.metroTileClear.Size = new System.Drawing.Size(106, 23);
            this.metroTileClear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClear.TabIndex = 3;
            this.metroTileClear.Text = "Clear";
            this.metroTileClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClear.UseSelectable = true;
            this.metroTileClear.UseStyleColors = true;
            this.metroTileClear.Click += new System.EventHandler(this.metroTileClear_Click);
            // 
            // metroTileAdd
            // 
            this.metroTileAdd.ActiveControl = null;
            this.metroTileAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileAdd.Location = new System.Drawing.Point(601, 509);
            this.metroTileAdd.Name = "metroTileAdd";
            this.metroTileAdd.Size = new System.Drawing.Size(106, 23);
            this.metroTileAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAdd.TabIndex = 4;
            this.metroTileAdd.Text = "Enter";
            this.metroTileAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAdd.UseSelectable = true;
            this.metroTileAdd.UseStyleColors = true;
            this.metroTileAdd.Click += new System.EventHandler(this.metroTileAdd_Click);
            // 
            // metroComboBoxGender
            // 
            this.metroComboBoxGender.FormattingEnabled = true;
            this.metroComboBoxGender.ItemHeight = 23;
            this.metroComboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.metroComboBoxGender.Location = new System.Drawing.Point(154, 288);
            this.metroComboBoxGender.Name = "metroComboBoxGender";
            this.metroComboBoxGender.Size = new System.Drawing.Size(129, 29);
            this.metroComboBoxGender.TabIndex = 14;
            this.metroComboBoxGender.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(77, 298);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(63, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "Gender:";
            this.metroLabel14.UseStyleColors = true;
            // 
            // AddStaffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 572);
            this.Controls.Add(this.metroTileAdd);
            this.Controls.Add(this.metroTileClear);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStaffMember";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Register New Staff Member";
            this.Load += new System.EventHandler(this.AddStaffMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroTile metroTileClear;
        private MetroFramework.Controls.MetroTile metroTileAdd;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGrade;
        private MetroFramework.Controls.MetroDateTime metroDateTimeAddStaff;
        private MetroFramework.Controls.MetroTextBox metroTextBoxJob;
        private MetroFramework.Controls.MetroTextBox metroTextBoxContact;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCitizenID;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLastName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFirstName;
        private DS dS;
        private System.Windows.Forms.BindingSource gRADEBindingSource;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEAddress;
        private MetroFramework.Controls.MetroTextBox metroTextBoxZipCode;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSuburb;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddressLine2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddressLine1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGender;
    }
}