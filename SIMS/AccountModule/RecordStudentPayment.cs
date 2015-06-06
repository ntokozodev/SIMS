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
            // TODO: This line of code loads data into the 'dS.FEE' table. You can move, or remove it, as needed.
            this.fEETableAdapter.Fill(this.dS.FEE);

        }
    }
}
