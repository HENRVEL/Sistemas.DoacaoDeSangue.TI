using Sistemas.DoacaoDeSangue.ColetaService.BusinessLogic;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.Log;
using System;
using System.Collections.Generic;


namespace Sistemas.DoacaoDeSangue.ColetaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ResultadoExameService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ResultadoExameService.svc or ResultadoExameService.svc.cs at the Solution Explorer and start debugging.
    public class ResultadoExameService : IResultadoExameService
    {
        public void CriarResultadoDeExames(List<ResultadoDeExames> contrato)
        {
            Logar logar = new Logar();
            ObjetoLog log = new ObjetoLog();

            try
            {
                BusinessLogicColeta businessLogic = new BusinessLogicColeta();
                businessLogic.CriarResultadoDeExames(contrato);

            }
            catch (Exception ex)
            {
                log.TipoLog = "ERRO";
                log.Mensagem = "(ResultadoExameService) -> " + ex.ToString();
                logar.CriaLog(log);

                throw ex;
            }
        }
    }
}
