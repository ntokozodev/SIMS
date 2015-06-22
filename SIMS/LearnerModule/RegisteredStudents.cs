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

namespace SIMS.LearnerModule
{
    public partial class RegisteredStudents : MetroForm
    {
        public RegisteredStudents()
        {
            InitializeComponent();
        }

        private void sTUDENT_ENROLLMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENT_ENROLLMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void RegisteredStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.STUDENT_ENROLLMENT' table. You can move, or remove it, as needed.
            this.sTUDENT_ENROLLMENTTableAdapter.Fill(this.dS.STUDENT_ENROLLMENT);

        }
    }
}
