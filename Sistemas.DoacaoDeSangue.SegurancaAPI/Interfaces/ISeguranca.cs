using Sistemas.DoacaoDeSangue.DTO;

namespace Sistemas.DoacaoDeSangue.SegurancaAPI.Interfaces
{
    interface ISeguranca
    {
        string Get(string usuario, string tipoUsuario, string senha);
        string Add(Seguranca item);
    }
}
