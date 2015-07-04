/**
 * SIMS is (c) 2015 Ntokozo. All rights reserved.
 * 
 * http://www.ntokozo.co.za
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
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace SIMS
{
    public class SimsOracle
    {
        private OracleConnection conn;
        private OracleCommand sqlCmd;

        public SimsOracle()
        {
            string conn_db = "DATA SOURCE=XE_DB;PASSWORD=oracle;USER ID=SIMS;";
            conn = new OracleConnection(conn_db);
            conn.Open();
        }

        public int InsertRecord(string SQLStatement)
        {
            int n = 0;
            if (SQLStatement.Length > 0)
            {
                if (conn.State.ToString().Equals("Open"))
                {
                    sqlCmd = new OracleCommand(SQLStatement, conn);
                    n = sqlCmd.ExecuteNonQuery();
                }
            }
            return n;
        }

        public void CloseDatabase()
        {
            conn.Close();
            conn.Dispose();
        }

        public OracleConnection Connection
        {
            get { return conn; }
        }
    }
}