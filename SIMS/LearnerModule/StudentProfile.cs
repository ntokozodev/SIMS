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
    public partial class StudentProfile : MetroForm
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.STUDENT_PROFILE' table. You can move, or remove it, as needed.
                this.student_profileTA.FillStudentProfile(this.student_profileDS.STUDENT_PROFILE);
                LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile:\n" + ex.Message.ToString());
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
        }
    }
}
