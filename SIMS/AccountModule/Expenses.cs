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
using SIMS.LearnerModule;

namespace SIMS.AccountModule
{
    public partial class Expenses : MetroForm
    {
        private SimsOracle db;
        public Expenses()
        {
            InitializeComponent();
        }

        private void metroTileClearAddExpense_Click(object sender, EventArgs e)
        {
            metroTextBoxExpType.Clear();
            metroTextBoxDescription.Clear();
        }

        private void metroTileClearExpPayment_Click(object sender, EventArgs e)
        {
            metroTextBoxExpAmount.Clear();
            metroTextBoxExpNote.Clear();
            metroDateTimeExpense.ResetText();
            metroComboBoxExpenseType.ResetText();
        }


        private void metroTileAddExpense_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;

            if (metroTextBoxExpType.Text == "")
            {
                MetroMessageBox.Show(ParentForm, "", "You need to enter Expense Type", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    string sql = "INSERT INTO EDU_SCHEMA.EXPENSE " +
                                        "(EXPENSE_TYPE, DESCRIPTION) " +
                                 "VALUES (:EXPENSE_TYPE, :DESCRIPTION)";

                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("EXPENSE_TYPE", metroTextBoxExpType.Text);
                    cmd.Parameters.Add("DESCRIPTION", metroTextBoxDescription.Text);

                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't connect to database!\n" + ex.Message.ToString());
                }
                finally
                {
                    db.CloseDatabase();
                }
            }

            if (rows > 0)
            {
                MetroMessageBox.Show(ParentForm, "", "Expense Details Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                metroTextBoxExpType.Clear();
                metroTextBoxDescription.Clear();
            }
            else
                MetroMessageBox.Show(ParentForm, " ", "Details not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            db.CloseDatabase();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {}
    }
}
