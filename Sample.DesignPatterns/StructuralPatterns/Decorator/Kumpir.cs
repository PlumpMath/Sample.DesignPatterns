namespace Sample.DesignPatterns.StructuralPatterns.Decorator
{
    public class Kumpir : IKumpir
    {
        public string Description()
        {
            return "Kumpir";
        }

        public decimal Price()
        {
            return 6.00m;
        }
    }
}