using System;

namespace Sistemas.DoacaoDeSangue.DTO
{
    public class Doador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public char Sexo { get; set; }
        public long CPF { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string TipoSanguineo { get; set; }
        public string FatorRH { get; set; }
        public Boolean DoadorDeSangue { get; set; }
        public DateTime? DataUltimaDoacao { get; set; }

    }
}