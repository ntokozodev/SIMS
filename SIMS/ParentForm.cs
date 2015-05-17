using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace SIMS
{
    public partial class ParentForm : MetroForm
    {
        LoginForm log = new LoginForm();
        public ParentForm()
        {
            InitializeComponent();
            log.ShowDialog();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            Control control = default(Control);
            MdiClient ctlMDI = default(MdiClient);

            // Loop through all of the form's controls looking for the control of type MdiClient.
            foreach (Control ctl in this.Controls) 
            {
	            try 
                {
		            // Attempt to cast the control to type MdiClient.
		            ctlMDI = (MdiClient)control;
	            } 
                catch (InvalidCastException exc) 
                {
		            // Catch and ignore the error if casting failed.
	            }
            }
        }

        internal void FormSetUp(MetroForm ChildForm)
        {

            var child = ChildForm;
            child.MdiParent = this;
            //child.WindowState = FormWindowState.Maximized;
            child.TopLevel = false;
            child.AutoScroll = true;
            MainPanel.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            child.Show();
        }

        private void exitTile_Click(object sender, EventArgs e)
        {
            DialogResult reply = default(DialogResult);
            reply = MetroMessageBox.Show(this, "Are you sure you want to exit application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }

        private void LearnerModuleTile_Click(object sender, EventArgs e)
        {
            LearnerModule.AddLearnerForm learner = new LearnerModule.AddLearnerForm();
            if (learner.IsMdiChild == false)
                FormSetUp(learner);
            else
                MetroMessageBox.Show(this, "Already on Student Module Form");

        }

        /* 
         * The String WndCls is the windows full path. Namespace.Classname 
         */
        internal bool CheckMdiClientDuplicates(string WndCls)
        {
            Form[] mdichld = ParentForm.MdiChildren;
            if (this.MdiChildren.Length == 0)
                return true;
            
            foreach (MetroForm selfm in mdichld)
            {
                string str = selfm.Name;
                str = str.IndexOf(WndCls).ToString();
                if (str != "-1")
                    return true;
            }
            return false;
        }

        private void aboutTile_Click(object sender, EventArgs e)
        {}

        private void addNewLearnerToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {}
    }
}
