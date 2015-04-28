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
            this.exitTile = new MetroFramework.Controls.MetroTile();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // exitTile
            // 
            this.exitTile.ActiveControl = null;
            this.exitTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitTile.Location = new System.Drawing.Point(20, 527);
            this.exitTile.Name = "exitTile";
            this.exitTile.Size = new System.Drawing.Size(987, 42);
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
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(987, 467);
            this.mainPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 589);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.exitTile);
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.Opacity = 0.95D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "School Information System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile exitTile;
        private MetroFramework.Controls.MetroPanel mainPanel;
    }
}

