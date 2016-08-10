using Sistemas.DoacaoDeSangue.BolsaDeSangueAPI.Repositorys;
using Sistemas.DoacaoDeSangue.DTO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.BolsaDeSangueAPI.Controllers
{
    public class BolsasDeSangueController : ApiController
    {
        BolsaDeSangueRepository repository = new BolsaDeSangueRepository();

        [HttpPost]
        public HttpResponseMessage CriarSolicitacaoBolsaDeSangue(BolsaDeSangue bolsaDeSangue)
        {
            string retorno = repository.Add(bolsaDeSangue);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }

        //[HttpGet]
        //public BolsaDeSangue obterSolicitacaoBolsaDeSangue()
        //{
        //    BolsaDeSangue bolsaDeSangue = new BolsaDeSangue();
            
        //    return bolsaDeSangue;
        //}
    }
}
