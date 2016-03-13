namespace Sample.DesignPatterns.BehavioralPatterns.State
{
    public abstract class AState
    {
        protected decimal Interest;
        protected decimal LowerLimit;
        protected decimal UpperLimit;

        public Account Account { get; protected set; }
        public decimal Balance { get; protected set; }
        public string Title { get; protected set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void PayInterest();

        public abstract void StateCheck();
    }
}