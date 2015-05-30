using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ParentForm());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Unexpected Error!", ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
