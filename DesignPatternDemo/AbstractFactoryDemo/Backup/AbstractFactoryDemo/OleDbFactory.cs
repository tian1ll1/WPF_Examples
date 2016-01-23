using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace AbstractFactoryDemo
{
    class OleDbFactory : DBFactory
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
