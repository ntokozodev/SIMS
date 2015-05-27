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
                                  TextBoxIDNumber.Text.ToString(), TextBoxGIdNumber.Text.ToString(), 
                                  ComboBoxGender.Text.ToString(), TextBoxContactNumber.Text.ToString(), 
                                  DateAdmission, TextBoxAdminNumber.Text.ToString(), 
                                  TextBoxAddressLine1.Text.ToString(), TextBoxAddressLine2.Text.ToString(), 
                                  TextBoxSuburb.Text.ToString(), TextBoxCity.Text.ToString(), 
                                  TextBoxZipCode.Text.ToString(), TextBoxEmailAddress.Text.ToString()
                                 );

            int rowsUpdated = student.addNewStudent(student);

            if (rowsUpdated > 0)
            {
                MetroMessageBox.Show(ParentForm, "Student details entered successful");
                clearAll();
            }
            else
                MetroMessageBox.Show(ParentForm, "Details not successful entered!");
        }

        internal void clearAll()
        {
            TextBoxFirstName.Clear();
            TextBoxLastName.Clear();
            TextBoxIDNumber.Clear();
            TextBoxAddressLine1.Clear();
            TextBoxAddressLine2.Clear();
            TextBoxAdminNumber.Clear();
            TextBoxCity.Clear();
            TextBoxContactNumber.Clear();
            TextBoxEmailAddress.Clear();
            TextBoxGEmailAddress.Clear();
            TextBoxGFirstName.Clear();
            TextBoxGIdNumber.Clear();
            TextBoxGLastName.Clear();
            TextBoxGContactNumber.Clear();
            TextBoxSuburb.Clear();
            TextBoxZipCode.Clear();
            DateAdmission.ResetText();
            ComboBoxCentre.ResetText();
            ComboBoxGender.ResetText();
            ComboBoxGGender.ResetText();
        }
    }
}
