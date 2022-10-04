using AuvoSelecao.Core.Base;
using AuvoSelecao.Views.Business;

namespace AuvoSelecao.Core.Business
{
    public class Estado : BaseEntity
    {
        public string Nome { get; set; }
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
