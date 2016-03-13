namespace Sample.DesignPatterns.BehavioralPatterns.State
{
    public class SilverState : AState
    {
        public SilverState(AState state)
            : this(state.Balance, state.Account)
        {
        }

        public SilverState(decimal balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            Initialize();
        }

        private void Initialize()
        {
            Title = GetType().Name;
            Interest = new decimal(0.0);
            LowerLimit = new decimal(0.0);
            UpperLimit = new decimal(1000.0);
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
            if (Balance < LowerLimit)
                Account.State = new RedState(this);
            else if (Balance > UpperLimit)
                Account.State = new GoldState(this);
        }
    }
}