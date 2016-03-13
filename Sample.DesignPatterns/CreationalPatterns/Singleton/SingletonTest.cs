using NUnit.Framework;
using Shouldly;

namespace Sample.DesignPatterns.CreationalPatterns.Singleton
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void singleton_test()
        {
            var singleton = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            
            singleton.ShouldBe(singleton2);
        }
    }
}