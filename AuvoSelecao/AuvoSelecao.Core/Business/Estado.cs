using AuvoSelecao.Core.Base;
using AuvoSelecao.Views.Business;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuvoSelecao.Core.Business
{
    [Table("Estado")]
    public class Estado : BaseEntity
    {
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("UF")]
        public string UF { get; set; }

        public ViewEstado GetViewList()
        {
            return new ViewEstado()
            {
                Nome = Nome,
                UF = UF
            };
        }
    }
}
