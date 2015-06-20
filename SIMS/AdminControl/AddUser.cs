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

namespace SIMS.AccessControl
{
    public partial class AddUser : MetroForm
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.EMPLOYEE' table. You can move, or remove it, as needed.
            this.employeeTA.Fill(this.employeeDS.EMPLOYEE);

        }

        private void metroTileSearch_Click(object sender, EventArgs e)
        {
            int rows = 0;
            try
            {
                rows = employeeTA.SearchBySurname(this.employeeDS.EMPLOYEE, TextBoxSearch.Text.ToLower());
                if (rows == 0)
                {
                    MessageBox.Show("The surname: " + TextBoxSearch.Text + " does not exist in our database records.");
                    TextBoxSearch.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching staff member:\n" + ex.Message.ToString());
            }
        }

        private void metroTileAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = "";
                string password = "";
                int id = 0;
                for (int i = 0; i < employeeDGV.Rows.Count; i++)
                {
                    if (employeeDGV.Rows[i].Selected)
                    { 
                        userName = Convert.ToString(employeeDGV.Rows[i].Cells[2].Value) + Convert.ToString(employeeDGV.Rows[i].Cells[0].Value);
                        password = Convert.ToString(employeeDGV.Rows[i].Cells[2].Value);
                        id = Convert.ToInt32(employeeDGV.Rows[i].Cells[0].Value);
                        InsertUser(userName, password, id);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding selected user:\n" + ex.Message.ToString());
            }
        }

        private void InsertUser(string userName, string password, int id)
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;

            usersTA.FillByUser(this.employeeDS.SIMS_USERS, id);
            if (employeeDS.SIMS_USERS.Rows.Count > 0)
                MessageBox.Show("Username: " + userName + " is already added");

            else
            {
                try
                {
                    string sql = "INSERT INTO SIMS_USERS " +
                                 "(USER_NAME, PASSWORD, EMPLOYEE_ID) " +
                                 " VALUES " +
                                 "(:USER_NAME, :PASSWORD, :EMPLOYEE_ID)";
                    OracleCommand cmd = new OracleCommand(sql, db.Connection);
                    cmd.Parameters.Add("USER_NAME", userName);
                    cmd.Parameters.Add("PASSWORD", password);
                    cmd.Parameters.Add("EMPLOYEE_ID", id);
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting user login details:\n" + ex.Message.ToString());
                }
            }
            if (rows > 0)
                MessageBox.Show("User login details has been added, you can now login using:\n" + userName + " and " + password  + " as login credentials");
        }
    }
}
