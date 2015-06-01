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

using Validation;

namespace SIMS.LearnerModule
{
    /**
     * <summary>
     *      This class stores guardian information for enroled students
     * </summary>
     */
    class Guardian
    {
        private string guardianCitizenID;
        private string firstName;
        private string lastName;
        private string contactNumber;
        private string homeAddress;
        private string emailAddress;
        private string gender;

        public Guardian(string gCitizenID, string fname,
                        string lname, string cnumber, 
                        string haddress, string eaddress, 
                        string gnd) 
        {
            if (Valid.isCitizenIDValid(gCitizenID))
                guardianCitizenID = gCitizenID;
            if (Valid.isEmailValid(eaddress))
                emailAddress = eaddress;
            if (Valid.isContactNumberValid(cnumber))
                contactNumber = cnumber;
            firstName = fname;
            lastName = lname;
            homeAddress = haddress;
            gender = gnd;
        }
         
        public string GuardianCitizenID
        {
            get { return guardianCitizenID; }
            set { guardianCitizenID = value; }
        }

        public string GuardianName
        {
            get { return firstName + " " + lastName; }
            set { firstName = value; lastName = value; }
        }

        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
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
    }
}