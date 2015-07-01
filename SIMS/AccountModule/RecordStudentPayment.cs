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
    public partial class RecordStudentPayment : MetroForm
    {
        private SimsOracle db;

        public RecordStudentPayment()
        {
            InitializeComponent();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecordStudentPayment_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dSS.STUDENT' table. You can move, or remove it, as needed.
                this.studentTA.Fill(this.stupDS.STUDENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error!\n" + ex.Message.ToString());
            }
        }

        private void metroTileAddPay_Click(object sender, EventArgs e)
        {
            payTuitionFee();
        }

        /**
         * @param adminNo, takes student admission number as input
         * @return true if adminNo is valid by finding student associated with it in database, otherwise false
         */
        internal bool isAdmissionNoValid(string adminNo)
        {
            try
            {
                studentTA.FillByEnrolmentNo(stupDS.STUDENT, adminNo);
                if (stupDS.STUDENT.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message.ToString());
            }
            return false;
        }

        internal void payTuitionFee() 
        {
            db = new SimsOracle();
            int rows = 0;

            if (TextBoxAdminNo.Text == "" || !isAdmissionNoValid(TextBoxAdminNo.Text))
                MessageBox.Show("Admission No. " + TextBoxAdminNo.Text + " is not valid");
            else if (TextBoxYear.Text == "" || TextBoxYear.Text.Length > 4 || TextBoxYear.Text.Length != 4 || TextBoxYear.Text.Length < 0)
                MessageBox.Show("Academic year is not valid");
            else if (!isYearRegistered(TextBoxYear.Text))
                MessageBox.Show("Student: " + TextBoxAdminNo.Text + " is not registered for academic year: " + TextBoxYear.Text);
            else if (TextBoxPayAmount.Text == "")
                MessageBox.Show("Enter payment amount");
            else if (ComboBoxPayType.Text == "")
                MessageBox.Show("Select type of payment");
            else
            {
                var datestring = DateTimePayment.Value.ToShortDateString();
                int feeAmount = Convert.ToInt32(student_feeTA.FeeAmount(TextBoxAdminNo.Text, TextBoxYear.Text));
                int newBalance;
                if (checkLearnerPayment())
                    newBalance = Convert.ToInt32(student_feeTA.Balance(TextBoxAdminNo.Text, TextBoxYear.Text)) - Convert.ToInt32(TextBoxPayAmount.Text);
                else
                    newBalance = feeAmount - Convert.ToInt32(TextBoxPayAmount.Text);
                
                try
                {
                    string sql = "INSERT INTO STUDENT_PAYMENT " +
                                        "(PAYMENT_AMOUNT, PAYMENT_TYPE, BALANCE, PAYMENT_DATE, CAPTURED_DATE, ADMISSION_NO, ACADEMIC_YEAR)" +
                                 "VALUES (" +
                                         ":PAYMENT_AMOUNT, :PAYMENT_TYPE, :BALANCE, :PAYMENT_DATE, :CAPTURED_DATE, :ADMISSION_NO, :ACADEMIC_YEAR )";

                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("PAYMENT_AMOUNT", TextBoxPayAmount.Text);
                    cmd.Parameters.Add("PAYMENT_TYPE", ComboBoxPayType.Text);
                    cmd.Parameters.Add("BALANCE", newBalance);
                    cmd.Parameters.Add("PAYMENT_DATE", OracleDbType.Date).Value = DateTime.Parse(datestring);
                    cmd.Parameters.Add("CAPTURED_DATE", OracleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("ADMISSION_NO", TextBoxAdminNo.Text);
                    cmd.Parameters.Add("ACADEMIC_YEAR", TextBoxYear.Text);

                    rows = cmd.ExecuteNonQuery();

                    db.CloseDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!\n" + ex.Message.ToString());
                }
                finally
                {
                    db.CloseDatabase();
                }

                if (rows > 0)
                {
                    MetroMessageBox.Show(ParentForm, "", "Student Payment Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    student_feeTA.UpdateBalance(newBalance, TextBoxAdminNo.Text, TextBoxYear.Text);
                    ClearControls();
                }
                else
                    MetroMessageBox.Show(ParentForm, " ", "Student Payment not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                db.CloseDatabase();
            }
        }

        private bool checkLearnerPayment()
        {
            try
            {
                student_paymentTA.FillByAdmissionNo(this.stupDS.STUDENT_PAYMENT, TextBoxAdminNo.Text, TextBoxYear.Text);
                if (stupDS.STUDENT_PAYMENT.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message.ToString());
            }
            return false;
        }

        internal bool isYearRegistered(string year) 
        {
            try
            {
                student_enrollmentTA.FillByAcademicYear(stupDS.STUDENT_ENROLLMENT, year);
                if (stupDS.STUDENT_ENROLLMENT.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message.ToString());
            }
            return false;
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        internal void ClearControls()
        {
            TextBoxAdminNo.Clear();
            TextBoxPayAmount.Clear();
            ComboBoxPayType.ResetText();
            DateTimePayment.ResetText();
            TextBoxYear.Clear();
            this.Refresh();
        }
    }
}
