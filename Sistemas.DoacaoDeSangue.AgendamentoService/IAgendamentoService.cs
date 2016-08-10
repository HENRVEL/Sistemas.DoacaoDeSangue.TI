using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;
using System.ServiceModel;


namespace Sistemas.DoacaoDeSangue.AgendamentoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAgendamentoService" in both code and config file together.
    [ServiceContract]
    public interface IAgendamentoService
    {
        [OperationContract]
        void CriarAgendaLaboratorio(List<AgendaLaboratorio> contrato);
    }
}
