using Sistemas.DoacaoDeSangue.AdministrativoAPI.Repository;
using Sistemas.DoacaoDeSangue.DTO;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.AdministrativoAPI.Controllers
{
    public class LaboratoriosConveniadoController : ApiController
    {
        LaboratorioConveniadoRepository repository = new LaboratorioConveniadoRepository();


        [HttpGet]
        public IEnumerable<LaboratorioConveniado> obterLaboratoriosConveniado()
        {
            IEnumerable<LaboratorioConveniado> listaLaboratorioConveniado;

            listaLaboratorioConveniado = repository.GetAll();

            if (listaLaboratorioConveniado == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return listaLaboratorioConveniado;
        }

        [HttpGet]
        public LaboratorioConveniado obterLaboratorioConveniado(int id)
        {
            LaboratorioConveniado laboratorioConveniado = new LaboratorioConveniado();

            laboratorioConveniado = repository.Get(id);

            if(laboratorioConveniado == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return laboratorioConveniado;
        }

        [HttpPost]
        public HttpResponseMessage CriarLaboratorioConveniado(LaboratorioConveniado laboratorio)
        {
            string retorno = repository.Add(laboratorio);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage ExcluirLaboratorioConveniado(int id)
        {
            LaboratorioConveniado item = repository.Get(id);

            if (item.Id == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                string retorno = repository.Remove(id);
                var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
                return response;
            }
        }

        [HttpPut]
        public HttpResponseMessage AlterarDoador(LaboratorioConveniado laboratorio)
        {
            string retorno = repository.Update(laboratorio);
            var response = Request.CreateResponse<string>(HttpStatusCode.Created, retorno);
            return response;

        }

    }
}
