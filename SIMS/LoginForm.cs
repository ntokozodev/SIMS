/**
 * SIMS is (c) 2015 Ntokozo. All rights reserved.
 * 
 * http://www.ntokozo.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Ntokozo. All rights reserved.
 * 
 * --------------------------------------------------------------------------------
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met: 
 *
 * 1) Redistributions of source code must retain the above copyright notice. 
 * 2) Redistributions in binary form must reproduce the above copyright notice 
 *    in the documentation and/or other materials provided with the distribution. 
 *
 * --------------------------------------------------------------------------------
 * Contributers to the code:
 *		- Ntokozo Nicholas Shagala [NNS]
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework;

namespace SIMS
{
    public partial class LoginForm : MetroForm
    {
        private static string userID;

        public LoginForm()
        {
            InitializeComponent();
            userIDTextBox.Focus();
        }

        #region "Properties"
        private Boolean authenticated = false;
        public Boolean Authenticated
        {
            get { return authenticated; }
            set { authenticated = value; }
        }

        private string username = "";
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        #endregion

        private void loginTile_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (pwordTextBox.Text.Length > 0 && userIDTextBox.Text.Length > 0)
            {
                if (isUserAuthenticated(userIDTextBox.Text, pwordTextBox.Text))
                {
                    Authenticated = true;
                    MetroMessageBox.Show(this, "Login successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close(); // close this form - do not exit the application
                }
                else
                {
                    Authenticated = false;
                    //Username or password is incorrect
                    DialogResult reply = default(DialogResult);
                    reply = MetroMessageBox.Show(this, "Username or Password is not recognised", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (reply == DialogResult.Cancel)
                        Application.Exit();
                    userIDTextBox.Clear();
                    pwordTextBox.Clear();
                    userIDTextBox.Focus();
                }
            }
            else // password or username is empty
            {
                Authenticated = false;
                DialogResult reply = default(DialogResult);
                reply = MetroMessageBox.Show(this, "You need to enter both a username and a password to continue", "Empty fields not allowed!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (reply == DialogResult.Cancel)
                    Application.Exit();
                userIDTextBox.Clear();
                pwordTextBox.Clear();
                userIDTextBox.Focus();
            }
        }

        private bool isUserAuthenticated(string user, string pword)
        {
            try
            {
                usersTA.FillByUserPass(loginDS.SIMS_USERS, user, pword);
                if (loginDS.SIMS_USERS.Rows.Count > 0)
                {
                    for (int i = 0; i < loginDS.SIMS_USERS.Rows.Count; i++)
                        userID = Convert.ToString(loginDS.SIMS_USERS.Rows[i][1]);
                    return true;
                }    
                else
                    return false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Login error:\n" + ex.Message.ToString());
                Application.Exit();
            }
            Authenticated = false;
            return false;
        }

        public static string UserName
        {
            get { return userID; }
        }

        private void cancelTile_Click(object sender, EventArgs e)
        {
            // exit the program if user do not want to login
            Application.Exit();
        }
    }
}
