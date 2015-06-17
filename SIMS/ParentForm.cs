﻿/**
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
using SIMS.AccountModule;
using SIMS.EmployeeModule;
using SIMS.AccessControl;

namespace SIMS
{
    /**
     * <summary>
     *      The main MDI Parent class for SIMS application
     * </summary>
     */
    public partial class ParentForm : MetroForm
    {
        LoginForm log = new LoginForm();
        AboutSIMS about;

        #region "Properties Learner Module"
        private AddLearner learner = null;
        private BrowseLearners details = null;
        private AsignLearner asign = null;
        private RegisterStudent register = null;
        #endregion

        #region "Properties Acounts Module"
        private Expenses expenseT = null;
        private ViewExpenses viewExp = null;
        private RecordStudentPayment studentPay = null;
        private RecordStaffSalaryPayment salaryPay = null;
        private BrowseStaffPayments staffPay = null;
        private AddFeeStructure feeStruct = null;
        private DueFees dueFee = null;
        private StudentProfiles studentPro = null;
        private StaffHours staffHr = null;
        #endregion

        #region "Properties Employee Module"
        private AddStaffMember staff = null;
        private BrowseStaffDetails staffD = null;
        private AsignEducatorClass asignEdu = null;
        private RemoveEducatorClass removeEdu = null;
        private RecordStaffAttendance staffAt = null;
        #endregion

        #region "Properties AccessControl"
        private AddUser addUser = null;
        private Login logon = null;
        private Logout logoff = null;
        private ChangePassword changeP = null;
        #endregion

        public ParentForm()
        {
            InitializeComponent();
            log.ShowDialog();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            Control control = default(Control);
            MdiClient ctlMDI = default(MdiClient);

            // Loop through all of the form's controls looking for the control of type MdiClient.
            foreach (Control ctl in this.Controls) 
            {
	            try 
                {
		            // Attempt to cast the control to type MdiClient.
		            ctlMDI = (MdiClient)control;
	            } 
                catch (InvalidCastException exc) 
                {
		            // Catch and ignore the error if casting failed.
	            }
            }
        }

        internal void FormSetUp(MetroForm ChildForm)
        {
            try 
            {
                var child = ChildForm;
                child.MdiParent = this;
                child.TopLevel = false;
                child.AutoScroll = true;
                MainPanel.Controls.Add(child);
                MainPanel.Controls.SetChildIndex(child, 0);
                child.Dock = DockStyle.Fill;
                child.Show();
            }
            catch (Exception ex) 
            {
                MetroMessageBox.Show(this, "Error:\n" + ex.Message.ToString());
            }
        }

        internal void createObject(MetroForm form)
        {
            if (form != null)
                form.Close();
            form = new MetroForm();
        }

        private void exitTile_Click(object sender, EventArgs e)
        {
            DialogResult reply = default(DialogResult);
            reply = MetroMessageBox.Show(this, "Do you want to close the application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }

        private void aboutTile_Click(object sender, EventArgs e)
        {
            if (about != null)
                about.Close();
            about = new AboutSIMS();
            about.ShowDialog();
        } 


        /*
         * Candidates for refactoring...
         */
        #region "Learner Module"
        private void addNewLearnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (learner != null)
                learner.Close();
            learner = new AddLearner();
            FormSetUp(learner);
        }

        private void browseLearnerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (details != null)
                details.Close();
            details = new BrowseLearners();
            FormSetUp(details);
        }

        private void assignLearnerToClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (asign != null)
                asign.Close();
            asign = new AsignLearner();
            FormSetUp(asign);
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (register != null)
                register.Close();
            register = new RegisterStudent();
            FormSetUp(register);
        }
        #endregion

        #region "Accounts Module"

        private void addExpenseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (expenseT != null)
                expenseT.Close();
            expenseT = new Expenses();
            FormSetUp(expenseT);
        }

        private void viewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (viewExp != null)
                viewExp.Close();
            viewExp = new ViewExpenses();
            FormSetUp(viewExp);
        }

        private void recordStudentPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (studentPay != null)
                studentPay.Close();
            studentPay = new RecordStudentPayment();
            FormSetUp(studentPay);
        }

        private void recordStaffSalaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (salaryPay != null)
                salaryPay.Close();
            salaryPay = new RecordStaffSalaryPayment();
            FormSetUp(salaryPay);
        }

        private void browseStaffPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (staffPay != null)
                staffPay.Close();
            staffPay = new BrowseStaffPayments();
            FormSetUp(staffPay);
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (dueFee != null)
                dueFee.Close();
            dueFee = new DueFees();
            FormSetUp(dueFee);
        }

        private void studentProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (studentPro != null)
                studentPro.Close();
            studentPro = new StudentProfiles();
            FormSetUp(studentPro);
        }

        private void staffHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (staffHr != null)
                staffHr.Close();
            staffHr = new StaffHours();
            FormSetUp(staffHr);
        }
        #endregion

        #region "Employee Module"
        private void addNewStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (staff != null)
                staff.Close();
            staff = new AddStaffMember();
            FormSetUp(staff);
        }

        private void browseStaffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (staffD != null)
                staffD.Close();
            staffD = new BrowseStaffDetails();
            FormSetUp(staffD);
        }

        private void asignEducatorToClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (asignEdu != null)
                asignEdu.Close();
            asignEdu = new AsignEducatorClass();
            FormSetUp(asignEdu);
        }

        private void removeEducatorFromClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (removeEdu != null)
                removeEdu.Close();
            removeEdu = new RemoveEducatorClass();
            FormSetUp(removeEdu);
        }

        private void recordStaffAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (staffAt != null)
                staffAt.Close();
            staffAt = new RecordStaffAttendance();
            FormSetUp(staffAt);
        }
        #endregion  

        #region "Access Control"
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (addUser != null)
                addUser.Close();
            addUser = new AddUser();
            FormSetUp(addUser);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (logon != null)
                logon.Close();
            logon = new Login();
            FormSetUp(logon);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (logoff != null)
                logoff.Close();
            logoff = new Logout();
            FormSetUp(logoff);
        }

        private void changePwordStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (changeP != null)
                changeP.Close();
            changeP = new ChangePassword();
            FormSetUp(changeP);
        }
        #endregion

        private void clearAllControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }
    }
}
