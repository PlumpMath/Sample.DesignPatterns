using System;
using System.Linq;
using System.Text;

namespace Sample.DesignPatterns.BehavioralPatterns.ServiceLocator
{
    public class ServiceB : IServiceB
    {
        public string GetServiceName()
        {
            return "ServiceB";
        }
    }
}
