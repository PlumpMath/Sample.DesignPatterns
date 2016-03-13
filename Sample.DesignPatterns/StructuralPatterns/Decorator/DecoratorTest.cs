using System;
using NUnit.Framework;
using Shouldly;

namespace Sample.DesignPatterns.StructuralPatterns.Decorator
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void kumpir_decorator_pattern_test()
        {
            var kumpir = new Kumpir();
            var mantar = new Mantar(kumpir);
            var zeytin = new Zeytin(mantar);

            kumpir.Price().ShouldBe(6);
            mantar.Price().ShouldBe(8);
            zeytin.Price().ShouldBe(11);

            Console.WriteLine("Description : {0} | Price: {1}", kumpir.Description(), kumpir.Price());
            Console.WriteLine("Description : {0} | Price: {1}", mantar.Description(), mantar.Price());
            Console.WriteLine("Description : {0} | Price: {1}", zeytin.Description(), zeytin.Price());

            var kumpir2 = new Zeytin(new Mantar(new Kumpir()));
            Console.WriteLine("Description : {0} | Price: {1}", kumpir2.Description(), kumpir2.Price());
            kumpir2.Price().ShouldBe(11);
        }
    }
}