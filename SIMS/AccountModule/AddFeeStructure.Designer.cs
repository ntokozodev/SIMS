namespace SIMS.AccountModule
{
    partial class AddFeeStructure
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
            this.metroTileClear = new MetroFramework.Controls.MetroTile();
            this.metroTileAddFeeStructure = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxOccurences = new MetroFramework.Controls.MetroComboBox();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.TAFee = new SIMS.DSTableAdapters.STUDENT_FEETableAdapter();
            this.ds1 = new SIMS.DS();
            this.metroTextBoxFeeName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFeeAmount = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroTextBoxFeeAmount);
            this.groupBox1.Controls.Add(this.metroTextBoxFeeName);
            this.groupBox1.Controls.Add(this.metroTileClear);
            this.groupBox1.Controls.Add(this.metroTileAddFeeStructure);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroComboBoxOccurences);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(178, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee Setup";
            // 
            // metroTileClear
            // 
            this.metroTileClear.ActiveControl = null;
            this.metroTileClear.Location = new System.Drawing.Point(482, 325);
            this.metroTileClear.Name = "metroTileClear";
            this.metroTileClear.Size = new System.Drawing.Size(75, 30);
            this.metroTileClear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClear.TabIndex = 10;
            this.metroTileClear.Text = "Clear";
            this.metroTileClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClear.UseSelectable = true;
            this.metroTileClear.UseStyleColors = true;
            this.metroTileClear.Click += new System.EventHandler(this.metroTileClear_Click);
            // 
            // metroTileAddFeeStructure
            // 
            this.metroTileAddFeeStructure.ActiveControl = null;
            this.metroTileAddFeeStructure.Location = new System.Drawing.Point(320, 326);
            this.metroTileAddFeeStructure.Name = "metroTileAddFeeStructure";
            this.metroTileAddFeeStructure.Size = new System.Drawing.Size(75, 29);
            this.metroTileAddFeeStructure.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAddFeeStructure.TabIndex = 9;
            this.metroTileAddFeeStructure.Text = "Add";
            this.metroTileAddFeeStructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddFeeStructure.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAddFeeStructure.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAddFeeStructure.UseSelectable = true;
            this.metroTileAddFeeStructure.UseStyleColors = true;
            this.metroTileAddFeeStructure.Click += new System.EventHandler(this.metroTileAddFeeStructure_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(123, 250);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Fee Amount:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(64, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(172, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Fee Category Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(106, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Fee Occurence:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroComboBoxOccurences
            // 
            this.metroComboBoxOccurences.FormattingEnabled = true;
            this.metroComboBoxOccurences.ItemHeight = 23;
            this.metroComboBoxOccurences.Items.AddRange(new object[] {
            "Once Off",
            "Monthly",
            "Quarterly",
            "Half Yearly",
            "Yearly"});
            this.metroComboBoxOccurences.Location = new System.Drawing.Point(320, 54);
            this.metroComboBoxOccurences.Name = "metroComboBoxOccurences";
            this.metroComboBoxOccurences.Size = new System.Drawing.Size(238, 29);
            this.metroComboBoxOccurences.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxOccurences.TabIndex = 3;
            this.metroComboBoxOccurences.UseSelectable = true;
            this.metroComboBoxOccurences.UseStyleColors = true;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(687, 503);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(135, 31);
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
            // TAFee
            // 
            this.TAFee.ClearBeforeFill = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTextBoxFeeName
            // 
            this.metroTextBoxFeeName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFeeName.Lines = new string[0];
            this.metroTextBoxFeeName.Location = new System.Drawing.Point(320, 141);
            this.metroTextBoxFeeName.MaxLength = 32767;
            this.metroTextBoxFeeName.Multiline = true;
            this.metroTextBoxFeeName.Name = "metroTextBoxFeeName";
            this.metroTextBoxFeeName.PasswordChar = '\0';
            this.metroTextBoxFeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFeeName.SelectedText = "";
            this.metroTextBoxFeeName.Size = new System.Drawing.Size(238, 29);
            this.metroTextBoxFeeName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxFeeName.TabIndex = 11;
            this.metroTextBoxFeeName.UseSelectable = true;
            this.metroTextBoxFeeName.UseStyleColors = true;
            // 
            // metroTextBoxFeeAmount
            // 
            this.metroTextBoxFeeAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFeeAmount.Lines = new string[0];
            this.metroTextBoxFeeAmount.Location = new System.Drawing.Point(320, 246);
            this.metroTextBoxFeeAmount.MaxLength = 32767;
            this.metroTextBoxFeeAmount.Multiline = true;
            this.metroTextBoxFeeAmount.Name = "metroTextBoxFeeAmount";
            this.metroTextBoxFeeAmount.PasswordChar = '\0';
            this.metroTextBoxFeeAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFeeAmount.SelectedText = "";
            this.metroTextBoxFeeAmount.Size = new System.Drawing.Size(238, 29);
            this.metroTextBoxFeeAmount.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxFeeAmount.TabIndex = 12;
            this.metroTextBoxFeeAmount.UseSelectable = true;
            this.metroTextBoxFeeAmount.UseStyleColors = true;
            // 
            // AddFeeStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 557);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFeeStructure";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add Fee Structure";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxOccurences;
        private MetroFramework.Controls.MetroTile metroTileClear;
        private MetroFramework.Controls.MetroTile metroTileAddFeeStructure;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private DSTableAdapters.STUDENT_FEETableAdapter TAFee;
        private DS ds1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFeeAmount;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFeeName;
    }
}