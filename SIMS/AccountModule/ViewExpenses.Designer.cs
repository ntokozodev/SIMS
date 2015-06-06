namespace SIMS.AccountModule
{
    partial class ViewExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTileExpChanges = new MetroFramework.Controls.MetroTile();
            this.metroGridExpenses = new MetroFramework.Controls.MetroGrid();
            this.eXPENSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new SIMS.DS();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTileExpPayChanges = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSENOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPTUREDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSEPAYMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TAExpenses = new SIMS.DSTableAdapters.EXPENSETableAdapter();
            this.TAExpensePayement = new SIMS.DSTableAdapters.EXPENSE_PAYMENTTableAdapter();
            this.metroTilePrint = new MetroFramework.Controls.MetroTile();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSEPAYMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.metroTileExpChanges);
            this.groupBox1.Controls.Add(this.metroGridExpenses);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Types";
            // 
            // metroTileExpChanges
            // 
            this.metroTileExpChanges.ActiveControl = null;
            this.metroTileExpChanges.Location = new System.Drawing.Point(6, 368);
            this.metroTileExpChanges.Name = "metroTileExpChanges";
            this.metroTileExpChanges.Size = new System.Drawing.Size(135, 35);
            this.metroTileExpChanges.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileExpChanges.TabIndex = 1;
            this.metroTileExpChanges.Text = "Save Changes";
            this.metroTileExpChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExpChanges.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileExpChanges.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileExpChanges.UseSelectable = true;
            this.metroTileExpChanges.UseStyleColors = true;
            this.metroTileExpChanges.Click += new System.EventHandler(this.metroTileExpChanges_Click);
            // 
            // metroGridExpenses
            // 
            this.metroGridExpenses.AllowUserToAddRows = false;
            this.metroGridExpenses.AllowUserToResizeRows = false;
            this.metroGridExpenses.AutoGenerateColumns = false;
            this.metroGridExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPENSEIDDataGridViewTextBoxColumn,
            this.eXPENSETYPEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn});
            this.metroGridExpenses.DataSource = this.eXPENSEBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridExpenses.DefaultCellStyle = dataGridViewCellStyle19;
            this.metroGridExpenses.EnableHeadersVisualStyles = false;
            this.metroGridExpenses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridExpenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridExpenses.Location = new System.Drawing.Point(6, 35);
            this.metroGridExpenses.Name = "metroGridExpenses";
            this.metroGridExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.metroGridExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridExpenses.Size = new System.Drawing.Size(490, 313);
            this.metroGridExpenses.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridExpenses.TabIndex = 0;
            this.metroGridExpenses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGridExpenses.UseStyleColors = true;
            // 
            // eXPENSEIDDataGridViewTextBoxColumn
            // 
            this.eXPENSEIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eXPENSEIDDataGridViewTextBoxColumn.DataPropertyName = "EXPENSE_ID";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXPENSEIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.eXPENSEIDDataGridViewTextBoxColumn.FillWeight = 66.8235F;
            this.eXPENSEIDDataGridViewTextBoxColumn.HeaderText = "EXPENSE ID";
            this.eXPENSEIDDataGridViewTextBoxColumn.Name = "eXPENSEIDDataGridViewTextBoxColumn";
            // 
            // eXPENSETYPEDataGridViewTextBoxColumn
            // 
            this.eXPENSETYPEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eXPENSETYPEDataGridViewTextBoxColumn.DataPropertyName = "EXPENSE_TYPE";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXPENSETYPEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.eXPENSETYPEDataGridViewTextBoxColumn.FillWeight = 91.37056F;
            this.eXPENSETYPEDataGridViewTextBoxColumn.HeaderText = "EXPENSE TYPE";
            this.eXPENSETYPEDataGridViewTextBoxColumn.Name = "eXPENSETYPEDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRIPTIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.dESCRIPTIONDataGridViewTextBoxColumn.FillWeight = 141.8059F;
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.metroTileExpPayChanges);
            this.groupBox2.Controls.Add(this.metroGrid1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(567, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expense Payments";
            // 
            // metroTileExpPayChanges
            // 
            this.metroTileExpPayChanges.ActiveControl = null;
            this.metroTileExpPayChanges.Location = new System.Drawing.Point(15, 368);
            this.metroTileExpPayChanges.Name = "metroTileExpPayChanges";
            this.metroTileExpPayChanges.Size = new System.Drawing.Size(148, 35);
            this.metroTileExpPayChanges.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileExpPayChanges.TabIndex = 1;
            this.metroTileExpPayChanges.Text = "Save Changes";
            this.metroTileExpPayChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExpPayChanges.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileExpPayChanges.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileExpPayChanges.UseSelectable = true;
            this.metroTileExpPayChanges.UseStyleColors = true;
            this.metroTileExpPayChanges.Click += new System.EventHandler(this.metroTileExpPayChanges_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn,
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn,
            this.eXPENSENOTEDataGridViewTextBoxColumn,
            this.pAYMENTDATEDataGridViewTextBoxColumn,
            this.cAPTUREDDATEDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.eXPENSEPAYMENTBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle27;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(15, 35);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(524, 313);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.UseStyleColors = true;
            // 
            // eXPENSEPAYMENTIDDataGridViewTextBoxColumn
            // 
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn.DataPropertyName = "EXPENSE_PAYMENT_ID";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn.HeaderText = "PAYMENT ID";
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn.Name = "eXPENSEPAYMENTIDDataGridViewTextBoxColumn";
            this.eXPENSEPAYMENTIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // eXPENSEAMOUNTDataGridViewTextBoxColumn
            // 
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "EXPENSE_AMOUNT";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT (R)";
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn.Name = "eXPENSEAMOUNTDataGridViewTextBoxColumn";
            this.eXPENSEAMOUNTDataGridViewTextBoxColumn.Width = 70;
            // 
            // eXPENSENOTEDataGridViewTextBoxColumn
            // 
            this.eXPENSENOTEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eXPENSENOTEDataGridViewTextBoxColumn.DataPropertyName = "EXPENSE_NOTE";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXPENSENOTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.eXPENSENOTEDataGridViewTextBoxColumn.HeaderText = "NOTE";
            this.eXPENSENOTEDataGridViewTextBoxColumn.Name = "eXPENSENOTEDataGridViewTextBoxColumn";
            // 
            // pAYMENTDATEDataGridViewTextBoxColumn
            // 
            this.pAYMENTDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pAYMENTDATEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_DATE";
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAYMENTDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.pAYMENTDATEDataGridViewTextBoxColumn.HeaderText = "PAYMENT DATE";
            this.pAYMENTDATEDataGridViewTextBoxColumn.Name = "pAYMENTDATEDataGridViewTextBoxColumn";
            this.pAYMENTDATEDataGridViewTextBoxColumn.Width = 97;
            // 
            // cAPTUREDDATEDataGridViewTextBoxColumn
            // 
            this.cAPTUREDDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cAPTUREDDATEDataGridViewTextBoxColumn.DataPropertyName = "CAPTURED_DATE";
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAPTUREDDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.cAPTUREDDATEDataGridViewTextBoxColumn.HeaderText = "CAPTURED DATE";
            this.cAPTUREDDATEDataGridViewTextBoxColumn.Name = "cAPTUREDDATEDataGridViewTextBoxColumn";
            this.cAPTUREDDATEDataGridViewTextBoxColumn.Width = 103;
            // 
            // eXPENSEPAYMENTBindingSource
            // 
            this.eXPENSEPAYMENTBindingSource.DataMember = "EXPENSE_PAYMENT";
            this.eXPENSEPAYMENTBindingSource.DataSource = this.dS;
            // 
            // TAExpenses
            // 
            this.TAExpenses.ClearBeforeFill = true;
            // 
            // TAExpensePayement
            // 
            this.TAExpensePayement.ClearBeforeFill = true;
            // 
            // metroTilePrint
            // 
            this.metroTilePrint.ActiveControl = null;
            this.metroTilePrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTilePrint.Location = new System.Drawing.Point(933, 514);
            this.metroTilePrint.Name = "metroTilePrint";
            this.metroTilePrint.Size = new System.Drawing.Size(75, 32);
            this.metroTilePrint.TabIndex = 2;
            this.metroTilePrint.Text = "Print";
            this.metroTilePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilePrint.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTilePrint.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTilePrint.UseSelectable = true;
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTileClose.Location = new System.Drawing.Point(1037, 514);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(75, 32);
            this.metroTileClose.TabIndex = 3;
            this.metroTileClose.Text = "Close";
            this.metroTileClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // ViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 560);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.metroTilePrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewExpenses";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "View Expenses";
            this.Load += new System.EventHandler(this.ViewExpenses_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSEPAYMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid metroGridExpenses;
        private System.Windows.Forms.GroupBox groupBox2;
        private DS dS;
        private System.Windows.Forms.BindingSource eXPENSEBindingSource;
        private DSTableAdapters.EXPENSETableAdapter TAExpenses;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource eXPENSEPAYMENTBindingSource;
        private DSTableAdapters.EXPENSE_PAYMENTTableAdapter TAExpensePayement;
        private MetroFramework.Controls.MetroTile metroTileExpChanges;
        private MetroFramework.Controls.MetroTile metroTileExpPayChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTilePrint;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSEPAYMENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSEAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSENOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPTUREDDATEDataGridViewTextBoxColumn;
    }
}