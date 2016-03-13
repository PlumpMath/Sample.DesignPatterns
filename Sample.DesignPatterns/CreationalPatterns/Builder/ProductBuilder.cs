namespace Sample.DesignPatterns.CreationalPatterns.Builder
{
    public class ProductBuilder : IBuilder<Product>
    {
        readonly Product _product = new Product();

        public ProductBuilder SetId(int productId)
        {
            _product.ChangeId(productId);
            return this;
        }
        
        public ProductBuilder SetCode(string code)
        {
            _product.ChangeCode(code);
            return this;
        }
        
        public ProductBuilder SetTitle(string title)
        {
            _product.ChangeTitle(title);
            return this;
        }
        
        public ProductBuilder SetBrand(string brand)
        {
            _product.ChangeBrand(brand);
            return this;
        }
        
        public ProductBuilder SetColor(string color)
        {
            _product.ChangeColor(color);
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}