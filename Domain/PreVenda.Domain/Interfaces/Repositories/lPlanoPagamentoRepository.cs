using PreVendaJP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVendaJP.Domain.Interfaces.Repositories
{
    public interface lPlanoPagamentoRepository
    {
        PlanoPagamento Get(int planoPagamento);
        List<PlanoPagamento> Get();
    }
}
