using System.Runtime.Serialization;

namespace Sistemas.DoacaoDeSangue.DTO
{
    [DataContract]
    public class ResultadoDeExames
    {
        public int id { get; set; }
        [DataMember]
        public LaboratorioConveniado laboratorioConveniado { get; set; }
        [DataMember]
        public Exame exame { get; set; }
        [DataMember]
        public Paciente Paciente { get; set; }
        [DataMember]
        public string resultado { get; set; }
    }
}
