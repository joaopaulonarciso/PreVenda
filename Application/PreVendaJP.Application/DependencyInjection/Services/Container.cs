using Microsoft.Practices.Unity;
using PreVendaJP.Application.DependencyInjection.Interfaces;
using PreVendaJP.Data.Repositories;
using PreVendaJP.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVendaJP.Application.DependencyInjection.Services
{

    public class Container : IDependencyInjection
    {
        private static Container _container;
        private readonly IUnityContainer _unityContainer;

        private Container()
        {
            _unityContainer = new UnityContainer();
            RegisterTypes();
        }

        public static Container GetContainer()
        {
            return _container ?? (_container ?? new Container());
        }

        public T Resolve<T>()
        {
            return _unityContainer.Resolve<T>();
        }

        public T Resolve<T>(Type type)
        {
            return (T)_unityContainer.Resolve(type);
        }

        private void RegisterTypes()
        {
            _unityContainer
            .RegisterType<IDataContext, DataContext>(new InjectionConstructor())
            .RegisterType<IClienteRepository, ClienteRepository>(new InjectionConstructor());
        }
    }
}
