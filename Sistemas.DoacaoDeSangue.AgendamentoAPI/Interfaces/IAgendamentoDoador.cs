using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Interfaces
{
    interface IAgendamentoDoador
    {
        IEnumerable<AgendamentoDoador> GetAll(int id);
        string Add(AgendamentoDoador item);
    }
}
