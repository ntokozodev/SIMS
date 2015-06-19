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
                    string sql = "INSERT INTO SIMS.EXPENSE " +
                                        "(EXPENSE_TYPE, DESCRIPTION) " +
                                 "VALUES (:EXPENSE_TYPE, :DESCRIPTION)";

                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("EXPENSE_TYPE", metroTextBoxExpType.Text);
                    cmd.Parameters.Add("DESCRIPTION", metroTextBoxDescription.Text);

                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!\n" + ex.Message.ToString());
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
                this.Refresh();
            }
            else
                MetroMessageBox.Show(ParentForm, " ", "Details not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            db.CloseDatabase();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.EXPENSE' table. You can move, or remove it, as needed.
                this.eXPENSETableAdapter.Fill(this.dS.EXPENSE);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(ParentForm, "Database error!\n" + ex.Message.ToString());
                this.Close();
            }
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void metroTileAddExpPayment_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;

            if (metroTextBoxExpAmount.Text == "")
            {
                MetroMessageBox.Show(ParentForm, "", "You need to enter expense amount", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (metroComboBoxExpenseType.Text == "")
            {
                MetroMessageBox.Show(ParentForm, "", "Select one of the expense type options", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                var datestring = metroDateTimeExpense.Value.ToShortDateString();
                try
                {
                    string query = "INSERT INTO SIMS.EXPENSE_PAYMENT " +
                                        "(EXPENSE_AMOUNT, EXPENSE_NOTE, payment_date, captured_date, expense_id)" +
                                   "VALUES (" +
                                        ":EXPENSE_AMOUNT, " +
                                        ":EXPENSE_NOTE, " +
                                        ":PAYMENT_DATE, " +
                                        ":CAPTURED_DATE, " +
                                        "(SELECT EXPENSE.EXPENSE_ID FROM EXPENSE WHERE EXPENSE.EXPENSE_TYPE = '" + metroComboBoxExpenseType.Text + "'))";

                    OracleCommand cmd = new OracleCommand(query, db.Connection);
                    cmd.Parameters.Add("EXPENSE_AMOUNT", metroTextBoxExpAmount.Text);
                    cmd.Parameters.Add("EXPENSE_NOTE", metroTextBoxExpNote.Text);
                    cmd.Parameters.Add("PAYMENT_DATE", OracleDbType.Date).Value = DateTime.Parse(datestring);
                    cmd.Parameters.Add("CAPTURED_DATE", OracleDbType.Date).Value = DateTime.Now;

                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!\n" + ex.Message.ToString());
                }
                finally
                {
                    db.CloseDatabase();
                }
            }

            if (rows > 0)
            {
                MetroMessageBox.Show(ParentForm, "", "Expense Payment Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                metroTextBoxExpAmount.Clear();
                metroTextBoxExpNote.Clear();
                metroDateTimeExpense.ResetText();
                metroComboBoxExpenseType.ResetText();
                this.Refresh();
            }
            else
                MetroMessageBox.Show(ParentForm, " ", "Expense Payment not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            db.CloseDatabase();
        }
    }
}
