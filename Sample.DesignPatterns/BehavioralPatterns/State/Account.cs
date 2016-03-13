namespace Sample.DesignPatterns.BehavioralPatterns.State
{
    public class Account
    {
        private string _owner;

        public Account(string owner)
        {
            _owner = owner;
            State = new SilverState(new decimal(0.0), this);
        }

        public decimal Balance { get { return State.Balance; } }
        public AState State { get; set; }

        public void Deposit(decimal amount)
        {
            State.Deposit(amount);
        }

        public void WithDraw(decimal amount)
        {
            State.Withdraw(amount);
        }

        public void PayInterest()
        {
            State.PayInterest();
        }

    }
}