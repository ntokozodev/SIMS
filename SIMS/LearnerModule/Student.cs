/**
 * Edu-SIMS is (c) 2015 Geek Studio Company. All rights reserved.
 * 
 * http://www.geekstudio.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Geek Studio Company. All rights reserved.
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
using Validation;

namespace StudentEnrolment
{
    /**
     * <summary>
     *      Implementation to IStudent. This class stores information 
     *      about students and their guardians
     * </summary>
     */
    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private string admissinNumber;
        private string studentCitizenID;
        private string guardianCitizenID;
        private string gender;
        private string contactNumber;
        private DateTime admittedDate;
        private Address address;
        private Centre schoolCentre;
        private ClassRoom studentClass;
        //private Image picture;

        public Student( string fName, string lName, 
                        string sNumber, string sCitizenID, 
                        string gCitizenID, string genderValue,
                        Address addr, string cNumber, 
                        DateTime adDate, Centre sCentre, 
                        ClassRoom sClass) 
        {
            firstName = fName;
            lastName = lName;
            admissinNumber = sNumber;
            gender = genderValue;
            address = addr;
            admittedDate = adDate;
            schoolCentre = sCentre;
            studentClass = sClass;
            //picture = pic;
            if (Valid.isCitizenIDValid(sCitizenID))
                studentCitizenID = sCitizenID;
            if (Valid.isCitizenIDValid(gCitizenID))
                guardianCitizenID = gCitizenID; 
            if (Valid.isContactNumberValid(cNumber))
                contactNumber = cNumber;
        }

        public string StudentName
        {
            get { return firstName + " " + lastName; }
            set { firstName = value; lastName = value; }
        }

        public string StudentNumber
        {
            get { return admissinNumber; }
            set { admissinNumber = value; }
        }

        public string StudentCitizenID
        {
            get { return studentCitizenID; }
            set { studentCitizenID = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Address HomeAddress
        {
            get { return address; }
            set { address = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public DateTime AdmittedDate
        {
            get { return admittedDate; }
            set { admittedDate = value; }
        }

        public string GuardianCitizenID
        {
            get { return guardianCitizenID; }
            set { guardianCitizenID = value; }
        }

        public Centre SchoolCentre
        {
            get { return schoolCentre; }
            set { schoolCentre = value; }
        }

        public ClassRoom StudentClass
        {
            get { return studentClass; }
            set { studentClass = value; }
        }

        //public Image Picture
        //{
        //    get { return picture; }
        //    set { picture = value; }
        //}


        public void addStudentToCentre(Student student)
        {
            throw new NotImplementedException();
        }

        public void assignStudentToClass(Student student)
        {
            throw new NotImplementedException();
        }

        public void moveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        //public void recordNewPayment(AccountsModule.Payment payment)
        //{
        //    throw new NotImplementedException();
        //}

        public string getStudentBalance(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
