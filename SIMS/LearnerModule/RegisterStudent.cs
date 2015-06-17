/**
 * SIMS is (c) 2015 Geek Studio Company. All rights reserved.
 * 
 * http://www.gstudioc.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Geek Studio Company. All rights reserved.
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
using MetroFramework;
using Oracle.ManagedDataAccess.Client;

namespace SIMS.LearnerModule
{
    public partial class RegisterStudent : MetroForm
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dSS.SUBJECT' table. You can move, or remove it, as needed.
                this.subjectTA.Fill(this.regDS.SUBJECT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error!\n" + ex.Message.ToString());
            }
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        /**
         * Register student curriculumn into school's database
         */
        private void metroTileRegister_Click(object sender, EventArgs e)
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;
            int count = 0;

            if (checkAllConditions()) // check all pre-conditions
            {
                try
                {
                    for (int i = 0; i < subjectsDGV.Rows.Count; i++)
                    {
                        if (subjectsDGV.Rows[i].Selected) // perform operation to selected row
                        {
                            string subject_code = Convert.ToString(subjectsDGV.Rows[i].Cells[0].Value);
                            student_enrollmentTA.AdminNoSubjCodeDuplicate(regDS.STUDENT_ENROLLMENT, metroTextBoxAdminNo.Text, subject_code, metroTextBoxYear.Text);

                            if (regDS.STUDENT_ENROLLMENT.Rows.Count > 0) // check subject registration duplicates
                                MessageBox.Show(subject_code + " is already registered to admission number: " + metroTextBoxAdminNo.Text);
                            else
                            {
                                string sql = "INSERT INTO SIMS.STUDENT_ENROLLMENT" +
                                              "(ADMISSION_NO, SUBJECT_CODE, ACADEMIC_YEAR, GRADE, COST)" +
                                              " VALUES" +
                                              "(:ADMISSION_NO, :SUBJECT_CODE, :ACADEMIC_YEAR, :GRADE, :COST)";

                                OracleCommand cmd = new OracleCommand(sql, db.Connection);
                                cmd.Parameters.Add("ADMISSION_NO", metroTextBoxAdminNo.Text);
                                cmd.Parameters.Add("SUBJECT_CODE", subjectsDGV.Rows[i].Cells[0].Value);
                                cmd.Parameters.Add("ACADEMIC_YEAR", metroTextBoxYear.Text);
                                cmd.Parameters.Add("GRADE", metroTextBoxGrade.Text);

                                /* The first subject will cost R500 extra than the subsequent subject */
                                count = Convert.ToInt32(student_enrollmentTA.CountRegisterdSubjects(metroTextBoxAdminNo.Text, metroTextBoxYear.Text));
                                if (count > 0)
                                    cmd.Parameters.Add("COST", subjectsDGV.Rows[i].Cells[2].Value);
                                else
                                {
                                    double cost = Convert.ToDouble(subjectsDGV.Rows[i].Cells[2].Value);
                                    cmd.Parameters.Add("COST", cost + 500);
                                }
  
                                rows = cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex.Message.ToString());
                }
                finally
                {
                    db.CloseDatabase();
                }
                db.CloseDatabase();
            } // end if(checkAllConditions)

            if (rows > 0)
            {
                MetroMessageBox.Show(ParentForm, "", "Registration captured successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ClearControls();
            }
        }

        
        /**
         * @param adminNo, takes student admission number as input
         * @return true if adminNo is valid by finding student associated with it in database, otherwise false
         */
        internal bool isAdmissionNoValid(string adminNo)
        {
            try
            {
                studentTA.FillByEnrolmentNo(regDS.STUDENT, adminNo);
                if (regDS.STUDENT.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Database rror:\n" + ex.Message.ToString());
            }
            return false;
        }

        /**
         * The method checks if there is at least one subject selected for registration
         * @return true if subject is selected otherwise false
         */
        internal bool isSubjectSelected()
        {
            for (int i = 0; i < subjectsDGV.Rows.Count; i++)
            {
                if (subjectsDGV.Rows[i].Selected)
                    return true;
            }
            return false;
        }

        /**
         * The methods checks if selected subjects are at most four
         * @return true if selection less than or equal to four, otherwise false
         */
        internal bool isSelectedLessThanFour()
        {
            int subjCount = 0;
            int count = 0;

            try
            {
                int subjects = Convert.ToInt32(student_enrollmentTA.CountRegisterdSubjects(metroTextBoxAdminNo.Text, metroTextBoxYear.Text));
                
                for (int i = 0; i < subjectsDGV.Rows.Count; i++)
                {
                    if (subjectsDGV.Rows[i].Selected)
                        count++;
                }
                subjCount = subjects + count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message.ToString());
            }

            if (subjCount > 4)
                return false;
            return true;
        }

        /**
         * Method determines whether one or more major subject(s) has been selected as per requirements
         */
        private bool isMajorSelected()
        {
            int count = 0;
            try
            {
                count = Convert.ToInt32(student_enrollmentTA.CountRegisterdSubjects(metroTextBoxAdminNo.Text, metroTextBoxYear.Text));
                if (count > 0)
                    return true;
                else
                {
                    for (int i = 0; i < subjectsDGV.Rows.Count; i++)
                    {
                        if (subjectsDGV.Rows[i].Selected)
                        {
                            string major = Convert.ToString(subjectsDGV.Rows[i].Cells[3].Value);
                            if (major.Equals("Major"))
                                return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message.ToString());
            }
            return false;
        }

        /**
         * This method checks all pre-conditions for registration
         */
        internal bool checkAllConditions()
        {
            if (RadioButtonAccept.Checked == false)
            {
                MessageBox.Show("Accept terms and conditions before you continue with registration");
                return false;
            }  
            else if (!isAdmissionNoValid(metroTextBoxAdminNo.Text))
            {
                MessageBox.Show("Admission No: " + metroTextBoxAdminNo.Text + " is not valid");
                metroTextBoxAdminNo.Clear();
                return false;
            }
            else if (metroTextBoxYear.Text == "")
            {
                MessageBox.Show("Enter academic year for this registration");
                return false;
            }
            else if (!isSubjectSelected())
            {
                MessageBox.Show("You must select at least one subject to continue");
                return false;
            }   
            else if (!isSelectedLessThanFour())
            {
                MessageBox.Show("You're not allowed to register more than four subject");
                return false;
            }  
            else if (!isMajorSelected())
            {
                MessageBox.Show("You must select at least one subject from major category group");
                return false;
            }
            else
                return true;
        }

        internal void ClearControls()
        {
            metroTextBoxYear.Clear();
            metroTextBoxRegCost.Clear();
            metroTextBoxAdminNo.Clear();
            metroTextBoxGrade.Clear();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
