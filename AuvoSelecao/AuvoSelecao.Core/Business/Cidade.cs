using AuvoSelecao.Core.Base;
using AuvoSelecao.Views.Business;

namespace AuvoSelecao.Core.Business
{
    public class Cidade : BaseEntity
    {
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public ViewCidade GetViewList()
        {
            return new ViewCidade()
            {
                Nome = Nome
            };
        }
    }

}
