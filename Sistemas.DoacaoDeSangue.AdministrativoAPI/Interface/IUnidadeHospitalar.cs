using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AdministrativoAPI.Interface
{
    interface IUnidadeHospitalar
    {
        IEnumerable<UnidadeHospitalar> GetAll();
        UnidadeHospitalar Get(int id);
        string Add(UnidadeHospitalar item);
        string Remove(int id);
        string Update(UnidadeHospitalar item);
    }
}
