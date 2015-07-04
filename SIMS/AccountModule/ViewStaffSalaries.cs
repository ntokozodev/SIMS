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
