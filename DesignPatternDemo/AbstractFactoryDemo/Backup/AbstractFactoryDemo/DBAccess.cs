using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AbstractFactoryDemo
{
    class DBAccess
    {
        private DBFactory _dBFactory = null;
        private IDbConnection conn = null;

       public DBAccess(DBFactory factory)
        {
            this._dBFactory = factory;
        }

        public void Open(string connStr)
        {
            conn = _dBFactory.GetDBConnection();
            conn.ConnectionString = connStr;
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public DataSet ExecSQL(string sql)
        {
            IDbCommand cmd = _dBFactory.GetDBCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            IDataAdapter da = _dBFactory.GetDataAdapter(cmd);

            DataSet result = new DataSet();
            da.Fill(result);

            return result;
        }
    }
}
