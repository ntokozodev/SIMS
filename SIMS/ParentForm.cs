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
using SIMS.LearnerModule;

namespace SIMS
{
    public partial class ParentForm : MetroForm
    {
        LoginForm log = new LoginForm();

        private AddLearner learner = null;
        private BrowseDetails details = null;
        private AsignLearner asign = null;

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
            try 
            {
                var child = ChildForm;
                child.MdiParent = this;
                child.TopLevel = false;
                child.AutoScroll = true;
                MainPanel.Controls.Add(child);
                MainPanel.Controls.SetChildIndex(child, 0);
                child.Dock = DockStyle.Fill;
                child.Show();
            }
            catch (Exception ex) 
            {
                MetroMessageBox.Show(this, "Error:\n" + ex.Message.ToString());
            }
        }

        private void exitTile_Click(object sender, EventArgs e)
        {
            DialogResult reply = default(DialogResult);
            reply = MetroMessageBox.Show(this, "Do you want to close the application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }

        private void aboutTile_Click(object sender, EventArgs e)
        {}

        private void addNewLearnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (learner != null)
                learner.Close();
            learner = new AddLearner();
            FormSetUp(learner);
        }

        private void browseLearnerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (details != null)
                details.Close();
            details = new BrowseDetails();
            FormSetUp(details);
        }

        private void assignLearnerToClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asign != null)
                asign.Close();
            asign = new AsignLearner();
            FormSetUp(asign);
        }
    }
}
