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

namespace SIMS.LearnerModule
{
    public partial class BrowseDetails : MetroForm
    {
        private SimsOracle db;
        public BrowseDetails()
        {
            InitializeComponent();
        }

        private void BrowseDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.STUDENT' table. You can move, or remove it, as needed.
            this.TAStudent.Fill(this.dS.STUDENT);
        }

        private void metroTileUpdateLearner_Click(object sender, EventArgs e)
        {
            try
            {
                TAStudent.Update(this.dS.STUDENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!\n" + ex.Message.ToString());
            }
        }

        private void metroTileSearchLearner_Click(object sender, EventArgs e)
        {
            try
            {
                TAStudent.FillByLearnerSearch(this.dS.STUDENT, metroTextBoxSearchLearner.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to database\n" + ex.Message.ToString());
            }
        }
    }
}
