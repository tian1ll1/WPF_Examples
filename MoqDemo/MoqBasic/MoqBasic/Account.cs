using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasic
{
    public class Account
    {
       public int ID { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public decimal Balance { get; set; }
    }

    public interface ITransferProvider
    {
        void TransferTo(Account accountFrom, Account accountTo);

    }
}
