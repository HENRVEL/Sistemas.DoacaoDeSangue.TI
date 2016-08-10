using Sistemas.DoacaoDeSangue.AdministrativoAPI.Repository;
using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.AdministrativoAPI.Controllers
{
    public class UnidadesHospitalaresController : ApiController
    {
        UnidadeHospitalarRepository repository = new UnidadeHospitalarRepository();

        [HttpGet]
        public IEnumerable<UnidadeHospitalar> obterUnidadesHospitalares()
        {
            IEnumerable<UnidadeHospitalar> listaUnidadesHospitalares;

            listaUnidadesHospitalares = repository.GetAll();

            if (listaUnidadesHospitalares == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return listaUnidadesHospitalares;
        }

        [HttpGet]
        public UnidadeHospitalar obterUnidadeHospitalar(int id)
        {
            UnidadeHospitalar unidadeHospitalar = new UnidadeHospitalar();

            unidadeHospitalar = repository.Get(id);

            if (unidadeHospitalar == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return unidadeHospitalar;
        }

        [HttpPost]
        public HttpResponseMessage CriarUnidadeHospitalar(UnidadeHospitalar unidadeHospitalar)
        {
            string retorno = repository.Add(unidadeHospitalar);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage ExcluirUnidadeHospitalar(int id)
        {
            UnidadeHospitalar item = repository.Get(id);

            if (item.Id == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                string retorno = repository.Remove(item.Id);
                var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
                return response;
            }
        }

        [HttpPut]
        public HttpResponseMessage AlterarUnidadeHospitalar(UnidadeHospitalar unidadeHospitalar)
        {
            string retorno = repository.Update(unidadeHospitalar);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;

        }

    }
}
