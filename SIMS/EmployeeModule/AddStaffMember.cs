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

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Validation;

namespace SIMS.EmployeeModule
{
    public partial class AddStaffMember : MetroForm
    {
        private SimsOracle db;
        private OracleCommand cmd;
        private ValidationClass checkIf = new ValidationClass();
        
        public AddStaffMember()
        {
            InitializeComponent();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void metroTileAdd_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;

            if (TextBoxFirstName.Text == "")
                MessageBox.Show("You must enter employee first name");
            else if (TextBoxLastName.Text == "")
                MessageBox.Show("You must enter employee last name");
            else if (!checkIf.isValidIDNumber(TextBoxCitizenID.Text))
                MessageBox.Show("ID number format is not valid");
            else if (!checkIf.isValidPhoneNumber(TextBoxContact.Text))
                MessageBox.Show("Contact number format is not valid");
            else if (ComboBoxRole.Text == "")
                MessageBox.Show("You must select a job role");
            else if (ComboBoxGender.Text == "")
                MessageBox.Show("You must select a gender");
            else if (TextBoxAddress.Text == "")
                MessageBox.Show("Enter employee address");
            else if (TextBoxCity.Text == "")
                MessageBox.Show("Enter employee city");
            else if (TextBoxZipCode.Text == "" || TextBoxZipCode.Text.Length > 4 || TextBoxZipCode.Text.Length < 0)
                MessageBox.Show("Employee postal code is not valid");
            else if (TextBoxEmail.Text != "" && !checkIf.isValidEmail(TextBoxEmail.Text))
                MessageBox.Show("Email address format is not valid");
            else
            {
                var dateString = DateTimeHireStaff.Value.ToShortDateString();
                try
                {
                    string sql = "INSERT INTO SIMS.EMPLOYEE" +
                                 "(NAME, SURNAME, GENDER, CITIZEN_ID, PHONE, ROLE, HIRE_DATE, EMAIL, ADDRESS, CITY, ZIPCODE)" +
                                 " VALUES " +
                                 "(:NAME, :SURNAME, :GENDER, :CITIZEN_ID, :PHONE, :ROLE, :HIRE_DATE, :EMAIL, :ADDRESS, :CITY, :ZIPCODE)";

                    cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("NAME", TextBoxFirstName.Text);
                    cmd.Parameters.Add("SURNAME", TextBoxLastName.Text);
                    cmd.Parameters.Add("GENDER", ComboBoxGender.Text);
                    cmd.Parameters.Add("CITIZEN_ID", TextBoxCitizenID.Text);
                    cmd.Parameters.Add("PHONE", TextBoxContact.Text);
                    cmd.Parameters.Add("ROLE", ComboBoxRole.Text);
                    cmd.Parameters.Add("HIRE_DATE", OracleDbType.Date).Value = DateTime.Parse(dateString);
                    cmd.Parameters.Add("EMAIL", TextBoxEmail.Text);
                    cmd.Parameters.Add("ADDRESS", TextBoxAddress.Text);
                    cmd.Parameters.Add("CITY", TextBoxCity.Text);
                    cmd.Parameters.Add("ZIPCODE", TextBoxZipCode.Text);

                    rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MetroMessageBox.Show(ParentForm, "", "Staff Details Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        ClearControls();
                    }
                    else
                        MetroMessageBox.Show(ParentForm, " ", "Staff Details not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex.Message.ToString());
                }
                finally
                {
                    db.CloseDatabase();
                }
            }

             db.CloseDatabase();
        }

        internal void ClearControls()
        {
            TextBoxFirstName.Clear();
            TextBoxLastName.Clear();
            TextBoxCitizenID.Clear();
            TextBoxContact.Clear();
            DateTimeHireStaff.ResetText();
            TextBoxAddress.Clear();
            TextBoxCity.Clear();
            TextBoxZipCode.Clear();
            TextBoxEmail.Clear();
        }
    }
}
