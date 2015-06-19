namespace SIMS.AccountModule
{
    partial class Expenses
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
            this.groupBoxAddExpense = new System.Windows.Forms.GroupBox();
            this.metroTileClearAddExpense = new MetroFramework.Controls.MetroTile();
            this.metroTileAddExpense = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxExpType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxRecordExpense = new System.Windows.Forms.GroupBox();
            this.metroDateTimeCaptureDate = new MetroFramework.Controls.MetroDateTime();
            this.metroTileClearExpPayment = new MetroFramework.Controls.MetroTile();
            this.metroTileAddExpPayment = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxExpNote = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxExpAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeExpense = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxExpenseType = new MetroFramework.Controls.MetroComboBox();
            this.eXPENSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.groupBoxAddExpense.SuspendLayout();
            this.groupBoxRecordExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddExpense
            // 
            this.groupBoxAddExpense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxAddExpense.Controls.Add(this.metroTileClearAddExpense);
            this.groupBoxAddExpense.Controls.Add(this.metroTileAddExpense);
            this.groupBoxAddExpense.Controls.Add(this.metroTextBoxDescription);
            this.groupBoxAddExpense.Controls.Add(this.metroLabel2);
            this.groupBoxAddExpense.Controls.Add(this.metroTextBoxExpType);
            this.groupBoxAddExpense.Controls.Add(this.metroLabel1);
            this.groupBoxAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddExpense.Location = new System.Drawing.Point(23, 109);
            this.groupBoxAddExpense.Name = "groupBoxAddExpense";
            this.groupBoxAddExpense.Size = new System.Drawing.Size(441, 405);
            this.groupBoxAddExpense.TabIndex = 0;
            this.groupBoxAddExpense.TabStop = false;
            this.groupBoxAddExpense.Text = "Add Expense Type";
            // 
            // metroTileClearAddExpense
            // 
            this.metroTileClearAddExpense.ActiveControl = null;
            this.metroTileClearAddExpense.Location = new System.Drawing.Point(312, 312);
            this.metroTileClearAddExpense.Name = "metroTileClearAddExpense";
            this.metroTileClearAddExpense.Size = new System.Drawing.Size(98, 32);
            this.metroTileClearAddExpense.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClearAddExpense.TabIndex = 5;
            this.metroTileClearAddExpense.Text = "Clear";
            this.metroTileClearAddExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClearAddExpense.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClearAddExpense.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClearAddExpense.UseSelectable = true;
            this.metroTileClearAddExpense.UseTileImage = true;
            this.metroTileClearAddExpense.Click += new System.EventHandler(this.metroTileClearAddExpense_Click);
            // 
            // metroTileAddExpense
            // 
            this.metroTileAddExpense.ActiveControl = null;
            this.metroTileAddExpense.Location = new System.Drawing.Point(164, 312);
            this.metroTileAddExpense.Name = "metroTileAddExpense";
            this.metroTileAddExpense.Size = new System.Drawing.Size(98, 32);
            this.metroTileAddExpense.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAddExpense.TabIndex = 4;
            this.metroTileAddExpense.Text = "Add";
            this.metroTileAddExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddExpense.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAddExpense.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAddExpense.UseSelectable = true;
            this.metroTileAddExpense.UseStyleColors = true;
            this.metroTileAddExpense.Click += new System.EventHandler(this.metroTileAddExpense_Click);
            // 
            // metroTextBoxDescription
            // 
            this.metroTextBoxDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxDescription.Lines = new string[0];
            this.metroTextBoxDescription.Location = new System.Drawing.Point(164, 129);
            this.metroTextBoxDescription.MaxLength = 32767;
            this.metroTextBoxDescription.Multiline = true;
            this.metroTextBoxDescription.Name = "metroTextBoxDescription";
            this.metroTextBoxDescription.PasswordChar = '\0';
            this.metroTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDescription.SelectedText = "";
            this.metroTextBoxDescription.Size = new System.Drawing.Size(246, 150);
            this.metroTextBoxDescription.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxDescription.TabIndex = 3;
            this.metroTextBoxDescription.UseSelectable = true;
            this.metroTextBoxDescription.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(34, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Description:";
            // 
            // metroTextBoxExpType
            // 
            this.metroTextBoxExpType.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxExpType.Lines = new string[0];
            this.metroTextBoxExpType.Location = new System.Drawing.Point(164, 52);
            this.metroTextBoxExpType.MaxLength = 32767;
            this.metroTextBoxExpType.Name = "metroTextBoxExpType";
            this.metroTextBoxExpType.PasswordChar = '\0';
            this.metroTextBoxExpType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxExpType.SelectedText = "";
            this.metroTextBoxExpType.Size = new System.Drawing.Size(246, 23);
            this.metroTextBoxExpType.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxExpType.TabIndex = 1;
            this.metroTextBoxExpType.UseSelectable = true;
            this.metroTextBoxExpType.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(17, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Expense Type:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxRecordExpense
            // 
            this.groupBoxRecordExpense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxRecordExpense.Controls.Add(this.metroDateTimeCaptureDate);
            this.groupBoxRecordExpense.Controls.Add(this.metroTileClearExpPayment);
            this.groupBoxRecordExpense.Controls.Add(this.metroTileAddExpPayment);
            this.groupBoxRecordExpense.Controls.Add(this.metroTextBoxExpNote);
            this.groupBoxRecordExpense.Controls.Add(this.metroLabel6);
            this.groupBoxRecordExpense.Controls.Add(this.metroTextBoxExpAmount);
            this.groupBoxRecordExpense.Controls.Add(this.metroLabel5);
            this.groupBoxRecordExpense.Controls.Add(this.metroDateTimeExpense);
            this.groupBoxRecordExpense.Controls.Add(this.metroLabel4);
            this.groupBoxRecordExpense.Controls.Add(this.metroComboBoxExpenseType);
            this.groupBoxRecordExpense.Controls.Add(this.metroLabel3);
            this.groupBoxRecordExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRecordExpense.Location = new System.Drawing.Point(511, 109);
            this.groupBoxRecordExpense.Name = "groupBoxRecordExpense";
            this.groupBoxRecordExpense.Size = new System.Drawing.Size(441, 445);
            this.groupBoxRecordExpense.TabIndex = 1;
            this.groupBoxRecordExpense.TabStop = false;
            this.groupBoxRecordExpense.Text = "Record Expense Payment";
            // 
            // metroDateTimeCaptureDate
            // 
            this.metroDateTimeCaptureDate.Location = new System.Drawing.Point(7, 264);
            this.metroDateTimeCaptureDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeCaptureDate.Name = "metroDateTimeCaptureDate";
            this.metroDateTimeCaptureDate.Size = new System.Drawing.Size(150, 29);
            this.metroDateTimeCaptureDate.TabIndex = 10;
            this.metroDateTimeCaptureDate.Visible = false;
            // 
            // metroTileClearExpPayment
            // 
            this.metroTileClearExpPayment.ActiveControl = null;
            this.metroTileClearExpPayment.Location = new System.Drawing.Point(286, 344);
            this.metroTileClearExpPayment.Name = "metroTileClearExpPayment";
            this.metroTileClearExpPayment.Size = new System.Drawing.Size(98, 28);
            this.metroTileClearExpPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClearExpPayment.TabIndex = 9;
            this.metroTileClearExpPayment.Text = "Clear";
            this.metroTileClearExpPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClearExpPayment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClearExpPayment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClearExpPayment.UseSelectable = true;
            this.metroTileClearExpPayment.UseStyleColors = true;
            this.metroTileClearExpPayment.Click += new System.EventHandler(this.metroTileClearExpPayment_Click);
            // 
            // metroTileAddExpPayment
            // 
            this.metroTileAddExpPayment.ActiveControl = null;
            this.metroTileAddExpPayment.Location = new System.Drawing.Point(180, 344);
            this.metroTileAddExpPayment.Name = "metroTileAddExpPayment";
            this.metroTileAddExpPayment.Size = new System.Drawing.Size(98, 28);
            this.metroTileAddExpPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAddExpPayment.TabIndex = 8;
            this.metroTileAddExpPayment.Text = "Add";
            this.metroTileAddExpPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddExpPayment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAddExpPayment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAddExpPayment.UseSelectable = true;
            this.metroTileAddExpPayment.UseStyleColors = true;
            this.metroTileAddExpPayment.Click += new System.EventHandler(this.metroTileAddExpPayment_Click);
            // 
            // metroTextBoxExpNote
            // 
            this.metroTextBoxExpNote.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxExpNote.Lines = new string[0];
            this.metroTextBoxExpNote.Location = new System.Drawing.Point(180, 217);
            this.metroTextBoxExpNote.MaxLength = 32767;
            this.metroTextBoxExpNote.Multiline = true;
            this.metroTextBoxExpNote.Name = "metroTextBoxExpNote";
            this.metroTextBoxExpNote.PasswordChar = '\0';
            this.metroTextBoxExpNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxExpNote.SelectedText = "";
            this.metroTextBoxExpNote.Size = new System.Drawing.Size(204, 88);
            this.metroTextBoxExpNote.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxExpNote.TabIndex = 7;
            this.metroTextBoxExpNote.UseSelectable = true;
            this.metroTextBoxExpNote.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(102, 217);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 25);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Note:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBoxExpAmount
            // 
            this.metroTextBoxExpAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxExpAmount.Lines = new string[0];
            this.metroTextBoxExpAmount.Location = new System.Drawing.Point(180, 150);
            this.metroTextBoxExpAmount.MaxLength = 32767;
            this.metroTextBoxExpAmount.Name = "metroTextBoxExpAmount";
            this.metroTextBoxExpAmount.PasswordChar = '\0';
            this.metroTextBoxExpAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxExpAmount.SelectedText = "";
            this.metroTextBoxExpAmount.Size = new System.Drawing.Size(204, 23);
            this.metroTextBoxExpAmount.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxExpAmount.TabIndex = 5;
            this.metroTextBoxExpAmount.UseSelectable = true;
            this.metroTextBoxExpAmount.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(7, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(150, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Expense Amount:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroDateTimeExpense
            // 
            this.metroDateTimeExpense.Location = new System.Drawing.Point(180, 86);
            this.metroDateTimeExpense.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeExpense.Name = "metroDateTimeExpense";
            this.metroDateTimeExpense.Size = new System.Drawing.Size(193, 29);
            this.metroDateTimeExpense.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(35, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(127, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Payment Date:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBoxExpenseType
            // 
            this.metroComboBoxExpenseType.DataSource = this.eXPENSEBindingSource;
            this.metroComboBoxExpenseType.DisplayMember = "EXPENSE_TYPE";
            this.metroComboBoxExpenseType.FormattingEnabled = true;
            this.metroComboBoxExpenseType.ItemHeight = 23;
            this.metroComboBoxExpenseType.Location = new System.Drawing.Point(180, 28);
            this.metroComboBoxExpenseType.Name = "metroComboBoxExpenseType";
            this.metroComboBoxExpenseType.Size = new System.Drawing.Size(193, 29);
            this.metroComboBoxExpenseType.TabIndex = 1;
            this.metroComboBoxExpenseType.UseSelectable = true;
            // 
            // eXPENSEBindingSource
            // 
            this.eXPENSEBindingSource.DataMember = "EXPENSE";
            this.eXPENSEBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(34, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Expense Type:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(373, 526);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(91, 28);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClose.TabIndex = 3;
            this.metroTileClose.Text = "Close";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseStyleColors = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 577);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.groupBoxRecordExpense);
            this.Controls.Add(this.groupBoxAddExpense);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expenses";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Expenses and Payments";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.groupBoxAddExpense.ResumeLayout(false);
            this.groupBoxAddExpense.PerformLayout();
            this.groupBoxRecordExpense.ResumeLayout(false);
            this.groupBoxRecordExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddExpense;
        private MetroFramework.Controls.MetroTile metroTileClearAddExpense;
        private MetroFramework.Controls.MetroTile metroTileAddExpense;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDescription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxExpType;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBoxRecordExpense;
        private MetroFramework.Controls.MetroTile metroTileClearExpPayment;
        private MetroFramework.Controls.MetroTile metroTileAddExpPayment;
        private MetroFramework.Controls.MetroTextBox metroTextBoxExpNote;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxExpAmount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTimeExpense;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private DS dS;
        private System.Windows.Forms.BindingSource eXPENSEBindingSource;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroComboBox metroComboBoxExpenseType;
        private MetroFramework.Controls.MetroDateTime metroDateTimeCaptureDate;
    }
}