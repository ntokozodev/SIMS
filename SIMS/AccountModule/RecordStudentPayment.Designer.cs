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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAdminNo = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxPayType = new MetroFramework.Controls.MetroComboBox();
            this.metroTileAddPay = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPayAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroTileClear = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dS = new SIMS.DS();
            this.fEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fEETableAdapter = new SIMS.DSTableAdapters.FEETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroTileClear);
            this.groupBox1.Controls.Add(this.metroTextBoxPayAmount);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.metroTileAddPay);
            this.groupBox1.Controls.Add(this.metroComboBoxPayType);
            this.groupBox1.Controls.Add(this.metroTextBoxAdminNo);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(237, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(563, 496);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(150, 35);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(46, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Adminssion No:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(57, 315);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Payment Type:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(58, 238);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Payment Date:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBoxAdminNo
            // 
            this.metroTextBoxAdminNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAdminNo.Lines = new string[0];
            this.metroTextBoxAdminNo.Location = new System.Drawing.Point(241, 12);
            this.metroTextBoxAdminNo.MaxLength = 32767;
            this.metroTextBoxAdminNo.Multiline = true;
            this.metroTextBoxAdminNo.Name = "metroTextBoxAdminNo";
            this.metroTextBoxAdminNo.PasswordChar = '\0';
            this.metroTextBoxAdminNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAdminNo.SelectedText = "";
            this.metroTextBoxAdminNo.Size = new System.Drawing.Size(179, 29);
            this.metroTextBoxAdminNo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxAdminNo.TabIndex = 3;
            this.metroTextBoxAdminNo.UseSelectable = true;
            this.metroTextBoxAdminNo.UseStyleColors = true;
            // 
            // metroComboBoxPayType
            // 
            this.metroComboBoxPayType.FormattingEnabled = true;
            this.metroComboBoxPayType.ItemHeight = 23;
            this.metroComboBoxPayType.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.metroComboBoxPayType.Location = new System.Drawing.Point(241, 311);
            this.metroComboBoxPayType.Name = "metroComboBoxPayType";
            this.metroComboBoxPayType.Size = new System.Drawing.Size(143, 29);
            this.metroComboBoxPayType.TabIndex = 4;
            this.metroComboBoxPayType.UseSelectable = true;
            // 
            // metroTileAddPay
            // 
            this.metroTileAddPay.ActiveControl = null;
            this.metroTileAddPay.Location = new System.Drawing.Point(84, 372);
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
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(241, 234);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(143, 29);
            this.metroDateTime1.TabIndex = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(30, 88);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(155, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Payment Amount:";
            // 
            // metroTextBoxPayAmount
            // 
            this.metroTextBoxPayAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPayAmount.Lines = new string[0];
            this.metroTextBoxPayAmount.Location = new System.Drawing.Point(241, 85);
            this.metroTextBoxPayAmount.MaxLength = 32767;
            this.metroTextBoxPayAmount.Multiline = true;
            this.metroTextBoxPayAmount.Name = "metroTextBoxPayAmount";
            this.metroTextBoxPayAmount.PasswordChar = '\0';
            this.metroTextBoxPayAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPayAmount.SelectedText = "";
            this.metroTextBoxPayAmount.Size = new System.Drawing.Size(179, 28);
            this.metroTextBoxPayAmount.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxPayAmount.TabIndex = 12;
            this.metroTextBoxPayAmount.UseSelectable = true;
            this.metroTextBoxPayAmount.UseStyleColors = true;
            // 
            // metroTileClear
            // 
            this.metroTileClear.ActiveControl = null;
            this.metroTileClear.Location = new System.Drawing.Point(241, 372);
            this.metroTileClear.Name = "metroTileClear";
            this.metroTileClear.Size = new System.Drawing.Size(140, 32);
            this.metroTileClear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClear.TabIndex = 13;
            this.metroTileClear.Text = "Clear";
            this.metroTileClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClear.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(65, 163);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(120, 25);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Fee Category:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.fEEBindingSource;
            this.metroComboBox1.DisplayMember = "FEE_CATEGORY";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(241, 159);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(143, 29);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.UseSelectable = true;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fEEBindingSource
            // 
            this.fEEBindingSource.DataMember = "FEE";
            this.fEEBindingSource.DataSource = this.dS;
            // 
            // fEETableAdapter
            // 
            this.fEETableAdapter.ClearBeforeFill = true;
            // 
            // RecordStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 554);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordStudentPayment";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Record Student Payment";
            this.Load += new System.EventHandler(this.RecordStudentPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPayAmount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTileAddPay;
        private MetroFramework.Controls.MetroComboBox metroComboBoxPayType;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdminNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTileClear;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DS dS;
        private System.Windows.Forms.BindingSource fEEBindingSource;
        private DSTableAdapters.FEETableAdapter fEETableAdapter;
    }
}