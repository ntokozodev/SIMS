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
                // TODO: This line of code loads data into the 'profileDS.STUDENT_PROFILE' table. You can move, or remove it, as needed.
                this.stu_profileTA.FillStudentProfile(this.profileDS.STUDENT_PROFILE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile:\n" + ex.Message.ToString());
            }
        }
    }
}
