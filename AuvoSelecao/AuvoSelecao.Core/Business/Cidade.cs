using AuvoSelecao.Core.Base;
using AuvoSelecao.Core.Interfaces;
using AuvoSelecao.Views.Business;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuvoSelecao.Core.Business
{
    [Table("Cidade")]
    public class Cidade : BaseEntity
    {
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("EstadoId")]
        public int EstadoId { get; set; }

        public Estado Estado { get; set; }
        /*public Estado Estado(IBaseRepository<Estado> service)
        {
            return service.Find(EstadoId);
        }*/
        public ViewCidade GetViewList()
        {
            return new ViewCidade()
            {
                Nome = Nome
            };
        }
    }

}
