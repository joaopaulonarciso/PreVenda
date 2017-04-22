using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVendaJP.Application.DependencyInjection.Interfaces
{
    public interface IDependencyInjection
    {
        T Resolve<T>();
        T Resolve<T>(Type type);
    }
}
