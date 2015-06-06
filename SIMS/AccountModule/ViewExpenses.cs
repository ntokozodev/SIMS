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
    public partial class ViewExpenses : MetroForm
    {
        public ViewExpenses()
        {
            InitializeComponent();
        }

        private void ViewExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.EXPENSE_PAYMENT' table. You can move, or remove it, as needed.
                this.TAExpensePayement.Fill(this.dS.EXPENSE_PAYMENT);
                // TODO: This line of code loads data into the 'dS.EXPENSE' table. You can move, or remove it, as needed.
                this.TAExpenses.Fill(this.dS.EXPENSE);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Database error!\n" + ex.Message.ToString());
            }
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileExpPayChanges_Click(object sender, EventArgs e)
        {
            try
            {
                TAExpensePayement.Update(this.dS.EXPENSE_PAYMENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!\n" + ex.Message.ToString());
            }
            
        }

        private void metroTileExpChanges_Click(object sender, EventArgs e)
        {
            try
            {
                TAExpenses.Update(this.dS.EXPENSE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!\n" + ex.Message.ToString());
            }
        }
    }
}
