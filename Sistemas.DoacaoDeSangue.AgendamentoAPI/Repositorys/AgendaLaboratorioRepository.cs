using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;
using Sistemas.DoacaoDeSangue.AgendamentoAPI.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Repositorys
{
    public class AgendaLaboratorioRepository : IAgendaLaboratorio
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        public IEnumerable<AgendaLaboratorio> Get(int id)
        {
            List<AgendaLaboratorio> listaAgendaLaboratorio = new List<AgendaLaboratorio>();

            var resultado = entities.ObterAgendaLaboratorio(id);

            foreach (var item in resultado)
            {
                AgendaLaboratorio agendaLaboratorio = new AgendaLaboratorio();
                agendaLaboratorio.Id = item.ID;
                agendaLaboratorio.IdLaboratorio = item.ID_LAB;
                agendaLaboratorio.Data = item.DATA;
                agendaLaboratorio.Hora = item.HORA;

                listaAgendaLaboratorio.Add(agendaLaboratorio);
            }

            return listaAgendaLaboratorio;
        }
    }
}