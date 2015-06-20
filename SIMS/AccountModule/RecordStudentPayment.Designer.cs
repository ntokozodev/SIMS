namespace SIMS.AccountModule
{
    partial class RecordStudentPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxYear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxPayAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.DateTimePayment = new MetroFramework.Controls.MetroDateTime();
            this.ComboBoxPayType = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxAdminNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTileClear = new MetroFramework.Controls.MetroTile();
            this.metroTileAddPay = new MetroFramework.Controls.MetroTile();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.DateTimeCaptured = new MetroFramework.Controls.MetroDateTime();
            this.stupDS = new SIMS.DS();
            this.studentTA = new SIMS.DSTableAdapters.STUDENTTableAdapter();
            this.student_enrollmentTA = new SIMS.DSTableAdapters.STUDENT_ENROLLMENTTableAdapter();
            this.student_feeTA = new SIMS.DSTableAdapters.STUDENT_FEETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stupDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.TextBoxYear);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.TextBoxPayAmount);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.DateTimePayment);
            this.groupBox1.Controls.Add(this.ComboBoxPayType);
            this.groupBox1.Controls.Add(this.TextBoxAdminNo);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(377, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxYear.Lines = new string[0];
            this.TextBoxYear.Location = new System.Drawing.Point(241, 86);
            this.TextBoxYear.MaxLength = 32767;
            this.TextBoxYear.Multiline = true;
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.PasswordChar = '\0';
            this.TextBoxYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxYear.SelectedText = "";
            this.TextBoxYear.Size = new System.Drawing.Size(179, 28);
            this.TextBoxYear.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxYear.TabIndex = 14;
            this.TextBoxYear.UseSelectable = true;
            this.TextBoxYear.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(72, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(132, 25);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Academic Year:";
            // 
            // TextBoxPayAmount
            // 
            this.TextBoxPayAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxPayAmount.Lines = new string[0];
            this.TextBoxPayAmount.Location = new System.Drawing.Point(241, 162);
            this.TextBoxPayAmount.MaxLength = 32767;
            this.TextBoxPayAmount.Multiline = true;
            this.TextBoxPayAmount.Name = "TextBoxPayAmount";
            this.TextBoxPayAmount.PasswordChar = '\0';
            this.TextBoxPayAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPayAmount.SelectedText = "";
            this.TextBoxPayAmount.Size = new System.Drawing.Size(179, 28);
            this.TextBoxPayAmount.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxPayAmount.TabIndex = 12;
            this.TextBoxPayAmount.UseSelectable = true;
            this.TextBoxPayAmount.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(50, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(155, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Payment Amount:";
            // 
            // DateTimePayment
            // 
            this.DateTimePayment.Location = new System.Drawing.Point(241, 241);
            this.DateTimePayment.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimePayment.Name = "DateTimePayment";
            this.DateTimePayment.Size = new System.Drawing.Size(143, 29);
            this.DateTimePayment.TabIndex = 10;
            // 
            // ComboBoxPayType
            // 
            this.ComboBoxPayType.FormattingEnabled = true;
            this.ComboBoxPayType.ItemHeight = 23;
            this.ComboBoxPayType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Debit"});
            this.ComboBoxPayType.Location = new System.Drawing.Point(241, 319);
            this.ComboBoxPayType.Name = "ComboBoxPayType";
            this.ComboBoxPayType.Size = new System.Drawing.Size(143, 29);
            this.ComboBoxPayType.TabIndex = 4;
            this.ComboBoxPayType.UseSelectable = true;
            // 
            // TextBoxAdminNo
            // 
            this.TextBoxAdminNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxAdminNo.Lines = new string[0];
            this.TextBoxAdminNo.Location = new System.Drawing.Point(241, 16);
            this.TextBoxAdminNo.MaxLength = 32767;
            this.TextBoxAdminNo.Multiline = true;
            this.TextBoxAdminNo.Name = "TextBoxAdminNo";
            this.TextBoxAdminNo.PasswordChar = '\0';
            this.TextBoxAdminNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAdminNo.SelectedText = "";
            this.TextBoxAdminNo.Size = new System.Drawing.Size(179, 29);
            this.TextBoxAdminNo.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxAdminNo.TabIndex = 3;
            this.TextBoxAdminNo.UseSelectable = true;
            this.TextBoxAdminNo.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(78, 241);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Payment Date:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(76, 323);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Payment Type:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(75, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Admission No:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTileClear
            // 
            this.metroTileClear.ActiveControl = null;
            this.metroTileClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClear.Location = new System.Drawing.Point(542, 489);
            this.metroTileClear.Name = "metroTileClear";
            this.metroTileClear.Size = new System.Drawing.Size(140, 32);
            this.metroTileClear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClear.TabIndex = 13;
            this.metroTileClear.Text = "Clear";
            this.metroTileClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClear.UseSelectable = true;
            this.metroTileClear.Click += new System.EventHandler(this.metroTileClear_Click);
            // 
            // metroTileAddPay
            // 
            this.metroTileAddPay.ActiveControl = null;
            this.metroTileAddPay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileAddPay.Location = new System.Drawing.Point(377, 489);
            this.metroTileAddPay.Name = "metroTileAddPay";
            this.metroTileAddPay.Size = new System.Drawing.Size(140, 32);
            this.metroTileAddPay.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAddPay.TabIndex = 6;
            this.metroTileAddPay.Text = "Add Payment";
            this.metroTileAddPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddPay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAddPay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAddPay.UseSelectable = true;
            this.metroTileAddPay.UseStyleColors = true;
            this.metroTileAddPay.Click += new System.EventHandler(this.metroTileAddPay_Click);
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(713, 489);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(140, 32);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 1;
            this.metroTileClose.Text = "Close Window";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // DateTimeCaptured
            // 
            this.DateTimeCaptured.Location = new System.Drawing.Point(78, 433);
            this.DateTimeCaptured.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeCaptured.Name = "DateTimeCaptured";
            this.DateTimeCaptured.Size = new System.Drawing.Size(147, 29);
            this.DateTimeCaptured.TabIndex = 14;
            this.DateTimeCaptured.Visible = false;
            // 
            // stupDS
            // 
            this.stupDS.DataSetName = "DSS";
            this.stupDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // RecordStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1216, 551);
            this.Controls.Add(this.DateTimeCaptured);
            this.Controls.Add(this.metroTileClear);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTileAddPay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordStudentPayment";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Record Student Payment";
            this.Load += new System.EventHandler(this.RecordStudentPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stupDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroTextBox TextBoxPayAmount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime DateTimePayment;
        private MetroFramework.Controls.MetroTile metroTileAddPay;
        private MetroFramework.Controls.MetroComboBox ComboBoxPayType;
        private MetroFramework.Controls.MetroTextBox TextBoxAdminNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTileClear;
        private MetroFramework.Controls.MetroTextBox TextBoxYear;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime DateTimeCaptured;
        private DS stupDS;
        private DSTableAdapters.STUDENTTableAdapter studentTA;
        private DSTableAdapters.STUDENT_ENROLLMENTTableAdapter student_enrollmentTA;
        private DSTableAdapters.STUDENT_FEETableAdapter student_feeTA;
    }
}