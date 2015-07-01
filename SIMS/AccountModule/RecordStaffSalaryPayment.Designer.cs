namespace SIMS.AccountModule
{
    partial class RecordStaffSalaryPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordStaffSalaryPayment));
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.LabelLessons = new MetroFramework.Controls.MetroLabel();
            this.LabelSurname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.LabelSalary = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.LabelDateEmployed = new MetroFramework.Controls.MetroLabel();
            this.LabeliDNo = new MetroFramework.Controls.MetroLabel();
            this.LabelStaffNo = new MetroFramework.Controls.MetroLabel();
            this.LabelName = new MetroFramework.Controls.MetroLabel();
            this.LabelOccupa = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxStart = new System.Windows.Forms.ComboBox();
            this.teacher_registerBS = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.comboBoxEnd = new System.Windows.Forms.ComboBox();
            this.teacher_registerTA = new SIMS.DSTableAdapters.TEACHERS_REGISTERTableAdapter();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.TileSalaryGenerate = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxRate = new MetroFramework.Controls.MetroTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.salary_captureBS = new System.Windows.Forms.BindingSource(this.components);
            this.salary_captureTA = new SIMS.DSTableAdapters.SALARY_CAPTURETableAdapter();
            this.CheckBoxPayPeriod = new MetroFramework.Controls.MetroCheckBox();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_registerBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_captureBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxHeader.Controls.Add(this.pictureBox2);
            this.groupBoxHeader.Location = new System.Drawing.Point(198, 98);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(626, 195);
            this.groupBoxHeader.TabIndex = 0;
            this.groupBoxHeader.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIMS.Properties.Resources.Isibani_Pro_Tutor1;
            this.pictureBox2.Location = new System.Drawing.Point(23, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 150);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // groupBoxBody
            // 
            this.groupBoxBody.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxBody.Controls.Add(this.LabelLessons);
            this.groupBoxBody.Controls.Add(this.LabelSurname);
            this.groupBoxBody.Controls.Add(this.metroLabel7);
            this.groupBoxBody.Controls.Add(this.LabelSalary);
            this.groupBoxBody.Controls.Add(this.metroLabel9);
            this.groupBoxBody.Controls.Add(this.metroLabel12);
            this.groupBoxBody.Controls.Add(this.LabelDateEmployed);
            this.groupBoxBody.Controls.Add(this.LabeliDNo);
            this.groupBoxBody.Controls.Add(this.LabelStaffNo);
            this.groupBoxBody.Controls.Add(this.LabelName);
            this.groupBoxBody.Controls.Add(this.LabelOccupa);
            this.groupBoxBody.Controls.Add(this.metroLabel5);
            this.groupBoxBody.Controls.Add(this.metroLabel3);
            this.groupBoxBody.Controls.Add(this.metroLabel2);
            this.groupBoxBody.Controls.Add(this.metroLabel1);
            this.groupBoxBody.Location = new System.Drawing.Point(198, 299);
            this.groupBoxBody.Name = "groupBoxBody";
            this.groupBoxBody.Size = new System.Drawing.Size(626, 180);
            this.groupBoxBody.TabIndex = 1;
            this.groupBoxBody.TabStop = false;
            // 
            // LabelLessons
            // 
            this.LabelLessons.AutoSize = true;
            this.LabelLessons.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelLessons.Location = new System.Drawing.Point(153, 131);
            this.LabelLessons.Name = "LabelLessons";
            this.LabelLessons.Size = new System.Drawing.Size(17, 19);
            this.LabelLessons.TabIndex = 22;
            this.LabelLessons.Text = "0";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "SURNAME", true));
            this.LabelSurname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelSurname.Location = new System.Drawing.Point(487, 16);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(62, 19);
            this.LabelSurname.TabIndex = 21;
            this.LabelSurname.Text = "surname";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(339, 16);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(142, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Employee Surname:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelSalary.Location = new System.Drawing.Point(428, 131);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(17, 19);
            this.LabelSalary.TabIndex = 19;
            this.LabelSalary.Text = "0";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(23, 131);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(109, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "No. of Lessons:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(339, 131);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(83, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "BASIC PAY:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // LabelDateEmployed
            // 
            this.LabelDateEmployed.AutoSize = true;
            this.LabelDateEmployed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "HIRE_DATE", true));
            this.LabelDateEmployed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelDateEmployed.Location = new System.Drawing.Point(487, 52);
            this.LabelDateEmployed.Name = "LabelDateEmployed";
            this.LabelDateEmployed.Size = new System.Drawing.Size(36, 19);
            this.LabelDateEmployed.TabIndex = 14;
            this.LabelDateEmployed.Text = "date";
            // 
            // LabeliDNo
            // 
            this.LabeliDNo.AutoSize = true;
            this.LabeliDNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "CITIZEN_ID", true));
            this.LabeliDNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabeliDNo.Location = new System.Drawing.Point(153, 90);
            this.LabeliDNo.Name = "LabeliDNo";
            this.LabeliDNo.Size = new System.Drawing.Size(43, 19);
            this.LabeliDNo.TabIndex = 8;
            this.LabeliDNo.Text = "id no.";
            // 
            // LabelStaffNo
            // 
            this.LabelStaffNo.AutoSize = true;
            this.LabelStaffNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "EMPLOYEE_ID", true));
            this.LabelStaffNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelStaffNo.Location = new System.Drawing.Point(153, 52);
            this.LabelStaffNo.Name = "LabelStaffNo";
            this.LabelStaffNo.Size = new System.Drawing.Size(55, 19);
            this.LabelStaffNo.TabIndex = 7;
            this.LabelStaffNo.Text = "staff no";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "NAME", true));
            this.LabelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelName.Location = new System.Drawing.Point(153, 16);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 19);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "name";
            // 
            // LabelOccupa
            // 
            this.LabelOccupa.AutoSize = true;
            this.LabelOccupa.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelOccupa.Location = new System.Drawing.Point(339, 90);
            this.LabelOccupa.Name = "LabelOccupa";
            this.LabelOccupa.Size = new System.Drawing.Size(89, 19);
            this.LabelOccupa.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelOccupa.TabIndex = 5;
            this.LabelOccupa.Text = "Occupation:";
            this.LabelOccupa.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(339, 52);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Date Employed:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Identity Number:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Employee No.:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Employee Name:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(44, 30);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Pay Period:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(135, 30);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "From";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(338, 30);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(24, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "To";
            // 
            // comboBoxStart
            // 
            this.comboBoxStart.DataSource = this.teacher_registerBS;
            this.comboBoxStart.DisplayMember = "TIME_IN";
            this.comboBoxStart.FormattingEnabled = true;
            this.comboBoxStart.Location = new System.Drawing.Point(184, 30);
            this.comboBoxStart.Name = "comboBoxStart";
            this.comboBoxStart.Size = new System.Drawing.Size(132, 21);
            this.comboBoxStart.TabIndex = 11;
            // 
            // teacher_registerBS
            // 
            this.teacher_registerBS.DataMember = "TEACHERS_REGISTER";
            this.teacher_registerBS.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEnd
            // 
            this.comboBoxEnd.DataSource = this.teacher_registerBS;
            this.comboBoxEnd.DisplayMember = "TIME_IN";
            this.comboBoxEnd.FormattingEnabled = true;
            this.comboBoxEnd.Location = new System.Drawing.Point(368, 30);
            this.comboBoxEnd.Name = "comboBoxEnd";
            this.comboBoxEnd.Size = new System.Drawing.Size(132, 21);
            this.comboBoxEnd.TabIndex = 12;
            // 
            // teacher_registerTA
            // 
            this.teacher_registerTA.ClearBeforeFill = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(44, 91);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(72, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Pay Rate:";
            this.metroLabel8.UseStyleColors = true;
            // 
            // TileSalaryGenerate
            // 
            this.TileSalaryGenerate.ActiveControl = null;
            this.TileSalaryGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TileSalaryGenerate.Location = new System.Drawing.Point(368, 91);
            this.TileSalaryGenerate.Name = "TileSalaryGenerate";
            this.TileSalaryGenerate.Size = new System.Drawing.Size(132, 23);
            this.TileSalaryGenerate.Style = MetroFramework.MetroColorStyle.Green;
            this.TileSalaryGenerate.TabIndex = 2;
            this.TileSalaryGenerate.Text = "Generate Salary";
            this.TileSalaryGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileSalaryGenerate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TileSalaryGenerate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileSalaryGenerate.UseSelectable = true;
            this.TileSalaryGenerate.UseStyleColors = true;
            this.TileSalaryGenerate.Click += new System.EventHandler(this.TileSalaryGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.TileSalaryGenerate);
            this.groupBox1.Controls.Add(this.TextBoxRate);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.comboBoxEnd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.comboBoxStart);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Location = new System.Drawing.Point(198, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 129);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // TextBoxRate
            // 
            this.TextBoxRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxRate.Lines = new string[0];
            this.TextBoxRate.Location = new System.Drawing.Point(122, 91);
            this.TextBoxRate.MaxLength = 32767;
            this.TextBoxRate.Name = "TextBoxRate";
            this.TextBoxRate.PasswordChar = '\0';
            this.TextBoxRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxRate.SelectedText = "";
            this.TextBoxRate.Size = new System.Drawing.Size(93, 23);
            this.TextBoxRate.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxRate.TabIndex = 18;
            this.TextBoxRate.UseSelectable = true;
            this.TextBoxRate.UseStyleColors = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNavigator1.BindingSource = this.salary_captureBS;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
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
            this.bindingNavigatorMoveLastItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(405, 70);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(203, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // salary_captureBS
            // 
            this.salary_captureBS.DataMember = "SALARY_CAPTURE";
            this.salary_captureBS.DataSource = this.dS;
            // 
            // salary_captureTA
            // 
            this.salary_captureTA.ClearBeforeFill = true;
            // 
            // CheckBoxPayPeriod
            // 
            this.CheckBoxPayPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBoxPayPeriod.AutoSize = true;
            this.CheckBoxPayPeriod.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.CheckBoxPayPeriod.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.CheckBoxPayPeriod.Location = new System.Drawing.Point(198, 621);
            this.CheckBoxPayPeriod.Name = "CheckBoxPayPeriod";
            this.CheckBoxPayPeriod.Size = new System.Drawing.Size(293, 19);
            this.CheckBoxPayPeriod.Style = MetroFramework.MetroColorStyle.Green;
            this.CheckBoxPayPeriod.TabIndex = 22;
            this.CheckBoxPayPeriod.Text = "Have you selected the right pay period?";
            this.CheckBoxPayPeriod.UseSelectable = true;
            this.CheckBoxPayPeriod.UseStyleColors = true;
            // 
            // RecordStaffSalaryPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 647);
            this.Controls.Add(this.CheckBoxPayPeriod);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBody);
            this.Controls.Add(this.groupBoxHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordStaffSalaryPayment";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Staff Salary Payment";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.RecordStaffSalaryPayment_Load);
            this.groupBoxHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxBody.ResumeLayout(false);
            this.groupBoxBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_registerBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_captureBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBoxBody;
        private System.Windows.Forms.ComboBox comboBoxEnd;
        private System.Windows.Forms.ComboBox comboBoxStart;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel LabeliDNo;
        private MetroFramework.Controls.MetroLabel LabelStaffNo;
        private MetroFramework.Controls.MetroLabel LabelName;
        private MetroFramework.Controls.MetroLabel LabelOccupa;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DS dS;
        private System.Windows.Forms.BindingSource teacher_registerBS;
        private DSTableAdapters.TEACHERS_REGISTERTableAdapter teacher_registerTA;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel LabelDateEmployed;
        private MetroFramework.Controls.MetroTile TileSalaryGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel LabelSalary;
        private MetroFramework.Controls.MetroLabel LabelSurname;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel LabelLessons;
        private MetroFramework.Controls.MetroTextBox TextBoxRate;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource salary_captureBS;
        private DSTableAdapters.SALARY_CAPTURETableAdapter salary_captureTA;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPayPeriod;
    }
}