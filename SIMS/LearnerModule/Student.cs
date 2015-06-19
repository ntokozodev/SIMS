/**
 * SIMS is (c) 2015 Geek Studio Company. All rights reserved.
 * 
 * http://www.gstudioc.co.za
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
using SIMS.DSTableAdapters;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;
using System.Data;
using MetroFramework;
using System.Globalization;

namespace SIMS.LearnerModule
{
    /**
     * <summary>
     *      Implementation to IStudent. This class stores information 
     *      about students details
     * </summary>
     */
    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private string studentCitizenID;
        private string gender;
        private string contactNumber;
        private string addressLine1;
        private string suburb;
        private string city;
        private string zipCode;
        private string emailAddress;
        private string centre;
        private DateTimePicker admittedDate;
        private SimsOracle db;

        //private Centre schoolCentre;
        //private ClassRoom studentClass;
        //private Image picture;

        public Student( string fName, string lName, 
                        string sCitizenID, string genderValue, 
                        string cNumber, DateTimePicker adDate, 
                        string addr1, string subV, string cityV, 
                        string zipV, string email, string cent
                      ) 
        {
            firstName = fName;
            lastName = lName;
            gender = genderValue;
            admittedDate = adDate;
            studentCitizenID = sCitizenID;
            contactNumber = cNumber;
            addressLine1 = addr1;
            suburb = subV;
            city = cityV;
            zipCode = zipV;
            emailAddress = email;
            centre = cent;

            //picture = pic;
            //schoolCentre = sCentre;
            //studentClass = sClass;
        }

        #region "Properties"
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

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
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

        public string Centre
        {
            get { return centre; }
            set { centre = value; }
        }
        #endregion


        public int addNewStudent(Student stu)
        {
            db = new SimsOracle();
            int rows = 0;
            var datestring = stu.admittedDate.Value.ToShortDateString();
            try
            {
                string query = "INSERT INTO SIMS.STUDENT " +
                                      "(NAME, SURNAME, GENDER," +
                                      "PHONE, ENROLLED_DATE, CITIZEN_ID, ADDRESS," +
                                      "SUBURB, CITY, ZIPCODE, EMAIL, CENTRE_ID) " +
                               "VALUES (:NAME, :SURNAME, :GENDER," +
                                       ":PHONE, :ENROLLED_DATE, :CITIZEN_ID, :ADDRESS," +
                                       ":SUBURB, :CITY, :ZIPCODE, :EMAIL, " +
                                       "(SELECT CENTRE_ID FROM SIMS.CENTRE WHERE NAME = '"+ stu.centre +"'))";
                OracleCommand cmd = new OracleCommand(query, db.Connection);
                cmd.Parameters.Add("FIRST_NAME", stu.firstName);
                cmd.Parameters.Add("LAST_NAME", stu.lastName);
                cmd.Parameters.Add("STUDENT_GENDER", stu.gender);
                cmd.Parameters.Add("PHONE_NUMBER", stu.contactNumber);
                cmd.Parameters.Add("ENROLLED_DATE", OracleDbType.Date).Value = DateTime.Parse(datestring);
                cmd.Parameters.Add("STUDENT_CITIZEN_ID", stu.studentCitizenID);
                cmd.Parameters.Add("ADDRESS_LINE1", stu.addressLine1);
                cmd.Parameters.Add("SUBURB", stu.suburb);
                cmd.Parameters.Add("CITY", stu.city);
                cmd.Parameters.Add("ZIP_CODE", stu.zipCode);
                cmd.Parameters.Add("EMAIL_ADDRESS", stu.emailAddress);
                
                rows = cmd.ExecuteNonQuery(); 
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
