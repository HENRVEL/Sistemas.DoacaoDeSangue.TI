using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;
using System.ServiceModel;


namespace Sistemas.DoacaoDeSangue.ColetaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IResultadoExameService" in both code and config file together.
    [ServiceContract]
    public interface IResultadoExameService
    {
        [OperationContract]
        void CriarResultadoDeExames(List<ResultadoDeExames> contrato);
    }
}
