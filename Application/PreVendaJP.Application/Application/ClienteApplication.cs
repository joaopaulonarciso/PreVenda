using PreVenda.Domain.Services;
using PreVendaJP.Application.DependencyInjection.Services;
using PreVendaJP.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVendaJP.Application.Application
{
    public static class ClienteApplication
    {
        private static readonly ClienteService _clienteService = new ClienteService(
            DependencyInjectionService.Resolve<IDataContext>(),
            DependencyInjectionService.Resolve<IClienteRepository>()
            );

        public static string ResponseMessage
        {
            get
            {
                return _clienteService.ResponseService.Message;
            }
        }

        public static string ResponseType
        {
            get
            {
                return _clienteService.ResponseService.Type.ToString();
            }
        }
    }
^}