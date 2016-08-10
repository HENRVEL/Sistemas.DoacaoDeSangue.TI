using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas.DoacaoDeSangue.DTO
{
    [DataContract]
     public class Exame
    {

        public int Id { get; set; }
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
