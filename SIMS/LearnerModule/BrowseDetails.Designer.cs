namespace SIMS.LearnerModule
{
    partial class BrowseDetails
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
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.TAStudent = new SIMS.DSTableAdapters.STUDENTTableAdapter();
            this.metroTileUpdateLearner = new MetroFramework.Controls.MetroTile();
            this.metroTileSearchLearner = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxSearchLearner = new MetroFramework.Controls.MetroTextBox();
            this.aDMISIONNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMITTEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBURB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.metroGridViewLearner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridViewLearner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridViewLearner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridViewLearner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridViewLearner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridViewLearner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridViewLearner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDMISIONNODataGridViewTextBoxColumn,
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridViewLearner.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGridViewLearner.EnableHeadersVisualStyles = false;
            this.metroGridViewLearner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridViewLearner.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridViewLearner.Location = new System.Drawing.Point(71, 101);
            this.metroGridViewLearner.Name = "metroGridViewLearner";
            this.metroGridViewLearner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridViewLearner.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGridViewLearner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridViewLearner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridViewLearner.Size = new System.Drawing.Size(939, 442);
            this.metroGridViewLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridViewLearner.TabIndex = 0;
            this.metroGridViewLearner.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAStudent
            // 
            this.TAStudent.ClearBeforeFill = true;
            // 
            // metroTileUpdateLearner
            // 
            this.metroTileUpdateLearner.ActiveControl = null;
            this.metroTileUpdateLearner.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTileUpdateLearner.Location = new System.Drawing.Point(852, 540);
            this.metroTileUpdateLearner.Name = "metroTileUpdateLearner";
            this.metroTileUpdateLearner.Size = new System.Drawing.Size(158, 33);
            this.metroTileUpdateLearner.TabIndex = 1;
            this.metroTileUpdateLearner.Text = "Save Changes";
            this.metroTileUpdateLearner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileUpdateLearner.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileUpdateLearner.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileUpdateLearner.UseSelectable = true;
            this.metroTileUpdateLearner.Click += new System.EventHandler(this.metroTileUpdateLearner_Click);
            // 
            // metroTileSearchLearner
            // 
            this.metroTileSearchLearner.ActiveControl = null;
            this.metroTileSearchLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileSearchLearner.Location = new System.Drawing.Point(303, 64);
            this.metroTileSearchLearner.Name = "metroTileSearchLearner";
            this.metroTileSearchLearner.Size = new System.Drawing.Size(191, 23);
            this.metroTileSearchLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSearchLearner.TabIndex = 2;
            this.metroTileSearchLearner.Text = "Search Learner by Surname";
            this.metroTileSearchLearner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSearchLearner.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSearchLearner.UseSelectable = true;
            this.metroTileSearchLearner.UseStyleColors = true;
            this.metroTileSearchLearner.Click += new System.EventHandler(this.metroTileSearchLearner_Click);
            // 
            // metroTextBoxSearchLearner
            // 
            this.metroTextBoxSearchLearner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxSearchLearner.Lines = new string[0];
            this.metroTextBoxSearchLearner.Location = new System.Drawing.Point(534, 64);
            this.metroTextBoxSearchLearner.MaxLength = 32767;
            this.metroTextBoxSearchLearner.Name = "metroTextBoxSearchLearner";
            this.metroTextBoxSearchLearner.PasswordChar = '\0';
            this.metroTextBoxSearchLearner.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearchLearner.SelectedText = "";
            this.metroTextBoxSearchLearner.Size = new System.Drawing.Size(260, 23);
            this.metroTextBoxSearchLearner.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxSearchLearner.TabIndex = 3;
            this.metroTextBoxSearchLearner.UseSelectable = true;
            this.metroTextBoxSearchLearner.UseStyleColors = true;
            // 
            // aDMISIONNODataGridViewTextBoxColumn
            // 
            this.aDMISIONNODataGridViewTextBoxColumn.DataPropertyName = "ADMISION_NO";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDMISIONNODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.aDMISIONNODataGridViewTextBoxColumn.HeaderText = "Admission No";
            this.aDMISIONNODataGridViewTextBoxColumn.Name = "aDMISIONNODataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIRSTNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lASTNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTGENDERDataGridViewTextBoxColumn
            // 
            this.sTUDENTGENDERDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_GENDER";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTGENDERDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sTUDENTGENDERDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.sTUDENTGENDERDataGridViewTextBoxColumn.Name = "sTUDENTGENDERDataGridViewTextBoxColumn";
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHONENUMBERDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            // 
            // aDMITTEDDATEDataGridViewTextBoxColumn
            // 
            this.aDMITTEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ADMITTED_DATE";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDMITTEDDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.aDMITTEDDATEDataGridViewTextBoxColumn.HeaderText = "Admitted Date";
            this.aDMITTEDDATEDataGridViewTextBoxColumn.Name = "aDMITTEDDATEDataGridViewTextBoxColumn";
            // 
            // sTUDENTCITIZENIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_CITIZEN_ID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.HeaderText = "Citizen ID";
            this.sTUDENTCITIZENIDDataGridViewTextBoxColumn.Name = "sTUDENTCITIZENIDDataGridViewTextBoxColumn";
            // 
            // SUBURB
            // 
            this.SUBURB.DataPropertyName = "SUBURB";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBURB.DefaultCellStyle = dataGridViewCellStyle9;
            this.SUBURB.HeaderText = "Home";
            this.SUBURB.Name = "SUBURB";
            // 
            // cENTREDataGridViewTextBoxColumn
            // 
            this.cENTREDataGridViewTextBoxColumn.DataPropertyName = "CENTRE";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cENTREDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.cENTREDataGridViewTextBoxColumn.HeaderText = "Centre";
            this.cENTREDataGridViewTextBoxColumn.Name = "cENTREDataGridViewTextBoxColumn";
            // 
            // BrowseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 583);
            this.Controls.Add(this.metroTextBoxSearchLearner);
            this.Controls.Add(this.metroTileSearchLearner);
            this.Controls.Add(this.metroTileUpdateLearner);
            this.Controls.Add(this.metroGridViewLearner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowseDetails";
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