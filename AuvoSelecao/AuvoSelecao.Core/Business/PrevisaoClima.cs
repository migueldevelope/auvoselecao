using AuvoSelecao.Core.Base;
using AuvoSelecao.Views.Business;
using System;

namespace AuvoSelecao.Core.Business
{
    public class PrevisaoClima : BaseEntity
    {
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
        public ViewPrevisaoClima GetViewList()
        {
            return new ViewPrevisaoClima()
            {
                Clima = Clima,
                DataPrevisao = DataPrevisao,
                TemperaturaMaxima = TemperaturaMaxima,
                TemperaturaMinima = TemperaturaMinima,
                Cidade = new ViewCidade() { Nome = Cidade.Nome }
        };
    }
}
}

