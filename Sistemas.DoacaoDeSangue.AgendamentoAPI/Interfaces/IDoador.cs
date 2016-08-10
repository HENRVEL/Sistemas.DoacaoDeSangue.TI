using Sistemas.DoacaoDeSangue.DTO;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Interfaces
{
    interface IDoador
    {
        Doador GetID(int id);
        Doador GetCPF(long id);
        string Add(Doador item);
        string Remove(int id);
        string Update(Doador item);
    }
}
