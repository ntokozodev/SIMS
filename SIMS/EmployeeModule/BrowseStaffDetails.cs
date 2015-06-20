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

namespace SIMS.EmployeeModule
{
    public partial class BrowseStaffDetails : MetroForm
    {
        public BrowseStaffDetails()
        {
            InitializeComponent();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.eMPLOYEEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dS);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving data:\n" + ex.Message.ToString());
            }
        }

        private void BrowseStaffDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.EMPLOYEE' table. You can move, or remove it, as needed.
                this.employeeTA.Fill(this.dS.EMPLOYEE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee details:\n" + ex.Message.ToString());
            }
        }

        private void metroTileSearchStaff_Click(object sender, EventArgs e)
        {
            int rows = 0;
            try
            {
                rows = employeeTA.SearchBySurname(this.dS.EMPLOYEE, TextBoxSearchStaff.Text.ToLower());
                if (rows == 0)
                {
                    MessageBox.Show("The surname: " + TextBoxSearchStaff.Text + " does not exist in our database records.");
                    TextBoxSearchStaff.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching staff member:\n" + ex.Message.ToString());
            }
        }
    }
}
