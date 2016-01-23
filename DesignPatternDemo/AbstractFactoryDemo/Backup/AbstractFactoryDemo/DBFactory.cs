using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace AbstractFactoryDemo
{
    public  abstract class DBFactory
    {
        public abstract IDbConnection GetDBConnection();
        public abstract IDbCommand GetDBCommand();
        public abstract IDataAdapter GetDataAdapter(IDbCommand dictionary);
            
    }
}
