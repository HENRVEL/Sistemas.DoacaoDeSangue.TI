using Sistemas.DoacaoDeSangue.SegurancaAPI.Interfaces;
using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;

using System;

namespace Sistemas.DoacaoDeSangue.SegurancaAPI.Respositorys
{
    public class SegurancaRepository : ISeguranca
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();


        public string Add(Seguranca item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Criar Usuário] - Objeto seguranca está sem valor!");
                }
                else
                {
                    var retornoEntity = entities.CriarUsuario(item.Usuario, item.Senha, item.TipoUsuario, item.IdDoador, item.IdUnidadeHospitalar, item.IdLaboratorio);

                    if (retornoEntity == 1)
                    {
                        retorno = "Usuário " + item.Usuario.ToUpper() + " cadastro com sucesso!";

                    }
                    else
                    {
                        retorno = "Erro ao realizar o cadastro do Usuário!";
                    }

                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro do Usuário -> " + ex.ToString();
            }

            return retorno;
        }

        public string Get(string usuario, string tipoUsuario, string senha)
        {
            string retorno = string.Empty;

            var resultado = entities.VerificarSenhaUsuario(usuario, tipoUsuario, senha);


            foreach (var item in resultado)
            {
                retorno = item.ID_USUARIO.ToString() +"," + item.SENHA_CONFERIDA.ToString();
            }

            return retorno;

        }
    }
}