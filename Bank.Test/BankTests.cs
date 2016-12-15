using System;
using Bank.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Test
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void 출금_딱_맞을때()
        {
            // arrange
            int amount = 100;
            int payment = 100;
            int expected = 0;
            var bankAccount = new BankAccount(amount);

            // act
            bankAccount.Withdraw(payment);

            // assert
            Assert.AreEqual(expected, bankAccount.Balance, "잔액과 출금액이 같을 때의 처리가 필요합니다.");
        }
    }
}
