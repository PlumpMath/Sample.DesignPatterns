using NUnit.Framework;
using Shouldly;

namespace Sample.DesignPatterns.CreationalPatterns.Builder
{
    [TestFixture]
    public class ProductBuilderTest
    {
        [Test]
        public void product_builder_test()
        {
            var product = new ProductBuilder()
                .SetId(1)
                .SetCode("0042")
                .SetTitle("Klavye")
                .SetBrand("Microsoft")
                .SetColor("Siyah")
                .Build();

            product.Id.ShouldBe(1);
            product.Code.ShouldBe("0042");
            product.Title.ShouldBe("Klavye");
            product.Brand.ShouldBe("Microsoft");
            product.Color.ShouldBe("Siyah");
        }

    }
}