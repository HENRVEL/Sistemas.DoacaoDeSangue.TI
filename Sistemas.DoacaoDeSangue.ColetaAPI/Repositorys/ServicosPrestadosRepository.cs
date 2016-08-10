using Sistemas.DoacaoDeSangue.ColetaAPI.Interfaces;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;
using System;
using System.Collections.Generic;


namespace Sistemas.DoacaoDeSangue.ColetaAPI.Repositorys
{
    public class ServicosPrestadosRepository : IServicoPrestado
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        public string Add(List<ServicosPrestados> lista)
        {
            string retorno = string.Empty;
            int contaServicos = 0;
            int retornoProcedure = 0;

            try
            {
                foreach (var item in lista)
                {

                    retornoProcedure = entities.CriarServicoPrestado(item.Laboratorio.Id, item.TipoServico, item.Valor);

                    if (retornoProcedure != 0)
                    {
                        contaServicos += 1;
                    }
                }

                if (contaServicos > 0)
                {
                    retorno = "O(s) " + contaServicos + " serviços prestados foram cadastrados com sucesso!";
                }
                else
                {
                    retorno = "Não foi possível cadastrar os serviços prestados!";

                }

            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro de servicos prestados-> " + ex.ToString();
            }
            return retorno;

        }

    }
}