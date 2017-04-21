using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVendaJP.Domain.Interfaces.Repositories
{
    public interface IDataContext
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void Finally();
    }
}
