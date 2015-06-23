/**
 * SIMS is (c) 2015 Ntokozo Company. All rights reserved.
 * 
 * http://www.ntokozo.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Ntokozo Company. All rights reserved.
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

namespace SIMS.LearnerModule
{
    /**
     * <summary>
     *      This class displays student details in a DataGridView and the data can also be update within the DGV.
     * </summary>
     */
    public partial class BrowseLearners : MetroForm
    {
        public BrowseLearners()
        {
            InitializeComponent();
        }


        private void BrowseDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.STUDENT' table. You can move, or remove it, as needed.
                this.studentTA.Fill(this.browse_learnerDS.STUDENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n", ex.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        /*
         * Method that update student details from a DataGridView
         */ 
        private void metroTileUpdateLearner_Click(object sender, EventArgs e)
        {
            try
            {
                studentTA.Update(this.browse_learnerDS.STUDENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message.ToString());
            }
        }

        /*
         * Method to search and return students data by surname
         */ 
        private void metroTileSearchLearner_Click(object sender, EventArgs e)
        {
            int rows = 0;
            try
            {
                rows = studentTA.FillByLearnerSearch(this.browse_learnerDS.STUDENT, metroTextBoxSearchLearner.Text.ToLower());
                if (rows == 0)
                {
                    MessageBox.Show("The surname: " + metroTextBoxSearchLearner.Text + " does not exist in our database records.");
                    metroTextBoxSearchLearner.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message.ToString());
            }
        }

        private void metroTileSearchByAdminNo_Click_1(object sender, EventArgs e)
        {
            int rows = 0;
            try
            {
                if (metroTextBoxSearchByAdminNo.Text == "")
                    MessageBox.Show("Please enter admission no. in search box");
                else
                {
                    rows = studentTA.SearchByAdminNo(this.browse_learnerDS.STUDENT, metroTextBoxSearchByAdminNo.Text);
                    if (rows == 0)
                    {
                        MessageBox.Show("Admission No: " + metroTextBoxSearchByAdminNo.Text + " does not exist in our database records.");
                        metroTextBoxSearchByAdminNo.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message.ToString());
            }
        }

        /*
         * This method closes this(BrowseDetails) form
         */
        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * This method stub filter student data displayed in a DataGridView by Admission no, Admitted date and Lastname.
         * It then sort data in ascending order accross all filters
         */
        private void metroTileFilter_Click(object sender, EventArgs e)
        {
            if (metroComboBoxFilter.Text != "")
            {
                if (metroComboBoxFilter.Text == "Admission No")
                    studentTA.OrderByAdmissionNo(this.browse_learnerDS.STUDENT);

                if (metroComboBoxFilter.Text == "Last Name")
                    studentTA.OrderBySurname(this.browse_learnerDS.STUDENT);
            }
            else
                MessageBox.Show("Please select one of the filter options first");
        }
    }
}
