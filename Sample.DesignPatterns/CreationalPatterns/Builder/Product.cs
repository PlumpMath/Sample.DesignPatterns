namespace Sample.DesignPatterns.CreationalPatterns.Builder
{
    public class Product
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Title { get; private set; }
        public string Brand { get; private set; }
        public string Color { get; private set; }

        public Product ChangeId(int productId)
        {
            this.Id = productId;
            return this;
        }
        
        public Product ChangeCode(string code)
        {
            this.Code = code;
            return this;
        }
        
        public Product ChangeTitle(string title)
        {
            this.Title = title;
            return this;
        }
        
        public Product ChangeBrand(string brand)
        {
            this.Brand = brand;
            return this;
        }
        
        public Product ChangeColor(string color)
        {
            this.Color = color;
            return this;
        }

    }
}