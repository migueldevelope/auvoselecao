using AuvoSelecao.Core.Business;
using AuvoSelecao.Core.Interfaces;
using AuvoSelecao.Data;
using AuvoSelecao.Views.Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AuvoSelecao.Services.Business
{
    public class ServiceCidade : IServiceCidade
    {
        private IBaseRepository<Cidade> _service;
        public ServiceCidade(IBaseRepository<Cidade> service)
        {
            _service = service;

        }

        public List<ViewCidade> List()
        {
            try
            {
                return _service.List().ToList().Select(p => p.GetViewList()).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("CIDADE_ERRO01");
            }
        }

    }
}
