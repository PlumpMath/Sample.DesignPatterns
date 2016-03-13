namespace Sample.DesignPatterns.BehavioralPatterns.State
{
    public class GoldState : AState
    {
        public GoldState(AState state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(decimal balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            Initialize();
        }

        private void Initialize()
        {
            Title = GetType().Name;
            Interest = new decimal(0.0);
            LowerLimit = new decimal(1000.0);
            UpperLimit = new decimal(100 * 100); // 10.000,00 // this case no needs it
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            StateCheck();
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            StateCheck();
        }

        public override void PayInterest()
        {
            Balance += Interest * Balance;
            StateCheck();
        }

        public override void StateCheck()
        {
            if (Balance < (decimal)0.0)
                Account.State = new RedState(this);
            else if (Balance < LowerLimit)
                Account.State = new SilverState(this);
        }
    }
}