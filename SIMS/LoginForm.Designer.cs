namespace SIMS
{
    partial class LoginForm
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
            this.loginTile = new MetroFramework.Controls.MetroTile();
            this.cancelTile = new MetroFramework.Controls.MetroTile();
            this.userIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.mainLabel = new MetroFramework.Controls.MetroLabel();
            this.loginDS = new SIMS.DSS();
            this.usersTA = new SIMS.DSSTableAdapters.SIMS_USERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loginDS)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTile
            // 
            this.loginTile.ActiveControl = null;
            this.loginTile.Location = new System.Drawing.Point(23, 310);
            this.loginTile.Name = "loginTile";
            this.loginTile.Size = new System.Drawing.Size(148, 30);
            this.loginTile.Style = MetroFramework.MetroColorStyle.Green;
            this.loginTile.TabIndex = 0;
            this.loginTile.Text = "Login";
            this.loginTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.loginTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.loginTile.UseSelectable = true;
            this.loginTile.UseStyleColors = true;
            this.loginTile.Click += new System.EventHandler(this.loginTile_Click);
            // 
            // cancelTile
            // 
            this.cancelTile.ActiveControl = null;
            this.cancelTile.Location = new System.Drawing.Point(193, 310);
            this.cancelTile.Name = "cancelTile";
            this.cancelTile.Size = new System.Drawing.Size(148, 30);
            this.cancelTile.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelTile.TabIndex = 1;
            this.cancelTile.Text = "Cancel";
            this.cancelTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cancelTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.cancelTile.UseSelectable = true;
            this.cancelTile.UseStyleColors = true;
            this.cancelTile.Click += new System.EventHandler(this.cancelTile_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userIDTextBox.Lines = new string[0];
            this.userIDTextBox.Location = new System.Drawing.Point(23, 107);
            this.userIDTextBox.MaxLength = 32767;
            this.userIDTextBox.Multiline = true;
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.PasswordChar = '\0';
            this.userIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userIDTextBox.SelectedText = "";
            this.userIDTextBox.Size = new System.Drawing.Size(318, 35);
            this.userIDTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.userIDTextBox.TabIndex = 2;
            this.userIDTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userIDTextBox.UseSelectable = true;
            this.userIDTextBox.UseStyleColors = true;
            // 
            // pwordTextBox
            // 
            this.pwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pwordTextBox.Lines = new string[0];
            this.pwordTextBox.Location = new System.Drawing.Point(23, 225);
            this.pwordTextBox.MaxLength = 32767;
            this.pwordTextBox.Multiline = true;
            this.pwordTextBox.Name = "pwordTextBox";
            this.pwordTextBox.PasswordChar = '●';
            this.pwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwordTextBox.SelectedText = "";
            this.pwordTextBox.Size = new System.Drawing.Size(317, 35);
            this.pwordTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.pwordTextBox.TabIndex = 3;
            this.pwordTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pwordTextBox.UseSelectable = true;
            this.pwordTextBox.UseStyleColors = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.userLabel.Location = new System.Drawing.Point(23, 79);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(95, 25);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username:";
            this.userLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainLabel.Location = new System.Drawing.Point(23, 197);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(92, 25);
            this.mainLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.mainLabel.TabIndex = 5;
            this.mainLabel.Text = "Password:";
            this.mainLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loginDS
            // 
            this.loginDS.DataSetName = "DSS";
            this.loginDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTA
            // 
            this.usersTA.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 363);
            this.ControlBox = false;
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pwordTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.cancelTile);
            this.Controls.Add(this.loginTile);
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Enter login details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.loginDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile loginTile;
        private MetroFramework.Controls.MetroTile cancelTile;
        private MetroFramework.Controls.MetroTextBox userIDTextBox;
        private MetroFramework.Controls.MetroTextBox pwordTextBox;
        private MetroFramework.Controls.MetroLabel userLabel;
        private MetroFramework.Controls.MetroLabel mainLabel;
        private SIMS.DSS loginDS;
        private SIMS.DSSTableAdapters.SIMS_USERSTableAdapter SIMS_USERSTableAdapter;
        private SIMS.DSSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSSTableAdapters.SIMS_USERSTableAdapter usersTA;
    }
}