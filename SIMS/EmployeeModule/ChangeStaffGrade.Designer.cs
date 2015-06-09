namespace SIMS.EmployeeModule
{
    partial class ChangeStaffGrade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxStaffGrades = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.gRADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.TAGrade = new SIMS.DSTableAdapters.GRADETableAdapter();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroTileUpdate = new MetroFramework.Controls.MetroTile();
            this.gRADEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRADENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRADERATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxStaffGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStaffGrades
            // 
            this.groupBoxStaffGrades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxStaffGrades.Controls.Add(this.metroGrid1);
            this.groupBoxStaffGrades.Location = new System.Drawing.Point(193, 63);
            this.groupBoxStaffGrades.Name = "groupBoxStaffGrades";
            this.groupBoxStaffGrades.Size = new System.Drawing.Size(555, 341);
            this.groupBoxStaffGrades.TabIndex = 0;
            this.groupBoxStaffGrades.TabStop = false;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRADEIDDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.gRADENAMEDataGridViewTextBoxColumn,
            this.gRADERATEDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.gRADEBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 19);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(543, 316);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 0;
            // 
            // gRADEBindingSource
            // 
            this.gRADEBindingSource.DataMember = "GRADE";
            this.gRADEBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAGrade
            // 
            this.TAGrade.ClearBeforeFill = true;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(631, 427);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(117, 26);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 1;
            this.metroTileClose.Text = "Close Window";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // metroTileUpdate
            // 
            this.metroTileUpdate.ActiveControl = null;
            this.metroTileUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileUpdate.Location = new System.Drawing.Point(492, 427);
            this.metroTileUpdate.Name = "metroTileUpdate";
            this.metroTileUpdate.Size = new System.Drawing.Size(117, 26);
            this.metroTileUpdate.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileUpdate.TabIndex = 2;
            this.metroTileUpdate.Text = "Update Changes";
            this.metroTileUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileUpdate.UseSelectable = true;
            this.metroTileUpdate.UseStyleColors = true;
            this.metroTileUpdate.Click += new System.EventHandler(this.metroTileUpdate_Click);
            // 
            // gRADEIDDataGridViewTextBoxColumn
            // 
            this.gRADEIDDataGridViewTextBoxColumn.DataPropertyName = "GRADE_ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gRADEIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.gRADEIDDataGridViewTextBoxColumn.HeaderText = "GRADE ID";
            this.gRADEIDDataGridViewTextBoxColumn.Name = "gRADEIDDataGridViewTextBoxColumn";
            this.gRADEIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRIPTIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Width = 247;
            // 
            // gRADENAMEDataGridViewTextBoxColumn
            // 
            this.gRADENAMEDataGridViewTextBoxColumn.DataPropertyName = "GRADE_NAME";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gRADENAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.gRADENAMEDataGridViewTextBoxColumn.HeaderText = "GRADE";
            this.gRADENAMEDataGridViewTextBoxColumn.Name = "gRADENAMEDataGridViewTextBoxColumn";
            this.gRADENAMEDataGridViewTextBoxColumn.Width = 75;
            // 
            // gRADERATEDataGridViewTextBoxColumn
            // 
            this.gRADERATEDataGridViewTextBoxColumn.DataPropertyName = "GRADE_RATE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gRADERATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.gRADERATEDataGridViewTextBoxColumn.HeaderText = "GRADE RATE";
            this.gRADERATEDataGridViewTextBoxColumn.Name = "gRADERATEDataGridViewTextBoxColumn";
            // 
            // ChangeStaffGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 476);
            this.Controls.Add(this.metroTileUpdate);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.groupBoxStaffGrades);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeStaffGrade";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Staff Grades";
            this.Load += new System.EventHandler(this.ChangeStaffGrade_Load);
            this.groupBoxStaffGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStaffGrades;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private DS dS;
        private System.Windows.Forms.BindingSource gRADEBindingSource;
        private DSTableAdapters.GRADETableAdapter TAGrade;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroTile metroTileUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADERATEDataGridViewTextBoxColumn;
    }
}