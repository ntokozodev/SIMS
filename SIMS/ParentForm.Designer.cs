namespace SIMS
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.exitTile = new MetroFramework.Controls.MetroTile();
            this.ParentButtonPanel = new MetroFramework.Controls.MetroPanel();
            this.LearnerModuleTile = new MetroFramework.Controls.MetroTile();
            this.StudentMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addNewLearnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseLearnerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessControlTile = new MetroFramework.Controls.MetroTile();
            this.AdminMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePwordStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTile = new MetroFramework.Controls.MetroTile();
            this.aboutTile = new MetroFramework.Controls.MetroTile();
            this.StaffTile = new MetroFramework.Controls.MetroTile();
            this.EmployeeMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addNewStaffMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseStaffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordStaffAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStaffGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.AccountsMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printExpensePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordStudentPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordStaffSalaryPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseStaffPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.mainPanelContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.clearAllControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParentButtonPanel.SuspendLayout();
            this.StudentMenu.SuspendLayout();
            this.AdminMenu.SuspendLayout();
            this.EmployeeMenu.SuspendLayout();
            this.AccountsMenu.SuspendLayout();
            this.mainPanelContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitTile
            // 
            this.exitTile.ActiveControl = null;
            this.exitTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitTile.Location = new System.Drawing.Point(20, 684);
            this.exitTile.Name = "exitTile";
            this.exitTile.Size = new System.Drawing.Size(1134, 42);
            this.exitTile.Style = MetroFramework.MetroColorStyle.Green;
            this.exitTile.TabIndex = 1;
            this.exitTile.Text = "Close Application";
            this.exitTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.exitTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.exitTile.UseSelectable = true;
            this.exitTile.UseStyleColors = true;
            this.exitTile.Click += new System.EventHandler(this.exitTile_Click);
            // 
            // ParentButtonPanel
            // 
            this.ParentButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentButtonPanel.Controls.Add(this.LearnerModuleTile);
            this.ParentButtonPanel.Controls.Add(this.accessControlTile);
            this.ParentButtonPanel.Controls.Add(this.helpTile);
            this.ParentButtonPanel.Controls.Add(this.aboutTile);
            this.ParentButtonPanel.Controls.Add(this.StaffTile);
            this.ParentButtonPanel.Controls.Add(this.metroTile2);
            this.ParentButtonPanel.HorizontalScrollbarBarColor = true;
            this.ParentButtonPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ParentButtonPanel.HorizontalScrollbarSize = 10;
            this.ParentButtonPanel.Location = new System.Drawing.Point(20, 54);
            this.ParentButtonPanel.Name = "ParentButtonPanel";
            this.ParentButtonPanel.Size = new System.Drawing.Size(1134, 38);
            this.ParentButtonPanel.Style = MetroFramework.MetroColorStyle.Black;
            this.ParentButtonPanel.TabIndex = 4;
            this.ParentButtonPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ParentButtonPanel.VerticalScrollbarBarColor = true;
            this.ParentButtonPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ParentButtonPanel.VerticalScrollbarSize = 10;
            // 
            // LearnerModuleTile
            // 
            this.LearnerModuleTile.ActiveControl = null;
            this.LearnerModuleTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LearnerModuleTile.ContextMenuStrip = this.StudentMenu;
            this.LearnerModuleTile.Location = new System.Drawing.Point(565, 1);
            this.LearnerModuleTile.Name = "LearnerModuleTile";
            this.LearnerModuleTile.Size = new System.Drawing.Size(170, 27);
            this.LearnerModuleTile.Style = MetroFramework.MetroColorStyle.Brown;
            this.LearnerModuleTile.TabIndex = 2;
            this.LearnerModuleTile.Text = "Student Enrolment";
            this.LearnerModuleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LearnerModuleTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LearnerModuleTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LearnerModuleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.LearnerModuleTile.UseSelectable = true;
            // 
            // StudentMenu
            // 
            this.StudentMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.StudentMenu.BackColor = System.Drawing.Color.Chocolate;
            this.StudentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLearnerToolStripMenuItem,
            this.browseLearnerDetailsToolStripMenuItem,
            this.registerStudentToolStripMenuItem});
            this.StudentMenu.Name = "StudentMenu";
            this.StudentMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StudentMenu.ShowImageMargin = false;
            this.StudentMenu.Size = new System.Drawing.Size(209, 82);
            this.StudentMenu.Style = MetroFramework.MetroColorStyle.Brown;
            this.StudentMenu.Text = "StudentMenu";
            this.StudentMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StudentMenu.UseStyleColors = true;
            // 
            // addNewLearnerToolStripMenuItem
            // 
            this.addNewLearnerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addNewLearnerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addNewLearnerToolStripMenuItem.Name = "addNewLearnerToolStripMenuItem";
            this.addNewLearnerToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.addNewLearnerToolStripMenuItem.Text = "Add New Student";
            this.addNewLearnerToolStripMenuItem.Click += new System.EventHandler(this.addNewLearnerToolStripMenuItem_Click);
            // 
            // browseLearnerDetailsToolStripMenuItem
            // 
            this.browseLearnerDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.browseLearnerDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.browseLearnerDetailsToolStripMenuItem.Name = "browseLearnerDetailsToolStripMenuItem";
            this.browseLearnerDetailsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.browseLearnerDetailsToolStripMenuItem.Text = "View Learner Details";
            this.browseLearnerDetailsToolStripMenuItem.Click += new System.EventHandler(this.browseLearnerDetailsToolStripMenuItem_Click);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.registerStudentToolStripMenuItem.Text = "Register Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // accessControlTile
            // 
            this.accessControlTile.ActiveControl = null;
            this.accessControlTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accessControlTile.ContextMenuStrip = this.AdminMenu;
            this.accessControlTile.Location = new System.Drawing.Point(37, 1);
            this.accessControlTile.Name = "accessControlTile";
            this.accessControlTile.Size = new System.Drawing.Size(170, 27);
            this.accessControlTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.accessControlTile.TabIndex = 2;
            this.accessControlTile.Text = "Admin Control";
            this.accessControlTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accessControlTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.accessControlTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.accessControlTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.accessControlTile.UseSelectable = true;
            // 
            // AdminMenu
            // 
            this.AdminMenu.BackColor = System.Drawing.Color.Purple;
            this.AdminMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AdminMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.changePwordStripMenuItem,
            this.addCentreToolStripMenuItem,
            this.addNewSubjectToolStripMenuItem});
            this.AdminMenu.Name = "AccessMenu";
            this.AdminMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AdminMenu.ShowImageMargin = false;
            this.AdminMenu.Size = new System.Drawing.Size(190, 108);
            this.AdminMenu.Style = MetroFramework.MetroColorStyle.Purple;
            this.AdminMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AdminMenu.UseStyleColors = true;
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // changePwordStripMenuItem
            // 
            this.changePwordStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.changePwordStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.changePwordStripMenuItem.Name = "changePwordStripMenuItem";
            this.changePwordStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.changePwordStripMenuItem.Text = "Change Password";
            this.changePwordStripMenuItem.Click += new System.EventHandler(this.changePwordStripMenuItem_Click);
            // 
            // addCentreToolStripMenuItem
            // 
            this.addCentreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCentreToolStripMenuItem.Name = "addCentreToolStripMenuItem";
            this.addCentreToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.addCentreToolStripMenuItem.Text = "Add Centre";
            // 
            // addNewSubjectToolStripMenuItem
            // 
            this.addNewSubjectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSubjectToolStripMenuItem.Name = "addNewSubjectToolStripMenuItem";
            this.addNewSubjectToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.addNewSubjectToolStripMenuItem.Text = "Add New Subject";
            // 
            // helpTile
            // 
            this.helpTile.ActiveControl = null;
            this.helpTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpTile.Location = new System.Drawing.Point(917, 1);
            this.helpTile.Name = "helpTile";
            this.helpTile.Size = new System.Drawing.Size(170, 27);
            this.helpTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.helpTile.TabIndex = 6;
            this.helpTile.Text = "Help";
            this.helpTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.helpTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.helpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.helpTile.UseSelectable = true;
            this.helpTile.UseStyleColors = true;
            // 
            // aboutTile
            // 
            this.aboutTile.ActiveControl = null;
            this.aboutTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aboutTile.Location = new System.Drawing.Point(741, 1);
            this.aboutTile.Name = "aboutTile";
            this.aboutTile.Size = new System.Drawing.Size(170, 27);
            this.aboutTile.Style = MetroFramework.MetroColorStyle.Red;
            this.aboutTile.TabIndex = 5;
            this.aboutTile.Text = "About SIMS";
            this.aboutTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aboutTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.aboutTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.aboutTile.UseSelectable = true;
            this.aboutTile.UseStyleColors = true;
            this.aboutTile.Click += new System.EventHandler(this.aboutTile_Click);
            // 
            // StaffTile
            // 
            this.StaffTile.ActiveControl = null;
            this.StaffTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StaffTile.ContextMenuStrip = this.EmployeeMenu;
            this.StaffTile.Location = new System.Drawing.Point(389, 1);
            this.StaffTile.Name = "StaffTile";
            this.StaffTile.Size = new System.Drawing.Size(170, 27);
            this.StaffTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.StaffTile.TabIndex = 4;
            this.StaffTile.Text = "Employee Module";
            this.StaffTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StaffTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StaffTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.StaffTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.StaffTile.UseSelectable = true;
            // 
            // EmployeeMenu
            // 
            this.EmployeeMenu.BackColor = System.Drawing.Color.GreenYellow;
            this.EmployeeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStaffMemberToolStripMenuItem,
            this.browseStaffDetailsToolStripMenuItem,
            this.recordStaffAttendanceToolStripMenuItem,
            this.addNewStaffGradeToolStripMenuItem,
            this.changeGradeToolStripMenuItem});
            this.EmployeeMenu.Name = "EmployeeMenu";
            this.EmployeeMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.EmployeeMenu.ShowImageMargin = false;
            this.EmployeeMenu.Size = new System.Drawing.Size(238, 134);
            // 
            // addNewStaffMemberToolStripMenuItem
            // 
            this.addNewStaffMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStaffMemberToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addNewStaffMemberToolStripMenuItem.Name = "addNewStaffMemberToolStripMenuItem";
            this.addNewStaffMemberToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.addNewStaffMemberToolStripMenuItem.Text = "Add New Staff Member";
            this.addNewStaffMemberToolStripMenuItem.Click += new System.EventHandler(this.addNewStaffMemberToolStripMenuItem_Click);
            // 
            // browseStaffDetailsToolStripMenuItem
            // 
            this.browseStaffDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseStaffDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.browseStaffDetailsToolStripMenuItem.Name = "browseStaffDetailsToolStripMenuItem";
            this.browseStaffDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.browseStaffDetailsToolStripMenuItem.Text = "Browse Staff Details";
            this.browseStaffDetailsToolStripMenuItem.Click += new System.EventHandler(this.browseStaffDetailsToolStripMenuItem_Click);
            // 
            // recordStaffAttendanceToolStripMenuItem
            // 
            this.recordStaffAttendanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordStaffAttendanceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.recordStaffAttendanceToolStripMenuItem.Name = "recordStaffAttendanceToolStripMenuItem";
            this.recordStaffAttendanceToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.recordStaffAttendanceToolStripMenuItem.Text = "Record Staff Attendance";
            this.recordStaffAttendanceToolStripMenuItem.Click += new System.EventHandler(this.recordStaffAttendanceToolStripMenuItem_Click);
            // 
            // addNewStaffGradeToolStripMenuItem
            // 
            this.addNewStaffGradeToolStripMenuItem.Name = "addNewStaffGradeToolStripMenuItem";
            this.addNewStaffGradeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            // 
            // changeGradeToolStripMenuItem
            // 
            this.changeGradeToolStripMenuItem.Name = "changeGradeToolStripMenuItem";
            this.changeGradeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile2.ContextMenuStrip = this.AccountsMenu;
            this.metroTile2.Location = new System.Drawing.Point(213, 1);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(170, 27);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Accounts Module";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            // 
            // AccountsMenu
            // 
            this.AccountsMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AccountsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AccountsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expensesToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.staffHoursToolStripMenuItem});
            this.AccountsMenu.Name = "AccountsMenu";
            this.AccountsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AccountsMenu.ShowImageMargin = false;
            this.AccountsMenu.Size = new System.Drawing.Size(141, 108);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.CheckOnClick = true;
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseTypeToolStripMenuItem,
            this.viewExpensesToolStripMenuItem,
            this.printExpensePaymentsToolStripMenuItem});
            this.expensesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // addExpenseTypeToolStripMenuItem
            // 
            this.addExpenseTypeToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addExpenseTypeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addExpenseTypeToolStripMenuItem.Name = "addExpenseTypeToolStripMenuItem";
            this.addExpenseTypeToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.addExpenseTypeToolStripMenuItem.Text = "Expenses and Payments";
            this.addExpenseTypeToolStripMenuItem.Click += new System.EventHandler(this.addExpenseTypeToolStripMenuItem_Click);
            // 
            // viewExpensesToolStripMenuItem
            // 
            this.viewExpensesToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.viewExpensesToolStripMenuItem.Name = "viewExpensesToolStripMenuItem";
            this.viewExpensesToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.viewExpensesToolStripMenuItem.Text = "View Expenses";
            this.viewExpensesToolStripMenuItem.Click += new System.EventHandler(this.viewExpensesToolStripMenuItem_Click);
            // 
            // printExpensePaymentsToolStripMenuItem
            // 
            this.printExpensePaymentsToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.printExpensePaymentsToolStripMenuItem.Name = "printExpensePaymentsToolStripMenuItem";
            this.printExpensePaymentsToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.printExpensePaymentsToolStripMenuItem.Text = "Record Staff Salary Expenses";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordStudentPaymentToolStripMenuItem,
            this.recordStaffSalaryPaymentToolStripMenuItem,
            this.browseStaffPaymentsToolStripMenuItem});
            this.paymentsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // recordStudentPaymentToolStripMenuItem
            // 
            this.recordStudentPaymentToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.recordStudentPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordStudentPaymentToolStripMenuItem.Name = "recordStudentPaymentToolStripMenuItem";
            this.recordStudentPaymentToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.recordStudentPaymentToolStripMenuItem.Text = "Record Student Payment";
            this.recordStudentPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordStudentPaymentToolStripMenuItem_Click);
            // 
            // recordStaffSalaryPaymentToolStripMenuItem
            // 
            this.recordStaffSalaryPaymentToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.recordStaffSalaryPaymentToolStripMenuItem.Name = "recordStaffSalaryPaymentToolStripMenuItem";
            this.recordStaffSalaryPaymentToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.recordStaffSalaryPaymentToolStripMenuItem.Text = "Record Staff Salary Payment";
            this.recordStaffSalaryPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordStaffSalaryPaymentToolStripMenuItem_Click);
            // 
            // browseStaffPaymentsToolStripMenuItem
            // 
            this.browseStaffPaymentsToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browseStaffPaymentsToolStripMenuItem.Name = "browseStaffPaymentsToolStripMenuItem";
            this.browseStaffPaymentsToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.browseStaffPaymentsToolStripMenuItem.Text = "Browse Staff Payments";
            this.browseStaffPaymentsToolStripMenuItem.Click += new System.EventHandler(this.browseStaffPaymentsToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.feesToolStripMenuItem.Text = "Due Fees";
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
            // 
            // staffHoursToolStripMenuItem
            // 
            this.staffHoursToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.staffHoursToolStripMenuItem.Name = "staffHoursToolStripMenuItem";
            this.staffHoursToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.staffHoursToolStripMenuItem.Text = "Staff Hours";
            this.staffHoursToolStripMenuItem.Click += new System.EventHandler(this.staffHoursToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.ContextMenuStrip = this.mainPanelContextMenu;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(20, 88);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1134, 599);
            this.MainPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // mainPanelContextMenu
            // 
            this.mainPanelContextMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.mainPanelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllControlsToolStripMenuItem});
            this.mainPanelContextMenu.Name = "mainPanelContextMenu";
            this.mainPanelContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainPanelContextMenu.ShowImageMargin = false;
            this.mainPanelContextMenu.Size = new System.Drawing.Size(185, 30);
            // 
            // clearAllControlsToolStripMenuItem
            // 
            this.clearAllControlsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllControlsToolStripMenuItem.Name = "clearAllControlsToolStripMenuItem";
            this.clearAllControlsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.clearAllControlsToolStripMenuItem.Text = "Clear All Controls";
            this.clearAllControlsToolStripMenuItem.Click += new System.EventHandler(this.clearAllControlsToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 746);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ParentButtonPanel);
            this.Controls.Add(this.exitTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.Opacity = 0.95D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "School Information Management System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.ParentButtonPanel.ResumeLayout(false);
            this.StudentMenu.ResumeLayout(false);
            this.AdminMenu.ResumeLayout(false);
            this.EmployeeMenu.ResumeLayout(false);
            this.AccountsMenu.ResumeLayout(false);
            this.mainPanelContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile exitTile;
        private MetroFramework.Controls.MetroPanel ParentButtonPanel;
        private MetroFramework.Controls.MetroTile StaffTile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile aboutTile;
        private MetroFramework.Controls.MetroTile LearnerModuleTile;
        private MetroFramework.Controls.MetroTile accessControlTile;
        private MetroFramework.Controls.MetroContextMenu StudentMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewLearnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseLearnerDetailsToolStripMenuItem;
        private MetroFramework.Controls.MetroTile helpTile;
        private MetroFramework.Controls.MetroContextMenu AdminMenu;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePwordStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu AccountsMenu;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordStudentPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordStaffSalaryPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseStaffPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffHoursToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu EmployeeMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewStaffMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseStaffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordStaffAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStaffGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGradeToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu mainPanelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearAllControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCentreToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem printExpensePaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSubjectToolStripMenuItem;
    }
}

