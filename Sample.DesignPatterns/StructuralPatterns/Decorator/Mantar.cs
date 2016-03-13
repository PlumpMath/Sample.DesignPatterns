namespace Sample.DesignPatterns.StructuralPatterns.Decorator
{
    public class Mantar : IKumpir
    {
        readonly IKumpir _kumpir;

        public Mantar(IKumpir kumpir)
        {
            _kumpir = kumpir;
        }

        public string Description()
        {
            return "Mantarli " + _kumpir.Description();
        }

        public decimal Price()
        {
            return 2.00m + _kumpir.Price();
        }
    }
}