using Sistemas.DoacaoDeSangue.AgendamentoAPI.Interfaces;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;
using System;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI.Repository
{
    public class DoadorRepository : IDoador
    {

        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Add(Doador item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Criar Doador] - Objeto doador está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.CriarDoador(item.Nome, item.SobreNome, item.Sexo.ToString(), item.CPF, item.Cidade, item.Estado, item.Bairro, item.Complemento, item.CEP, item.Email, item.Telefone, item.Celular, item.TipoSanguineo, item.FatorRH, item.DoadorDeSangue, item.DataUltimaDoacao);

                    if (retornoEntity == 1)
                    {
                        retorno = "Doador " + item.Nome.ToUpper() + " cadastro com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar o cadastro do doador!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro do doador -> " + ex.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Doador GetID(int id)
        {
            Doador doador = new Doador();
            var resultado = entities.ObterDoador(id, null);

            foreach (var item in resultado)
            {
                doador.Id = item.ID;
                doador.Nome = item.NOME;
                doador.SobreNome = item.SOBRENOME;
                doador.Sexo = Convert.ToChar(item.SEXO);
                doador.CPF = item.CPF;
                doador.Cidade = item.CIDADE;
                doador.Estado = item.ESTADO;
                doador.Bairro = item.BAIRRO;
                doador.Complemento = item.COMPLEMENTO;
                doador.CEP = item.CEP;
                doador.Email = item.EMAIL;
                doador.Telefone = item.TELEFONE;
                doador.Celular = item.CELULAR;
                doador.TipoSanguineo = item.TIPO_SANGUINEO;
                doador.FatorRH = item.FATOR_RH;
                doador.DoadorDeSangue = Convert.ToBoolean(item.DOADOR_DE_SANGUE);
                doador.DataUltimaDoacao = item.ULTIMA_DOACAO;
            }

            return doador;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public Doador GetCPF(long cpf)
        {
            Doador doador = new Doador();
            var resultado = entities.ObterDoador(null, cpf);

            foreach (var item in resultado)
            {
                doador.Id = item.ID;
                doador.Nome = item.NOME;
                doador.SobreNome = item.SOBRENOME;
                doador.Sexo = Convert.ToChar(item.SEXO);
                doador.CPF = item.CPF;
                doador.Cidade = item.CIDADE;
                doador.Estado = item.ESTADO;
                doador.Bairro = item.BAIRRO;
                doador.Complemento = item.COMPLEMENTO;
                doador.CEP = item.CEP;
                doador.Email = item.EMAIL;
                doador.Telefone = item.TELEFONE;
                doador.Celular = item.CELULAR;
                doador.TipoSanguineo = item.TIPO_SANGUINEO;
                doador.FatorRH = item.FATOR_RH;
                doador.DoadorDeSangue = Convert.ToBoolean(item.DOADOR_DE_SANGUE);
                doador.DataUltimaDoacao = item.ULTIMA_DOACAO;
            }

            return doador;
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
                var retornoEntity = entities.ExcluirDoador(id);

                if (retornoEntity == 1)
                {
                    retorno = "Doador excluido com sucesso!";

                }
                else
                {
                    retorno = "Erro ao excluir o doador!";
                }

            }
            catch (Exception ex)
            {
                retorno = "Erro ao excluir o doado   -> " + ex.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string Update(Doador item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Alterar Doador] - Objeto doador está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.AlterarDoador(item.Id, item.Nome, item.SobreNome, item.Sexo.ToString(), item.CPF, item.Cidade, item.Estado, item.Bairro, item.Complemento, item.CEP, item.Email, item.Telefone, item.Celular, item.TipoSanguineo, item.FatorRH, item.DoadorDeSangue, item.DataUltimaDoacao);

                    if (retornoEntity == 1)
                    {
                        retorno = "Doador " + item.Nome.ToUpper() + " atualizado com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar a atualização do doador!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar a atualização do doador -> " + ex.ToString();
            }

            return retorno;
        }
    }
}