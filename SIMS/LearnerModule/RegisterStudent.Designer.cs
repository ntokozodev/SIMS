namespace SIMS.LearnerModule
{
    partial class RegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroTileRegister = new MetroFramework.Controls.MetroTile();
            this.metroTileClear = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonAccept = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.subjectsDGV = new System.Windows.Forms.DataGridView();
            this.subjectBS = new System.Windows.Forms.BindingSource(this.components);
            this.regDS = new SIMS.DS();
            this.metroTextBoxGrade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxYear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAdminNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.subjectTA = new SIMS.DSTableAdapters.SUBJECTTableAdapter();
            this.studentTA = new SIMS.DSTableAdapters.STUDENTTableAdapter();
            this.student_enrollmentTA = new SIMS.DSTableAdapters.STUDENT_ENROLLMENTTableAdapter();
            this.student_feeTA = new SIMS.DSTableAdapters.STUDENT_FEETableAdapter();
            this.student_paymentTA = new SIMS.DSTableAdapters.STUDENT_PAYMENTTableAdapter();
            this.sUBJECTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBJECTCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDS)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.Location = new System.Drawing.Point(79, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(934, 51);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // metroTileRegister
            // 
            this.metroTileRegister.ActiveControl = null;
            this.metroTileRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileRegister.Location = new System.Drawing.Point(353, 316);
            this.metroTileRegister.Name = "metroTileRegister";
            this.metroTileRegister.Size = new System.Drawing.Size(112, 31);
            this.metroTileRegister.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileRegister.TabIndex = 4;
            this.metroTileRegister.Text = "Register";
            this.metroTileRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRegister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileRegister.UseSelectable = true;
            this.metroTileRegister.UseStyleColors = true;
            this.metroTileRegister.Click += new System.EventHandler(this.metroTileRegister_Click);
            // 
            // metroTileClear
            // 
            this.metroTileClear.ActiveControl = null;
            this.metroTileClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClear.Location = new System.Drawing.Point(258, 187);
            this.metroTileClear.Name = "metroTileClear";
            this.metroTileClear.Size = new System.Drawing.Size(75, 23);
            this.metroTileClear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClear.TabIndex = 5;
            this.metroTileClear.Text = "Clear";
            this.metroTileClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileClear.UseSelectable = true;
            this.metroTileClear.UseStyleColors = true;
            this.metroTileClear.Click += new System.EventHandler(this.metroTileClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.RadioButtonAccept);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terms and Conditions";
            // 
            // RadioButtonAccept
            // 
            this.RadioButtonAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButtonAccept.AutoSize = true;
            this.RadioButtonAccept.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioButtonAccept.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.RadioButtonAccept.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonAccept.Name = "RadioButtonAccept";
            this.RadioButtonAccept.Size = new System.Drawing.Size(71, 19);
            this.RadioButtonAccept.Style = MetroFramework.MetroColorStyle.Green;
            this.RadioButtonAccept.TabIndex = 3;
            this.RadioButtonAccept.Text = "Accept";
            this.RadioButtonAccept.UseSelectable = true;
            this.RadioButtonAccept.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.metroTileClose);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.metroTextBoxGrade);
            this.groupBox2.Controls.Add(this.metroTileRegister);
            this.groupBox2.Controls.Add(this.metroTileClear);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroTextBoxYear);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroTextBoxAdminNo);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 435);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(764, 316);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(112, 31);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 9;
            this.metroTileClose.Text = "Close Window";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.subjectsDGV);
            this.groupBox3.Location = new System.Drawing.Point(353, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 275);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subjects Selection";
            // 
            // subjectsDGV
            // 
            this.subjectsDGV.AllowUserToAddRows = false;
            this.subjectsDGV.AllowUserToDeleteRows = false;
            this.subjectsDGV.AutoGenerateColumns = false;
            this.subjectsDGV.BackgroundColor = System.Drawing.Color.White;
            this.subjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUBJECTCODEDataGridViewTextBoxColumn,
            this.SUBJECT,
            this.sUBJECTCOSTDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn});
            this.subjectsDGV.DataSource = this.subjectBS;
            this.subjectsDGV.Location = new System.Drawing.Point(6, 19);
            this.subjectsDGV.Name = "subjectsDGV";
            this.subjectsDGV.Size = new System.Drawing.Size(509, 245);
            this.subjectsDGV.TabIndex = 0;
            // 
            // subjectBS
            // 
            this.subjectBS.DataMember = "SUBJECT";
            this.subjectBS.DataSource = this.regDS;
            // 
            // regDS
            // 
            this.regDS.DataSetName = "DSS";
            this.regDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTextBoxGrade
            // 
            this.metroTextBoxGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxGrade.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxGrade.Lines = new string[0];
            this.metroTextBoxGrade.Location = new System.Drawing.Point(189, 135);
            this.metroTextBoxGrade.MaxLength = 32767;
            this.metroTextBoxGrade.Name = "metroTextBoxGrade";
            this.metroTextBoxGrade.PasswordChar = '\0';
            this.metroTextBoxGrade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxGrade.SelectedText = "";
            this.metroTextBoxGrade.Size = new System.Drawing.Size(144, 23);
            this.metroTextBoxGrade.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxGrade.TabIndex = 5;
            this.metroTextBoxGrade.UseSelectable = true;
            this.metroTextBoxGrade.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(129, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Grade:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroTextBoxYear
            // 
            this.metroTextBoxYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxYear.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxYear.Lines = new string[0];
            this.metroTextBoxYear.Location = new System.Drawing.Point(189, 77);
            this.metroTextBoxYear.MaxLength = 32767;
            this.metroTextBoxYear.Name = "metroTextBoxYear";
            this.metroTextBoxYear.PasswordChar = '\0';
            this.metroTextBoxYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxYear.SelectedText = "";
            this.metroTextBoxYear.Size = new System.Drawing.Size(144, 23);
            this.metroTextBoxYear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxYear.TabIndex = 3;
            this.metroTextBoxYear.UseSelectable = true;
            this.metroTextBoxYear.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(69, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Academic Year:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroTextBoxAdminNo
            // 
            this.metroTextBoxAdminNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTextBoxAdminNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAdminNo.Lines = new string[0];
            this.metroTextBoxAdminNo.Location = new System.Drawing.Point(189, 23);
            this.metroTextBoxAdminNo.MaxLength = 32767;
            this.metroTextBoxAdminNo.Name = "metroTextBoxAdminNo";
            this.metroTextBoxAdminNo.PasswordChar = '\0';
            this.metroTextBoxAdminNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAdminNo.SelectedText = "";
            this.metroTextBoxAdminNo.Size = new System.Drawing.Size(144, 23);
            this.metroTextBoxAdminNo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxAdminNo.TabIndex = 1;
            this.metroTextBoxAdminNo.UseSelectable = true;
            this.metroTextBoxAdminNo.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(77, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Admission No:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // subjectTA
            // 
            this.subjectTA.ClearBeforeFill = true;
            // 
            // studentTA
            // 
            this.studentTA.ClearBeforeFill = true;
            // 
            // student_enrollmentTA
            // 
            this.student_enrollmentTA.ClearBeforeFill = true;
            // 
            // student_feeTA
            // 
            this.student_feeTA.ClearBeforeFill = true;
            // 
            // student_paymentTA
            // 
            this.student_paymentTA.ClearBeforeFill = true;
            // 
            // sUBJECTCODEDataGridViewTextBoxColumn
            // 
            this.sUBJECTCODEDataGridViewTextBoxColumn.DataPropertyName = "SUBJECT_CODE";
            this.sUBJECTCODEDataGridViewTextBoxColumn.HeaderText = "SUBJECT CODE";
            this.sUBJECTCODEDataGridViewTextBoxColumn.Name = "sUBJECTCODEDataGridViewTextBoxColumn";
            this.sUBJECTCODEDataGridViewTextBoxColumn.Width = 115;
            // 
            // SUBJECT
            // 
            this.SUBJECT.DataPropertyName = "SUBJECT";
            this.SUBJECT.HeaderText = "SUBJECT NAME";
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.Width = 135;
            // 
            // sUBJECTCOSTDataGridViewTextBoxColumn
            // 
            this.sUBJECTCOSTDataGridViewTextBoxColumn.DataPropertyName = "SUBJECT_COST";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sUBJECTCOSTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sUBJECTCOSTDataGridViewTextBoxColumn.HeaderText = "SUBJECT COST";
            this.sUBJECTCOSTDataGridViewTextBoxColumn.Name = "sUBJECTCOSTDataGridViewTextBoxColumn";
            this.sUBJECTCOSTDataGridViewTextBoxColumn.Width = 115;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RegisterStudent";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Student Registration Form";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.RegisterStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroTile metroTileRegister;
        private MetroFramework.Controls.MetroTile metroTileClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGrade;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxYear;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdminNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DS regDS;
        private System.Windows.Forms.BindingSource subjectBS;
        private DSTableAdapters.SUBJECTTableAdapter subjectTA;
        private System.Windows.Forms.DataGridView subjectsDGV;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private DSTableAdapters.STUDENTTableAdapter studentTA;
        private MetroFramework.Controls.MetroRadioButton RadioButtonAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTNAMEDataGridViewTextBoxColumn;
        private DSTableAdapters.STUDENT_ENROLLMENTTableAdapter student_enrollmentTA;
        private DSTableAdapters.STUDENT_FEETableAdapter student_feeTA;
        private DSTableAdapters.STUDENT_PAYMENTTableAdapter student_paymentTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
    }
}