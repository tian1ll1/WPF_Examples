using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBSubsystemInterface
{
    public abstract class DemoDBFactory
    {
        public abstract IDbConnection GetDBConnection();
        public abstract IDbCommand GetDBCommand();
        public abstract IDataAdapter GetDataAdapter(IDbCommand dictionary);

    }
}
