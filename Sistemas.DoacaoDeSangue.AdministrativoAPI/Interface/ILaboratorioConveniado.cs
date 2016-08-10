using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AdministrativoAPI.Interface
{
    interface ILaboratorioConveniado
    {
        IEnumerable<LaboratorioConveniado> GetAll();
        LaboratorioConveniado Get(int id);
        string Add(LaboratorioConveniado item);
        string Remove(int id);
        string Update(LaboratorioConveniado item);
    }
}
