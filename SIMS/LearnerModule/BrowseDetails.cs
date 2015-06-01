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
    public partial class BrowseDetails : MetroForm
    {
        public BrowseDetails()
        {
            InitializeComponent();
        }


        private void BrowseDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.STUDENT' table. You can move, or remove it, as needed.
                this.TAStudent.Fill(this.dS.STUDENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error\n", ex.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        /*
         * Method that update student details from a DataGridView
         */ 
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

        /*
         * Method to search and return students data by surname
         */ 
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
                    TAStudent.OrderByAdmissionNo(this.dS.STUDENT);

                if (metroComboBoxFilter.Text == "Admitted Date")
                    TAStudent.OrderByDate(this.dS.STUDENT);

                if (metroComboBoxFilter.Text == "Last Name")
                    TAStudent.OrderByName(this.dS.STUDENT);
            }
            else
                MessageBox.Show("Please select one of the filter options first");
        }
    }
}
