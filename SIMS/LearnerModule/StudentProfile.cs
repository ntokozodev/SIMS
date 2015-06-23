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
using Oracle.ManagedDataAccess.Client;

namespace SIMS.LearnerModule
{
    public partial class StudentProfile : MetroForm
    {

        private string admission_no = "";
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_profileDS.STUDENT_ENROLLMENT' table. You can move, or remove it, as needed.
            this.student_enrollmentTA.Fill(this.student_profileDS.STUDENT_ENROLLMENT);
            try
            {
                // TODO: This line of code loads data into the 'dS.STUDENT_PROFILE' table. You can move, or remove it, as needed.
                this.student_profileTA.FillStudentProfile(this.student_profileDS.STUDENT_PROFILE);
                LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
                admission_no = LabelAdmissionNo.Text;
                displaySubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile:\n" + ex.Message.ToString());
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LabelFullName.Text = LabelName.Text + " " + LabelSurname.Text;
            admission_no = LabelAdmissionNo.Text;
            displaySubjects();
        }

        internal void displaySubjects()
        {
            SimsOracle db = new SimsOracle();
            string sql = "SELECT SUBJECT_CODE, ACADEMIC_YEAR "+
                         " FROM STUDENT_ENROLLMENT SE"+
                         " WHERE SE.ADMISSION_NO = '" + admission_no + "'";
            try
            {
                OracleDataAdapter da = new OracleDataAdapter(sql, db.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                subjectDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects:\n" + ex.Message.ToString());
            }
            db.CloseDatabase();
        }
    }
}
