using System;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.Log;
using Sistemas.DoacaoDeSangue.AgendamentoService.BusinessLogic;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AgendamentoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AgendamentoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AgendamentoService.svc or AgendamentoService.svc.cs at the Solution Explorer and start debugging.
    public class AgendamentoService : IAgendamentoService
    {
        public void CriarAgendaLaboratorio(List<AgendaLaboratorio> contrato)
        {
            Logar logar = new Logar();
            ObjetoLog log = new ObjetoLog();
            
            try
            {
                BusinessLogicAgendamento businessLogic = new BusinessLogicAgendamento();
                businessLogic.CriarAgendaLaboratorio(contrato);
       
            }
            catch (Exception ex)
            {
                log.TipoLog = "ERRO";
                log.Mensagem = "(AgendamentoService) -> " + ex.ToString();
                logar.CriaLog(log);

                throw ex;
            }
        }
    }
}
