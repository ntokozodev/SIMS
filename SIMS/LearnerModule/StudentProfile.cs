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
using Oracle.ManagedDataAccess.Client;

namespace SIMS.LearnerModule
{
    public partial class StudentProfile : MetroForm
    {

        private string admission_no = "";
        private PrintStudentProfile print;

        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {  
            try
            {
                // TODO: This line of code loads data into the 'student_profileDS.STUDENT_ENROLLMENT' table. You can move, or remove it, as needed.
                this.student_enrollmentTA.Fill(this.student_profileDS.STUDENT_ENROLLMENT);
                // TODO: This line of code loads data into the 'dS.STUDENT_PROFILE' table. You can move, or remove it, as needed.
                this.student_profileTA.FillStudentProfile(this.student_profileDS.STUDENT_PROFILE);
                LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
                admission_no = LabelAdmissionNo.Text;
                displaySubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile:\n" + ex.Message.ToString());
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        internal void displaySubjects()
        {
            SimsOracle db = new SimsOracle();

            string s = "SELECT SIMS.STUDENT_ENROLLMENT.SUBJECT_CODE, SIMS.SUBJECT.SUBJECT_NAME, SIMS.STUDENT_ENROLLMENT.ACADEMIC_YEAR " +
                       " FROM  SIMS.STUDENT_ENROLLMENT INNER JOIN " +
                        "SIMS.SUBJECT ON SIMS.STUDENT_ENROLLMENT.SUBJECT_CODE = SIMS.SUBJECT.SUBJECT_CODE " +
                        "WHERE (ADMISSION_NO = '" + admission_no + "')";

            try
            {
                OracleDataAdapter da = new OracleDataAdapter(s, db.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                subjectDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects:\n" + ex.Message.ToString());
            }
            db.CloseDatabase();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            print = new PrintStudentProfile();
            passDataToPrintForm(print);
            print.ShowDialog();
        }

        private void passDataToPrintForm(PrintStudentProfile print)
        {
            print.LabelAdmissionNo.Text = LabelAdmissionNo.Text.ToString();
            print.LabelID.Text = LabelID.Text.ToString();
            print.LabelGender.Text = LabelGender.Text.ToString();
            print.LabelCentre.Text = LabelCentre.Text.ToString();
            print.LabelFullName.Text = LabelFullName.Text.ToString();
            print.LabelAddress.Text = LabelAddress.Text.ToString();
            print.LabelSuburb.Text = LabelSuburb.Text.ToString();
            print.LabelCity.Text = LabelCity.Text.ToString();
            print.LabelZipCode.Text = LabelZipCode.Text.ToString();
            print.LabelTotal.Text = LabelTotal.Text.ToString();
            print.LabelDue.Text = LabelDue.Text.ToString();
            registeredSubjects(print);
        }

        private void registeredSubjects(PrintStudentProfile print)
        {
            int rows = getRows();
            
            // Populating first column with data
            if (rows > 0)
                print.labelCode1.Text = Convert.ToString(subjectDGV.Rows[0].Cells[0].Value);
            else
                print.labelCode1.Visible = false;

            if (rows > 1)
                print.labelCode2.Text = Convert.ToString(subjectDGV.Rows[1].Cells[0].Value);
            else
                print.labelCode2.Visible = false;

            if (rows > 2)
                print.labelCode3.Text = Convert.ToString(subjectDGV.Rows[2].Cells[0].Value);
            else
                print.labelCode3.Visible = false;

            if (rows > 3)
                print.labelCode4.Text = Convert.ToString(subjectDGV.Rows[3].Cells[0].Value);
            else
                print.labelCode4.Visible = false;

            // Populating second column with data
            if (rows > 0)
                print.labelName1.Text = Convert.ToString(subjectDGV.Rows[0].Cells[1].Value);
            else
                print.labelName1.Visible = false;

            if (rows > 1)
                print.labelName2.Text = Convert.ToString(subjectDGV.Rows[1].Cells[1].Value);
            else
                print.labelName2.Visible = false;

            if (rows > 2)
                print.labelName3.Text = Convert.ToString(subjectDGV.Rows[2].Cells[1].Value);
            else
                print.labelName3.Visible = false;

            if (rows > 3)
                print.labelName4.Text = Convert.ToString(subjectDGV.Rows[3].Cells[1].Value);
            else
                print.labelName4.Visible = false;

            // Populating the third column with data
            if (rows > 0)
                print.labelYear1.Text = Convert.ToString(subjectDGV.Rows[0].Cells[2].Value);
            else
                print.labelYear1.Visible = false;

            if (rows > 1)
                print.labelYear2.Text = Convert.ToString(subjectDGV.Rows[1].Cells[2].Value);
            else
                print.labelYear2.Visible = false;

            if (rows > 2)
                print.labelYear3.Text = Convert.ToString(subjectDGV.Rows[2].Cells[2].Value);
            else
                print.labelYear3.Visible = false;

            if (rows > 3)
                print.labelYear4.Text = Convert.ToString(subjectDGV.Rows[3].Cells[2].Value);
            else
                print.labelYear4.Visible = false;
        }

        private int getRows()
        {
            int r = 0;
            for (int i = 0; i < subjectDGV.Rows.Count; i++)
                r++;
            return r;
        }
    }
}
