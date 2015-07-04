namespace SIMS.AccessControl
{
    partial class ChangePassword
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
            this.metroTileChange = new MetroFramework.Controls.MetroTile();
            this.TextBoxConfirmPword = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxNewPword = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxOldPword = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.changePTA = new SIMS.DSTableAdapters.SIMS_USERSTableAdapter();
            this.changeDS = new SIMS.DS();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroTileClear);
            this.groupBox1.Controls.Add(this.metroTileChange);
            this.groupBox1.Controls.Add(this.TextBoxConfirmPword);
            this.groupBox1.Controls.Add(this.TextBoxNewPword);
            this.groupBox1.Controls.Add(this.TextBoxOldPword);
            this.groupBox1.Controls.Add(this.TextBoxUsername);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(388, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // metroTileClear
            // 
            this.metroTileClear.ActiveControl = null;
            this.metroTileClear.Location = new System.Drawing.Point(276, 290);
            this.metroTileClear.Name = "metroTileClear";
            this.metroTileClear.Size = new System.Drawing.Size(75, 23);
            this.metroTileClear.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClear.TabIndex = 9;
            this.metroTileClear.Text = "Clear";
            this.metroTileClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClear.UseSelectable = true;
            this.metroTileClear.UseStyleColors = true;
            this.metroTileClear.Click += new System.EventHandler(this.metroTileClear_Click);
            // 
            // metroTileChange
            // 
            this.metroTileChange.ActiveControl = null;
            this.metroTileChange.Location = new System.Drawing.Point(170, 290);
            this.metroTileChange.Name = "metroTileChange";
            this.metroTileChange.Size = new System.Drawing.Size(75, 23);
            this.metroTileChange.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileChange.TabIndex = 8;
            this.metroTileChange.Text = "Change";
            this.metroTileChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileChange.UseSelectable = true;
            this.metroTileChange.UseStyleColors = true;
            this.metroTileChange.Click += new System.EventHandler(this.metroTileChange_Click);
            // 
            // TextBoxConfirmPword
            // 
            this.TextBoxConfirmPword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxConfirmPword.Lines = new string[0];
            this.TextBoxConfirmPword.Location = new System.Drawing.Point(170, 229);
            this.TextBoxConfirmPword.MaxLength = 32767;
            this.TextBoxConfirmPword.Name = "TextBoxConfirmPword";
            this.TextBoxConfirmPword.PasswordChar = '●';
            this.TextBoxConfirmPword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxConfirmPword.SelectedText = "";
            this.TextBoxConfirmPword.Size = new System.Drawing.Size(181, 23);
            this.TextBoxConfirmPword.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxConfirmPword.TabIndex = 7;
            this.TextBoxConfirmPword.UseSelectable = true;
            this.TextBoxConfirmPword.UseStyleColors = true;
            // 
            // TextBoxNewPword
            // 
            this.TextBoxNewPword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxNewPword.Lines = new string[0];
            this.TextBoxNewPword.Location = new System.Drawing.Point(170, 160);
            this.TextBoxNewPword.MaxLength = 32767;
            this.TextBoxNewPword.Name = "TextBoxNewPword";
            this.TextBoxNewPword.PasswordChar = '●';
            this.TextBoxNewPword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxNewPword.SelectedText = "";
            this.TextBoxNewPword.Size = new System.Drawing.Size(181, 23);
            this.TextBoxNewPword.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxNewPword.TabIndex = 6;
            this.TextBoxNewPword.UseSelectable = true;
            this.TextBoxNewPword.UseStyleColors = true;
            // 
            // TextBoxOldPword
            // 
            this.TextBoxOldPword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxOldPword.Lines = new string[0];
            this.TextBoxOldPword.Location = new System.Drawing.Point(170, 88);
            this.TextBoxOldPword.MaxLength = 32767;
            this.TextBoxOldPword.Name = "TextBoxOldPword";
            this.TextBoxOldPword.PasswordChar = '●';
            this.TextBoxOldPword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxOldPword.SelectedText = "";
            this.TextBoxOldPword.Size = new System.Drawing.Size(181, 23);
            this.TextBoxOldPword.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxOldPword.TabIndex = 5;
            this.TextBoxOldPword.UseSelectable = true;
            this.TextBoxOldPword.UseStyleColors = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxUsername.Lines = new string[0];
            this.TextBoxUsername.Location = new System.Drawing.Point(170, 25);
            this.TextBoxUsername.MaxLength = 32767;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.Size = new System.Drawing.Size(181, 23);
            this.TextBoxUsername.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxUsername.TabIndex = 4;
            this.TextBoxUsername.UseSelectable = true;
            this.TextBoxUsername.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(6, 229);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Confirm Password:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(30, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "New Password:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(36, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Old Password:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(61, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // changePTA
            // 
            this.changePTA.ClearBeforeFill = true;
            // 
            // changeDS
            // 
            this.changeDS.DataSetName = "DS";
            this.changeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 526);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Change Password";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTileClear;
        private MetroFramework.Controls.MetroTile metroTileChange;
        private MetroFramework.Controls.MetroTextBox TextBoxConfirmPword;
        private MetroFramework.Controls.MetroTextBox TextBoxNewPword;
        private MetroFramework.Controls.MetroTextBox TextBoxOldPword;
        private MetroFramework.Controls.MetroTextBox TextBoxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DSTableAdapters.SIMS_USERSTableAdapter changePTA;
        private DS changeDS;
    }
}