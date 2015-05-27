using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace SIMS
{
    public class SimsOracle
    {
        private OracleConnection connOracle;
        private OracleCommand sqlCommandOracle;

        public SimsOracle()
        {
            string p_conn_db = "DATA SOURCE=XE_DB;PASSWORD=Nng#8089;USER ID=EDU_SCHEMA;";
            connOracle = new OracleConnection(p_conn_db);
            connOracle.Open();
        }

        public int InsertRecord(string SQLStatement)
        {
            int n = 0;
            if (SQLStatement.Length > 0)
            {
                if (connOracle.State.ToString().Equals("Open"))
                {
                    sqlCommandOracle = new OracleCommand(SQLStatement, connOracle);
                    n = sqlCommandOracle.ExecuteNonQuery();
                }
            }
            return n;
        }

        public void CloseDatabase()
        {
            connOracle.Close();
            connOracle.Dispose();
        }
    }
}
