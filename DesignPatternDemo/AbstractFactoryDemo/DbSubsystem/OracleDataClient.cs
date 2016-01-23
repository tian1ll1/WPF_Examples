using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DbSubsystem
{
    class OracleDataClient : DBSubsystemInterface.DemoDBFactory
    {
        public override System.Data.IDbConnection GetDBConnection()
        {
            return new OleDbConnection();
        }

        public override System.Data.IDbCommand GetDBCommand()
        {
            return new OleDbCommand();
        }

        public override System.Data.IDataAdapter GetDataAdapter(System.Data.IDbCommand dictionary)
        {
            return new OleDbDataAdapter((OleDbCommand)dictionary);
        }
    }
}
