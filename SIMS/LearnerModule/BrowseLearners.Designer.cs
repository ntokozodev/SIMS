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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridViewLearner = new MetroFramework.Controls.MetroGrid();
            this.AdmissionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMITTEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBURB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.metroTileUpdateLearner = new MetroFramework.Controls.MetroTile();
            this.metroTileSearchLearner = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxSearchLearner = new MetroFramework.Controls.MetroTextBox();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroTileFilter = new MetroFramework.Controls.MetroTile();
            this.TAStudent = new SIMS.DSTableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridViewLearner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridViewLearner
            // 
            this.metroGridViewLearner.AllowUserToAddRows = false;
            this.metroGridViewLearner.AllowUserToDeleteRows = false;
            this.metroGridViewLearner.AllowUserToOrderColumns = true;
            this.metroGridViewLearner.AllowUserToResizeRows = false;
            this.metroGridViewLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroGridViewLearner.AutoGenerateColumns = false;
            this.metroGridViewLearner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridViewLearner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridViewLearner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridViewLearner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridViewLearner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridViewLearner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridViewLearner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdmissionNo,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTGENDERDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.aDMITTEDDATEDataGridViewTextBoxColumn,
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn,
            this.SUBURB,
            this.cENTREDataGridViewTextBoxColumn});
            this.metroGridViewLearner.DataSource = this.sTUDENTBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridViewLearner.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGridViewLearner.EnableHeadersVisualStyles = false;
            this.metroGridViewLearner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridViewLearner.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridViewLearner.Location = new System.Drawing.Point(51, 101);
            this.metroGridViewLearner.Name = "metroGridViewLearner";
            this.metroGridViewLearner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridViewLearner.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGridViewLearner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridViewLearner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridViewLearner.Size = new System.Drawing.Size(980, 442);
            this.metroGridViewLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridViewLearner.TabIndex = 0;
            this.metroGridViewLearner.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // AdmissionNo
            // 
            this.AdmissionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdmissionNo.DataPropertyName = "ADMISSION_NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmissionNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdmissionNo.HeaderText = "Admission No";
            this.AdmissionNo.Name = "AdmissionNo";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIRSTNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lASTNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTGENDERDataGridViewTextBoxColumn
            // 
            this.sTUDENTGENDERDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_GENDER";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTGENDERDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sTUDENTGENDERDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.sTUDENTGENDERDataGridViewTextBoxColumn.Name = "sTUDENTGENDERDataGridViewTextBoxColumn";
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHONENUMBERDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            // 
            // aDMITTEDDATEDataGridViewTextBoxColumn
            // 
            this.aDMITTEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ADMITTED_DATE";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDMITTEDDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.aDMITTEDDATEDataGridViewTextBoxColumn.HeaderText = "Admitted Date";
            this.aDMITTEDDATEDataGridViewTextBoxColumn.Name = "aDMITTEDDATEDataGridViewTextBoxColumn";
            // 
            // sTUDENTCITIZENIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_CITIZEN_ID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.HeaderText = "Citizen ID";
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.Name = "sTUDENTCITIZENIDDataGridViewTextBoxColumn";
            // 
            // SUBURB
            // 
            this.SUBURB.DataPropertyName = "SUBURB";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBURB.DefaultCellStyle = dataGridViewCellStyle9;
            this.SUBURB.HeaderText = "Home";
            this.SUBURB.Name = "SUBURB";
            // 
            // cENTREDataGridViewTextBoxColumn
            // 
            this.cENTREDataGridViewTextBoxColumn.DataPropertyName = "CENTRE";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cENTREDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.cENTREDataGridViewTextBoxColumn.HeaderText = "Centre";
            this.cENTREDataGridViewTextBoxColumn.Name = "cENTREDataGridViewTextBoxColumn";
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
            this.metroTileUpdateLearner.Location = new System.Drawing.Point(788, 558);
            this.metroTileUpdateLearner.Name = "metroTileUpdateLearner";
            this.metroTileUpdateLearner.Size = new System.Drawing.Size(108, 23);
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
            this.metroTileClose.Location = new System.Drawing.Point(902, 558);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(108, 23);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 4;
            this.metroTileClose.Text = "Close";
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
            "Admitted Date",
            "Last Name"});
            this.metroComboBoxFilter.Location = new System.Drawing.Point(812, 66);
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
            this.metroTileFilter.Location = new System.Drawing.Point(941, 66);
            this.metroTileFilter.Name = "metroTileFilter";
            this.metroTileFilter.Size = new System.Drawing.Size(90, 29);
            this.metroTileFilter.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileFilter.TabIndex = 8;
            this.metroTileFilter.Text = "Filter";
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
            // BrowseLearners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 583);
            this.Controls.Add(this.metroTileFilter);
            this.Controls.Add(this.metroComboBoxFilter);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.metroTextBoxSearchLearner);
            this.Controls.Add(this.metroTileSearchLearner);
            this.Controls.Add(this.metroTileUpdateLearner);
            this.Controls.Add(this.metroGridViewLearner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowseLearners";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Learner Details";
            this.Load += new System.EventHandler(this.BrowseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridViewLearner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridViewLearner;
        private DS dS;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private DSTableAdapters.STUDENTTableAdapter TAStudent;
        private MetroFramework.Controls.MetroTile metroTileUpdateLearner;
        private MetroFramework.Controls.MetroTile metroTileSearchLearner;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchLearner;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMISIONNODataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFilter;
        private MetroFramework.Controls.MetroTile metroTileFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMITTEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTCITIZENIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBURB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENTREDataGridViewTextBoxColumn;

    }
}