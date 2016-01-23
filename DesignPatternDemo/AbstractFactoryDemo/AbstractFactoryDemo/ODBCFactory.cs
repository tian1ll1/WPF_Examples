using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;

namespace AbstractFactoryDemo
{
    class ODBCFactory : DBFactory
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
