namespace SIMS.AccountModule
{
    partial class PrintPayslip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPayslip));
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.LabelSurname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.LabelDateEmployed = new MetroFramework.Controls.MetroLabel();
            this.LabeliDNo = new MetroFramework.Controls.MetroLabel();
            this.LabelStaffNo = new MetroFramework.Controls.MetroLabel();
            this.LabelName = new MetroFramework.Controls.MetroLabel();
            this.LabelOccupa = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LabelLessons = new MetroFramework.Controls.MetroLabel();
            this.LabelSalary = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.payslipBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new SIMS.DS();
            this.salary_captureBS = new System.Windows.Forms.BindingSource(this.components);
            this.salary_captureTA = new SIMS.DSTableAdapters.SALARY_CAPTURETableAdapter();
            this.printDialogPayslip = new System.Windows.Forms.PrintDialog();
            this.printDocumentPayslip = new System.Drawing.Printing.PrintDocument();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payslipBN)).BeginInit();
            this.payslipBN.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_captureBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxHeader.Controls.Add(this.pictureBox2);
            this.groupBoxHeader.Location = new System.Drawing.Point(113, 88);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(626, 195);
            this.groupBoxHeader.TabIndex = 1;
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
            this.groupBoxBody.Controls.Add(this.LabelSurname);
            this.groupBoxBody.Controls.Add(this.metroLabel7);
            this.groupBoxBody.Controls.Add(this.LabelDateEmployed);
            this.groupBoxBody.Controls.Add(this.LabeliDNo);
            this.groupBoxBody.Controls.Add(this.LabelStaffNo);
            this.groupBoxBody.Controls.Add(this.LabelName);
            this.groupBoxBody.Controls.Add(this.LabelOccupa);
            this.groupBoxBody.Controls.Add(this.metroLabel5);
            this.groupBoxBody.Controls.Add(this.metroLabel3);
            this.groupBoxBody.Controls.Add(this.metroLabel2);
            this.groupBoxBody.Controls.Add(this.metroLabel1);
            this.groupBoxBody.Location = new System.Drawing.Point(113, 289);
            this.groupBoxBody.Name = "groupBoxBody";
            this.groupBoxBody.Size = new System.Drawing.Size(626, 122);
            this.groupBoxBody.TabIndex = 2;
            this.groupBoxBody.TabStop = false;
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
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Hire Date:";
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
            // LabelLessons
            // 
            this.LabelLessons.AutoSize = true;
            this.LabelLessons.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "LESSONS", true));
            this.LabelLessons.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelLessons.Location = new System.Drawing.Point(6, 7);
            this.LabelLessons.Name = "LabelLessons";
            this.LabelLessons.Size = new System.Drawing.Size(17, 19);
            this.LabelLessons.TabIndex = 22;
            this.LabelLessons.Text = "0";
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "BASIC_PAY", true));
            this.LabelSalary.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelSalary.Location = new System.Drawing.Point(6, 7);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(17, 19);
            this.LabelSalary.TabIndex = 19;
            this.LabelSalary.Text = "0";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(23, 91);
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
            this.metroLabel12.Location = new System.Drawing.Point(383, 152);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(83, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "BASIC PAY:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(6, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Start Date:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(230, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "End Date:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Location = new System.Drawing.Point(113, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 190);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LabelSalary);
            this.groupBox5.Location = new System.Drawing.Point(479, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(140, 29);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel14);
            this.groupBox4.Location = new System.Drawing.Point(479, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 29);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "RATE", true));
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(6, 7);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(17, 19);
            this.metroLabel14.TabIndex = 22;
            this.metroLabel14.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LabelLessons);
            this.groupBox3.Location = new System.Drawing.Point(153, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 29);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Location = new System.Drawing.Point(153, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 38);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "END_DATE", true));
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(308, 11);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(49, 19);
            this.metroLabel13.TabIndex = 27;
            this.metroLabel13.Text = "e_date";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salary_captureBS, "START_DATE", true));
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(92, 11);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "s_date";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(383, 91);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Pay Rate:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(23, 30);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(87, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "Pay Period:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // payslipBN
            // 
            this.payslipBN.AddNewItem = null;
            this.payslipBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payslipBN.BindingSource = this.salary_captureBS;
            this.payslipBN.CountItem = this.bindingNavigatorCountItem;
            this.payslipBN.DeleteItem = null;
            this.payslipBN.Dock = System.Windows.Forms.DockStyle.None;
            this.payslipBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.printToolStripButton,
            this.toolStripSeparator});
            this.payslipBN.Location = new System.Drawing.Point(295, 60);
            this.payslipBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.payslipBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.payslipBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.payslipBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.payslipBN.Name = "payslipBN";
            this.payslipBN.PositionItem = this.bindingNavigatorPositionItem;
            this.payslipBN.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.payslipBN.Size = new System.Drawing.Size(232, 25);
            this.payslipBN.TabIndex = 20;
            this.payslipBN.Text = "payslipBN";
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
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(112, 638);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(626, 143);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 105);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isibani Educational Empowerment - Non-profit Organisation\r\n";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // printDialogPayslip
            // 
            this.printDialogPayslip.UseEXDialog = true;
            // 
            // PrintPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 788);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.payslipBN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBody);
            this.Controls.Add(this.groupBoxHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintPayslip";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Payslip";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.PrintPayslip_Load);
            this.groupBoxHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxBody.ResumeLayout(false);
            this.groupBoxBody.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payslipBN)).EndInit();
            this.payslipBN.ResumeLayout(false);
            this.payslipBN.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_captureBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBoxBody;
        private MetroFramework.Controls.MetroLabel LabelLessons;
        private MetroFramework.Controls.MetroLabel LabelSurname;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel LabelSalary;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel LabelDateEmployed;
        private MetroFramework.Controls.MetroLabel LabeliDNo;
        private MetroFramework.Controls.MetroLabel LabelStaffNo;
        private MetroFramework.Controls.MetroLabel LabelName;
        private MetroFramework.Controls.MetroLabel LabelOccupa;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.BindingNavigator payslipBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource salary_captureBS;
        private DSTableAdapters.SALARY_CAPTURETableAdapter salary_captureTA;
        private System.Windows.Forms.PrintDialog printDialogPayslip;
        private System.Drawing.Printing.PrintDocument printDocumentPayslip;
    }
}