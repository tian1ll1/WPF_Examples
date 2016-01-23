using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MoqBasic.Test
{
    [TestClass]
    public class TransferTest
    {
        [TestMethod]
        public void TestTransfer()
        {
            var transfer = new Mock<ITransferProvider>();
            Account accountFrom = new Account() { ID = 1, Balance = 1000, Name = "AccountA" };
            Account accountTo = new Account() { ID = 2, Balance = 1000, Name = "AccountB" };

            TransferProcess tp = new TransferProcess(accountFrom, accountTo, transfer.Object);
            tp.Transfer(500);
            Assert.AreEqual(500, accountFrom.Balance);
            Assert.AreEqual(1500, accountTo.Balance);
        }
    }
}
