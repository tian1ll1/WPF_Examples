using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace MySqlDBSubSystem
{
    public class MySQLDBFactory : DBSubsystemInterface.DemoDBFactory

    {
        public override System.Data.IDbConnection GetDBConnection()
        {
            return new OdbcConnection();
        }

        public override System.Data.IDbCommand GetDBCommand()
        {
            return new OdbcCommand();
        }

        public override System.Data.IDataAdapter GetDataAdapter(System.Data.IDbCommand dictionary)
        {
            return new OdbcDataAdapter((OdbcCommand)dictionary);
        }
    }
}
