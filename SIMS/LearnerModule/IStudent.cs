/**
 * Edu-SIMS is (c) 2015 Create12. All rights reserved.
 * 
 * https://www.create12.com
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Create12. All rights reserved.
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

using CentreModule;


namespace StudentEnrolment
{
    /**
     * <summary>
     *      Interface for students 
     * </summary>
     */
    interface IStudent
    {
        string StudentName { get; }
        string StudentNumber { get; }
        string StudentCitizenID { get; }
        string GuardianCitizenID { get; }
        string Gender { get; }
        Address HomeAddress { get; }
        string ContactNumber { get; }
        DateTime AdmittedDate { get; }
        Centre SchoolCentre { get; }
        ClassRoom StudentClass { get; }
        //Image Picture { get; }

        void addStudentToCentre(Student student);
        void assignStudentToClass(Student student);
        void moveStudent(Student student);
        //void recordNewPayment(Payment payment);
        string getStudentBalance(Student student);
    }
}
