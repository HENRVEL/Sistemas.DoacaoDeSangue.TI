using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas.DoacaoDeSangue.DTO
{
    public class AgendamentoDoador
    {
        public int Id { get; set; }
        public int IdLaboratorio { get; set; }
        public string NomeLaboratorio { get; set;}
        public int IdDoador { get; set; }
        public int IdAgendaLaboratorio { get; set; }
        public string Data{ get; set; }
        public string Hora { get; set; }
        public bool Cancelado { get; set; }
        public string MotivoCancelamento { get; set; }
    }
}
