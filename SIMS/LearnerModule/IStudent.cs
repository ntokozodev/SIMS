/**
 * SIMS is (c) 2015 Ntokozo Company. All rights reserved.
 * 
 * http://www.ntokozo.com
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Ntokozo Company. All rights reserved.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using CentreModule;
using SIMS.DSTableAdapters;


namespace SIMS.LearnerModule
{
    /**
     * <summary>
     *      Interface for creating students 
     * </summary>
     */
    interface IStudent
    {
        string FirstName { get; }
        string LastName { get; }
        string StudentCitizenID { get; }
        string Gender { get; }
        string AddressLine1 { get; }
        string Suburb { get; }
        string City { get; }
        string ZipCode { get; }
        string EmailAddress { get; }
        string ContactNumber { get; }
        DateTimePicker AdmittedDate { get; }
        string AdmissionNumber { get; }
        string Centre { get; }

        //Centre SchoolCentre { get; }
        //ClassRoom StudentClass { get; }
        //Image Picture { get; }

        void addStudentToCentre(Student student);
        void assignStudentToClass(Student student);
        void moveStudent(Student student);
        string getStudentBalance(Student student);
        int addNewStudent(Student student);

        //void recordNewPayment(Payment payment);
    }
}
