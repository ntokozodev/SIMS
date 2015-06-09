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
    public partial class AddNewStaffGrade : MetroForm
    {
        private SimsOracle db;
        private OracleCommand cmd;

        public AddNewStaffGrade()
        {
            InitializeComponent();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            metroTextBoxDescription.Clear();
            metroTextBoxGradeNo.Clear();
            metroTextBoxRate.Clear();
        }

        private void metroTileAddGrade_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            int rows = 0;
            if (metroTextBoxGradeNo.Text == "")
                MessageBox.Show("You enter Grade number first");
            else if (metroTextBoxRate.Text == "")
                MessageBox.Show("You must enter Grade rate");
            else
            {
                try
                {
                    string sql = "INSERT INTO SIMS.GRADE " +
                                 "(DESCRIPTION, GRADE_NAME, GRADE_RATE) " +
                                 " VALUES " +
                                 " (:DESCRIPTION, :GRADE_NAME, :GRADE_RATE)";
                    cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("DESCRIPTION", metroTextBoxDescription.Text);
                    cmd.Parameters.Add("GRADE_NAME", metroTextBoxGradeNo.Text);
                    cmd.Parameters.Add("GRADE_RATE", metroTextBoxRate.Text);

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
                    MetroMessageBox.Show(ParentForm, "", "Staff Grade Captured Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    metroTextBoxDescription.Clear();
                    metroTextBoxGradeNo.Clear();
                    metroTextBoxRate.Clear();
                }
                else
                    MetroMessageBox.Show(ParentForm, " ", "Staff Grade not captured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                db.CloseDatabase();
            }     
        }
    }
}
