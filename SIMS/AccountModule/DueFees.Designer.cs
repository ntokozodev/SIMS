namespace SIMS.AccountModule
{
    partial class DueFees
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
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroGridDueFees = new System.Windows.Forms.DataGridView();
            this.aDMISSIONNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPTUREDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCADEMICYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_paymentBS = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.metroTextBoxTotalDue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTotalDue = new MetroFramework.Controls.MetroLabel();
            this.sTUDENTPAYMENTBS = new System.Windows.Forms.BindingSource(this.components);
            this.stu_paymentTA = new SIMS.DSTableAdapters.STUDENT_PAYMENTTableAdapter();
            this.stu_feeTA = new SIMS.DSTableAdapters.STUDENT_FEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDueFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_paymentBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTPAYMENTBS)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(795, 522);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(148, 31);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTileClose.TabIndex = 7;
            this.metroTileClose.Text = "Close Window";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // metroGridDueFees
            // 
            this.metroGridDueFees.AllowUserToAddRows = false;
            this.metroGridDueFees.AllowUserToDeleteRows = false;
            this.metroGridDueFees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroGridDueFees.AutoGenerateColumns = false;
            this.metroGridDueFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridDueFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDMISSIONNODataGridViewTextBoxColumn,
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn,
            this.pAYMENTTYPEDataGridViewTextBoxColumn,
            this.bALANCEDataGridViewTextBoxColumn,
            this.pAYMENTDATEDataGridViewTextBoxColumn,
            this.cAPTUREDDATEDataGridViewTextBoxColumn,
            this.aCADEMICYEARDataGridViewTextBoxColumn});
            this.metroGridDueFees.DataSource = this.stu_paymentBS;
            this.metroGridDueFees.Location = new System.Drawing.Point(23, 119);
            this.metroGridDueFees.Name = "metroGridDueFees";
            this.metroGridDueFees.ReadOnly = true;
            this.metroGridDueFees.Size = new System.Drawing.Size(920, 369);
            this.metroGridDueFees.TabIndex = 9;
            // 
            // aDMISSIONNODataGridViewTextBoxColumn
            // 
            this.aDMISSIONNODataGridViewTextBoxColumn.DataPropertyName = "ADMISSION_NO";
            this.aDMISSIONNODataGridViewTextBoxColumn.HeaderText = "ADMISSION NO";
            this.aDMISSIONNODataGridViewTextBoxColumn.Name = "aDMISSIONNODataGridViewTextBoxColumn";
            this.aDMISSIONNODataGridViewTextBoxColumn.ReadOnly = true;
            this.aDMISSIONNODataGridViewTextBoxColumn.Width = 115;
            // 
            // pAYMENTAMOUNTDataGridViewTextBoxColumn
            // 
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_AMOUNT";
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn.HeaderText = "PAYMENT AMOUNT";
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn.Name = "pAYMENTAMOUNTDataGridViewTextBoxColumn";
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAYMENTAMOUNTDataGridViewTextBoxColumn.Width = 140;
            // 
            // pAYMENTTYPEDataGridViewTextBoxColumn
            // 
            this.pAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "PAYMENT TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.Name = "pAYMENTTYPEDataGridViewTextBoxColumn";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAYMENTTYPEDataGridViewTextBoxColumn.Width = 130;
            // 
            // bALANCEDataGridViewTextBoxColumn
            // 
            this.bALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.HeaderText = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.Name = "bALANCEDataGridViewTextBoxColumn";
            this.bALANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYMENTDATEDataGridViewTextBoxColumn
            // 
            this.pAYMENTDATEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_DATE";
            this.pAYMENTDATEDataGridViewTextBoxColumn.HeaderText = "PAYMENT DATE";
            this.pAYMENTDATEDataGridViewTextBoxColumn.Name = "pAYMENTDATEDataGridViewTextBoxColumn";
            this.pAYMENTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAYMENTDATEDataGridViewTextBoxColumn.Width = 130;
            // 
            // cAPTUREDDATEDataGridViewTextBoxColumn
            // 
            this.cAPTUREDDATEDataGridViewTextBoxColumn.DataPropertyName = "CAPTURED_DATE";
            this.cAPTUREDDATEDataGridViewTextBoxColumn.HeaderText = "CAPTURED DATE";
            this.cAPTUREDDATEDataGridViewTextBoxColumn.Name = "cAPTUREDDATEDataGridViewTextBoxColumn";
            this.cAPTUREDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cAPTUREDDATEDataGridViewTextBoxColumn.Width = 130;
            // 
            // aCADEMICYEARDataGridViewTextBoxColumn
            // 
            this.aCADEMICYEARDataGridViewTextBoxColumn.DataPropertyName = "ACADEMIC_YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.HeaderText = "ACADEMIC YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.Name = "aCADEMICYEARDataGridViewTextBoxColumn";
            this.aCADEMICYEARDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCADEMICYEARDataGridViewTextBoxColumn.Width = 132;
            // 
            // stu_paymentBS
            // 
            this.stu_paymentBS.DataMember = "STUDENT_PAYMENT";
            this.stu_paymentBS.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTextBoxTotalDue
            // 
            this.metroTextBoxTotalDue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxTotalDue.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxTotalDue.Lines = new string[0];
            this.metroTextBoxTotalDue.Location = new System.Drawing.Point(198, 522);
            this.metroTextBoxTotalDue.MaxLength = 32767;
            this.metroTextBoxTotalDue.Name = "metroTextBoxTotalDue";
            this.metroTextBoxTotalDue.PasswordChar = '\0';
            this.metroTextBoxTotalDue.ReadOnly = true;
            this.metroTextBoxTotalDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTotalDue.SelectedText = "";
            this.metroTextBoxTotalDue.Size = new System.Drawing.Size(135, 31);
            this.metroTextBoxTotalDue.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTotalDue.TabIndex = 8;
            this.metroTextBoxTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroTextBoxTotalDue.UseSelectable = true;
            this.metroTextBoxTotalDue.UseStyleColors = true;
            // 
            // metroLabelTotalDue
            // 
            this.metroLabelTotalDue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabelTotalDue.AutoSize = true;
            this.metroLabelTotalDue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTotalDue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTotalDue.Location = new System.Drawing.Point(23, 528);
            this.metroLabelTotalDue.Name = "metroLabelTotalDue";
            this.metroLabelTotalDue.Size = new System.Drawing.Size(169, 25);
            this.metroLabelTotalDue.TabIndex = 6;
            this.metroLabelTotalDue.Text = "TOTAL BALANCES:";
            this.metroLabelTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTUDENTPAYMENTBS
            // 
            this.sTUDENTPAYMENTBS.DataMember = "STUDENT_PAYMENT";
            this.sTUDENTPAYMENTBS.DataSource = this.dS;
            // 
            // stu_paymentTA
            // 
            this.stu_paymentTA.ClearBeforeFill = true;
            // 
            // stu_feeTA
            // 
            this.stu_feeTA.ClearBeforeFill = true;
            // 
            // DueFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 576);
            this.Controls.Add(this.metroGridDueFees);
            this.Controls.Add(this.metroTextBoxTotalDue);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.metroLabelTotalDue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DueFees";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Student Transactions";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.DueFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDueFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_paymentBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTPAYMENTBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileClose;
        private DS dS;
        private System.Windows.Forms.BindingSource sTUDENTPAYMENTBS;
        private DSTableAdapters.STUDENT_PAYMENTTableAdapter stu_paymentTA;
        private System.Windows.Forms.DataGridView metroGridDueFees;
        private System.Windows.Forms.BindingSource stu_paymentBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMISSIONNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPTUREDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCADEMICYEARDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTotalDue;
        private MetroFramework.Controls.MetroLabel metroLabelTotalDue;
        private DSTableAdapters.STUDENT_FEETableAdapter stu_feeTA;
    }
}