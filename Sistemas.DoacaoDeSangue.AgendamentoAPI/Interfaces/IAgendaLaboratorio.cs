using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Interfaces
{
    interface IAgendaLaboratorio
    {
        IEnumerable<AgendaLaboratorio> Get(int id);
    }
}
