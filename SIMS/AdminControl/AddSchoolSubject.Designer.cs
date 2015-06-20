namespace SIMS.AdminControl
{
    partial class AddSchoolSubject
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.subjectTA = new SIMS.DSTableAdapters.SUBJECTTableAdapter();
            this.subjectDS = new SIMS.DS();
            this.TextBoxCode = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxCost = new MetroFramework.Controls.MetroTextBox();
            this.ComboBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroTileAdd = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroTileAdd);
            this.groupBox1.Controls.Add(this.ComboBoxCategory);
            this.groupBox1.Controls.Add(this.TextBoxCost);
            this.groupBox1.Controls.Add(this.TextBoxCode);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(360, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(29, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Subject Code:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(54, 330);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Category:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(39, 218);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Subject Cost";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(24, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Subject Name:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // TextBoxName
            // 
            this.TextBoxName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxName.Lines = new string[0];
            this.TextBoxName.Location = new System.Drawing.Point(166, 35);
            this.TextBoxName.MaxLength = 32767;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.Size = new System.Drawing.Size(250, 23);
            this.TextBoxName.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxName.TabIndex = 4;
            this.TextBoxName.UseSelectable = true;
            this.TextBoxName.UseStyleColors = true;
            // 
            // subjectTA
            // 
            this.subjectTA.ClearBeforeFill = true;
            // 
            // subjectDS
            // 
            this.subjectDS.DataSetName = "DS";
            this.subjectDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxCode.Lines = new string[0];
            this.TextBoxCode.Location = new System.Drawing.Point(166, 122);
            this.TextBoxCode.MaxLength = 32767;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.PasswordChar = '\0';
            this.TextBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCode.SelectedText = "";
            this.TextBoxCode.Size = new System.Drawing.Size(150, 23);
            this.TextBoxCode.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxCode.TabIndex = 9;
            this.TextBoxCode.UseSelectable = true;
            this.TextBoxCode.UseStyleColors = true;
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxCost.Lines = new string[0];
            this.TextBoxCost.Location = new System.Drawing.Point(166, 218);
            this.TextBoxCost.MaxLength = 32767;
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.PasswordChar = '\0';
            this.TextBoxCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCost.SelectedText = "";
            this.TextBoxCost.Size = new System.Drawing.Size(150, 23);
            this.TextBoxCost.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBoxCost.TabIndex = 10;
            this.TextBoxCost.UseSelectable = true;
            this.TextBoxCost.UseStyleColors = true;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.ItemHeight = 23;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Major",
            "Complimentary"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(166, 320);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(150, 29);
            this.ComboBoxCategory.TabIndex = 11;
            this.ComboBoxCategory.UseSelectable = true;
            // 
            // metroTileAdd
            // 
            this.metroTileAdd.ActiveControl = null;
            this.metroTileAdd.Location = new System.Drawing.Point(166, 400);
            this.metroTileAdd.Name = "metroTileAdd";
            this.metroTileAdd.Size = new System.Drawing.Size(93, 23);
            this.metroTileAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAdd.TabIndex = 12;
            this.metroTileAdd.Text = "Add Subject";
            this.metroTileAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAdd.UseSelectable = true;
            this.metroTileAdd.UseStyleColors = true;
            this.metroTileAdd.Click += new System.EventHandler(this.metroTileAdd_Click_1);
            // 
            // AddSchoolSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 532);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSchoolSubject";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add Subjects to School Curriculum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TextBoxName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DSTableAdapters.SUBJECTTableAdapter subjectTA;
        private DS subjectDS;
        private MetroFramework.Controls.MetroTextBox TextBoxCost;
        private MetroFramework.Controls.MetroTextBox TextBoxCode;
        private MetroFramework.Controls.MetroTile metroTileAdd;
        private MetroFramework.Controls.MetroComboBox ComboBoxCategory;
    }
}