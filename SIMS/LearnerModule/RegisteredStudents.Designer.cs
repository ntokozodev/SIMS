namespace SIMS.LearnerModule
{
    partial class RegisteredStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisteredStudents));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sTUDENT_ENROLLMENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENT_ENROLLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.sTUDENT_ENROLLMENTTableAdapter = new SIMS.DSTableAdapters.STUDENT_ENROLLMENTTableAdapter();
            this.tableAdapterManager = new SIMS.DSTableAdapters.TableAdapterManager();
            this.sTUDENT_ENROLLMENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_ENROLLMENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_ENROLLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_ENROLLMENTBindingNavigator)).BeginInit();
            this.sTUDENT_ENROLLMENTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.sTUDENT_ENROLLMENTDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(90, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sTUDENT_ENROLLMENTDataGridView
            // 
            this.sTUDENT_ENROLLMENTDataGridView.AllowUserToAddRows = false;
            this.sTUDENT_ENROLLMENTDataGridView.AutoGenerateColumns = false;
            this.sTUDENT_ENROLLMENTDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sTUDENT_ENROLLMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTUDENT_ENROLLMENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sTUDENT_ENROLLMENTDataGridView.DataSource = this.sTUDENT_ENROLLMENTBindingSource;
            this.sTUDENT_ENROLLMENTDataGridView.Location = new System.Drawing.Point(15, 19);
            this.sTUDENT_ENROLLMENTDataGridView.Name = "sTUDENT_ENROLLMENTDataGridView";
            this.sTUDENT_ENROLLMENTDataGridView.Size = new System.Drawing.Size(606, 449);
            this.sTUDENT_ENROLLMENTDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ADMISSION_NO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ADMISSION NO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SUBJECT_CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "SUBJECT CODE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACADEMIC_YEAR";
            this.dataGridViewTextBoxColumn3.HeaderText = "ACADEMIC YEAR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 123;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GRADE";
            this.dataGridViewTextBoxColumn4.HeaderText = "GRADE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COST";
            this.dataGridViewTextBoxColumn5.HeaderText = "COST";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // sTUDENT_ENROLLMENTBindingSource
            // 
            this.sTUDENT_ENROLLMENTBindingSource.DataMember = "STUDENT_ENROLLMENT";
            this.sTUDENT_ENROLLMENTBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENT_ENROLLMENTTableAdapter
            // 
            this.sTUDENT_ENROLLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CENTRETableAdapter = null;
            this.tableAdapterManager.CLASSTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.SALARYTableAdapter = null;
            this.tableAdapterManager.SIMS_USERSTableAdapter = null;
            this.tableAdapterManager.STUDENT_FEETableAdapter = null;
            this.tableAdapterManager.STUDENT_PAYMENTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.SUBJECTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SIMS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sTUDENT_ENROLLMENTBindingNavigator
            // 
            this.sTUDENT_ENROLLMENTBindingNavigator.AddNewItem = null;
            this.sTUDENT_ENROLLMENTBindingNavigator.BindingSource = this.sTUDENT_ENROLLMENTBindingSource;
            this.sTUDENT_ENROLLMENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem});
            this.sTUDENT_ENROLLMENTBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.sTUDENT_ENROLLMENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.Name = "sTUDENT_ENROLLMENTBindingNavigator";
            this.sTUDENT_ENROLLMENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sTUDENT_ENROLLMENTBindingNavigator.Size = new System.Drawing.Size(802, 25);
            this.sTUDENT_ENROLLMENTBindingNavigator.TabIndex = 1;
            this.sTUDENT_ENROLLMENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sTUDENT_ENROLLMENTBindingNavigatorSaveItem
            // 
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sTUDENT_ENROLLMENTBindingNavigatorSaveItem.Image")));
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem.Name = "sTUDENT_ENROLLMENTBindingNavigatorSaveItem";
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem.Text = "Save Data";
            this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.sTUDENT_ENROLLMENTBindingNavigatorSaveItem_Click);
            // 
            // RegisteredStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 577);
            this.Controls.Add(this.sTUDENT_ENROLLMENTBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisteredStudents";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Showing Registered Students";
            this.Load += new System.EventHandler(this.RegisteredStudents_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_ENROLLMENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_ENROLLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_ENROLLMENTBindingNavigator)).EndInit();
            this.sTUDENT_ENROLLMENTBindingNavigator.ResumeLayout(false);
            this.sTUDENT_ENROLLMENTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DS dS;
        private System.Windows.Forms.BindingSource sTUDENT_ENROLLMENTBindingSource;
        private DSTableAdapters.STUDENT_ENROLLMENTTableAdapter sTUDENT_ENROLLMENTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sTUDENT_ENROLLMENTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sTUDENT_ENROLLMENTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sTUDENT_ENROLLMENTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}