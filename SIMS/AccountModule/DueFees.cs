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
    public partial class DueFees : MetroForm
    {
        private SimsOracle db;
        private OracleDataAdapter da;
        private DataTable dt;

        public DueFees()
        {
            InitializeComponent();
        }

        private void DueFees_Load(object sender, EventArgs e)
        {
        }

        private void metroTileLoadDueFee_Click(object sender, EventArgs e)
        {
            db = new SimsOracle();
            try
            {
                string sql = "SELECT admission_no, first_name, last_name, phone_number, fee_occurence, fee_category, fee_amount, fee_balance" +
                             " FROM STUDENT S, FEE F, STUDENT_PAYMENT P" +
                             " WHERE S.student_citizen_id = P.student_id" +
                             " AND P.fee_id = F.fee_id " +
                             " AND fee_balance > 0 " +
                             " ORDER BY admission_no";

                da = new OracleDataAdapter(sql, db.Connection);
                dt = new DataTable();
                da.Fill(dt);
                metroGridDueFees.DataSource = dt;
                metroTilePrintDueFees.Visible = true;
                metroLabelDueAmount.Visible = true;
                metroLabelTotalDue.Visible = true;
                db.CloseDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message.ToString());
            }
            finally
            {
                db.CloseDatabase();
            }
        }
    }
}
