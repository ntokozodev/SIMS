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
    public partial class RecordStaffSalaryPayment : MetroForm
    {
        private string employee_id = "";
        private OracleDataAdapter da;

        public RecordStaffSalaryPayment()
        {
            InitializeComponent();
        }

        private void RecordStaffSalaryPayment_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.SALARY_CAPTURE' table. You can move, or remove it, as needed.
                this.salary_captureTA.Fill(this.dS.SALARY_CAPTURE);
                // TODO: This line of code loads data into the 'dS.TEACHERS_REGISTER' table. You can move, or remove it, as needed.
                this.teacher_registerTA.Fill(this.dS.TEACHERS_REGISTER);

                employee_id = LabelStaffNo.Text;
                displayTimes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message.ToString());
            }
        }

        private void displayTimes()
        {
            fillStartDate();
            fillEndDate();
        }

        private void fillStartDate()
        {
            SimsOracle db = new SimsOracle();

            string sql_start = "SELECT SIMS.STAFF_ATTENDANCE.TIME_IN " +
                               " FROM SIMS.STAFF_ATTENDANCE " +
                               " WHERE (EMPLOYEE_ID = '" + employee_id + "')";
            try
            {
                da = new OracleDataAdapter(sql_start, db.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxStart.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading start dates:\n" + ex.Message.ToString());
            }
            db.CloseDatabase();
        }

        private void fillEndDate()
        {
            SimsOracle db = new SimsOracle();
            string sql_end = "SELECT SIMS.STAFF_ATTENDANCE.TIME_OUT " +
                             " FROM SIMS.STAFF_ATTENDANCE " +
                             " WHERE (EMPLOYEE_ID = '" + employee_id + "')";
            try
            {
                da = new OracleDataAdapter(sql_end, db.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxEnd.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading start dates:\n" + ex.Message.ToString());
            }
            db.CloseDatabase();
        }


        private void TileSalaryGenerate_Click(object sender, EventArgs e)
        {
            int rows = 0;
            if (CheckBoxPayPeriod.Checked == false)
                MessageBox.Show("Select the right pay period and then check the small box below to confirm");
            else if (TextBoxRate.Text == "")
                MessageBox.Show("You should enter Payment Rate per lesson");
            else
            {
                rows = generateSalary();
                if (rows > 0)
                    MessageBox.Show("Salary generated successfully");
                else
                    MetroMessageBox.Show(ParentForm, "Salary was not generated", "Unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }

        private int generateSalary()
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;
            try
            {
                decimal lessons = computeLessons();
                decimal pay = computeBasicPay(lessons);

                string sql = "INTSERT INTO SIMS.SALARY " +
                             "(START_DATE, END_DATE, LESSONS, RATE, BASIC_PAY, EMPLOYEE_ID) " +
                             " VALUES " +
                             "(:START_DATE, :END_DATE, :LESSONS, :RATE, :BASIC_PAY, :EMPLOYEE_ID)";

                OracleCommand cmd = new OracleCommand(sql, db.Connection);
                cmd.Parameters.Add("START_DATE", OracleDbType.Date).Value = DateTime.Parse(comboBoxStart.Text);
                cmd.Parameters.Add("END_DATE", OracleDbType.Date).Value = DateTime.Parse(comboBoxEnd.Text);
                cmd.Parameters.Add("LESSONS", LabelLessons.Text);
                cmd.Parameters.Add("RATE", TextBoxRate.Text);
                cmd.Parameters.Add("BASIC_PAY", LabelSalary.Text);
                cmd.Parameters.Add("EMPLOYEE_ID", LabelStaffNo.Text);

                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message.ToString());
            }
            finally
            {
                db.CloseDatabase();
            }

            return rows;
        }

        private decimal computeBasicPay(decimal lessons)
        {
            decimal pay = lessons * Convert.ToInt32(TextBoxRate.Text);
            LabelSalary.Text = Convert.ToString(pay);
            return pay;
        }

        private decimal computeLessons()
        {
            var start_date = Convert.ToDateTime(comboBoxStart.Text);
            var end_date = Convert.ToDateTime(comboBoxEnd.Text);
            decimal lessons = Convert.ToDecimal(staff_attendanceTA.Lessons_Sum(Convert.ToDecimal(LabelStaffNo.Text), start_date, end_date));
            LabelLessons.Text = Convert.ToString(lessons);
            return lessons;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            employee_id = LabelStaffNo.Text;
            displayTimes();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            employee_id = LabelStaffNo.Text;
            displayTimes();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            employee_id = LabelStaffNo.Text;
            displayTimes();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            employee_id = LabelStaffNo.Text;
            displayTimes();
        }
    }
}
