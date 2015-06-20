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

namespace SIMS.AccessControl
{
    public partial class ChangePassword : MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            TextBoxConfirmPword.Clear();
            TextBoxNewPword.Clear();
            TextBoxOldPword.Clear();
            TextBoxUsername.Clear();
        }

        private void metroTileChange_Click(object sender, EventArgs e)
        {
            int rows = 0;

            if (TextBoxUsername.Text == "" || !isUsernameValid())
            {
                MessageBox.Show("Username is not valid");
                TextBoxUsername.Focus();
            }
            else if (!isCurrentUser())
                MessageBox.Show("You can't change password for " + TextBoxUsername.Text + "\nYou should logon as " + TextBoxUsername.Text +" to change its password");
            else if (TextBoxOldPword.Text == "" || !isOldPasswordValid())
            {
                MessageBox.Show("Old password is not valid");
                TextBoxOldPword.Focus();
            }
            else if (TextBoxNewPword.Text == "")
            {
                MessageBox.Show("You should enter new password");
                TextBoxNewPword.Focus();
            }
            else if (TextBoxConfirmPword.Text == "")
            {
                MessageBox.Show("You should confirm new password");
                TextBoxConfirmPword.Focus();
            }
            else if (TextBoxNewPword.Text != TextBoxConfirmPword.Text)
            {
                MessageBox.Show("Passwords do not match");
                TextBoxConfirmPword.Focus();
            }
            else
            {
                try
                {
                    rows = changePTA.UpdatePassword(TextBoxNewPword.Text, TextBoxUsername.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing password:\n" + ex.Message.ToString());
                }
                if (rows > 0)
                {
                    MessageBox.Show("Password has been changed successfully");
                    ClearControls();
                }
                else
                    MessageBox.Show("Password not updated");
            }
        }

        private bool isOldPasswordValid()
        {
            changePTA.FillByPassword(this.changeDS.SIMS_USERS, TextBoxOldPword.Text);
            if (changeDS.SIMS_USERS.Rows.Count > 0)
                return true;
            else
                return false;
        }


        private bool isUsernameValid()
        {
           changePTA.FillByUserName(this.changeDS.SIMS_USERS, TextBoxUsername.Text);
           if (changeDS.SIMS_USERS.Rows.Count > 0)
               return true;
           else
               return false;
        }

        private bool isCurrentUser()
        {

            if (LoginForm.UserName == TextBoxUsername.Text)
                return true;
            return false;
        }
    }
}
