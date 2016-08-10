using Sistemas.DoacaoDeSangue.AdministrativoAPI.Interface;
using Sistemas.DoacaoDeSangue.DAO;
using Sistemas.DoacaoDeSangue.DTO;
using System;
using System.Collections.Generic;

namespace Sistemas.DoacaoDeSangue.AdministrativoAPI.Repository
{
    public class LaboratorioConveniadoRepository : ILaboratorioConveniado
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Add(LaboratorioConveniado item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Erro - Criar laboratório] - Objeto LaboratorioConveniado está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.CriarLaboratorio(item.Nome, item.Cidade, item.Estado, item.Bairro, item.Complemento, item.CNPJ, item.Responsavel, item.Email, item.Telefone, item.IdSistemaSUS, item.LaboratorioAtivo);

                    if (retornoEntity == 1)
                    {
                        retorno = "Laboratório " + item.Nome.ToUpper() + " cadastro com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar o cadastro do laboratório!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro do laboratório -> " + ex.ToString();
            }

            return retorno;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LaboratorioConveniado Get(int id)
        {
            LaboratorioConveniado laboratorioConveniado = new LaboratorioConveniado();

            var resultado = entities.ObterLaboratorio(id);

            foreach (var item in resultado)
            {
                laboratorioConveniado.Id = item.ID;
                laboratorioConveniado.Nome = item.NOME;
                laboratorioConveniado.Cidade = item.CIDADE;
                laboratorioConveniado.Estado = item.ESTADO;
                laboratorioConveniado.Bairro = item.BAIRRO;
                laboratorioConveniado.Complemento = item.COMPLEMENTO;
                laboratorioConveniado.CNPJ = item.CNPJ;
                laboratorioConveniado.Responsavel = item.RESPONSAVEL;
                laboratorioConveniado.Email = item.EMAIL;
                laboratorioConveniado.Telefone = item.TELEFONE;
                laboratorioConveniado.IdSistemaSUS = item.ID_SUS;
                laboratorioConveniado.LaboratorioAtivo = item.ATIVO;

            }

            return laboratorioConveniado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LaboratorioConveniado> GetAll()
        {
            List<LaboratorioConveniado> laboratoriosConveniado = new List<LaboratorioConveniado>();
            
            var resultado = entities.ObterLaboratorio(null);

            foreach (var item in resultado)
            {
                LaboratorioConveniado laboratorioConveniado = new LaboratorioConveniado();

                laboratorioConveniado.Id = item.ID;
                laboratorioConveniado.Nome = item.NOME;
                laboratorioConveniado.Cidade = item.CIDADE;
                laboratorioConveniado.Estado = item.ESTADO;
                laboratorioConveniado.Bairro = item.BAIRRO;
                laboratorioConveniado.Complemento = item.COMPLEMENTO;
                laboratorioConveniado.CNPJ = item.CNPJ;
                laboratorioConveniado.Responsavel = item.RESPONSAVEL;
                laboratorioConveniado.Email = item.EMAIL;
                laboratorioConveniado.Telefone = item.TELEFONE;
                laboratorioConveniado.IdSistemaSUS = item.ID_SUS;
                laboratorioConveniado.LaboratorioAtivo = item.ATIVO;

                laboratoriosConveniado.Add(laboratorioConveniado);
            }

            return laboratoriosConveniado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Remove(int id)
        {
            string retorno = string.Empty;
            try
            {
                var retornoEntity = entities.ExcluirLaboratorio(id);

                if (retornoEntity == 1)
                {
                    retorno = "Laboratório conveniado excluido com sucesso!";

                }
                else
                {
                    retorno = "Erro ao excluir o laboratório conveniado !";
                }

            }
            catch (Exception ex)
            {
                retorno = "Erro ao excluir o laboratório conveniado -> " + ex.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Update(LaboratorioConveniado item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Erro - Alterar laboratório] - Objeto LaboratorioConveniado está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.CriarLaboratorio(item.Nome, item.Cidade, item.Estado, item.Bairro, item.Complemento, item.CNPJ, item.Responsavel, item.Email, item.Telefone, item.IdSistemaSUS, item.LaboratorioAtivo);

                    if (retornoEntity == 1)
                    {
                        retorno = "Laboratório " + item.Nome.ToUpper() + " atualizado com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar a atualização do laboratório!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar a atualização do laboratório -> " + ex.ToString();
            }

            return retorno;
        }
    }
}