using System;
using NUnit.Framework;
using Shouldly;

namespace Sample.DesignPatterns.BehavioralPatterns.State
{
    [TestFixture]
    public class StateTest
    {
        [Test]
        public void state_test()
        {
            var account = new Account("Martin Fowler"); // default: SilverState and 0.0 Balance

            account.State.Title.ShouldBe("SilverState");

            account.WithDraw(10); // current balance is -10
            account.State.Title.ShouldBe("RedState");
            Console.WriteLine("State: {0, -11} | Balance: {1}", account.State.Title, account.Balance);

            account.Deposit(20); // current balance is 10
            account.State.Title.ShouldBe("SilverState");
            Console.WriteLine("State: {0, -11} | Balance: {1}", account.State.Title, account.Balance);

            account.Deposit(4000); // current balance is 4010
            account.State.Title.ShouldBe("GoldState");
            Console.WriteLine("State: {0, -11} | Balance: {1}", account.State.Title, account.Balance);

            account.WithDraw(4000); // current balance is 10
            account.State.Title.ShouldBe("SilverState");
            Console.WriteLine("State: {0, -11} | Balance: {1}", account.State.Title, account.Balance);

            account.WithDraw(50); // current balance is -40
            account.State.Title.ShouldBe("RedState");
            Console.WriteLine("State: {0, -11} | Balance: {1}", account.State.Title, account.Balance);
        }

    }
}