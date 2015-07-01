namespace SIMS.EmployeeModule
{
    partial class RecordStaffAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordStaffAttendance));
            this.dS = new SIMS.DS();
            this.tableM = new SIMS.DSTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTileCancel = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmployeeID = new MetroFramework.Controls.MetroLabel();
            this.LabelEmployeeID = new MetroFramework.Controls.MetroLabel();
            this.employeeBS = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabelLessons = new MetroFramework.Controls.MetroLabel();
            this.textBoxLessons = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSubject = new MetroFramework.Controls.MetroComboBox();
            this.subjectBS = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabelSubject = new MetroFramework.Controls.MetroLabel();
            this.LabelTimeOut = new MetroFramework.Controls.MetroLabel();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.LabelTimeIn = new MetroFramework.Controls.MetroLabel();
            this.dateTimeIn = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.metroTileSubmit = new MetroFramework.Controls.MetroTile();
            this.employeeTA = new SIMS.DSTableAdapters.EMPLOYEETableAdapter();
            this.subjectTA = new SIMS.DSTableAdapters.SUBJECTTableAdapter();
            this.student_profileTA = new SIMS.DSTableAdapters.STUDENT_PROFILETableAdapter();
            this.attendanceBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.staff_attTA = new SIMS.DSTableAdapters.STAFF_ATTENDANCETableAdapter();
            this.dateTimeAttendance = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBN)).BeginInit();
            this.attendanceBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableM
            // 
            this.tableM.BackupDataSetBeforeUpdate = false;
            this.tableM.CENTRETableAdapter = null;
            this.tableM.CLASSTableAdapter = null;
            this.tableM.Connection = null;
            this.tableM.EMPLOYEETableAdapter = null;
            this.tableM.SALARYTableAdapter = null;
            this.tableM.SIMS_USERSTableAdapter = null;
            //this.tableM.STAFF_ATTENDANCETableAdapter = null;
            this.tableM.STUDENT_FEETableAdapter = null;
            this.tableM.STUDENT_PAYMENTTableAdapter = null;
            this.tableM.STUDENTTableAdapter = null;
            this.tableM.SUBJECTTableAdapter = null;
            this.tableM.UpdateOrder = SIMS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroTileCancel);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.metroTileSubmit);
            this.groupBox1.Location = new System.Drawing.Point(89, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // metroTileCancel
            // 
            this.metroTileCancel.ActiveControl = null;
            this.metroTileCancel.Location = new System.Drawing.Point(686, 380);
            this.metroTileCancel.Name = "metroTileCancel";
            this.metroTileCancel.Size = new System.Drawing.Size(75, 23);
            this.metroTileCancel.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileCancel.TabIndex = 19;
            this.metroTileCancel.Text = "Cancel";
            this.metroTileCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileCancel.UseSelectable = true;
            this.metroTileCancel.UseStyleColors = true;
            this.metroTileCancel.Click += new System.EventHandler(this.metroTileCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.29308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.12077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.54934F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.74227F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelTimeOut, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeOut, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSurname, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelEmployeeID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelEmployeeID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelLessons, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLessons, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelSubject, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSubject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelTimeIn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeIn, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 59);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 288);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(421, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Surname:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelName.Location = new System.Drawing.Point(421, 0);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(53, 19);
            this.metroLabelName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelName.TabIndex = 23;
            this.metroLabelName.Text = "Name:";
            this.metroLabelName.UseStyleColors = true;
            // 
            // metroLabelEmployeeID
            // 
            this.metroLabelEmployeeID.AutoSize = true;
            this.metroLabelEmployeeID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelEmployeeID.Location = new System.Drawing.Point(3, 0);
            this.metroLabelEmployeeID.Name = "metroLabelEmployeeID";
            this.metroLabelEmployeeID.Size = new System.Drawing.Size(107, 19);
            this.metroLabelEmployeeID.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelEmployeeID.TabIndex = 10;
            this.metroLabelEmployeeID.Text = "Employee No.:";
            this.metroLabelEmployeeID.UseStyleColors = true;
            // 
            // LabelEmployeeID
            // 
            this.LabelEmployeeID.AutoSize = true;
            this.LabelEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBS, "EMPLOYEE_ID", true));
            this.LabelEmployeeID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelEmployeeID.Location = new System.Drawing.Point(134, 0);
            this.LabelEmployeeID.Name = "LabelEmployeeID";
            this.LabelEmployeeID.Size = new System.Drawing.Size(86, 19);
            this.LabelEmployeeID.TabIndex = 5;
            this.LabelEmployeeID.Text = "Employee ID";
            // 
            // employeeBS
            // 
            this.employeeBS.DataMember = "EMPLOYEE";
            this.employeeBS.DataSource = this.dS;
            // 
            // metroLabelLessons
            // 
            this.metroLabelLessons.AutoSize = true;
            this.metroLabelLessons.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelLessons.Location = new System.Drawing.Point(3, 72);
            this.metroLabelLessons.Name = "metroLabelLessons";
            this.metroLabelLessons.Size = new System.Drawing.Size(102, 19);
            this.metroLabelLessons.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelLessons.TabIndex = 11;
            this.metroLabelLessons.Text = "N. Of Lessons:";
            this.metroLabelLessons.UseStyleColors = true;
            // 
            // textBoxLessons
            // 
            this.textBoxLessons.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxLessons.Lines = new string[0];
            this.textBoxLessons.Location = new System.Drawing.Point(134, 75);
            this.textBoxLessons.MaxLength = 32767;
            this.textBoxLessons.Name = "textBoxLessons";
            this.textBoxLessons.PasswordChar = '\0';
            this.textBoxLessons.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxLessons.SelectedText = "";
            this.textBoxLessons.Size = new System.Drawing.Size(139, 23);
            this.textBoxLessons.Style = MetroFramework.MetroColorStyle.Green;
            this.textBoxLessons.TabIndex = 9;
            this.textBoxLessons.UseSelectable = true;
            this.textBoxLessons.UseStyleColors = true;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DataSource = this.subjectBS;
            this.comboBoxSubject.DisplayMember = "SUBJECT";
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.ItemHeight = 23;
            this.comboBoxSubject.Location = new System.Drawing.Point(134, 147);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(168, 29);
            this.comboBoxSubject.TabIndex = 13;
            this.comboBoxSubject.UseSelectable = true;
            // 
            // subjectBS
            // 
            this.subjectBS.DataMember = "SUBJECT";
            this.subjectBS.DataSource = this.dS;
            // 
            // metroLabelSubject
            // 
            this.metroLabelSubject.AutoSize = true;
            this.metroLabelSubject.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelSubject.Location = new System.Drawing.Point(3, 144);
            this.metroLabelSubject.Name = "metroLabelSubject";
            this.metroLabelSubject.Size = new System.Drawing.Size(62, 19);
            this.metroLabelSubject.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelSubject.TabIndex = 12;
            this.metroLabelSubject.Text = "Subject:";
            this.metroLabelSubject.UseStyleColors = true;
            // 
            // LabelTimeOut
            // 
            this.LabelTimeOut.AutoSize = true;
            this.LabelTimeOut.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelTimeOut.Location = new System.Drawing.Point(421, 216);
            this.LabelTimeOut.Name = "LabelTimeOut";
            this.LabelTimeOut.Size = new System.Drawing.Size(74, 19);
            this.LabelTimeOut.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelTimeOut.TabIndex = 17;
            this.LabelTimeOut.Text = "Time Out:";
            this.LabelTimeOut.UseStyleColors = true;
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeOut.Location = new System.Drawing.Point(513, 219);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(84, 20);
            this.dateTimeOut.TabIndex = 20;
            // 
            // LabelTimeIn
            // 
            this.LabelTimeIn.AutoSize = true;
            this.LabelTimeIn.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelTimeIn.Location = new System.Drawing.Point(3, 216);
            this.LabelTimeIn.Name = "LabelTimeIn";
            this.LabelTimeIn.Size = new System.Drawing.Size(62, 19);
            this.LabelTimeIn.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelTimeIn.TabIndex = 16;
            this.LabelTimeIn.Text = "Time In:";
            this.LabelTimeIn.UseStyleColors = true;
            // 
            // dateTimeIn
            // 
            this.dateTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeIn.Location = new System.Drawing.Point(134, 219);
            this.dateTimeIn.Name = "dateTimeIn";
            this.dateTimeIn.Size = new System.Drawing.Size(84, 20);
            this.dateTimeIn.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBS, "NAME", true));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(513, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 16);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBS, "SURNAME", true));
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(513, 72);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(62, 16);
            this.labelSurname.TabIndex = 25;
            this.labelSurname.Text = "Surname";
            // 
            // metroTileSubmit
            // 
            this.metroTileSubmit.ActiveControl = null;
            this.metroTileSubmit.Location = new System.Drawing.Point(563, 380);
            this.metroTileSubmit.Name = "metroTileSubmit";
            this.metroTileSubmit.Size = new System.Drawing.Size(75, 23);
            this.metroTileSubmit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSubmit.TabIndex = 18;
            this.metroTileSubmit.Text = "Submit";
            this.metroTileSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSubmit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSubmit.UseSelectable = true;
            this.metroTileSubmit.UseStyleColors = true;
            this.metroTileSubmit.Click += new System.EventHandler(this.metroTileSubmit_Click);
            // 
            // employeeTA
            // 
            this.employeeTA.ClearBeforeFill = true;
            // 
            // subjectTA
            // 
            this.subjectTA.ClearBeforeFill = true;
            // 
            // student_profileTA
            // 
            this.student_profileTA.ClearBeforeFill = true;
            // 
            // attendanceBN
            // 
            this.attendanceBN.AddNewItem = null;
            this.attendanceBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.attendanceBN.BindingSource = this.employeeBS;
            this.attendanceBN.CountItem = this.bindingNavigatorCountItem;
            this.attendanceBN.DeleteItem = null;
            this.attendanceBN.Dock = System.Windows.Forms.DockStyle.None;
            this.attendanceBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.attendanceBN.Location = new System.Drawing.Point(416, 85);
            this.attendanceBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendanceBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendanceBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendanceBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendanceBN.Name = "attendanceBN";
            this.attendanceBN.PositionItem = this.bindingNavigatorPositionItem;
            this.attendanceBN.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.attendanceBN.Size = new System.Drawing.Size(240, 25);
            this.attendanceBN.TabIndex = 2;
            this.attendanceBN.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // staff_attTA
            // 
            this.staff_attTA.ClearBeforeFill = true;
            // 
            // dateTimeAttendance
            // 
            this.dateTimeAttendance.Location = new System.Drawing.Point(207, 63);
            this.dateTimeAttendance.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeAttendance.Name = "dateTimeAttendance";
            this.dateTimeAttendance.Size = new System.Drawing.Size(117, 29);
            this.dateTimeAttendance.TabIndex = 2;
            this.dateTimeAttendance.Visible = false;
            // 
            // RecordStaffAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 577);
            this.Controls.Add(this.attendanceBN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimeAttendance);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordStaffAttendance";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Teachers\' Attendance";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.RecordStaffAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBN)).EndInit();
            this.attendanceBN.ResumeLayout(false);
            this.attendanceBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private DSTableAdapters.TableAdapterManager tableM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource employeeBS;
        private DSTableAdapters.EMPLOYEETableAdapter employeeTA;
        private MetroFramework.Controls.MetroLabel LabelEmployeeID;
        private MetroFramework.Controls.MetroLabel metroLabelSubject;
        private MetroFramework.Controls.MetroLabel metroLabelLessons;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeeID;
        private MetroFramework.Controls.MetroTextBox textBoxLessons;
        private MetroFramework.Controls.MetroComboBox comboBoxSubject;
        private System.Windows.Forms.BindingSource subjectBS;
        private DSTableAdapters.SUBJECTTableAdapter subjectTA;
        private DSTableAdapters.STUDENT_PROFILETableAdapter student_profileTA;
        private MetroFramework.Controls.MetroLabel LabelTimeOut;
        private MetroFramework.Controls.MetroLabel LabelTimeIn;
        private MetroFramework.Controls.MetroTile metroTileCancel;
        private MetroFramework.Controls.MetroTile metroTileSubmit;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.DateTimePicker dateTimeIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.BindingNavigator attendanceBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DSTableAdapters.STAFF_ATTENDANCETableAdapter staff_attTA;
        private MetroFramework.Controls.MetroDateTime dateTimeAttendance;
    }
}