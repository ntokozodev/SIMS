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

namespace SIMS
{
    public partial class ParentForm : MetroForm
    {
        LoginForm log = new LoginForm();
        public ParentForm()
        {
            InitializeComponent();
            log.ShowDialog();
        }

        private void exitTile_Click(object sender, EventArgs e)
        {
            DialogResult reply = default(DialogResult);
            reply = MetroMessageBox.Show(this, "Are you sure you want to exit application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }
    }
}
