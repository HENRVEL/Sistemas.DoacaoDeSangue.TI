

namespace Sistemas.DoacaoDeSangue.DTO
{
    public class ServicosPrestados
    {
        public int Id { get; set; }
        public LaboratorioConveniado Laboratorio{ get; set; }
        public string TipoServico { get; set; }
        public decimal Valor { get; set; }
    }
}
