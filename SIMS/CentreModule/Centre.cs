/**
 * Edu-SIMS is (c) 2015 Geek Studio. All rights reserved.
 * 
 * http://www.geekstudio.co.za
 *
 * COPYRIGHTS:
 * Copyright (c) 2015 Geek Studio. All rights reserved.
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
     *      This class stores information about a centre/campus/school
     * </summary>
     */
    public class Centre
    {
        private string centreName;
        private int numberOfClasses;

        Centre(string name, int classes)
        {
            name = centreName;
            classes = numberOfClasses;
        }

        #region Properties

        string CentreName
        {
            get { return centreName; }
            set { centreName = value; }
        }
        int NumbeOfClasses
        {
            get { return numberOfClasses; }
            set { numberOfClasses = value; }
        }
        #endregion

        /**
         * A method that returns a number of classes in a specified centre or school
         * @param Centre - the specified school or centre
         */
        public List<ClassRoom> GetCentreClasses(Centre centre)
        {
            return null;
        }
        
    }
}
