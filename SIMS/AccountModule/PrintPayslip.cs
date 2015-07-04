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

using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIMS.AccountModule
{
    public partial class PrintPayslip : MetroForm
    {
        public PrintPayslip()
        {
            InitializeComponent();
            this.printDocumentPayslip.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPayslip_PrintPage);
        }

        private void PrintPayslip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.PAYSLIP' table. You can move, or remove it, as needed.
            this.pAYSLIPTableAdapter.Fill(this.dS.PAYSLIP);

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            payslipBN.Visible = false;
            printDialogPayslip.Document = printDocumentPayslip;
            DialogResult result = printDialogPayslip.ShowDialog();
            if (result == DialogResult.OK)
                printDocumentPayslip.Print();
            this.Close();
        }

        private void PrintPayslip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap memoryImage = new Bitmap(this.Width, this.Height);

            this.DrawToBitmap(memoryImage, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(memoryImage, 0, 0);
            memoryImage.Dispose();

        }
    }
}
