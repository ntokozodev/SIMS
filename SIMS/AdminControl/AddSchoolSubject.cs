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

using MetroFramework.Forms;
using MetroFramework.Animation;
using MetroFramework.Components;
using MetroFramework.Controls;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace SIMS.AdminControl
{
    public partial class AddSchoolSubject : MetroForm
    {
        public AddSchoolSubject()
        {
            InitializeComponent();
        }

        private void ClearControls()
        {
            TextBoxCode.Clear();
            TextBoxName.Clear();
            TextBoxCost.Clear();
            ComboBoxCategory.ResetText();
        }

        private void metroTileAdd_Click_1(object sender, EventArgs e)
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;
            subjectTA.FillBySubjectCode(this.subjectDS.SUBJECT, TextBoxCode.Text.ToUpper());
            if (subjectDS.SUBJECT.Rows.Count > 0)
            { 
                MessageBox.Show("Subject with code: " + TextBoxCode.Text + " is already added"); 
                ClearControls(); 
            }
            else if (TextBoxName.Text == "")
            { 
                MessageBox.Show("Enter subject name or description");  
            }
            else if (TextBoxCode.Text == "")
                MessageBox.Show("Enter subject code");
            else if (TextBoxCost.Text == "")
                MessageBox.Show("Enter subject cost");
            else if (ComboBoxCategory.Text == "")
                MessageBox.Show("Select subject category");
            else
            {
                try
                {
                    string sql = "INSERT INTO SUBJECT " +
                                 "(SUBJECT_CODE, SUBJECT_NAME, SUBJECT_COST, CATEGORY) " +
                                 " VALUES " +
                                 "(:SUBJECT_CODE, :SUBJECT_NAME, :SUBJECT_COST, :CATEGORY)";
                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("SUBJECT_CODE", TextBoxCode.Text.ToUpper());
                    cmd.Parameters.Add("SUBJECT_NAME", TextBoxName.Text);
                    cmd.Parameters.Add("SUBJECT_COST", TextBoxCost.Text);
                    cmd.Parameters.Add("CATEGORY", ComboBoxCategory.Text);
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding a school subject:\n" + ex.Message.ToString());
                }
            }
            if (rows > 0)
            {
                MessageBox.Show("Subject added successfully.");
                ClearControls();
            }
        }
    }
}
