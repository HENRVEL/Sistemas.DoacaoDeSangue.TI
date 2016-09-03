
namespace Sistemas.DoacaoDeSangue.DTO
{
    public class Seguranca
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
        public int? IdDoador { get; set; }
        public int? IdUnidadeHospitalar { get; set; }
        public int? IdLaboratorio { get; set; }
    }
}
