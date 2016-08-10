using System.Runtime.Serialization;

namespace Sistemas.DoacaoDeSangue.DTO
{
    [DataContract]
    public class Paciente
    {
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string SobreNome { get; set; }
        [DataMember]
        public string DataNascimento { get; set; }
        [DataMember]
        public char Sexo { get; set; }
        [DataMember]
        public long CPF { get; set; }
        [DataMember]
        public string TipoSanguineo { get; set; }
        [DataMember]
        public string FatorRH { get; set; }
    }
}
