namespace Sample.DesignPatterns.StructuralPatterns.Decorator
{
    public class Zeytin : IKumpir
    {
        readonly IKumpir _kumpir;
        
        public Zeytin(IKumpir kumpir)
        {
            _kumpir = kumpir;
        }

        public string Description()
        {
            return "Zeytinli " + _kumpir.Description();
        }

        public decimal Price()
        {
            return 3m + _kumpir.Price();
        }
    }
}