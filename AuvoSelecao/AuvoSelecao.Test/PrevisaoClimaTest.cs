using AuvoSelecao.Core.Business;
using AuvoSelecao.Core.Interfaces;
using AuvoSelecao.Data;
using AuvoSelecao.Services.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static AuvoSelecao.Data.Repository;

namespace AuvoSelecao.Test
{
    [TestClass]
    public class PrevisaoClimaTest
    {
        string connString = "Server=45.231.132.153;Database=ClimaTempoSimples;User Id=sa;Password=Bti9010.";
        [TestMethod]
        public void TestMethod1()
        {
            IUnitOfWork unitOfWork = new DataContext(connString);
            IBaseRepository<PrevisaoClima> repository = new BaseRepository<PrevisaoClima>(unitOfWork);
            IBaseRepository<Cidade> repositoryCidade = new BaseRepository<Cidade>(unitOfWork);
            IBaseRepository<Estado> repositoryEstado = new BaseRepository<Estado>(unitOfWork);

            IServicePrevisaoClima service = new ServicePrevisaoClima(repository, repositoryCidade, repositoryEstado);
            IServiceCidade serviceCidade = new ServiceCidade(repositoryCidade);

            //verifica cidades
            var listCD = serviceCidade.List();

            //verifica cidades frias
            var listCF = service.ListCidadesFrias();

            //verifica cidades quentes
            var listCQ = service.ListCidadesQuentes();

            //previsao
            var listPC = service.ListPrevisaoClima(1);

        }
    }
}
