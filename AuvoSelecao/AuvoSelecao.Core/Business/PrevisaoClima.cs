using AuvoSelecao.Core.Base;
using AuvoSelecao.Core.Interfaces;
using AuvoSelecao.Views.Business;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuvoSelecao.Core.Business
{
    [Table("PrevisaoClima")]
    public class PrevisaoClima : BaseEntity
    {
        [Column("CidadeId")]
        public int CidadeId { get; set; }
        
        public Cidade Cidade(IBaseRepository<Cidade> service)
        {
            return service.Find(CidadeId);
        }
        [Column("DataPrevisao")]
        public DateTime DataPrevisao { get; set; }
        [Column("Clima")]
        public string Clima { get; set; }
        [Column("TemperaturaMinima")]
        public decimal TemperaturaMinima { get; set; }
        [Column("TemperaturaMaxima")]
        public decimal TemperaturaMaxima { get; set; }
        public ViewPrevisaoClima GetViewList()
        {
            return new ViewPrevisaoClima()
            {
                Clima = Clima,
                DataPrevisao = DataPrevisao,
                TemperaturaMaxima = TemperaturaMaxima,
                TemperaturaMinima = TemperaturaMinima,
                //Cidade = new ViewCidade() { Nome = Cidade.Nome }
        };
    }
}
}

