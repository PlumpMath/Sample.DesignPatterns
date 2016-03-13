using System;
using System.Linq;
using System.Text;

namespace Sample.DesignPatterns.BehavioralPatterns.ServiceLocator
{
    public class ServiceA : IServiceA
    {
        public string GetServiceName()
        {
            return "ServiceA";
        }
    }
}
