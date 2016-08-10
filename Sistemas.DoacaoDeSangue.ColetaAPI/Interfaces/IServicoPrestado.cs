using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.ColetaAPI.Interfaces
{
    interface IServicoPrestado
    {
        string Add(List<ServicosPrestados> item);
    }
}
