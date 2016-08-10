using System.Runtime.Serialization;

namespace Sistemas.DoacaoDeSangue.DTO
{
    [DataContract]
    public class AgendaLaboratorio
    {
        public int Id { get; set; }
        [DataMember]
        public int IdLaboratorio { get; set; }
        [DataMember]
        public string Data { get; set; }
        [DataMember]
        public string Hora { get; set; }
    }
}
