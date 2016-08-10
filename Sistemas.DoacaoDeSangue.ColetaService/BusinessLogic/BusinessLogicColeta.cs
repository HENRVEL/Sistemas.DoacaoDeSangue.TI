using Sistemas.DoacaoDeSangue.DAO;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.Log;
using System;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.ColetaService.BusinessLogic
{
    public class BusinessLogicColeta
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();
        Logar logar = new Logar();
        ObjetoLog log = new ObjetoLog();


        public void CriarResultadoDeExames(List<ResultadoDeExames> resultadosDeExames)
        {
            
            try
            {

                foreach (var item in resultadosDeExames)
                {
                    int retornoResultadoDeExames = -1;

                    CriarPacienteLaboratorio(item.Paciente);


                    retornoResultadoDeExames = entities.CriarResultadoDeExames(item.laboratorioConveniado.Id, item.Paciente.CPF, item.exame.codigo, item.resultado);

                    if (retornoResultadoDeExames != 1)
                    {
                        log.TipoLog = "ERRO";
                        log.Mensagem = "(ResultadoExameService / CriarResultadoDeExames)";
                        logar.CriaLog(log);
                    }

                }

            }
            catch (Exception ex)
            {
                log.TipoLog = "ERRO";
                log.Mensagem = "(ResultadoExameService / CriarResultadoDeExames) -> " + ex.ToString();
                logar.CriaLog(log);

                throw ex;
            }
        }


        public void CriarPacienteLaboratorio(Paciente paciente)
        {
            try
            {

                entities.CriarPacienteLaboratorio(paciente.Nome, paciente.SobreNome, paciente.Sexo.ToString(), paciente.DataNascimento, paciente.CPF, paciente.TipoSanguineo, paciente.FatorRH);

            }
            catch (Exception ex)
            {
                log.TipoLog = "ERRO";
                log.Mensagem = "(ResultadoExameService / CriarPacienteLaboratorio) -> " + ex.ToString();
                logar.CriaLog(log);

                throw ex;
            }

        }

    }
}