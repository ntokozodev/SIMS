namespace SIMS.AdminControl
{
    partial class ViewSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSubject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sUBJECTDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectBS = new System.Windows.Forms.BindingSource(this.components);
            this.veiw_subjectDS = new SIMS.DS();
            this.subjectTA = new SIMS.DSTableAdapters.SUBJECTTableAdapter();
            this.tableAM = new SIMS.DSTableAdapters.TableAdapterManager();
            this.subjectBN = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sUBJECTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiw_subjectDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBN)).BeginInit();
            this.subjectBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.sUBJECTDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(88, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sUBJECTDataGridView
            // 
            this.sUBJECTDataGridView.AllowUserToAddRows = false;
            this.sUBJECTDataGridView.AutoGenerateColumns = false;
            this.sUBJECTDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sUBJECTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUBJECTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SUBJECT,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sUBJECTDataGridView.DataSource = this.subjectBS;
            this.sUBJECTDataGridView.Location = new System.Drawing.Point(141, 62);
            this.sUBJECTDataGridView.Name = "sUBJECTDataGridView";
            this.sUBJECTDataGridView.Size = new System.Drawing.Size(514, 324);
            this.sUBJECTDataGridView.TabIndex = 0;
            // 
            // subjectBS
            // 
            this.subjectBS.DataMember = "SUBJECT";
            this.subjectBS.DataSource = this.veiw_subjectDS;
            // 
            // veiw_subjectDS
            // 
            this.veiw_subjectDS.DataSetName = "DS";
            this.veiw_subjectDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectTA
            // 
            this.subjectTA.ClearBeforeFill = true;
            // 
            // tableAM
            // 
            this.tableAM.ATTENDEESTableAdapter = null;
            this.tableAM.BackupDataSetBeforeUpdate = false;
            this.tableAM.CENTRETableAdapter = null;
            this.tableAM.CLASSTableAdapter = null;
            this.tableAM.CLOCK_TIMESTableAdapter = null;
            this.tableAM.EDIT_STAFF_ATTENDANCETableAdapter = null;
            this.tableAM.EMPLOYEETableAdapter = null;
            this.tableAM.SALARYTableAdapter = null;
            this.tableAM.SIMS_USERSTableAdapter = null;
            this.tableAM.STUDENT_FEETableAdapter = null;
            this.tableAM.STUDENT_PAYMENTTableAdapter = null;
            this.tableAM.STUDENTTableAdapter = null;
            this.tableAM.SUBJECTTableAdapter = this.subjectTA;
            this.tableAM.UpdateOrder = SIMS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subjectBN
            // 
            this.subjectBN.AddNewItem = null;
            this.subjectBN.BindingSource = this.subjectBS;
            this.subjectBN.CountItem = this.bindingNavigatorCountItem;
            this.subjectBN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjectBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sUBJECTBindingNavigatorSaveItem,
            this.toolStripSeparator});
            this.subjectBN.Location = new System.Drawing.Point(20, 60);
            this.subjectBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjectBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjectBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjectBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjectBN.Name = "subjectBN";
            this.subjectBN.PositionItem = this.bindingNavigatorPositionItem;
            this.subjectBN.Size = new System.Drawing.Size(936, 25);
            this.subjectBN.TabIndex = 1;
            this.subjectBN.Text = "bindingNavigator1";
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
            // sUBJECTBindingNavigatorSaveItem
            // 
            this.sUBJECTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sUBJECTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sUBJECTBindingNavigatorSaveItem.Image")));
            this.sUBJECTBindingNavigatorSaveItem.Name = "sUBJECTBindingNavigatorSaveItem";
            this.sUBJECTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sUBJECTBindingNavigatorSaveItem.Text = "Save Data";
            this.sUBJECTBindingNavigatorSaveItem.Click += new System.EventHandler(this.sUBJECTBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SUBJECT_CODE";
            this.dataGridViewTextBoxColumn1.HeaderText = "SUBJECT CODE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // SUBJECT
            // 
            this.SUBJECT.DataPropertyName = "SUBJECT";
            this.SUBJECT.HeaderText = "SUBJECT NAME";
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SUBJECT_COST";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "SUBJECT COST";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CATEGORY";
            this.dataGridViewTextBoxColumn4.HeaderText = "CATEGORY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ViewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 561);
            this.Controls.Add(this.subjectBN);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSubject";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "View School Subjects";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ViewSubject_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiw_subjectDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBN)).EndInit();
            this.subjectBN.ResumeLayout(false);
            this.subjectBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DS veiw_subjectDS;
        private System.Windows.Forms.BindingSource subjectBS;
        private DSTableAdapters.SUBJECTTableAdapter subjectTA;
        private DSTableAdapters.TableAdapterManager tableAM;
        private System.Windows.Forms.BindingNavigator subjectBN;
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
        private System.Windows.Forms.ToolStripButton sUBJECTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sUBJECTDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}