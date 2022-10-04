using System;

namespace AuvoSelecao.Views.Business
{
    public class ViewPrevisaoClima
    {
        public ViewCidade Cidade { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
    }
}
