using System;
using System.Collections.Generic;
using Sistemas.DoacaoDeSangue.AdministrativoAPI.Interface;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;

namespace Sistemas.DoacaoDeSangue.AdministrativoAPI.Repository
{
    public class UnidadeHospitalarRepository : IUnidadeHospitalar
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Add(UnidadeHospitalar item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Erro - Criar Unidade Hospitalar] - Objeto UnidadeHospitalar está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.CriarUnidadeHospitalar(item.Nome, item.Cidade, item.Estado, item.Bairro, item.Complemento, item.CNPJ, item.Responsavel, item.Email, item.Telefone, item.UnidadeAtivo);

                    if (retornoEntity == 1)
                    {
                        retorno = "Unidade hospitalar " + item.Nome.ToUpper() + " cadastra com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar o cadastro da Unidade Hospitalar!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro da Unidade Hospitalar -> " + ex.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UnidadeHospitalar Get(int id)
        {
            UnidadeHospitalar unidadeHospitalar = new UnidadeHospitalar();

            var resultado = entities.ObterUnidadeHospitalar(id);

            foreach (var item in resultado)
            {
                unidadeHospitalar.Id = item.ID;
                unidadeHospitalar.Nome = item.NOME;
                unidadeHospitalar.Cidade = item.CIDADE;
                unidadeHospitalar.Estado = item.ESTADO;
                unidadeHospitalar.Bairro = item.BAIRRO;
                unidadeHospitalar.Complemento = item.COMPLEMENTO;
                unidadeHospitalar.CNPJ = item.CNPJ;
                unidadeHospitalar.Responsavel = item.RESPONSAVEL;
                unidadeHospitalar.Email = item.EMAIL;
                unidadeHospitalar.Telefone = item.TELEFONE;
                unidadeHospitalar.UnidadeAtivo= item.ATIVO;

            }

            return unidadeHospitalar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UnidadeHospitalar> GetAll()
        {
            List<UnidadeHospitalar> unidadesHospitalares = new List<UnidadeHospitalar>();

            var resultado = entities.ObterUnidadeHospitalar(null);

            foreach (var item in resultado)
            {
                UnidadeHospitalar unidadeHospitalar = new UnidadeHospitalar();

                unidadeHospitalar.Id = item.ID;
                unidadeHospitalar.Nome = item.NOME;
                unidadeHospitalar.Cidade = item.CIDADE;
                unidadeHospitalar.Estado = item.ESTADO;
                unidadeHospitalar.Bairro = item.BAIRRO;
                unidadeHospitalar.Complemento = item.COMPLEMENTO;
                unidadeHospitalar.CNPJ = item.CNPJ;
                unidadeHospitalar.Responsavel = item.RESPONSAVEL;
                unidadeHospitalar.Email = item.EMAIL;
                unidadeHospitalar.Telefone = item.TELEFONE;
                unidadeHospitalar.UnidadeAtivo = item.ATIVO;

                unidadesHospitalares.Add(unidadeHospitalar);
            }

            return unidadesHospitalares;
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
                var retornoEntity = entities.ExcluirUnidadeHospitalar(id);

                if (retornoEntity == 1)
                {
                    retorno = "Unidade Hospitalar excluida com sucesso!";

                }
                else
                {
                    retorno = "Erro ao excluir a Unidade Hospitalar!";
                }

            }
            catch (Exception ex)
            {
                retorno = "Erro ao excluir o Unidade Hospitalar -> " + ex.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Update(UnidadeHospitalar item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Erro - Unidade Hospitalar] - Objeto UnidadeHospitalar está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.AlterarUnidadeHospitalar(item.Id,item.Nome, item.Cidade, item.Estado, item.Bairro, item.Complemento, item.CNPJ, item.Responsavel, item.Email, item.Telefone, item.UnidadeAtivo);

                    if (retornoEntity == 1)
                    {
                        retorno = "Unidade Hospitalar " + item.Nome.ToUpper() + " atualizada com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar a atualização da unidade hospitalar!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar a atualização da unidade hospitalar-> " + ex.ToString();
            }

            return retorno;
        }
    }
}