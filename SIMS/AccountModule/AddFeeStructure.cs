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
    public partial class AddFeeStructure : MetroForm
    {
        private SimsOracle db;

        public AddFeeStructure()
        {
            InitializeComponent();
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            metroComboBoxOccurences.ResetText();
            metroTextBoxFeeName.Clear();
            metroTextBoxFeeAmount.Clear();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileAddFeeStructure_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;

            if (metroComboBoxOccurences.Text == "")
                MessageBox.Show("You have to select one of the fee occurence options first");
            else if (metroTextBoxFeeName.Text == "")
                MessageBox.Show("Enter fee category name to continue");
            else if (metroTextBoxFeeAmount.Text == "")
                MessageBox.Show("Enter fee amount to continue");
            else
            {
                try
                {
                    string sql = "INSERT INTO SIMS.FEE " +
                                        "(FEE_CATEGORY, FEE_AMOUNT, FEE_OCCURENCE) " +
                                 "VALUES (:FEE_CATEGORY, :FEE_AMOUNT, :FEE_OCCURENCE)";

                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("FEE_CATEGORY", metroTextBoxFeeName.Text);
                    cmd.Parameters.Add("FEE_AMOUNT", metroTextBoxFeeAmount.Text);
                    cmd.Parameters.Add("FEE_OCCURENCE", metroComboBoxOccurences.Text);

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
                MetroMessageBox.Show(ParentForm, "", "Fee Strucure Setup Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                metroComboBoxOccurences.ResetText();
                metroTextBoxFeeName.Clear();
                metroTextBoxFeeAmount.Clear();
            }
            else
                MetroMessageBox.Show(ParentForm, " ", "Details not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            db.CloseDatabase();
        }
    }
}
