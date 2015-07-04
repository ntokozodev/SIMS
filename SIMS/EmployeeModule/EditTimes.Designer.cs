namespace SIMS.EmployeeModule
{
    partial class EditTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTimes));
            this.dS = new SIMS.DS();
            this.eDIT_STAFF_ATTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDIT_STAFF_ATTENDANCETableAdapter = new SIMS.DSTableAdapters.EDIT_STAFF_ATTENDANCETableAdapter();
            this.tableAdapterManager = new SIMS.DSTableAdapters.TableAdapterManager();
            this.eDIT_STAFF_ATTENDANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eDIT_STAFF_ATTENDANCEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT_STAFF_ATTENDANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT_STAFF_ATTENDANCEBindingNavigator)).BeginInit();
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT_STAFF_ATTENDANCEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eDIT_STAFF_ATTENDANCEBindingSource
            // 
            this.eDIT_STAFF_ATTENDANCEBindingSource.DataMember = "EDIT_STAFF_ATTENDANCE";
            this.eDIT_STAFF_ATTENDANCEBindingSource.DataSource = this.dS;
            // 
            // eDIT_STAFF_ATTENDANCETableAdapter
            // 
            this.eDIT_STAFF_ATTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATTENDEESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CENTRETableAdapter = null;
            this.tableAdapterManager.CLASSTableAdapter = null;
            this.tableAdapterManager.CLOCK_TIMESTableAdapter = null;
            this.tableAdapterManager.EDIT_STAFF_ATTENDANCETableAdapter = this.eDIT_STAFF_ATTENDANCETableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.SALARYTableAdapter = null;
            this.tableAdapterManager.SIMS_USERSTableAdapter = null;
            this.tableAdapterManager.STUDENT_FEETableAdapter = null;
            this.tableAdapterManager.STUDENT_PAYMENTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.SUBJECTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SIMS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eDIT_STAFF_ATTENDANCEBindingNavigator
            // 
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.AddNewItem = null;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.BindingSource = this.eDIT_STAFF_ATTENDANCEBindingSource;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem});
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.Name = "eDIT_STAFF_ATTENDANCEBindingNavigator";
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.Size = new System.Drawing.Size(879, 25);
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.TabIndex = 0;
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.Text = "bindingNavigator1";
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
            // eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem
            // 
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.Image")));
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.Name = "eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem";
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.Text = "Save Data";
            this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem_Click);
            // 
            // eDIT_STAFF_ATTENDANCEDataGridView
            // 
            this.eDIT_STAFF_ATTENDANCEDataGridView.AllowUserToAddRows = false;
            this.eDIT_STAFF_ATTENDANCEDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eDIT_STAFF_ATTENDANCEDataGridView.AutoGenerateColumns = false;
            this.eDIT_STAFF_ATTENDANCEDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.eDIT_STAFF_ATTENDANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eDIT_STAFF_ATTENDANCEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eDIT_STAFF_ATTENDANCEDataGridView.DataSource = this.eDIT_STAFF_ATTENDANCEBindingSource;
            this.eDIT_STAFF_ATTENDANCEDataGridView.Location = new System.Drawing.Point(114, 105);
            this.eDIT_STAFF_ATTENDANCEDataGridView.Name = "eDIT_STAFF_ATTENDANCEDataGridView";
            this.eDIT_STAFF_ATTENDANCEDataGridView.Size = new System.Drawing.Size(669, 427);
            this.eDIT_STAFF_ATTENDANCEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EMPLOYEE ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SUBJECT";
            this.dataGridViewTextBoxColumn2.HeaderText = "SUBJECT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TIME_IN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIME IN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 135;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TIME_OUT";
            this.dataGridViewTextBoxColumn4.HeaderText = "TIME OUT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 135;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NUM_LESSONS";
            this.dataGridViewTextBoxColumn5.HeaderText = "LESSONS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // EditTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 584);
            this.Controls.Add(this.eDIT_STAFF_ATTENDANCEDataGridView);
            this.Controls.Add(this.eDIT_STAFF_ATTENDANCEBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTimes";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit Staff Attendance";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.EditTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT_STAFF_ATTENDANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT_STAFF_ATTENDANCEBindingNavigator)).EndInit();
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.ResumeLayout(false);
            this.eDIT_STAFF_ATTENDANCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT_STAFF_ATTENDANCEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource eDIT_STAFF_ATTENDANCEBindingSource;
        private DSTableAdapters.EDIT_STAFF_ATTENDANCETableAdapter eDIT_STAFF_ATTENDANCETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eDIT_STAFF_ATTENDANCEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eDIT_STAFF_ATTENDANCEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eDIT_STAFF_ATTENDANCEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;



    }
}