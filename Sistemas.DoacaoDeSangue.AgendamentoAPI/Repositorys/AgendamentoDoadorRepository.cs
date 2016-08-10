using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;
using Sistemas.DoacaoDeSangue.AgendamentoAPI.Interfaces;
using System;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Repository
{
    public class AgendamentoDoadorRepository : IAgendamentoDoador
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Add(AgendamentoDoador item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Erro - Criar Agendamento Doador] - Objeto AgendamentoDoador está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.CriarAgendaDoador(item.IdLaboratorio,item.IdDoador,item.IdAgendaLaboratorio,false,null);

                    if (retornoEntity == 1)
                    {
                        retorno = "Agendamento realizado com sucesso";

                    }
                    else
                    {
                        retorno = "Erro ao realizar o cadastro o agendamento do doador!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro o agendamento do doador -> " + ex.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<AgendamentoDoador> GetAll(int id)
        {
            List<AgendamentoDoador> listaAgendamentoDoador = new List<AgendamentoDoador>();

            var resultado = entities.ObterAgendaDoador(id);

            foreach (var item in resultado)
            {
                AgendamentoDoador agendamentoDoador = new AgendamentoDoador();
                agendamentoDoador.Id = item.ID;
                agendamentoDoador.IdAgendaLaboratorio = item.ID_AGL;
                agendamentoDoador.NomeLaboratorio = item.NOME;
                agendamentoDoador.IdDoador = item.ID_DOA;
                agendamentoDoador.IdLaboratorio = item.ID_LAB;
                agendamentoDoador.Data = item.DATA;
                agendamentoDoador.Hora = item.HORA;
                agendamentoDoador.Cancelado = item.CANCELADO;
                agendamentoDoador.MotivoCancelamento = item.MOTIVO_CANCELAMENTO;

                listaAgendamentoDoador.Add(agendamentoDoador);
            }

            return listaAgendamentoDoador;
        }


    }
}