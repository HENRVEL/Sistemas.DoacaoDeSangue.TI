
namespace Sistemas.DoacaoDeSangue.DTO
{
    public class LaboratorioConveniado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CNPJ { get; set; }
        public string Responsavel { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int? IdSistemaSUS { get; set; }
        public bool LaboratorioAtivo { get; set; }
    }
}