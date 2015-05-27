/**
 * Edu-SIMS is (c) 2015 Ntokozo Company. All rights reserved.
 * 
 * http://www.ntokozo.co.za
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

using CentreModule;
using Validation;
using SIMS.SIMS_DSTableAdapters;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;
using System.Data;
using MetroFramework;

namespace SIMS.LearnerModule
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
        private string studentCitizenID;
        private string guardianCitizenID;
        private string gender;
        private string contactNumber;
        private DateTimePicker admittedDate;
        private string addressLine1;
        private string addressLine2;
        private string suburb;
        private string city;
        private string zipCode;
        private string emailAddress;
        private string admissionNumber;

        //private Centre schoolCentre;
        //private ClassRoom studentClass;
        //private Image picture;

        public Student( string fName, string lName, 
                        string sCitizenID, string gCitizenID, 
                        string genderValue, string cNumber,
                        DateTimePicker adDate, string adminNo, 
                        string addr1, string addr2, 
                        string subV, string cityV, 
                        string zipV, string email
                      ) 
        {
            firstName = fName;
            lastName = lName;
            gender = genderValue;
            admittedDate = adDate;
            studentCitizenID = sCitizenID;
            guardianCitizenID = gCitizenID; 
            contactNumber = cNumber;
            addressLine1 = addr1;
            addressLine2 = addr2;
            suburb = subV;
            city = cityV;
            zipCode = zipV;
            emailAddress = email;
            admissionNumber = adminNo;

            //picture = pic;
            //schoolCentre = sCentre;
            //studentClass = sClass;
        }

        #region Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StudentCitizenID
        {
            get { return studentCitizenID; }
            set { studentCitizenID = value; }
        }

        public string GuardianCitizenID
        {
            get { return guardianCitizenID; }
            set { guardianCitizenID = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public DateTimePicker AdmittedDate
        {
            get { return admittedDate; }
            set { admittedDate = value; }
        }

        public string AdmissionNumber
        {
            get { return admissionNumber; }
            set { admissionNumber = value; }
        }

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        #endregion


        public int addNewStudent(Student stu)
        {
            SimsOracle db = new SimsOracle();
            int rows = 0;
            try
            {
                string query = "INSERT INTO EDU_SCHEMA.STUDENT (ADMISION_NO, FIRST_NAME, STUDENT_CITIZEN_ID, STUDENT_GENDER, PHONE_NUMBER, LAST_NAME, ADDRESS_LINE1, ADDRESS_LINE2, SUBURB, CITY, ZIP_CODE, EMAIL_ADDRESS) VALUES ('"+stu.admissionNumber+"', '"+stu.firstName+"', '"+stu.studentCitizenID+"', '"+stu.gender+"', '"+stu.contactNumber+"', '"+stu.lastName+"', '"+stu.addressLine1+"', '"+stu.addressLine2+"', '"+stu.suburb+"', '"+stu.city+"', '"+stu.zipCode+"', '"+stu.emailAddress+"')";
 
                rows = db.InsertRecord(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!\n" + ex.Message.ToString());
            }
            finally
            {
                db.CloseDatabase();
            }

            db.CloseDatabase();
            return rows;
        }

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

        public string getStudentBalance(Student student)
        {
            throw new NotImplementedException();
        }

        //public void recordNewPayment(AccountsModule.Payment payment)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
