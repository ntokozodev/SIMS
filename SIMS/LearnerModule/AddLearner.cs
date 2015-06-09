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
    public partial class AddLearner : MetroForm
    {
        private Student student;

        public AddLearner()
        {
            InitializeComponent();
        }

        private void cancelTile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearTile_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void addDetailsTile_Click(object sender, EventArgs e)
        {
            student = new Student(TextBoxFirstName.Text.ToString(), TextBoxLastName.Text.ToString(), 
                                  TextBoxIDNumber.Text.ToString(), ComboBoxGender.Text.ToString(), 
                                  TextBoxContactNumber.Text.ToString(), DateAdmission, 
                                  TextBoxAdminNumber.Text.ToString(), TextBoxAddressLine1.Text.ToString(), 
                                  TextBoxSuburb.Text.ToString(), TextBoxCity.Text.ToString(), 
                                  TextBoxZipCode.Text.ToString(), TextBoxEmailAddress.Text.ToString(),
                                  ComboBoxCentre.Text.ToString()
                                 );

            int rowsUpdated = student.addNewStudent(student);

            if (rowsUpdated > 0)
            {
                MetroMessageBox.Show(ParentForm, "", "Student Details Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                clearAll();
            }
            else
                MetroMessageBox.Show(ParentForm, " ","Details not captured!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal void clearAll()
        {
            TextBoxFirstName.Clear();
            TextBoxLastName.Clear();
            TextBoxIDNumber.Clear();
            TextBoxAddressLine1.Clear();
            TextBoxAdminNumber.Clear();
            TextBoxZipCode.Clear();
            TextBoxContactNumber.Clear();
            TextBoxEmailAddress.Clear();
            TextBoxCity.Clear();
            TextBoxEmailAddress.Clear();
            TextBoxAddressLine1.Clear();
            TextBoxSuburb.Clear();
            TextBoxSuburb.Clear();
            TextBoxCity.Clear();
            DateAdmission.ResetText();
            ComboBoxCentre.ResetText();
            ComboBoxGender.ResetText();
        }

        private void AddLearner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CENTRE' table. You can move, or remove it, as needed.
            this.cENTRETableAdapter.Fill(this.dS.CENTRE);

        }
    }
}
