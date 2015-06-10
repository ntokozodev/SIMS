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
    public partial class AddStaffMember : MetroForm
    {
        private SimsOracle db;
        private OracleCommand cmd;

        public AddStaffMember()
        {
            InitializeComponent();
        }

        private void AddStaffMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GRADE' table. You can move, or remove it, as needed.
            this.gRADETableAdapter.Fill(this.dS.GRADE);

        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroTileAdd_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;

            try
            {
                string sql = "INSERT INTO SIMS.EMPLOYEE" +
                             " (FIRST_NAME, LAST_NAME, CITIZEN_ID, PHONE_NO, JOB, HIRE_DATE, GRADE_ID, EMAIL_ADDRESS," + 
                             " ADDRESS_LINE1, ADDRESS_LINE2, SUBURB, CITY, ZIP_CODE, GENDER)" +
                             " VALUES" +
                             " (:FIRST_NAME, "+
                             "  :LAST_NAME, " +
                             "  :CITIZEN_ID, " +
                             "  :PHONE_N0, " +
                             "  :JOB, " +
                             "  :HIRE_DATE, " +
                             "  (SELECT GRADE_ID FROM SIMS.GRADE WHERE GRADE_NAME = '"+ metroComboBoxGrade.Text +"'), " +
                             "  :EMAIL_ADDRESS, "+
                             "  :ADDRESS_LINE1, "+
                             "  :ADDRESS_LINE2, "+
                             "  :SUBURB, "+
                             "  :CITY, "+
                             "  :ZIP_CODE, "+
                             "  :GENDER)";

                cmd = new OracleCommand(sql, db.Connection);

                cmd.Parameters.Add("FIRST_NAME", metroTextBoxFirstName.Text);
                cmd.Parameters.Add("LAST_NAME", metroTextBoxLastName.Text);
                cmd.Parameters.Add("CITIZEN_ID", metroTextBoxCitizenID.Text);
                cmd.Parameters.Add("PHONE_NO", metroTextBoxContact.Text);
                cmd.Parameters.Add("JOB", metroTextBoxJob.Text);
                cmd.Parameters.Add("HIRE_DATE", OracleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("EMAIL_ADDRESS", metroTextBoxEAddress.Text);
                cmd.Parameters.Add("ADDRESS_LINE1", metroTextBoxAddressLine1.Text);
                cmd.Parameters.Add("ADDRESS_LINE2", metroTextBoxAddressLine2.Text);
                cmd.Parameters.Add("SUBURB", metroTextBoxSuburb.Text);
                cmd.Parameters.Add("CITY", metroTextBoxCity.Text);
                cmd.Parameters.Add("ZIP_CODE", metroTextBoxZipCode.Text);
                cmd.Parameters.Add("GENDER", metroComboBoxGender.Text);

                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message.ToString());
            }
            finally
            {
                db.CloseDatabase();
            }
            if (rows > 0)
            {
                MetroMessageBox.Show(ParentForm, "", "Staff Details Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear();
                
             }
             else
                 MetroMessageBox.Show(ParentForm, " ", "Staff Details not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             db.CloseDatabase();
        }

        internal void Clear()
        {
            metroTextBoxFirstName.Clear();
            metroTextBoxLastName.Clear();
            metroTextBoxCitizenID.Clear();
            metroTextBoxContact.Clear();
            metroTextBoxJob.Clear();
            metroDateTimeAddStaff.ResetText();
            metroComboBoxGrade.ResetText();
            metroTextBoxAddressLine1.Clear();
            metroTextBoxAddressLine2.Clear();
            metroTextBoxSuburb.Clear();
            metroTextBoxCity.Clear();
            metroTextBoxZipCode.Clear();
            metroTextBoxEAddress.Clear();
        }
    }
}
