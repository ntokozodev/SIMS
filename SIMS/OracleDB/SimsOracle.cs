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
            string conn_db = "DATA SOURCE=XE_DB;PASSWORD=Nng#8089;USER ID=EDU_SCHEMA;";
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