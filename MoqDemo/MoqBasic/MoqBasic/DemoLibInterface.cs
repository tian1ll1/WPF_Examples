using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasic
{
    public interface ITest
    {
        string ShowMsg();
    }

    public interface IMatchTest
    {
        string MathDiv(int test);
    }

    public interface IPropertiesTest
    {
        int UserInfo { get; set; }
    }
}
