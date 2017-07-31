/**
 * SIMS is (c) 2015 Ntokozo. All rights reserved.
 * 
 * https://www.ntokozos.com
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
 *		- Asive Dlaba [AD]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Validation
{
    public class ValidationClass
    {
        /**
         * Takes email address as input and
         * returns True if given input is a valid email address,
         * returns False otherwise.
         */
        internal Boolean isValidEmail(String email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /** 
         * Takes in name as input
         * returns true if name is valid
         * returns false otherwise
         */
        internal Boolean isValidName(String name)
        {
            Regex regex = new Regex(@"^[A-z][A-z|\.|\s]+$");
            return regex.IsMatch(name);
        }

        /**
         * Takes as phone number as input encoded as a string,
         * returns true if input is a valid phone number based on first digit 0 and 9 following digits
         * returns false otherwise. // This only works for south african phone numbers
         */
        internal Boolean isValidPhoneNumber(String phoneNumber)
        {
            //Accepts only 10 digits, no more no less.
            Regex regex = new Regex(@"^((\+)?27|0)\d{9}$");
            return regex.IsMatch(phoneNumber);
        }


        /** 
         * <summary>
         *     Check if a string is an integer.
         * </summary>
         * <param name="number">true if input string is an integer; otherwise, false.</param>
         */
        internal Boolean isValidInteger(string number)
        {
            Regex rgx = new Regex(@"^(\d)$");
            return rgx.IsMatch(number);
        }

        /** 
         * Takes South African ID number as input
         * returns true if ID number is valid,
         * return false otherwise
         */

        internal Boolean isValidIDNumber(String idNumber)
        {
            Regex regex = new Regex(@"^(((\d{2}((0[13578]|1[02])(0[1-9]|[12]\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\d|30)|02(0[1-9]|1\d|2[0-8])))|([02468][048]|[13579][26])0229))(( |-)(\d{4})( |-)(\d{3})|(\d{7}))$");
            return regex.IsMatch(idNumber);
        }
    }
}
