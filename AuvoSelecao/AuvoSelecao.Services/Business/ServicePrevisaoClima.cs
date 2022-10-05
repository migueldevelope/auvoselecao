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
    public class ServicePrevisaoClima : IServicePrevisaoClima
    {
        private IBaseRepository<PrevisaoClima> _service;
        private IBaseRepository<Cidade> _serviceCidade;
        private IBaseRepository<Estado> _serviceEstado;
        public ServicePrevisaoClima(IBaseRepository<PrevisaoClima> service, IBaseRepository<Cidade> serviceCidade, IBaseRepository<Estado> serviceEstado)
        {
            _service = service;
            _serviceCidade = serviceCidade;
            _serviceEstado = serviceEstado;

        }

        public List<ViewListCidades> ListCidadesFrias()
        {
            try
            {
                return _service.List().OrderBy(p => p.TemperaturaMinima).Take(3).ToList().Select(p => new
                ViewListCidades()
                {
                    Nome = p.Cidade(_serviceCidade)?.Nome + "/" + p.Cidade(_serviceCidade)?.Estado?.UF,
                    Minima = "Min " + p.TemperaturaMinima + "°C",
                    Maxima = "Máx " + p.TemperaturaMaxima + "°C",
                }).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("PREVISAO_CLIMA_ERRO01");
            }
        }

        public List<ViewListCidades> ListCidadesQuentes()
        {
            try
            {
                return _service.List().OrderByDescending(p => p.TemperaturaMaxima).Take(3).ToList().Select(p => new
                ViewListCidades()
                {
                    Nome = p.Cidade(_serviceCidade)?.Nome + "/" + p.Cidade(_serviceCidade)?.Estado?.UF,
                    Minima = "Min " + p.TemperaturaMinima + "°C",
                    Maxima = "Máx " + p.TemperaturaMaxima + "°C",
                }).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("PREVISAO_CLIMA_ERRO02");
            }
        }

        public List<ViewListPrevisaoClima> ListPrevisaoClima(int cidade)
        {
            try
            {
                DateTime dateNow = DateTime.Now.AddDays(-10);
                DateTime datePre = DateTime.Now.AddDays(7);
                return _service.List().Where(p => p.CidadeId == cidade && p.DataPrevisao >= dateNow
                && p.DataPrevisao <= datePre).OrderBy(p => p.TemperaturaMinima).Take(7).ToList().Select(p => new
                ViewListPrevisaoClima()
                {
                    DiaSemana = p.DataPrevisao.ToString("dddd", new CultureInfo("pt-BR")),
                    Clima = p.Clima,
                    Minima = "Minima " + p.TemperaturaMinima + "°C",
                    Maxima = "Máxima " + p.TemperaturaMaxima + "°C",
                }).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("PREVISAO_CLIMA_ERRO03");
            }
        }

    }
}
