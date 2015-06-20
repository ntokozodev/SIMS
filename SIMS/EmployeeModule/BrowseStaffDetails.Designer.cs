namespace SIMS.EmployeeModule
{
    partial class BrowseStaffDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseStaffDetails));
            this.eMPLOYEEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLOYEEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.metroTileSearchStaff = new MetroFramework.Controls.MetroTile();
            this.TextBoxSearchStaff = new MetroFramework.Controls.MetroTextBox();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.employeeTA = new SIMS.DSTableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new SIMS.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).BeginInit();
            this.eMPLOYEEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEEBindingNavigator
            // 
            this.eMPLOYEEBindingNavigator.AddNewItem = null;
            this.eMPLOYEEBindingNavigator.BindingSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLOYEEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLOYEEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.eMPLOYEEBindingNavigatorSaveItem});
            this.eMPLOYEEBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.eMPLOYEEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLOYEEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLOYEEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLOYEEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLOYEEBindingNavigator.Name = "eMPLOYEEBindingNavigator";
            this.eMPLOYEEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLOYEEBindingNavigator.Size = new System.Drawing.Size(1131, 25);
            this.eMPLOYEEBindingNavigator.TabIndex = 0;
            this.eMPLOYEEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // eMPLOYEEBindingNavigatorSaveItem
            // 
            this.eMPLOYEEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEEBindingNavigatorSaveItem.Image")));
            this.eMPLOYEEBindingNavigatorSaveItem.Name = "eMPLOYEEBindingNavigatorSaveItem";
            this.eMPLOYEEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLOYEEBindingNavigatorSaveItem.Text = "Save Data";
            this.eMPLOYEEBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLOYEEBindingNavigatorSaveItem_Click);
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.AllowUserToDeleteRows = false;
            this.eMPLOYEEDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eMPLOYEEDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.ADDRESS,
            this.CITY,
            this.ZIPCODE});
            this.eMPLOYEEDataGridView.DataSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(26, 142);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(1125, 434);
            this.eMPLOYEEDataGridView.TabIndex = 1;
            // 
            // metroTileSearchStaff
            // 
            this.metroTileSearchStaff.ActiveControl = null;
            this.metroTileSearchStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileSearchStaff.Location = new System.Drawing.Point(26, 97);
            this.metroTileSearchStaff.Name = "metroTileSearchStaff";
            this.metroTileSearchStaff.Size = new System.Drawing.Size(168, 29);
            this.metroTileSearchStaff.TabIndex = 2;
            this.metroTileSearchStaff.Text = "Search Staff by Surname:";
            this.metroTileSearchStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSearchStaff.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSearchStaff.UseSelectable = true;
            this.metroTileSearchStaff.Click += new System.EventHandler(this.metroTileSearchStaff_Click);
            // 
            // TextBoxSearchStaff
            // 
            this.TextBoxSearchStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxSearchStaff.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxSearchStaff.Lines = new string[0];
            this.TextBoxSearchStaff.Location = new System.Drawing.Point(200, 97);
            this.TextBoxSearchStaff.MaxLength = 32767;
            this.TextBoxSearchStaff.Name = "TextBoxSearchStaff";
            this.TextBoxSearchStaff.PasswordChar = '\0';
            this.TextBoxSearchStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearchStaff.SelectedText = "";
            this.TextBoxSearchStaff.Size = new System.Drawing.Size(176, 29);
            this.TextBoxSearchStaff.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxSearchStaff.TabIndex = 3;
            this.TextBoxSearchStaff.UseSelectable = true;
            this.TextBoxSearchStaff.UseStyleColors = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Width = 120;
            // 
            // CITY
            // 
            this.CITY.DataPropertyName = "CITY";
            this.CITY.HeaderText = "CITY";
            this.CITY.Name = "CITY";
            // 
            // ZIPCODE
            // 
            this.ZIPCODE.DataPropertyName = "ZIPCODE";
            this.ZIPCODE.HeaderText = "ZIPCODE";
            this.ZIPCODE.Name = "ZIPCODE";
            this.ZIPCODE.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "STAFF NO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "SURNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GENDER";
            this.dataGridViewTextBoxColumn4.HeaderText = "GENDER";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CITIZEN_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID NUMBER";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn6.HeaderText = "PHONE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ROLE";
            this.dataGridViewTextBoxColumn7.HeaderText = "ROLE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HIRE_DATE";
            this.dataGridViewTextBoxColumn8.HeaderText = "HIRE DATE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn9.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTA
            // 
            this.employeeTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CENTRETableAdapter = null;
            this.tableAdapterManager.CLASSTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_CENTRETableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.employeeTA;
            this.tableAdapterManager.SALARYTableAdapter = null;
            this.tableAdapterManager.SIMS_USERSTableAdapter = null;
            this.tableAdapterManager.STUDENT_ENROLLMENTTableAdapter = null;
            this.tableAdapterManager.STUDENT_FEETableAdapter = null;
            this.tableAdapterManager.STUDENT_PAYMENTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.SUBJECTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SIMS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BrowseStaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 585);
            this.Controls.Add(this.TextBoxSearchStaff);
            this.Controls.Add(this.metroTileSearchStaff);
            this.Controls.Add(this.eMPLOYEEDataGridView);
            this.Controls.Add(this.eMPLOYEEBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowseStaffDetails";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Staff Details";
            this.Load += new System.EventHandler(this.BrowseStaffDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).EndInit();
            this.eMPLOYEEBindingNavigator.ResumeLayout(false);
            this.eMPLOYEEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DSTableAdapters.EMPLOYEETableAdapter employeeTA;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLOYEEBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eMPLOYEEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private MetroFramework.Controls.MetroTile metroTileSearchStaff;
        private MetroFramework.Controls.MetroTextBox TextBoxSearchStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIPCODE;
    }
}