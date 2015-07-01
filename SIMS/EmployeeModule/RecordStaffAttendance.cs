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

namespace SIMS.EmployeeModule
{
    public partial class RecordStaffAttendance : MetroForm
    {

        public RecordStaffAttendance()
        {
            InitializeComponent();
            
        }

        private void RecordStaffAttendance_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.STUDENT_PROFILE' table. You can move, or remove it, as needed.
                this.student_profileTA.FillStudentProfile(this.dS.STUDENT_PROFILE);
                // TODO: This line of code loads data into the 'dS.SUBJECT' table. You can move, or remove it, as needed.
                this.subjectTA.Fill(this.dS.SUBJECT);
                // TODO: This line of code loads data into the 'dS.EMPLOYEE' table. You can move, or remove it, as needed.
                this.employeeTA.Fill(this.dS.EMPLOYEE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n"+ex.Message.ToString());
            }
        }

        private void metroTileCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileSubmit_Click(object sender, EventArgs e)
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;
            var time_in = dateTimeIn.Value.ToShortTimeString();
            var time_out = dateTimeOut.Value.ToShortTimeString();
            var attendanceDate = dateTimeAttendance.Value.ToShortDateString();

            if (isSignedIn())
                MessageBox.Show(labelName.Text.ToString() + " " + labelSurname.Text.ToString() + " is already signed in for today.\n" + "To edit times go to (Employee Module -> Edit Attendance Times)");
            else if (textBoxLessons.Text == "")
                MessageBox.Show("You should enter number of lessons");
            else
            {
                try
                {
                    string sql = "INSERT INTO STAFF_ATTENDANCE " +
                             "(EMPLOYEE_ID, SUBJECT, TIME_IN, TIME_OUT, NUM_LESSONS, HOURS, ATT_DATE) " +
                             " VALUES " +
                             " (:EMPLOYEE_ID, :SUBJECT, :TIME_IN, :TIME_OUT, :NUM_LESSONS, :HOURS, :ATT_DATE) ";

                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("EMPLOYEE_ID", LabelEmployeeID.Text);
                    cmd.Parameters.Add("SUBJECT", comboBoxSubject.Text);
                    cmd.Parameters.Add("TIME_IN", OracleDbType.Date).Value = DateTime.Parse(time_in);
                    cmd.Parameters.Add("TIME_OUT", OracleDbType.Date).Value = DateTime.Parse(time_out);
                    cmd.Parameters.Add("NUM_LESSONS", textBoxLessons.Text);
                    cmd.Parameters.Add("HOURS", getHours());
                    cmd.Parameters.Add("ATT_DATE", attendanceDate);
                    rows = cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message.ToString());
                }
                if (rows > 0)
                {
                    MessageBox.Show("Thank you, attendance is recorded successful");
                }
            }
                
        }

        private double getHours()
        {
            return 2;
        }

        private bool isSignedIn()
        {
            var attendanceDate = dateTimeAttendance.Value.ToShortDateString();

            staff_attTA.CheckIfSigned(this.dS.STAFF_ATTENDANCE, Convert.ToDecimal(LabelEmployeeID.Text), attendanceDate);
            if (dS.STAFF_ATTENDANCE.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
