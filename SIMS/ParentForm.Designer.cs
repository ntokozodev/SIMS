namespace SIMS
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.exitTile = new MetroFramework.Controls.MetroTile();
            this.ParentButtonPanel = new MetroFramework.Controls.MetroPanel();
            this.LearnerModuleTile = new MetroFramework.Controls.MetroTile();
            this.StudentMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addNewLearnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseLearnerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignLearnerToClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.AccessMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTile = new MetroFramework.Controls.MetroTile();
            this.aboutTile = new MetroFramework.Controls.MetroTile();
            this.StaffTile = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.ParentButtonPanel.SuspendLayout();
            this.StudentMenu.SuspendLayout();
            this.AccessMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitTile
            // 
            this.exitTile.ActiveControl = null;
            this.exitTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitTile.Location = new System.Drawing.Point(20, 684);
            this.exitTile.Name = "exitTile";
            this.exitTile.Size = new System.Drawing.Size(1134, 42);
            this.exitTile.Style = MetroFramework.MetroColorStyle.Green;
            this.exitTile.TabIndex = 1;
            this.exitTile.Text = "Close Application";
            this.exitTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.exitTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.exitTile.UseSelectable = true;
            this.exitTile.UseStyleColors = true;
            this.exitTile.Click += new System.EventHandler(this.exitTile_Click);
            // 
            // ParentButtonPanel
            // 
            this.ParentButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentButtonPanel.Controls.Add(this.LearnerModuleTile);
            this.ParentButtonPanel.Controls.Add(this.metroTile1);
            this.ParentButtonPanel.Controls.Add(this.helpTile);
            this.ParentButtonPanel.Controls.Add(this.aboutTile);
            this.ParentButtonPanel.Controls.Add(this.StaffTile);
            this.ParentButtonPanel.Controls.Add(this.metroTile2);
            this.ParentButtonPanel.HorizontalScrollbarBarColor = true;
            this.ParentButtonPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ParentButtonPanel.HorizontalScrollbarSize = 10;
            this.ParentButtonPanel.Location = new System.Drawing.Point(20, 54);
            this.ParentButtonPanel.Name = "ParentButtonPanel";
            this.ParentButtonPanel.Size = new System.Drawing.Size(1134, 38);
            this.ParentButtonPanel.Style = MetroFramework.MetroColorStyle.Black;
            this.ParentButtonPanel.TabIndex = 4;
            this.ParentButtonPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ParentButtonPanel.VerticalScrollbarBarColor = true;
            this.ParentButtonPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ParentButtonPanel.VerticalScrollbarSize = 10;
            // 
            // LearnerModuleTile
            // 
            this.LearnerModuleTile.ActiveControl = null;
            this.LearnerModuleTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LearnerModuleTile.ContextMenuStrip = this.StudentMenu;
            this.LearnerModuleTile.Location = new System.Drawing.Point(565, 1);
            this.LearnerModuleTile.Name = "LearnerModuleTile";
            this.LearnerModuleTile.Size = new System.Drawing.Size(170, 27);
            this.LearnerModuleTile.Style = MetroFramework.MetroColorStyle.Brown;
            this.LearnerModuleTile.TabIndex = 2;
            this.LearnerModuleTile.Text = "Student Module";
            this.LearnerModuleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LearnerModuleTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LearnerModuleTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LearnerModuleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.LearnerModuleTile.UseSelectable = true;
            // 
            // StudentMenu
            // 
            this.StudentMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.StudentMenu.BackColor = System.Drawing.Color.Chocolate;
            this.StudentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLearnerToolStripMenuItem,
            this.browseLearnerDetailsToolStripMenuItem,
            this.assignLearnerToClassToolStripMenuItem});
            this.StudentMenu.Name = "StudentMenu";
            this.StudentMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StudentMenu.ShowImageMargin = false;
            this.StudentMenu.Size = new System.Drawing.Size(226, 104);
            this.StudentMenu.Style = MetroFramework.MetroColorStyle.Brown;
            this.StudentMenu.Text = "StudentMenu";
            this.StudentMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StudentMenu.UseStyleColors = true;
            // 
            // addNewLearnerToolStripMenuItem
            // 
            this.addNewLearnerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addNewLearnerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewLearnerToolStripMenuItem.Name = "addNewLearnerToolStripMenuItem";
            this.addNewLearnerToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addNewLearnerToolStripMenuItem.Text = "Add New Learner";
            this.addNewLearnerToolStripMenuItem.Click += new System.EventHandler(this.addNewLearnerToolStripMenuItem_Click);
            // 
            // browseLearnerDetailsToolStripMenuItem
            // 
            this.browseLearnerDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.browseLearnerDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.browseLearnerDetailsToolStripMenuItem.Name = "browseLearnerDetailsToolStripMenuItem";
            this.browseLearnerDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.browseLearnerDetailsToolStripMenuItem.Text = "Browse Learner Details";
            this.browseLearnerDetailsToolStripMenuItem.Click += new System.EventHandler(this.browseLearnerDetailsToolStripMenuItem_Click);
            // 
            // assignLearnerToClassToolStripMenuItem
            // 
            this.assignLearnerToClassToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.assignLearnerToClassToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.assignLearnerToClassToolStripMenuItem.Name = "assignLearnerToClassToolStripMenuItem";
            this.assignLearnerToClassToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.assignLearnerToClassToolStripMenuItem.Text = "Assign Learner to Class";
            this.assignLearnerToClassToolStripMenuItem.Click += new System.EventHandler(this.assignLearnerToClassToolStripMenuItem_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile1.ContextMenuStrip = this.AccessMenu;
            this.metroTile1.Location = new System.Drawing.Point(37, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(170, 27);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Access Control";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            // 
            // AccessMenu
            // 
            this.AccessMenu.BackColor = System.Drawing.Color.Purple;
            this.AccessMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AccessMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.AccessMenu.Name = "AccessMenu";
            this.AccessMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AccessMenu.ShowImageMargin = false;
            this.AccessMenu.Size = new System.Drawing.Size(190, 108);
            this.AccessMenu.Style = MetroFramework.MetroColorStyle.Purple;
            this.AccessMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AccessMenu.UseStyleColors = true;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpTile
            // 
            this.helpTile.ActiveControl = null;
            this.helpTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpTile.Location = new System.Drawing.Point(917, 0);
            this.helpTile.Name = "helpTile";
            this.helpTile.Size = new System.Drawing.Size(170, 27);
            this.helpTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.helpTile.TabIndex = 6;
            this.helpTile.Text = "Help";
            this.helpTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.helpTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.helpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.helpTile.UseSelectable = true;
            this.helpTile.UseStyleColors = true;
            // 
            // aboutTile
            // 
            this.aboutTile.ActiveControl = null;
            this.aboutTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aboutTile.Location = new System.Drawing.Point(741, 1);
            this.aboutTile.Name = "aboutTile";
            this.aboutTile.Size = new System.Drawing.Size(170, 27);
            this.aboutTile.Style = MetroFramework.MetroColorStyle.Red;
            this.aboutTile.TabIndex = 5;
            this.aboutTile.Text = "About";
            this.aboutTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aboutTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.aboutTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.aboutTile.UseSelectable = true;
            this.aboutTile.UseStyleColors = true;
            this.aboutTile.Click += new System.EventHandler(this.aboutTile_Click);
            // 
            // StaffTile
            // 
            this.StaffTile.ActiveControl = null;
            this.StaffTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StaffTile.Location = new System.Drawing.Point(389, 1);
            this.StaffTile.Name = "StaffTile";
            this.StaffTile.Size = new System.Drawing.Size(170, 27);
            this.StaffTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.StaffTile.TabIndex = 4;
            this.StaffTile.Text = "Employee Module";
            this.StaffTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StaffTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StaffTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.StaffTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.StaffTile.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile2.Location = new System.Drawing.Point(213, 1);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(170, 27);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Accounts Module";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(20, 88);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1134, 599);
            this.MainPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 746);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ParentButtonPanel);
            this.Controls.Add(this.exitTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.Opacity = 0.95D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "School Information Management System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.ParentButtonPanel.ResumeLayout(false);
            this.StudentMenu.ResumeLayout(false);
            this.AccessMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile exitTile;
        private MetroFramework.Controls.MetroPanel ParentButtonPanel;
        private MetroFramework.Controls.MetroTile StaffTile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile aboutTile;
        private MetroFramework.Controls.MetroTile LearnerModuleTile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroContextMenu StudentMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewLearnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseLearnerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignLearnerToClassToolStripMenuItem;
        private MetroFramework.Controls.MetroTile helpTile;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroContextMenu AccessMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

