using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SIMS.AdminControl
{
    public partial class ViewCentre : MetroForm
    {
        public ViewCentre()
        {
            InitializeComponent();
        }

        private void cENTREBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cENTREBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void ViewCentre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CENTRE' table. You can move, or remove it, as needed.
            this.cENTRETableAdapter.Fill(this.dS.CENTRE);

        }
    }
}
