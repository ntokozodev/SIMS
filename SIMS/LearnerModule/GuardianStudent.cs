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
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.LearnerModule
{
    /**
     * <summary>
     *      Extension to the normal Guardian. This class stores a collection of students for every guardian 
     *      and a guardian role to each student in the collection.
     * </summary>
     */
    class GuardianStudent : Guardian
    {
        private Hashtable students;
        private int studentCount; // number of students registered under this guardian
        private string guardianRole;
        private Student student;

        public GuardianStudent( string guardianRole,
                                Student student,
                                string gCitizenID, string fname,
                                string lname, string cnumber, 
                                string haddress, string eaddress, 
                                string gnd) 
                                : base(gCitizenID, fname,
                                       lname, cnumber, 
                                       haddress, eaddress, 
                                       gnd)
        {
            this.guardianRole = guardianRole;
            this.student = student;
            students = new Hashtable();
        }

        public Hashtable Students
        {
            get { return students; }
            set 
            {
                try
                {
                    students.Add(this.guardianRole, student);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.ToString());
                }
            }
        }

        public int StudentCount
        {
            get { return students.Count; }
            set { studentCount = value; }
        }

        public string GuardianRole
        {
            get { return guardianRole; }
            set { guardianRole = value; }
        }
    }
}