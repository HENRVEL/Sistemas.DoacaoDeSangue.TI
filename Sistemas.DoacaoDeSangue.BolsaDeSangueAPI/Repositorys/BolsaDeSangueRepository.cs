using Sistemas.DoacaoDeSangue.DTO;
using Sistemas.DoacaoDeSangue.DAO;
using Sistemas.DoacaoDeSangue.BolsaDeSangueAPI.Interfaces;
using System;


namespace Sistemas.DoacaoDeSangue.BolsaDeSangueAPI.Repositorys
{
    public class BolsaDeSangueRepository : IBolsaDeSangue
    {
        BD_DOACAOEntities entities = new BD_DOACAOEntities();

        public string Add(BolsaDeSangue item)
        {
            string retorno = string.Empty;
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("[Erro - Bolsa de sangue] - Objeto BolsaDeSangue está sem valor!");
                }
                else
                {

                    if (item.Paciente == null)
                    {
                        throw new ArgumentNullException("[Erro - Bolsa de sangue] - Objeto Paciente está sem valor!");
                    }
                    else
                    {
                        var retornoPacienteHospitalarEntity = entities.CriarPacienteHospitalar(item.Paciente.Nome, item.Paciente.SobreNome, item.Paciente.Sexo.ToString(), item.Paciente.DataNascimento, item.Paciente.CPF, item.Paciente.TipoSanguineo, item.Paciente.FatorRH);

                        if (retornoPacienteHospitalarEntity == 1)
                        {

                            var retornoEntity = entities.CriarSolicitacaoBolsaDeSangue(item.UnidadeHospitalar.Id, item.LaboratorioConveniado.Id, item.MotivoDoacao, item.Diagnostico);

                            if (retornoEntity == 1)
                            {
                                retorno = "Solicitação de bolsa de sangue cadastrada com sucesso";

                            }
                            else
                            {
                                retorno = "Erro ao realizar o cadastro da solicitação da bolsa de sangue!";
                            }

                        }
                        else
                        {
                            retorno = "[Erro - Bolsa de sangue] - Objeto idPacienteHospitalar está sem valor!";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao realizar o cadastro da solicitação da bolsa de sangue -> " + ex.ToString();
            }

            return retorno;

        }
    }
}