namespace SIMS.AccessControl
{
    partial class AddUser
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
            this.employeeDGV = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDS = new SIMS.DS();
            this.employeeTA = new SIMS.DSTableAdapters.EMPLOYEETableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTileAdd = new MetroFramework.Controls.MetroTile();
            this.TextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroTileSearch = new MetroFramework.Controls.MetroTile();
            this.usersTA = new SIMS.DSTableAdapters.SIMS_USERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDGV
            // 
            this.employeeDGV.AllowUserToAddRows = false;
            this.employeeDGV.AllowUserToDeleteRows = false;
            this.employeeDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeDGV.AutoGenerateColumns = false;
            this.employeeDGV.BackgroundColor = System.Drawing.Color.White;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.rOLEDataGridViewTextBoxColumn,
            this.hIREDATEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.employeeDGV.DataSource = this.eMPLOYEEBindingSource;
            this.employeeDGV.Location = new System.Drawing.Point(85, 19);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.ReadOnly = true;
            this.employeeDGV.Size = new System.Drawing.Size(813, 414);
            this.employeeDGV.TabIndex = 0;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            this.sURNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOLEDataGridViewTextBoxColumn
            // 
            this.rOLEDataGridViewTextBoxColumn.DataPropertyName = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.HeaderText = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.Name = "rOLEDataGridViewTextBoxColumn";
            this.rOLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hIREDATEDataGridViewTextBoxColumn
            // 
            this.hIREDATEDataGridViewTextBoxColumn.DataPropertyName = "HIRE_DATE";
            this.hIREDATEDataGridViewTextBoxColumn.HeaderText = "HIRE DATE";
            this.hIREDATEDataGridViewTextBoxColumn.Name = "hIREDATEDataGridViewTextBoxColumn";
            this.hIREDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.employeeDS;
            // 
            // employeeDS
            // 
            this.employeeDS.DataSetName = "DS";
            this.employeeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTA
            // 
            this.employeeTA.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroTileAdd);
            this.groupBox1.Controls.Add(this.employeeDGV);
            this.groupBox1.Location = new System.Drawing.Point(113, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 490);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(276, 449);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(622, 35);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Default username is SurnameEmployeeID password is surname of newly added employee" +
    ".\nE.g. for EmployeeID = 101 and Surname = Smith, the username will be Smith101 a" +
    "nd password will be Smith.";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(223, 459);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "NOTE:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTileAdd
            // 
            this.metroTileAdd.ActiveControl = null;
            this.metroTileAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileAdd.Location = new System.Drawing.Point(85, 448);
            this.metroTileAdd.Name = "metroTileAdd";
            this.metroTileAdd.Size = new System.Drawing.Size(112, 31);
            this.metroTileAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAdd.TabIndex = 1;
            this.metroTileAdd.Text = "Add Selected";
            this.metroTileAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAdd.UseSelectable = true;
            this.metroTileAdd.UseStyleColors = true;
            this.metroTileAdd.Click += new System.EventHandler(this.metroTileAdd_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TextBoxSearch.Lines = new string[0];
            this.TextBoxSearch.Location = new System.Drawing.Point(257, 52);
            this.TextBoxSearch.MaxLength = 32767;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(162, 32);
            this.TextBoxSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxSearch.UseSelectable = true;
            // 
            // metroTileSearch
            // 
            this.metroTileSearch.ActiveControl = null;
            this.metroTileSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileSearch.Location = new System.Drawing.Point(113, 52);
            this.metroTileSearch.Name = "metroTileSearch";
            this.metroTileSearch.Size = new System.Drawing.Size(138, 32);
            this.metroTileSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSearch.TabIndex = 3;
            this.metroTileSearch.Text = "Search by Surname:";
            this.metroTileSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSearch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSearch.UseSelectable = true;
            this.metroTileSearch.UseStyleColors = true;
            this.metroTileSearch.Click += new System.EventHandler(this.metroTileSearch_Click);
            // 
            // usersTA
            // 
            this.usersTA.ClearBeforeFill = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 592);
            this.Controls.Add(this.metroTileSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add User";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDGV;
        private DS employeeDS;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DSTableAdapters.EMPLOYEETableAdapter employeeTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TextBoxSearch;
        private MetroFramework.Controls.MetroTile metroTileSearch;
        private MetroFramework.Controls.MetroTile metroTileAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DSTableAdapters.SIMS_USERSTableAdapter usersTA;
    }
}