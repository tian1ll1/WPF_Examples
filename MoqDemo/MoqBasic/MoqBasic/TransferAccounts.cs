using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasic
{
    public class TransferProcess
    {
        private Account From;
        private Account To;
        private ITransferProvider transfer;
        public TransferProcess(Account from, Account to, ITransferProvider transfer)
        {
            this.From = from;
            this.To = to;
            this.transfer = transfer;
        }
        public void Transfer(decimal money)
        {
            if (money < From.Balance)
            {
                From.Balance = From.Balance - money;
                To.Balance = To.Balance + money;
                transfer.TransferTo(From, To);
            }
            else
            {
                throw new Exception("No sufficient money for transfer!");
            }
        }
    }
}
