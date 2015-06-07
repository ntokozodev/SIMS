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
        { }

        private void metroTileAddPay_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;

            if (metroTextBoxAdminNo.Text == "")
                MessageBox.Show("Enter student admission no");
            else if (metroTextBoxPayAmount.Text == "")
                MessageBox.Show("Enter payment amount");
            else if (metroComboBoxCategory.Text == "")
                MessageBox.Show("Select fee category");
            else if (metroComboBoxPayType.Text == "")
                MessageBox.Show("Select type of payment");
            else 
            {
                try
                {
                    string sql = "INSERT INTO STUDENT_PAYMENT " +
                                        "(STUDENT_ID, FEE_ID, FEE_BALANCE, PAYMENT_AMOUNT, PAYMENT_DATE, PAYMENT_TYPE)" +
                                 "VALUES" +
                                        "((SELECT STUDENT_ID FROM SIMS.STUDENT WHERE ADMISSION_NO = '"+metroTextBoxAdminNo.Text+"'),"+
                                         "(SELECT FEE_ID FROM SIMS.FEE WHERE FEE_CATEGORY = '"+metroComboBoxCategory.Text+"')," +
                                         "(SELECT FEE_AMOUNT FROM SIMS.FEE WHERE FEE_CATEGORY = '" + metroComboBoxCategory.Text + "') - '"+ metroTextBoxPayAmount.Text +"'," +
                                         ":PAYMENT_AMOUNT, :PAYMENT_DATE, :PAYMENT_TYPE" +
                                         ")";
                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("PAYMENT_AMOUNT", metroTextBoxPayAmount.Text);
                    cmd.Parameters.Add("PAYMENT_DATE", OracleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("PAYMENT_TYPE", metroComboBoxPayType.Text);

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

                if (rows > 0)
                {
                    MetroMessageBox.Show(ParentForm, "", "Student Payment Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    metroTextBoxAdminNo.Clear();
                    metroTextBoxPayAmount.Clear();
                    metroComboBoxCategory.ResetText();
                    metroComboBoxPayType.ResetText();
                    metroDateTimePayment.ResetText();
                    this.Refresh();
                }
                else
                    MetroMessageBox.Show(ParentForm, " ", "Student Payment not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                db.CloseDatabase();
            }
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            metroTextBoxAdminNo.Clear();
            metroTextBoxPayAmount.Clear();
            metroComboBoxCategory.ResetText();
            metroComboBoxPayType.ResetText();
            metroDateTimePayment.ResetText();
        }
    }
}
