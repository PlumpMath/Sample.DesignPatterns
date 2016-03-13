namespace Sample.DesignPatterns.BehavioralPatterns.State
{
    public class RedState : AState
    {
        public RedState(AState state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            Title = GetType().Name;
            Interest = new decimal(0.0);
            LowerLimit = new decimal(-100.0); // this case no needs it
            UpperLimit = (decimal)0.0;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            StateCheck();
        }

        public override void Withdraw(decimal amount)
        {
            // no money
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        public override void StateCheck()
        {
            if (Balance > UpperLimit)
                Account.State = new SilverState(this);
        }

    }
}