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

using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using SIMS.LearnerModule;

namespace SIMS.AccountModule
{
    public partial class DueFees : MetroForm
    {
        //private SimsOracle db;
        //private OracleDataAdapter da;
        //private DataTable dt;
        //private OracleDataReader dr;
        //private OracleCommand cmd;

        public DueFees()
        {
            InitializeComponent();
        }

        private void DueFees_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dS.STUDENT_PAYMENT' table. You can move, or remove it, as needed.
                this.stu_paymentTA.Fill(this.dS.STUDENT_PAYMENT);
                metroTextBoxTotalDue.Text = "R" + Convert.ToInt32(stu_feeTA.TotalBalance());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student transactions"+ex.Message.ToString());
            }
            
        }

        private double CellSum()
        {
            double sum = 0;
            for (int i = 0; i < metroGridDueFees.Rows.Count; ++i)
            {
                double d = 0;
                Double.TryParse(metroGridDueFees.Rows[i].Cells[3].Value.ToString(), out d);
                sum += d;
            }
            return sum;
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
