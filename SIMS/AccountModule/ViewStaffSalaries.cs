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

namespace SIMS.AccountModule
{
    public partial class ViewStaffSalaries : MetroForm
    {
        public ViewStaffSalaries()
        {
            InitializeComponent();
        }

        private void sALARYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALARYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void ViewStaffSalaries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SALARY' table. You can move, or remove it, as needed.
            this.sALARYTableAdapter.Fill(this.dS.SALARY);

        }
    }
}
