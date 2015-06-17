namespace SIMS.LearnerModule
{
    partial class BrowseLearners
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
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DSS();
            this.metroTileUpdateLearner = new MetroFramework.Controls.MetroTile();
            this.metroTileSearchLearner = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxSearchLearner = new MetroFramework.Controls.MetroTextBox();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroTileFilter = new MetroFramework.Controls.MetroTile();
            this.TAStudent = new SIMS.DSSTableAdapters.STUDENTTableAdapter();
            this.metroGridViewLearner = new System.Windows.Forms.DataGridView();
            this.aDMISSIONNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNROLLEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITIZENIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroTileSearchByAdminNo = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxSearchByAdminNo = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridViewLearner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dS;
            this.sTUDENTBindingSource.Filter = "";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTileUpdateLearner
            // 
            this.metroTileUpdateLearner.ActiveControl = null;
            this.metroTileUpdateLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileUpdateLearner.Location = new System.Drawing.Point(788, 539);
            this.metroTileUpdateLearner.Name = "metroTileUpdateLearner";
            this.metroTileUpdateLearner.Size = new System.Drawing.Size(108, 30);
            this.metroTileUpdateLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileUpdateLearner.TabIndex = 1;
            this.metroTileUpdateLearner.Text = "Save Changes";
            this.metroTileUpdateLearner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileUpdateLearner.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileUpdateLearner.UseSelectable = true;
            this.metroTileUpdateLearner.UseStyleColors = true;
            this.metroTileUpdateLearner.Click += new System.EventHandler(this.metroTileUpdateLearner_Click);
            // 
            // metroTileSearchLearner
            // 
            this.metroTileSearchLearner.ActiveControl = null;
            this.metroTileSearchLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileSearchLearner.Location = new System.Drawing.Point(51, 64);
            this.metroTileSearchLearner.Name = "metroTileSearchLearner";
            this.metroTileSearchLearner.Size = new System.Drawing.Size(136, 31);
            this.metroTileSearchLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSearchLearner.TabIndex = 2;
            this.metroTileSearchLearner.Text = "Search by Surname";
            this.metroTileSearchLearner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSearchLearner.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSearchLearner.UseSelectable = true;
            this.metroTileSearchLearner.UseStyleColors = true;
            this.metroTileSearchLearner.Click += new System.EventHandler(this.metroTileSearchLearner_Click);
            // 
            // metroTextBoxSearchLearner
            // 
            this.metroTextBoxSearchLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxSearchLearner.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxSearchLearner.Lines = new string[0];
            this.metroTextBoxSearchLearner.Location = new System.Drawing.Point(193, 64);
            this.metroTextBoxSearchLearner.MaxLength = 32767;
            this.metroTextBoxSearchLearner.Name = "metroTextBoxSearchLearner";
            this.metroTextBoxSearchLearner.PasswordChar = '\0';
            this.metroTextBoxSearchLearner.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearchLearner.SelectedText = "";
            this.metroTextBoxSearchLearner.Size = new System.Drawing.Size(169, 31);
            this.metroTextBoxSearchLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxSearchLearner.TabIndex = 3;
            this.metroTextBoxSearchLearner.UseSelectable = true;
            this.metroTextBoxSearchLearner.UseStyleColors = true;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(902, 539);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(108, 30);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 4;
            this.metroTileClose.Text = "Close Window";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // metroComboBoxFilter
            // 
            this.metroComboBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroComboBoxFilter.FormattingEnabled = true;
            this.metroComboBoxFilter.ItemHeight = 23;
            this.metroComboBoxFilter.Items.AddRange(new object[] {
            "Admission No",
            "Last Name"});
            this.metroComboBoxFilter.Location = new System.Drawing.Point(887, 66);
            this.metroComboBoxFilter.Name = "metroComboBoxFilter";
            this.metroComboBoxFilter.Size = new System.Drawing.Size(123, 29);
            this.metroComboBoxFilter.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxFilter.TabIndex = 7;
            this.metroComboBoxFilter.UseSelectable = true;
            this.metroComboBoxFilter.UseStyleColors = true;
            // 
            // metroTileFilter
            // 
            this.metroTileFilter.ActiveControl = null;
            this.metroTileFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileFilter.Location = new System.Drawing.Point(791, 66);
            this.metroTileFilter.Name = "metroTileFilter";
            this.metroTileFilter.Size = new System.Drawing.Size(90, 29);
            this.metroTileFilter.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileFilter.TabIndex = 8;
            this.metroTileFilter.Text = "Filter by";
            this.metroTileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFilter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileFilter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileFilter.UseSelectable = true;
            this.metroTileFilter.UseStyleColors = true;
            this.metroTileFilter.Click += new System.EventHandler(this.metroTileFilter_Click);
            // 
            // TAStudent
            // 
            this.TAStudent.ClearBeforeFill = true;
            // 
            // metroGridViewLearner
            // 
            this.metroGridViewLearner.AllowUserToAddRows = false;
            this.metroGridViewLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroGridViewLearner.AutoGenerateColumns = false;
            this.metroGridViewLearner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridViewLearner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDMISSIONNODataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.eNROLLEDDATEDataGridViewTextBoxColumn,
            this.cITIZENIDDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.metroGridViewLearner.DataSource = this.sTUDENTBindingSource1;
            this.metroGridViewLearner.Location = new System.Drawing.Point(51, 124);
            this.metroGridViewLearner.Name = "metroGridViewLearner";
            this.metroGridViewLearner.Size = new System.Drawing.Size(959, 409);
            this.metroGridViewLearner.TabIndex = 9;
            // 
            // aDMISSIONNODataGridViewTextBoxColumn
            // 
            this.aDMISSIONNODataGridViewTextBoxColumn.DataPropertyName = "ADMISSION_NO";
            this.aDMISSIONNODataGridViewTextBoxColumn.HeaderText = "Admission No";
            this.aDMISSIONNODataGridViewTextBoxColumn.Name = "aDMISSIONNODataGridViewTextBoxColumn";
            this.aDMISSIONNODataGridViewTextBoxColumn.Width = 115;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            this.sURNAMEDataGridViewTextBoxColumn.Width = 80;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.Width = 70;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // eNROLLEDDATEDataGridViewTextBoxColumn
            // 
            this.eNROLLEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ENROLLED_DATE";
            this.eNROLLEDDATEDataGridViewTextBoxColumn.HeaderText = "Enrolled Date";
            this.eNROLLEDDATEDataGridViewTextBoxColumn.Name = "eNROLLEDDATEDataGridViewTextBoxColumn";
            this.eNROLLEDDATEDataGridViewTextBoxColumn.Width = 120;
            // 
            // cITIZENIDDataGridViewTextBoxColumn
            // 
            this.cITIZENIDDataGridViewTextBoxColumn.DataPropertyName = "CITIZEN_ID";
            this.cITIZENIDDataGridViewTextBoxColumn.HeaderText = "ID Number";
            this.cITIZENIDDataGridViewTextBoxColumn.Name = "cITIZENIDDataGridViewTextBoxColumn";
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "City";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 130;
            // 
            // sTUDENTBindingSource1
            // 
            this.sTUDENTBindingSource1.DataMember = "STUDENT";
            this.sTUDENTBindingSource1.DataSource = this.dS;
            // 
            // metroTileSearchByAdminNo
            // 
            this.metroTileSearchByAdminNo.ActiveControl = null;
            this.metroTileSearchByAdminNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileSearchByAdminNo.Location = new System.Drawing.Point(402, 63);
            this.metroTileSearchByAdminNo.Name = "metroTileSearchByAdminNo";
            this.metroTileSearchByAdminNo.Size = new System.Drawing.Size(166, 31);
            this.metroTileSearchByAdminNo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSearchByAdminNo.TabIndex = 10;
            this.metroTileSearchByAdminNo.Text = "Search by Admission No";
            this.metroTileSearchByAdminNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSearchByAdminNo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSearchByAdminNo.UseSelectable = true;
            this.metroTileSearchByAdminNo.UseStyleColors = true;
            this.metroTileSearchByAdminNo.Click += new System.EventHandler(this.metroTileSearchByAdminNo_Click_1);
            // 
            // metroTextBoxSearchByAdminNo
            // 
            this.metroTextBoxSearchByAdminNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxSearchByAdminNo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxSearchByAdminNo.Lines = new string[0];
            this.metroTextBoxSearchByAdminNo.Location = new System.Drawing.Point(574, 64);
            this.metroTextBoxSearchByAdminNo.MaxLength = 32767;
            this.metroTextBoxSearchByAdminNo.Name = "metroTextBoxSearchByAdminNo";
            this.metroTextBoxSearchByAdminNo.PasswordChar = '\0';
            this.metroTextBoxSearchByAdminNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearchByAdminNo.SelectedText = "";
            this.metroTextBoxSearchByAdminNo.Size = new System.Drawing.Size(169, 31);
            this.metroTextBoxSearchByAdminNo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxSearchByAdminNo.TabIndex = 11;
            this.metroTextBoxSearchByAdminNo.UseSelectable = true;
            this.metroTextBoxSearchByAdminNo.UseStyleColors = true;
            // 
            // BrowseLearners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 583);
            this.Controls.Add(this.metroTextBoxSearchByAdminNo);
            this.Controls.Add(this.metroTileSearchByAdminNo);
            this.Controls.Add(this.metroGridViewLearner);
            this.Controls.Add(this.metroTileFilter);
            this.Controls.Add(this.metroComboBoxFilter);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.metroTextBoxSearchLearner);
            this.Controls.Add(this.metroTileSearchLearner);
            this.Controls.Add(this.metroTileUpdateLearner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowseLearners";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Learner Details";
            this.Load += new System.EventHandler(this.BrowseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridViewLearner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSS dS;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private DSSTableAdapters.STUDENTTableAdapter TAStudent;
        private MetroFramework.Controls.MetroTile metroTileUpdateLearner;
        private MetroFramework.Controls.MetroTile metroTileSearchLearner;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchLearner;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMISIONNODataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFilter;
        private MetroFramework.Controls.MetroTile metroTileFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMITTEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTCITIZENIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView metroGridViewLearner;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMISSIONNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNROLLEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITIZENIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTileSearchByAdminNo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchByAdminNo;

    }
}