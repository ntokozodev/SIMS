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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSubjects = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sUBJECTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCADEMICYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_profileBS = new System.Windows.Forms.BindingSource(this.components);
            this.profileDS = new SIMS.DS();
            this.LabelDue = new MetroFramework.Controls.MetroLabel();
            this.LabelTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.LabelCentre = new MetroFramework.Controls.MetroLabel();
            this.LabelGender = new MetroFramework.Controls.MetroLabel();
            this.LabelSurname = new MetroFramework.Controls.MetroLabel();
            this.LabelName = new MetroFramework.Controls.MetroLabel();
            this.LabelAdmissionNo = new MetroFramework.Controls.MetroLabel();
            this.LabelAdmission = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName0 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabelSurname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.stu_feeBS = new System.Windows.Forms.BindingSource(this.components);
            this.centreBS = new System.Windows.Forms.BindingSource(this.components);
            this.studentBS = new System.Windows.Forms.BindingSource(this.components);
            this.stu_enrolBS = new System.Windows.Forms.BindingSource(this.components);
            this.stu_enrolTA = new SIMS.DSTableAdapters.STUDENT_ENROLLMENTTableAdapter();
            this.studentTA = new SIMS.DSTableAdapters.STUDENTTableAdapter();
            this.centreTA = new SIMS.DSTableAdapters.CENTRETableAdapter();
            this.stu_feeTA = new SIMS.DSTableAdapters.STUDENT_FEETableAdapter();
            this.stu_profileTA = new SIMS.DSTableAdapters.STUDENT_PROFILETableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_profileBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_feeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_enrolBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxProfile.Controls.Add(this.pictureBox1);
            this.groupBoxProfile.Controls.Add(this.groupBoxSubjects);
            this.groupBoxProfile.Controls.Add(this.LabelDue);
            this.groupBoxProfile.Controls.Add(this.LabelTotal);
            this.groupBoxProfile.Controls.Add(this.metroLabel4);
            this.groupBoxProfile.Controls.Add(this.LabelCentre);
            this.groupBoxProfile.Controls.Add(this.LabelGender);
            this.groupBoxProfile.Controls.Add(this.LabelSurname);
            this.groupBoxProfile.Controls.Add(this.LabelName);
            this.groupBoxProfile.Controls.Add(this.LabelAdmissionNo);
            this.groupBoxProfile.Controls.Add(this.LabelAdmission);
            this.groupBoxProfile.Controls.Add(this.metroLabel2);
            this.groupBoxProfile.Controls.Add(this.metroLabelName0);
            this.groupBoxProfile.Controls.Add(this.metroLabel3);
            this.groupBoxProfile.Controls.Add(this.MetroLabelSurname);
            this.groupBoxProfile.Controls.Add(this.metroLabel1);
            this.groupBoxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfile.Location = new System.Drawing.Point(216, 36);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(614, 616);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Student Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMS.Properties.Resources.GeekLogo;
            this.pictureBox1.Location = new System.Drawing.Point(188, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 193);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxSubjects
            // 
            this.groupBoxSubjects.Controls.Add(this.dataGridView1);
            this.groupBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSubjects.Location = new System.Drawing.Point(6, 333);
            this.groupBoxSubjects.Name = "groupBoxSubjects";
            this.groupBoxSubjects.Size = new System.Drawing.Size(602, 229);
            this.groupBoxSubjects.TabIndex = 25;
            this.groupBoxSubjects.TabStop = false;
            this.groupBoxSubjects.Text = "Registered Subjects";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUBJECTCODEDataGridViewTextBoxColumn,
            this.sUBJECTNAMEDataGridViewTextBoxColumn,
            this.gRADEDataGridViewTextBoxColumn,
            this.aCADEMICYEARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stu_profileBS;
            this.dataGridView1.Location = new System.Drawing.Point(21, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // sUBJECTCODEDataGridViewTextBoxColumn
            // 
            this.sUBJECTCODEDataGridViewTextBoxColumn.DataPropertyName = "SUBJECT_CODE";
            this.sUBJECTCODEDataGridViewTextBoxColumn.HeaderText = "SUBJECT CODE";
            this.sUBJECTCODEDataGridViewTextBoxColumn.Name = "sUBJECTCODEDataGridViewTextBoxColumn";
            this.sUBJECTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUBJECTCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sUBJECTNAMEDataGridViewTextBoxColumn
            // 
            this.sUBJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUBJECT_NAME";
            this.sUBJECTNAMEDataGridViewTextBoxColumn.HeaderText = "SUBJECT NAME";
            this.sUBJECTNAMEDataGridViewTextBoxColumn.Name = "sUBJECTNAMEDataGridViewTextBoxColumn";
            this.sUBJECTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUBJECTNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // gRADEDataGridViewTextBoxColumn
            // 
            this.gRADEDataGridViewTextBoxColumn.DataPropertyName = "GRADE";
            this.gRADEDataGridViewTextBoxColumn.HeaderText = "GRADE";
            this.gRADEDataGridViewTextBoxColumn.Name = "gRADEDataGridViewTextBoxColumn";
            this.gRADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCADEMICYEARDataGridViewTextBoxColumn
            // 
            this.aCADEMICYEARDataGridViewTextBoxColumn.DataPropertyName = "ACADEMIC_YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.HeaderText = "ACADEMIC YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.Name = "aCADEMICYEARDataGridViewTextBoxColumn";
            this.aCADEMICYEARDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCADEMICYEARDataGridViewTextBoxColumn.Width = 140;
            // 
            // stu_profileBS
            // 
            this.stu_profileBS.DataMember = "STUDENT_PROFILE";
            this.stu_profileBS.DataSource = this.profileDS;
            // 
            // profileDS
            // 
            this.profileDS.DataSetName = "DS";
            this.profileDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelDue
            // 
            this.LabelDue.AutoSize = true;
            this.LabelDue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "BALANCE", true));
            this.LabelDue.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelDue.Location = new System.Drawing.Point(330, 565);
            this.LabelDue.Name = "LabelDue";
            this.LabelDue.Size = new System.Drawing.Size(32, 19);
            this.LabelDue.TabIndex = 24;
            this.LabelDue.Text = "due";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "AMOUNT", true));
            this.LabelTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelTotal.Location = new System.Drawing.Point(87, 565);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(34, 19);
            this.LabelTotal.TabIndex = 23;
            this.LabelTotal.Text = "cost";
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
            this.LabelCentre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "CENTRE_NAME", true));
            this.LabelCentre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelCentre.Location = new System.Drawing.Point(81, 295);
            this.LabelCentre.Name = "LabelCentre";
            this.LabelCentre.Size = new System.Drawing.Size(47, 19);
            this.LabelCentre.TabIndex = 21;
            this.LabelCentre.Text = "centre";
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "GENDER", true));
            this.LabelGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelGender.Location = new System.Drawing.Point(87, 276);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(52, 19);
            this.LabelGender.TabIndex = 19;
            this.LabelGender.Text = "gender";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "SURNAME", true));
            this.LabelSurname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelSurname.Location = new System.Drawing.Point(96, 257);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(62, 19);
            this.LabelSurname.TabIndex = 18;
            this.LabelSurname.Text = "surname";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "NAME", true));
            this.LabelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelName.Location = new System.Drawing.Point(102, 238);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 19);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "name";
            // 
            // LabelAdmissionNo
            // 
            this.LabelAdmissionNo.AutoSize = true;
            this.LabelAdmissionNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "ADMISSION_NO", true));
            this.LabelAdmissionNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelAdmissionNo.Location = new System.Drawing.Point(120, 218);
            this.LabelAdmissionNo.Name = "LabelAdmissionNo";
            this.LabelAdmissionNo.Size = new System.Drawing.Size(54, 19);
            this.LabelAdmissionNo.TabIndex = 16;
            this.LabelAdmissionNo.Text = "admNo";
            // 
            // LabelAdmission
            // 
            this.LabelAdmission.AutoSize = true;
            this.LabelAdmission.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelAdmission.Location = new System.Drawing.Point(18, 219);
            this.LabelAdmission.Name = "LabelAdmission";
            this.LabelAdmission.Size = new System.Drawing.Size(106, 19);
            this.LabelAdmission.Style = MetroFramework.MetroColorStyle.Black;
            this.LabelAdmission.TabIndex = 0;
            this.LabelAdmission.Text = "Admission No:";
            this.LabelAdmission.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(18, 295);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Centre:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabelName0
            // 
            this.metroLabelName0.AutoSize = true;
            this.metroLabelName0.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelName0.Location = new System.Drawing.Point(18, 238);
            this.metroLabelName0.Name = "metroLabelName0";
            this.metroLabelName0.Size = new System.Drawing.Size(85, 19);
            this.metroLabelName0.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabelName0.TabIndex = 2;
            this.metroLabelName0.Text = "First Name:";
            this.metroLabelName0.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(6, 565);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Total Cost:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // MetroLabelSurname
            // 
            this.MetroLabelSurname.AutoSize = true;
            this.MetroLabelSurname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetroLabelSurname.Location = new System.Drawing.Point(18, 257);
            this.MetroLabelSurname.Name = "MetroLabelSurname";
            this.MetroLabelSurname.Size = new System.Drawing.Size(72, 19);
            this.MetroLabelSurname.Style = MetroFramework.MetroColorStyle.Black;
            this.MetroLabelSurname.TabIndex = 5;
            this.MetroLabelSurname.Text = "Surname:";
            this.MetroLabelSurname.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(18, 276);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Gender:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // stu_feeBS
            // 
            this.stu_feeBS.DataMember = "STUDENT_FEE";
            this.stu_feeBS.DataSource = this.profileDS;
            // 
            // centreBS
            // 
            this.centreBS.DataMember = "CENTRE";
            this.centreBS.DataSource = this.profileDS;
            // 
            // studentBS
            // 
            this.studentBS.DataMember = "STUDENT";
            this.studentBS.DataSource = this.profileDS;
            // 
            // stu_enrolBS
            // 
            this.stu_enrolBS.DataMember = "STUDENT_ENROLLMENT";
            this.stu_enrolBS.DataSource = this.profileDS;
            // 
            // stu_enrolTA
            // 
            this.stu_enrolTA.ClearBeforeFill = true;
            // 
            // studentTA
            // 
            this.studentTA.ClearBeforeFill = true;
            // 
            // centreTA
            // 
            this.centreTA.ClearBeforeFill = true;
            // 
            // stu_feeTA
            // 
            this.stu_feeTA.ClearBeforeFill = true;
            // 
            // stu_profileTA
            // 
            this.stu_profileTA.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNavigator1.BindingSource = this.stu_profileBS;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stu_profileBS, "ADMISSION_NO", true));
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(402, 8);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(238, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 687);
            this.Controls.Add(this.bindingNavigator1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_profileBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_feeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_enrolBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfile;
        private MetroFramework.Controls.MetroLabel LabelAdmission;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabelName0;
        private MetroFramework.Controls.MetroLabel MetroLabelSurname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DS profileDS;
        private System.Windows.Forms.BindingSource stu_enrolBS;
        private DSTableAdapters.STUDENT_ENROLLMENTTableAdapter stu_enrolTA;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel LabelAdmissionNo;
        private MetroFramework.Controls.MetroLabel LabelName;
        private MetroFramework.Controls.MetroLabel LabelSurname;
        private MetroFramework.Controls.MetroLabel LabelGender;
        private MetroFramework.Controls.MetroLabel LabelCentre;
        private System.Windows.Forms.BindingSource studentBS;
        private DSTableAdapters.STUDENTTableAdapter studentTA;
        private System.Windows.Forms.BindingSource centreBS;
        private DSTableAdapters.CENTRETableAdapter centreTA;
        private MetroFramework.Controls.MetroLabel LabelDue;
        private MetroFramework.Controls.MetroLabel LabelTotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource stu_feeBS;
        private DSTableAdapters.STUDENT_FEETableAdapter stu_feeTA;
        private System.Windows.Forms.BindingSource stu_profileBS;
        private DSTableAdapters.STUDENT_PROFILETableAdapter stu_profileTA;
        private System.Windows.Forms.GroupBox groupBoxSubjects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCADEMICYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}