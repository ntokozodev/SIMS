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
