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
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;

namespace SIMS.AdminControl
{
    public partial class AddCentre : MetroForm
    {
        public AddCentre()
        {
            InitializeComponent();
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            TextBoxAddress.Clear();
            TextBoxName.Clear();
            TextBoxClasses.Clear();
        }

        private void metroTileEnter_Click(object sender, EventArgs e)
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;

            if (TextBoxName.Text == "")
            {
                MessageBox.Show("You should enter address name");
                TextBoxName.Focus();
            }
            else if (TextBoxAddress.Text == "")
            {
                MessageBox.Show("You should enter centre address");
                TextBoxAddress.Focus();
            }
            else
            {
                try
                {
                    string sql = "INSERT INTO CENTRE " +
                                 "(NAME, ADDRESS, CLASSES) " +
                                 " VALUES " +
                                 "(:NAME, :ADDRESS, :CLASSES)";
                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("NAME", TextBoxName.Text);
                    cmd.Parameters.Add("ADDRESS", TextBoxAddress.Text);
                    cmd.Parameters.Add("CLASSES", TextBoxClasses.Text);

                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding a centre:\n" + ex.Message.ToString());
                }
                if (rows > 0)
                {
                    MessageBox.Show("Centre added successfully");
                    ClearControls();
                }
                else
                    MessageBox.Show("Centre was not added, there might have been unexpected error");
            }
        }
    }
}
