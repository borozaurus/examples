using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestMe.Logic;
using TestMe.Model;
using TestMe.Service;

namespace TestMe.Tests
{
    [TestClass]
    public class BankLogicTests
    {
        [TestInitialize]
        public void Setup()
        {
            
        }

        [TestMethod]
        public void WithrowAmountWhenAmountEqalsToBalansShouldWithrow()
        {
            //Given (arrange)
            var dataAccessMock = new Mock<IDataAccess>();
            dataAccessMock.Setup(p => p.LoadBankAccount(It.IsAny<int>())).Returns<int>(p => new BankAccount()
            {
                Number = p,
                Value = 10
            });
            var sut = new BankLogic(dataAccessMock.Object);

            //When (act)
            var result = sut.WithrowAmount(10);

            //Then (assert)
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAmountException))]
        public void DepositAmountAmountShouldBeGreaterThan0()
        {
            //Given (arrange)
            var dataAccessMock = new Mock<IDataAccess>();
            dataAccessMock.Setup(p => p.LoadBankAccount(It.IsAny<int>())).Returns<int>(p => new BankAccount());
            var sut = new BankLogic(dataAccessMock.Object);

            //When (act)
            sut.DepositAmount(0);

            //Then (assert)
        }

        [TestMethod]
        public void ShowAccountDataShoulReturnEmptyStringWhenAccountDNE()
        {
            //Given (arrange)
            var dataAccessMock = new Mock<IDataAccess>();
            dataAccessMock.Setup(p => p.LoadBankAccount(It.IsAny<int>())).Throws(new FileNotFoundException());
            var sut = new BankLogic(dataAccessMock.Object);

            //When (act)
            var result = sut.GetAccountData();

            //Then (assert)
            Assert.AreEqual(string.Empty, result);
        }

    }
}
