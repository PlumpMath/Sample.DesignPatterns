using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace Sample.DesignPatterns.BehavioralPatterns.ServiceLocator
{
    [TestFixture]
    public class ServiceLocatorTest
    {
        [Test]
        public void service_locator_test()
        {
            var serviceLocator = new ServiceLocator();

            var serviceA = serviceLocator.GetService<IServiceA>();
            serviceA.GetServiceName().ShouldBe("ServiceA");
            
            var serviceB = serviceLocator.GetService<IServiceB>();
            serviceB.GetServiceName().ShouldBe("ServiceB");
        }

    }
}
