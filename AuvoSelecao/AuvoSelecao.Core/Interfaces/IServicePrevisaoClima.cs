using AuvoSelecao.Core.Business;
using AuvoSelecao.Views.Business;
using System.Collections.Generic;

namespace AuvoSelecao.Core.Interfaces
{
    public interface IServicePrevisaoClima
    {
        List<ViewListCidades> ListCidadesQuentes();
        List<ViewListCidades> ListCidadesFrias();
        List<ViewListPrevisaoClima> ListPrevisaoClima(int cidade);
    }
}
