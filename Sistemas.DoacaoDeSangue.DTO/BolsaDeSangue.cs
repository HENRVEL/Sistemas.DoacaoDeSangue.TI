
namespace Sistemas.DoacaoDeSangue.DTO
{
    public class BolsaDeSangue
    {
        public int Id { get; set; }
        public UnidadeHospitalar UnidadeHospitalar { get; set; }
        public LaboratorioConveniado LaboratorioConveniado { get; set; }
        public Paciente Paciente { get; set; }
        public string MotivoDoacao { get; set; }
        public string Diagnostico { get; set; }
    }
}
