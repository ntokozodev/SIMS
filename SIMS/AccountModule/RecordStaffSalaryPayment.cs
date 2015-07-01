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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message.ToString());
            }
        }

        private void TileSalaryGenerate_Click(object sender, EventArgs e)
        {
            if (CheckBoxPayPeriod.Checked == false)
                MessageBox.Show("Select the right pay period and then check the small box below to confirm");
            else if (TextBoxRate.Text == "")
                MessageBox.Show("You should enter Payment Rate per lesson");
            else
                generateSalary();
        }

        private void generateSalary()
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;

            //string sql = 
        }
    }
}
