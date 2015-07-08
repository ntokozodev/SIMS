/**
 * SIMS is (c) 2015 Ntokozo. All rights reserved.
 * 
 * http://www.ntokozo.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Ntokozo. All rights reserved.
 * 
 * --------------------------------------------------------------------------------
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met: 
 *
 * 1) Redistributions of source code must retain the above copyright notice. 
 * 2) Redistributions in binary form must reproduce the above copyright notice 
 *    in the documentation and/or other materials provided with the distribution. 
 *
 * --------------------------------------------------------------------------------
 * Contributers to the code:
 *		- Ntokozo Nicholas Shagala [NNS]
 */

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
using Validation;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace SIMS.LearnerModule
{
    public partial class AddLearner : MetroForm
    {
        private Student student;
        private ValidationClass checkValue;

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
            int rowsUpdated = 0;
            if (checkAllConditions())
            {
                student = new Student(TextBoxFirstName.Text.ToString(), TextBoxLastName.Text.ToString(),
                                  TextBoxIDNumber.Text.ToString(), ComboBoxGender.Text.ToString(),
                                  TextBoxContactNumber.Text.ToString(), DateAdmission,
                                  TextBoxAddressLine1.Text.ToString(), TextBoxSuburb.Text.ToString(),
                                  TextBoxCity.Text.ToString(), TextBoxZipCode.Text.ToString(),
                                  TextBoxEmailAddress.Text.ToString(), ComboBoxCentre.Text.ToString()
                                 );
                rowsUpdated = student.addNewStudent(student);
            }

            if (rowsUpdated > 0)
            {
                MetroMessageBox.Show(ParentForm, "", "Student Details Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                clearAll();
            }
        }

        private bool checkAllConditions()
        {
            checkValue = new ValidationClass();
            if (TextBoxFirstName.Text == "")
            {
                MessageBox.Show("You should enter first name");
                return false;
            }
            else if (TextBoxLastName.Text == "")
            {
                MessageBox.Show("You should enter last name");
                return false;
            }
            else if (TextBoxIDNumber.Text == "")
            {
                MessageBox.Show("You should enter ID number");
                return false;
            }
            else if (!checkValue.isValidIDNumber(TextBoxIDNumber.Text))
            {
                MessageBox.Show("ID number format is not valid");
                return false;
            }
            else if (TextBoxContactNumber.Text == "")
            {
                MessageBox.Show("You should enter contact number");
                return false;
            }
            else if (!checkValue.isValidPhoneNumber(TextBoxContactNumber.Text))
            {
                MessageBox.Show("Contact number format is not valid");
                return false;
            }
            else if (ComboBoxGender.Text == "")
            {
                MessageBox.Show("You select gender");
                return false;
            }
            else if (ComboBoxCentre.Text == "")
            {
                MessageBox.Show("You select centre");
                return false;
            }
            else if (TextBoxEmailAddress.Text != "" && !checkValue.isValidEmail(TextBoxEmailAddress.Text))
            {
                    MessageBox.Show("Email address format is not valid");
                    return false;
            }
            else if (TextBoxAddressLine1.Text == "")
            {
                MessageBox.Show("You should enter address");
                return false;
            }
            else if (TextBoxSuburb.Text == "")
            {
                MessageBox.Show("You should enter suburb");
                return false;
            }
            else if (TextBoxZipCode.Text == "")
            {
                MessageBox.Show("You should enter postal code");
                return false;
            }
            else
                return true;
        }

        internal void clearAll()
        {
            TextBoxFirstName.Clear();
            TextBoxLastName.Clear();
            TextBoxIDNumber.Clear();
            ComboBoxGender.ResetText();
            TextBoxContactNumber.Clear();
            TextBoxEmailAddress.Clear();
            TextBoxAddressLine1.Clear();
            TextBoxSuburb.Clear();
            TextBoxCity.Clear();
            TextBoxZipCode.Clear();
            DateAdmission.ResetText();
            ComboBoxCentre.ResetText();
        }

        private void AddLearner_Load(object sender, EventArgs e)
        { 
            try
            {
                // TODO: This line of code loads data into the 'add_learnerDS.CENTRE' table. You can move, or remove it, as needed.
                this.centreTA.Fill(this.add_learnerDS.CENTRE);
                // TODO: This line of code loads data into the 'dSS.CENTRE' table. You can move, or remove it, as needed.
                this.centreTA.Fill(this.add_learnerDS.CENTRE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error!\n" + ex.Message.ToString());
            }
        }
    }
}
