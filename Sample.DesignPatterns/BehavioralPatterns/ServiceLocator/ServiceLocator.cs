using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.DesignPatterns.BehavioralPatterns.ServiceLocator
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly IDictionary<object, object> _services;

        internal ServiceLocator()
        {
            _services = new Dictionary<object, object>();

            this._services.Add(typeof(IServiceA), new ServiceA());
            this._services.Add(typeof(IServiceB), new ServiceB());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }

    }
}
