namespace SIMS.LearnerModule
{
    partial class StudentProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfile));
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelSuburb = new MetroFramework.Controls.MetroLabel();
            this.student_profileBS = new System.Windows.Forms.BindingSource(this.components);
            this.student_profileDS = new SIMS.DS();
            this.LabelID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.LabelFullName = new MetroFramework.Controls.MetroLabel();
            this.LabelCity = new MetroFramework.Controls.MetroLabel();
            this.LabelAddress = new MetroFramework.Controls.MetroLabel();
            this.LabelZipCode = new MetroFramework.Controls.MetroLabel();
            this.groupBoxSubjects = new System.Windows.Forms.GroupBox();
            this.subjectDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_registeredBS = new System.Windows.Forms.BindingSource(this.components);
            this.LabelDue = new MetroFramework.Controls.MetroLabel();
            this.LabelTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.LabelCentre = new MetroFramework.Controls.MetroLabel();
            this.LabelGender = new MetroFramework.Controls.MetroLabel();
            this.LabelAdmissionNo = new MetroFramework.Controls.MetroLabel();
            this.LabelAdmission = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LabelSurname = new MetroFramework.Controls.MetroLabel();
            this.LabelName = new MetroFramework.Controls.MetroLabel();
            this.student_profileBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.student_profileTA = new SIMS.DSTableAdapters.STUDENT_PROFILETableAdapter();
            this.student_enrollmentBS = new System.Windows.Forms.BindingSource(this.components);
            this.student_enrollmentTA = new SIMS.DSTableAdapters.STUDENT_ENROLLMENTTableAdapter();
            this.subject_registeredTA = new SIMS.DSTableAdapters.SUBJECT_REGISTEREDTableAdapter();
            this.printDialogStudentProfile = new System.Windows.Forms.PrintDialog();
            this.printDocumentStudentProfile = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogProfile = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_profileBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_profileDS)).BeginInit();
            this.groupBoxSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subject_registeredBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_profileBN)).BeginInit();
            this.student_profileBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_enrollmentBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxProfile.Controls.Add(this.pictureBox2);
            this.groupBoxProfile.Controls.Add(this.LabelSuburb);
            this.groupBoxProfile.Controls.Add(this.LabelID);
            this.groupBoxProfile.Controls.Add(this.metroLabel5);
            this.groupBoxProfile.Controls.Add(this.LabelFullName);
            this.groupBoxProfile.Controls.Add(this.LabelCity);
            this.groupBoxProfile.Controls.Add(this.LabelAddress);
            this.groupBoxProfile.Controls.Add(this.LabelZipCode);
            this.groupBoxProfile.Controls.Add(this.groupBoxSubjects);
            this.groupBoxProfile.Controls.Add(this.LabelDue);
            this.groupBoxProfile.Controls.Add(this.LabelTotal);
            this.groupBoxProfile.Controls.Add(this.metroLabel4);
            this.groupBoxProfile.Controls.Add(this.LabelCentre);
            this.groupBoxProfile.Controls.Add(this.LabelGender);
            this.groupBoxProfile.Controls.Add(this.LabelAdmissionNo);
            this.groupBoxProfile.Controls.Add(this.LabelAdmission);
            this.groupBoxProfile.Controls.Add(this.metroLabel2);
            this.groupBoxProfile.Controls.Add(this.metroLabel3);
            this.groupBoxProfile.Controls.Add(this.metroLabel1);
            this.groupBoxProfile.Controls.Add(this.LabelSurname);
            this.groupBoxProfile.Controls.Add(this.LabelName);
            this.groupBoxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfile.Location = new System.Drawing.Point(203, 38);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(614, 617);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Student Profile";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIMS.Properties.Resources.Isibani_Pro_Tutor1;
            this.pictureBox2.Location = new System.Drawing.Point(18, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 193);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // LabelSuburb
            // 
            this.LabelSuburb.AutoSize = true;
            this.LabelSuburb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "SUBURB", true));
            this.LabelSuburb.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelSuburb.Location = new System.Drawing.Point(349, 276);
            this.LabelSuburb.Name = "LabelSuburb";
            this.LabelSuburb.Size = new System.Drawing.Size(52, 19);
            this.LabelSuburb.TabIndex = 33;
            this.LabelSuburb.Text = "suburb";
            // 
            // student_profileBS
            // 
            this.student_profileBS.DataMember = "STUDENT_PROFILE";
            this.student_profileBS.DataSource = this.student_profileDS;
            // 
            // student_profileDS
            // 
            this.student_profileDS.DataSetName = "DS";
            this.student_profileDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "CITIZEN_ID", true));
            this.LabelID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelID.Location = new System.Drawing.Point(111, 273);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(43, 19);
            this.LabelID.TabIndex = 32;
            this.LabelID.Text = "id no.";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(18, 273);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "ID Number:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelFullName.Location = new System.Drawing.Point(349, 238);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(61, 19);
            this.LabelFullName.TabIndex = 30;
            this.LabelFullName.Text = "fullname";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "CITY", true));
            this.LabelCity.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelCity.Location = new System.Drawing.Point(349, 292);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(30, 19);
            this.LabelCity.TabIndex = 29;
            this.LabelCity.Text = "city";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "ADDRESS", true));
            this.LabelAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelAddress.Location = new System.Drawing.Point(349, 257);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(56, 19);
            this.LabelAddress.TabIndex = 28;
            this.LabelAddress.Text = "address";
            // 
            // LabelZipCode
            // 
            this.LabelZipCode.AutoSize = true;
            this.LabelZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "ZIPCODE", true));
            this.LabelZipCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelZipCode.Location = new System.Drawing.Point(349, 311);
            this.LabelZipCode.Name = "LabelZipCode";
            this.LabelZipCode.Size = new System.Drawing.Size(55, 19);
            this.LabelZipCode.TabIndex = 27;
            this.LabelZipCode.Text = "zipcode";
            // 
            // groupBoxSubjects
            // 
            this.groupBoxSubjects.Controls.Add(this.subjectDGV);
            this.groupBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSubjects.Location = new System.Drawing.Point(18, 344);
            this.groupBoxSubjects.Name = "groupBoxSubjects";
            this.groupBoxSubjects.Size = new System.Drawing.Size(541, 218);
            this.groupBoxSubjects.TabIndex = 25;
            this.groupBoxSubjects.TabStop = false;
            this.groupBoxSubjects.Text = "Registered Subjects";
            // 
            // subjectDGV
            // 
            this.subjectDGV.AllowUserToAddRows = false;
            this.subjectDGV.AllowUserToDeleteRows = false;
            this.subjectDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectDGV.AutoGenerateColumns = false;
            this.subjectDGV.BackgroundColor = System.Drawing.Color.White;
            this.subjectDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.subjectDGV.DataSource = this.subject_registeredBS;
            this.subjectDGV.Location = new System.Drawing.Point(34, 44);
            this.subjectDGV.MultiSelect = false;
            this.subjectDGV.Name = "subjectDGV";
            this.subjectDGV.ReadOnly = true;
            this.subjectDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subjectDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subjectDGV.Size = new System.Drawing.Size(468, 134);
            this.subjectDGV.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SUBJECT_CODE";
            this.dataGridViewTextBoxColumn1.HeaderText = "SUBJECT CODE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SUBJECT_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "SUBJECT NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACADEMIC_YEAR";
            this.dataGridViewTextBoxColumn3.HeaderText = "ACADEMIC YEAR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // subject_registeredBS
            // 
            this.subject_registeredBS.DataMember = "SUBJECT_REGISTERED";
            this.subject_registeredBS.DataSource = this.student_profileDS;
            // 
            // LabelDue
            // 
            this.LabelDue.AutoSize = true;
            this.LabelDue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "BALANCE", true));
            this.LabelDue.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelDue.Location = new System.Drawing.Point(330, 565);
            this.LabelDue.Name = "LabelDue";
            this.LabelDue.Size = new System.Drawing.Size(17, 19);
            this.LabelDue.TabIndex = 24;
            this.LabelDue.Text = "0";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "AMOUNT", true));
            this.LabelTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelTotal.Location = new System.Drawing.Point(112, 565);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(17, 19);
            this.LabelTotal.TabIndex = 23;
            this.LabelTotal.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(247, 565);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Due to Us:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // LabelCentre
            // 
            this.LabelCentre.AutoSize = true;
            this.LabelCentre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "CENTRE", true));
            this.LabelCentre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelCentre.Location = new System.Drawing.Point(81, 311);
            this.LabelCentre.Name = "LabelCentre";
            this.LabelCentre.Size = new System.Drawing.Size(47, 19);
            this.LabelCentre.TabIndex = 21;
            this.LabelCentre.Text = "centre";
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "GENDER", true));
            this.LabelGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelGender.Location = new System.Drawing.Point(87, 292);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(52, 19);
            this.LabelGender.TabIndex = 19;
            this.LabelGender.Text = "gender";
            // 
            // LabelAdmissionNo
            // 
            this.LabelAdmissionNo.AutoSize = true;
            this.LabelAdmissionNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "ADMISSION_NO", true));
            this.LabelAdmissionNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelAdmissionNo.Location = new System.Drawing.Point(134, 254);
            this.LabelAdmissionNo.Name = "LabelAdmissionNo";
            this.LabelAdmissionNo.Size = new System.Drawing.Size(54, 19);
            this.LabelAdmissionNo.TabIndex = 16;
            this.LabelAdmissionNo.Text = "admNo";
            // 
            // LabelAdmission
            // 
            this.LabelAdmission.AutoSize = true;
            this.LabelAdmission.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelAdmission.Location = new System.Drawing.Point(18, 254);
            this.LabelAdmission.Name = "LabelAdmission";
            this.LabelAdmission.Size = new System.Drawing.Size(110, 19);
            this.LabelAdmission.Style = MetroFramework.MetroColorStyle.Black;
            this.LabelAdmission.TabIndex = 0;
            this.LabelAdmission.Text = "Admission No.:";
            this.LabelAdmission.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(18, 311);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Centre:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(27, 565);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Total Cost:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(18, 292);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Gender:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // LabelSurname
            // 
            this.LabelSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "SURNAME", true));
            this.LabelSurname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelSurname.Location = new System.Drawing.Point(314, 441);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(17, 19);
            this.LabelSurname.TabIndex = 33;
            this.LabelSurname.Text = "n";
            // 
            // LabelName
            // 
            this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelName.AutoSize = true;
            this.LabelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_profileBS, "NAME", true));
            this.LabelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelName.Location = new System.Drawing.Point(187, 441);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(15, 19);
            this.LabelName.TabIndex = 31;
            this.LabelName.Text = "s";
            // 
            // student_profileBN
            // 
            this.student_profileBN.AddNewItem = null;
            this.student_profileBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.student_profileBN.BindingSource = this.student_profileBS;
            this.student_profileBN.CountItem = this.bindingNavigatorCountItem;
            this.student_profileBN.DeleteItem = null;
            this.student_profileBN.Dock = System.Windows.Forms.DockStyle.None;
            this.student_profileBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.printToolStripButton,
            this.toolStripSeparator});
            this.student_profileBN.Location = new System.Drawing.Point(385, 10);
            this.student_profileBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.student_profileBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.student_profileBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.student_profileBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.student_profileBN.Name = "student_profileBN";
            this.student_profileBN.PositionItem = this.bindingNavigatorPositionItem;
            this.student_profileBN.Size = new System.Drawing.Size(238, 25);
            this.student_profileBN.TabIndex = 1;
            this.student_profileBN.Text = "stuproBN";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // student_profileTA
            // 
            this.student_profileTA.ClearBeforeFill = true;
            // 
            // student_enrollmentBS
            // 
            this.student_enrollmentBS.DataMember = "STUDENT_ENROLLMENT";
            this.student_enrollmentBS.DataSource = this.student_profileDS;
            // 
            // student_enrollmentTA
            // 
            this.student_enrollmentTA.ClearBeforeFill = true;
            // 
            // subject_registeredTA
            // 
            this.subject_registeredTA.ClearBeforeFill = true;
            // 
            // printDialogStudentProfile
            // 
            this.printDialogStudentProfile.UseEXDialog = true;
            // 
            // printPreviewDialogProfile
            // 
            this.printPreviewDialogProfile.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProfile.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProfile.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogProfile.Enabled = true;
            this.printPreviewDialogProfile.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogProfile.Icon")));
            this.printPreviewDialogProfile.Name = "printPreviewDialogProfile";
            this.printPreviewDialogProfile.Visible = false;
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 666);
            this.Controls.Add(this.student_profileBN);
            this.Controls.Add(this.groupBoxProfile);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentProfile";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_profileBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_profileDS)).EndInit();
            this.groupBoxSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subject_registeredBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_profileBN)).EndInit();
            this.student_profileBN.ResumeLayout(false);
            this.student_profileBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_enrollmentBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfile;
        private MetroFramework.Controls.MetroLabel LabelAdmission;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel LabelAdmissionNo;
        private MetroFramework.Controls.MetroLabel LabelGender;
        private MetroFramework.Controls.MetroLabel LabelCentre;
        private MetroFramework.Controls.MetroLabel LabelDue;
        private MetroFramework.Controls.MetroLabel LabelTotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBoxSubjects;
        private System.Windows.Forms.BindingNavigator student_profileBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private MetroFramework.Controls.MetroLabel LabelCity;
        private MetroFramework.Controls.MetroLabel LabelAddress;
        private MetroFramework.Controls.MetroLabel LabelZipCode;
        private MetroFramework.Controls.MetroLabel LabelID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel LabelFullName;
        private DS student_profileDS;
        private System.Windows.Forms.BindingSource student_profileBS;
        private DSTableAdapters.STUDENT_PROFILETableAdapter student_profileTA;
        private MetroFramework.Controls.MetroLabel LabelSuburb;
        private MetroFramework.Controls.MetroLabel LabelSurname;
        private MetroFramework.Controls.MetroLabel LabelName;
        private System.Windows.Forms.BindingSource student_enrollmentBS;
        private DSTableAdapters.STUDENT_ENROLLMENTTableAdapter student_enrollmentTA;
        private System.Windows.Forms.DataGridView subjectDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource subject_registeredBS;
        private DSTableAdapters.SUBJECT_REGISTEREDTableAdapter subject_registeredTA;
        private System.Windows.Forms.PrintDialog printDialogStudentProfile;
        private System.Drawing.Printing.PrintDocument printDocumentStudentProfile;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProfile;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}