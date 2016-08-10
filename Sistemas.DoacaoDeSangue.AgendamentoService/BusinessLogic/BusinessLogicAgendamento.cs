using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;
using System;
using System.Collections.Generic;
using Sistemas.DoacaoDeSangue.Log;

namespace Sistemas.DoacaoDeSangue.AgendamentoService.BusinessLogic
{
    public class BusinessLogicAgendamento
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();
        Logar logar = new Logar();
        ObjetoLog log = new ObjetoLog();

        public void CriarAgendaLaboratorio(List<AgendaLaboratorio> lista)
        {
          
            try
            {
                foreach (var item in lista)
                {
                    bool data;
                    bool hora;

                    data = ValidarData(item.Data);
                    hora = ValidarHora(item.Hora);

                    if ((data) && (hora))
                    {
                        if (item.IdLaboratorio > 0)
                        {
                            entities.CriarAgendaLaboratorio(item.IdLaboratorio, item.Data, item.Hora);
                        }
                        else
                        {
                            log.TipoLog = "ERRO";
                            log.Mensagem = "(AgendamentoService / CriarAgendaLaboratorio)";
                            logar.CriaLog(log);
                        }

                    }
                    else
                    {
                        log.TipoLog = "ERRO";
                        log.Mensagem = "(AgendamentoService / CriarAgendaLaboratorio)";
                        logar.CriaLog(log);
                    }
                }

            }
            catch (Exception ex)
            {
                log.TipoLog = "ERRO";
                log.Mensagem = "(AgendamentoService / CriarAgendaLaboratorio) -> " + ex.ToString();
                logar.CriaLog(log);

                throw ex;
            }
        }

        private bool ValidarData(string strData)
        {
            try
            {
                Convert.ToDateTime(strData);

                if (Convert.ToDateTime(strData) <= DateTime.Now)
                {
                    throw new Exception();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidarHora(string strHora)
        {
            try
            {
                Convert.ToDateTime(strHora);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}