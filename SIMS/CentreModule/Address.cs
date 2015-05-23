/**
 * Edu-SIMS is (c) 2015 Geek Studio. All rights reserved.
 * 
 * http://www.geekstudio.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Geek Studio Company (Pty) Ltd. All rights reserved.
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

namespace CentreModule
{
    /**
    * <summary>
    *      This class stores information about address including email address for each entity
    * </summary>
    */
    public class Address
    {
        private string addressLine1;
        private string addressLine2;
        private string surburb;
        private string city;
        private string email;
        private int zipCode;
        private int studentNo;
        private int staffNo;

        Address(string addressL1, string addressL2,
                string surburbV, string cityV, string emailA,
                int zipC, int studentN, int staffN)
        {
            addressL1 = addressLine1;
            addressL2 = addressLine2;
            surburbV = surburb;
            city = cityV;
            email = emailA;
            zipC = zipCode;
            studentN = studentNo;
            staffN = staffNo;
        }


    }
}
