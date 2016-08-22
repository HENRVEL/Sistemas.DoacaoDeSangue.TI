﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistemas.DoacaoDeSangue.DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class BD_DOACAOEntities : DbContext
    {
        public BD_DOACAOEntities()
            : base("name=BD_DOACAOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<ObterDoador_Result> ObterDoador(Nullable<int> iD, Nullable<long> cPF)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var cPFParameter = cPF.HasValue ?
                new ObjectParameter("CPF", cPF) :
                new ObjectParameter("CPF", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObterDoador_Result>("ObterDoador", iDParameter, cPFParameter);
        }
    
        public virtual int CriarDoador(string nOME, string sOBRENOME, string sEXO, Nullable<long> cPF, string cIDADE, string eSTADO, string bAIRRO, string cOMPLEMENTO, string cEP, string eMAIL, string tELEFONE, string cELULAR, string tIPO_SANGUINEO, string fATOR_RH, Nullable<bool> dOADOR_DE_SANGUE, Nullable<System.DateTime> uLTIMA_DOACAO)
        {
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var sOBRENOMEParameter = sOBRENOME != null ?
                new ObjectParameter("SOBRENOME", sOBRENOME) :
                new ObjectParameter("SOBRENOME", typeof(string));
    
            var sEXOParameter = sEXO != null ?
                new ObjectParameter("SEXO", sEXO) :
                new ObjectParameter("SEXO", typeof(string));
    
            var cPFParameter = cPF.HasValue ?
                new ObjectParameter("CPF", cPF) :
                new ObjectParameter("CPF", typeof(long));
    
            var cIDADEParameter = cIDADE != null ?
                new ObjectParameter("CIDADE", cIDADE) :
                new ObjectParameter("CIDADE", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var bAIRROParameter = bAIRRO != null ?
                new ObjectParameter("BAIRRO", bAIRRO) :
                new ObjectParameter("BAIRRO", typeof(string));
    
            var cOMPLEMENTOParameter = cOMPLEMENTO != null ?
                new ObjectParameter("COMPLEMENTO", cOMPLEMENTO) :
                new ObjectParameter("COMPLEMENTO", typeof(string));
    
            var cEPParameter = cEP != null ?
                new ObjectParameter("CEP", cEP) :
                new ObjectParameter("CEP", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var tELEFONEParameter = tELEFONE != null ?
                new ObjectParameter("TELEFONE", tELEFONE) :
                new ObjectParameter("TELEFONE", typeof(string));
    
            var cELULARParameter = cELULAR != null ?
                new ObjectParameter("CELULAR", cELULAR) :
                new ObjectParameter("CELULAR", typeof(string));
    
            var tIPO_SANGUINEOParameter = tIPO_SANGUINEO != null ?
                new ObjectParameter("TIPO_SANGUINEO", tIPO_SANGUINEO) :
                new ObjectParameter("TIPO_SANGUINEO", typeof(string));
    
            var fATOR_RHParameter = fATOR_RH != null ?
                new ObjectParameter("FATOR_RH", fATOR_RH) :
                new ObjectParameter("FATOR_RH", typeof(string));
    
            var dOADOR_DE_SANGUEParameter = dOADOR_DE_SANGUE.HasValue ?
                new ObjectParameter("DOADOR_DE_SANGUE", dOADOR_DE_SANGUE) :
                new ObjectParameter("DOADOR_DE_SANGUE", typeof(bool));
    
            var uLTIMA_DOACAOParameter = uLTIMA_DOACAO.HasValue ?
                new ObjectParameter("ULTIMA_DOACAO", uLTIMA_DOACAO) :
                new ObjectParameter("ULTIMA_DOACAO", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarDoador", nOMEParameter, sOBRENOMEParameter, sEXOParameter, cPFParameter, cIDADEParameter, eSTADOParameter, bAIRROParameter, cOMPLEMENTOParameter, cEPParameter, eMAILParameter, tELEFONEParameter, cELULARParameter, tIPO_SANGUINEOParameter, fATOR_RHParameter, dOADOR_DE_SANGUEParameter, uLTIMA_DOACAOParameter);
        }
    
        public virtual int AlterarDoador(Nullable<int> iD, string nOME, string sOBRENOME, string sEXO, Nullable<long> cPF, string cIDADE, string eSTADO, string bAIRRO, string cOMPLEMENTO, string cEP, string eMAIL, string tELEFONE, string cELULAR, string tIPO_SANGUINEO, string fATOR_RH, Nullable<bool> dOADOR_DE_SANGUE, Nullable<System.DateTime> uLTIMA_DOACAO)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var sOBRENOMEParameter = sOBRENOME != null ?
                new ObjectParameter("SOBRENOME", sOBRENOME) :
                new ObjectParameter("SOBRENOME", typeof(string));
    
            var sEXOParameter = sEXO != null ?
                new ObjectParameter("SEXO", sEXO) :
                new ObjectParameter("SEXO", typeof(string));
    
            var cPFParameter = cPF.HasValue ?
                new ObjectParameter("CPF", cPF) :
                new ObjectParameter("CPF", typeof(long));
    
            var cIDADEParameter = cIDADE != null ?
                new ObjectParameter("CIDADE", cIDADE) :
                new ObjectParameter("CIDADE", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var bAIRROParameter = bAIRRO != null ?
                new ObjectParameter("BAIRRO", bAIRRO) :
                new ObjectParameter("BAIRRO", typeof(string));
    
            var cOMPLEMENTOParameter = cOMPLEMENTO != null ?
                new ObjectParameter("COMPLEMENTO", cOMPLEMENTO) :
                new ObjectParameter("COMPLEMENTO", typeof(string));
    
            var cEPParameter = cEP != null ?
                new ObjectParameter("CEP", cEP) :
                new ObjectParameter("CEP", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var tELEFONEParameter = tELEFONE != null ?
                new ObjectParameter("TELEFONE", tELEFONE) :
                new ObjectParameter("TELEFONE", typeof(string));
    
            var cELULARParameter = cELULAR != null ?
                new ObjectParameter("CELULAR", cELULAR) :
                new ObjectParameter("CELULAR", typeof(string));
    
            var tIPO_SANGUINEOParameter = tIPO_SANGUINEO != null ?
                new ObjectParameter("TIPO_SANGUINEO", tIPO_SANGUINEO) :
                new ObjectParameter("TIPO_SANGUINEO", typeof(string));
    
            var fATOR_RHParameter = fATOR_RH != null ?
                new ObjectParameter("FATOR_RH", fATOR_RH) :
                new ObjectParameter("FATOR_RH", typeof(string));
    
            var dOADOR_DE_SANGUEParameter = dOADOR_DE_SANGUE.HasValue ?
                new ObjectParameter("DOADOR_DE_SANGUE", dOADOR_DE_SANGUE) :
                new ObjectParameter("DOADOR_DE_SANGUE", typeof(bool));
    
            var uLTIMA_DOACAOParameter = uLTIMA_DOACAO.HasValue ?
                new ObjectParameter("ULTIMA_DOACAO", uLTIMA_DOACAO) :
                new ObjectParameter("ULTIMA_DOACAO", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlterarDoador", iDParameter, nOMEParameter, sOBRENOMEParameter, sEXOParameter, cPFParameter, cIDADEParameter, eSTADOParameter, bAIRROParameter, cOMPLEMENTOParameter, cEPParameter, eMAILParameter, tELEFONEParameter, cELULARParameter, tIPO_SANGUINEOParameter, fATOR_RHParameter, dOADOR_DE_SANGUEParameter, uLTIMA_DOACAOParameter);
        }
    
        public virtual int ExcluirDoador(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExcluirDoador", iDParameter);
        }
    
        public virtual int AlterarLaboratorio(Nullable<int> iD, string nOME, string cIDADE, string eSTADO, string bAIRRO, string cOMPLEMENTO, string cNPJ, string rESPONSAVEL, string eMAIL, string tELEFONE, Nullable<int> iD_SUS, Nullable<bool> aTIVO)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var cIDADEParameter = cIDADE != null ?
                new ObjectParameter("CIDADE", cIDADE) :
                new ObjectParameter("CIDADE", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var bAIRROParameter = bAIRRO != null ?
                new ObjectParameter("BAIRRO", bAIRRO) :
                new ObjectParameter("BAIRRO", typeof(string));
    
            var cOMPLEMENTOParameter = cOMPLEMENTO != null ?
                new ObjectParameter("COMPLEMENTO", cOMPLEMENTO) :
                new ObjectParameter("COMPLEMENTO", typeof(string));
    
            var cNPJParameter = cNPJ != null ?
                new ObjectParameter("CNPJ", cNPJ) :
                new ObjectParameter("CNPJ", typeof(string));
    
            var rESPONSAVELParameter = rESPONSAVEL != null ?
                new ObjectParameter("RESPONSAVEL", rESPONSAVEL) :
                new ObjectParameter("RESPONSAVEL", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var tELEFONEParameter = tELEFONE != null ?
                new ObjectParameter("TELEFONE", tELEFONE) :
                new ObjectParameter("TELEFONE", typeof(string));
    
            var iD_SUSParameter = iD_SUS.HasValue ?
                new ObjectParameter("ID_SUS", iD_SUS) :
                new ObjectParameter("ID_SUS", typeof(int));
    
            var aTIVOParameter = aTIVO.HasValue ?
                new ObjectParameter("ATIVO", aTIVO) :
                new ObjectParameter("ATIVO", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlterarLaboratorio", iDParameter, nOMEParameter, cIDADEParameter, eSTADOParameter, bAIRROParameter, cOMPLEMENTOParameter, cNPJParameter, rESPONSAVELParameter, eMAILParameter, tELEFONEParameter, iD_SUSParameter, aTIVOParameter);
        }
    
        public virtual int CriarLaboratorio(string nOME, string cIDADE, string eSTADO, string bAIRRO, string cOMPLEMENTO, string cNPJ, string rESPONSAVEL, string eMAIL, string tELEFONE, Nullable<int> iD_SUS, Nullable<bool> aTIVO)
        {
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var cIDADEParameter = cIDADE != null ?
                new ObjectParameter("CIDADE", cIDADE) :
                new ObjectParameter("CIDADE", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var bAIRROParameter = bAIRRO != null ?
                new ObjectParameter("BAIRRO", bAIRRO) :
                new ObjectParameter("BAIRRO", typeof(string));
    
            var cOMPLEMENTOParameter = cOMPLEMENTO != null ?
                new ObjectParameter("COMPLEMENTO", cOMPLEMENTO) :
                new ObjectParameter("COMPLEMENTO", typeof(string));
    
            var cNPJParameter = cNPJ != null ?
                new ObjectParameter("CNPJ", cNPJ) :
                new ObjectParameter("CNPJ", typeof(string));
    
            var rESPONSAVELParameter = rESPONSAVEL != null ?
                new ObjectParameter("RESPONSAVEL", rESPONSAVEL) :
                new ObjectParameter("RESPONSAVEL", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var tELEFONEParameter = tELEFONE != null ?
                new ObjectParameter("TELEFONE", tELEFONE) :
                new ObjectParameter("TELEFONE", typeof(string));
    
            var iD_SUSParameter = iD_SUS.HasValue ?
                new ObjectParameter("ID_SUS", iD_SUS) :
                new ObjectParameter("ID_SUS", typeof(int));
    
            var aTIVOParameter = aTIVO.HasValue ?
                new ObjectParameter("ATIVO", aTIVO) :
                new ObjectParameter("ATIVO", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarLaboratorio", nOMEParameter, cIDADEParameter, eSTADOParameter, bAIRROParameter, cOMPLEMENTOParameter, cNPJParameter, rESPONSAVELParameter, eMAILParameter, tELEFONEParameter, iD_SUSParameter, aTIVOParameter);
        }
    
        public virtual int ExcluirLaboratorio(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExcluirLaboratorio", iDParameter);
        }
    
        public virtual ObjectResult<ObterLaboratorio_Result> ObterLaboratorio(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObterLaboratorio_Result>("ObterLaboratorio", iDParameter);
        }
    
        public virtual int AlterarUnidadeHospitalar(Nullable<int> iD, string nOME, string cIDADE, string eSTADO, string bAIRRO, string cOMPLEMENTO, string cNPJ, string rESPONSAVEL, string eMAIL, string tELEFONE, Nullable<bool> aTIVO)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var cIDADEParameter = cIDADE != null ?
                new ObjectParameter("CIDADE", cIDADE) :
                new ObjectParameter("CIDADE", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var bAIRROParameter = bAIRRO != null ?
                new ObjectParameter("BAIRRO", bAIRRO) :
                new ObjectParameter("BAIRRO", typeof(string));
    
            var cOMPLEMENTOParameter = cOMPLEMENTO != null ?
                new ObjectParameter("COMPLEMENTO", cOMPLEMENTO) :
                new ObjectParameter("COMPLEMENTO", typeof(string));
    
            var cNPJParameter = cNPJ != null ?
                new ObjectParameter("CNPJ", cNPJ) :
                new ObjectParameter("CNPJ", typeof(string));
    
            var rESPONSAVELParameter = rESPONSAVEL != null ?
                new ObjectParameter("RESPONSAVEL", rESPONSAVEL) :
                new ObjectParameter("RESPONSAVEL", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var tELEFONEParameter = tELEFONE != null ?
                new ObjectParameter("TELEFONE", tELEFONE) :
                new ObjectParameter("TELEFONE", typeof(string));
    
            var aTIVOParameter = aTIVO.HasValue ?
                new ObjectParameter("ATIVO", aTIVO) :
                new ObjectParameter("ATIVO", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlterarUnidadeHospitalar", iDParameter, nOMEParameter, cIDADEParameter, eSTADOParameter, bAIRROParameter, cOMPLEMENTOParameter, cNPJParameter, rESPONSAVELParameter, eMAILParameter, tELEFONEParameter, aTIVOParameter);
        }
    
        public virtual int CriarUnidadeHospitalar(string nOME, string cIDADE, string eSTADO, string bAIRRO, string cOMPLEMENTO, string cNPJ, string rESPONSAVEL, string eMAIL, string tELEFONE, Nullable<bool> aTIVO)
        {
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var cIDADEParameter = cIDADE != null ?
                new ObjectParameter("CIDADE", cIDADE) :
                new ObjectParameter("CIDADE", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var bAIRROParameter = bAIRRO != null ?
                new ObjectParameter("BAIRRO", bAIRRO) :
                new ObjectParameter("BAIRRO", typeof(string));
    
            var cOMPLEMENTOParameter = cOMPLEMENTO != null ?
                new ObjectParameter("COMPLEMENTO", cOMPLEMENTO) :
                new ObjectParameter("COMPLEMENTO", typeof(string));
    
            var cNPJParameter = cNPJ != null ?
                new ObjectParameter("CNPJ", cNPJ) :
                new ObjectParameter("CNPJ", typeof(string));
    
            var rESPONSAVELParameter = rESPONSAVEL != null ?
                new ObjectParameter("RESPONSAVEL", rESPONSAVEL) :
                new ObjectParameter("RESPONSAVEL", typeof(string));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var tELEFONEParameter = tELEFONE != null ?
                new ObjectParameter("TELEFONE", tELEFONE) :
                new ObjectParameter("TELEFONE", typeof(string));
    
            var aTIVOParameter = aTIVO.HasValue ?
                new ObjectParameter("ATIVO", aTIVO) :
                new ObjectParameter("ATIVO", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarUnidadeHospitalar", nOMEParameter, cIDADEParameter, eSTADOParameter, bAIRROParameter, cOMPLEMENTOParameter, cNPJParameter, rESPONSAVELParameter, eMAILParameter, tELEFONEParameter, aTIVOParameter);
        }
    
        public virtual int ExcluirUnidadeHospitalar(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExcluirUnidadeHospitalar", iDParameter);
        }
    
        public virtual ObjectResult<ObterUnidadeHospitalar_Result> ObterUnidadeHospitalar(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObterUnidadeHospitalar_Result>("ObterUnidadeHospitalar", iDParameter);
        }
    
        public virtual int CriarAgendaLaboratorio(Nullable<int> iD_LAB, string dATA, string hORA)
        {
            var iD_LABParameter = iD_LAB.HasValue ?
                new ObjectParameter("ID_LAB", iD_LAB) :
                new ObjectParameter("ID_LAB", typeof(int));
    
            var dATAParameter = dATA != null ?
                new ObjectParameter("DATA", dATA) :
                new ObjectParameter("DATA", typeof(string));
    
            var hORAParameter = hORA != null ?
                new ObjectParameter("HORA", hORA) :
                new ObjectParameter("HORA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarAgendaLaboratorio", iD_LABParameter, dATAParameter, hORAParameter);
        }
    
        public virtual int CriarAgendaDoador(Nullable<int> iD_LAB, Nullable<int> iD_DOA, Nullable<int> iD_AGL, Nullable<bool> cANCELADO, string mOTIVO_CANCELAMENTO)
        {
            var iD_LABParameter = iD_LAB.HasValue ?
                new ObjectParameter("ID_LAB", iD_LAB) :
                new ObjectParameter("ID_LAB", typeof(int));
    
            var iD_DOAParameter = iD_DOA.HasValue ?
                new ObjectParameter("ID_DOA", iD_DOA) :
                new ObjectParameter("ID_DOA", typeof(int));
    
            var iD_AGLParameter = iD_AGL.HasValue ?
                new ObjectParameter("ID_AGL", iD_AGL) :
                new ObjectParameter("ID_AGL", typeof(int));
    
            var cANCELADOParameter = cANCELADO.HasValue ?
                new ObjectParameter("CANCELADO", cANCELADO) :
                new ObjectParameter("CANCELADO", typeof(bool));
    
            var mOTIVO_CANCELAMENTOParameter = mOTIVO_CANCELAMENTO != null ?
                new ObjectParameter("MOTIVO_CANCELAMENTO", mOTIVO_CANCELAMENTO) :
                new ObjectParameter("MOTIVO_CANCELAMENTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarAgendaDoador", iD_LABParameter, iD_DOAParameter, iD_AGLParameter, cANCELADOParameter, mOTIVO_CANCELAMENTOParameter);
        }
    
        public virtual ObjectResult<ObterAgendaDoador_Result> ObterAgendaDoador(Nullable<int> iD_DOA)
        {
            var iD_DOAParameter = iD_DOA.HasValue ?
                new ObjectParameter("ID_DOA", iD_DOA) :
                new ObjectParameter("ID_DOA", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObterAgendaDoador_Result>("ObterAgendaDoador", iD_DOAParameter);
        }
    
        public virtual int CriarPacienteHospitalar(string nOME, string sOBRENOME, string sEXO, string dATA_NASCIMENTO, Nullable<long> cPF, string tIPO_SANGUINEO, string fATOR_RH)
        {
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var sOBRENOMEParameter = sOBRENOME != null ?
                new ObjectParameter("SOBRENOME", sOBRENOME) :
                new ObjectParameter("SOBRENOME", typeof(string));
    
            var sEXOParameter = sEXO != null ?
                new ObjectParameter("SEXO", sEXO) :
                new ObjectParameter("SEXO", typeof(string));
    
            var dATA_NASCIMENTOParameter = dATA_NASCIMENTO != null ?
                new ObjectParameter("DATA_NASCIMENTO", dATA_NASCIMENTO) :
                new ObjectParameter("DATA_NASCIMENTO", typeof(string));
    
            var cPFParameter = cPF.HasValue ?
                new ObjectParameter("CPF", cPF) :
                new ObjectParameter("CPF", typeof(long));
    
            var tIPO_SANGUINEOParameter = tIPO_SANGUINEO != null ?
                new ObjectParameter("TIPO_SANGUINEO", tIPO_SANGUINEO) :
                new ObjectParameter("TIPO_SANGUINEO", typeof(string));
    
            var fATOR_RHParameter = fATOR_RH != null ?
                new ObjectParameter("FATOR_RH", fATOR_RH) :
                new ObjectParameter("FATOR_RH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarPacienteHospitalar", nOMEParameter, sOBRENOMEParameter, sEXOParameter, dATA_NASCIMENTOParameter, cPFParameter, tIPO_SANGUINEOParameter, fATOR_RHParameter);
        }
    
        public virtual int CriarSolicitacaoBolsaDeSangue(Nullable<int> iD_UHP, Nullable<int> iD_LAB, string mOTIVO_DOACAO, string dIAGNOSTICO)
        {
            var iD_UHPParameter = iD_UHP.HasValue ?
                new ObjectParameter("ID_UHP", iD_UHP) :
                new ObjectParameter("ID_UHP", typeof(int));
    
            var iD_LABParameter = iD_LAB.HasValue ?
                new ObjectParameter("ID_LAB", iD_LAB) :
                new ObjectParameter("ID_LAB", typeof(int));
    
            var mOTIVO_DOACAOParameter = mOTIVO_DOACAO != null ?
                new ObjectParameter("MOTIVO_DOACAO", mOTIVO_DOACAO) :
                new ObjectParameter("MOTIVO_DOACAO", typeof(string));
    
            var dIAGNOSTICOParameter = dIAGNOSTICO != null ?
                new ObjectParameter("DIAGNOSTICO", dIAGNOSTICO) :
                new ObjectParameter("DIAGNOSTICO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarSolicitacaoBolsaDeSangue", iD_UHPParameter, iD_LABParameter, mOTIVO_DOACAOParameter, dIAGNOSTICOParameter);
        }
    
        public virtual int CriarPacienteLaboratorio(string nOME, string sOBRENOME, string sEXO, string dATA_NASCIMENTO, Nullable<long> cPF, string tIPO_SANGUINEO, string fATOR_RH)
        {
            var nOMEParameter = nOME != null ?
                new ObjectParameter("NOME", nOME) :
                new ObjectParameter("NOME", typeof(string));
    
            var sOBRENOMEParameter = sOBRENOME != null ?
                new ObjectParameter("SOBRENOME", sOBRENOME) :
                new ObjectParameter("SOBRENOME", typeof(string));
    
            var sEXOParameter = sEXO != null ?
                new ObjectParameter("SEXO", sEXO) :
                new ObjectParameter("SEXO", typeof(string));
    
            var dATA_NASCIMENTOParameter = dATA_NASCIMENTO != null ?
                new ObjectParameter("DATA_NASCIMENTO", dATA_NASCIMENTO) :
                new ObjectParameter("DATA_NASCIMENTO", typeof(string));
    
            var cPFParameter = cPF.HasValue ?
                new ObjectParameter("CPF", cPF) :
                new ObjectParameter("CPF", typeof(long));
    
            var tIPO_SANGUINEOParameter = tIPO_SANGUINEO != null ?
                new ObjectParameter("TIPO_SANGUINEO", tIPO_SANGUINEO) :
                new ObjectParameter("TIPO_SANGUINEO", typeof(string));
    
            var fATOR_RHParameter = fATOR_RH != null ?
                new ObjectParameter("FATOR_RH", fATOR_RH) :
                new ObjectParameter("FATOR_RH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarPacienteLaboratorio", nOMEParameter, sOBRENOMEParameter, sEXOParameter, dATA_NASCIMENTOParameter, cPFParameter, tIPO_SANGUINEOParameter, fATOR_RHParameter);
        }
    
        public virtual int CriarResultadoDeExames(Nullable<int> iD_LAB, Nullable<long> cPF, Nullable<int> cODIGO, string rESULTADO)
        {
            var iD_LABParameter = iD_LAB.HasValue ?
                new ObjectParameter("ID_LAB", iD_LAB) :
                new ObjectParameter("ID_LAB", typeof(int));
    
            var cPFParameter = cPF.HasValue ?
                new ObjectParameter("CPF", cPF) :
                new ObjectParameter("CPF", typeof(long));
    
            var cODIGOParameter = cODIGO.HasValue ?
                new ObjectParameter("CODIGO", cODIGO) :
                new ObjectParameter("CODIGO", typeof(int));
    
            var rESULTADOParameter = rESULTADO != null ?
                new ObjectParameter("RESULTADO", rESULTADO) :
                new ObjectParameter("RESULTADO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarResultadoDeExames", iD_LABParameter, cPFParameter, cODIGOParameter, rESULTADOParameter);
        }
    
        public virtual int CriarServicoPrestado(Nullable<int> iD_LAB, string tIPO_SERVICO, Nullable<decimal> vALOR)
        {
            var iD_LABParameter = iD_LAB.HasValue ?
                new ObjectParameter("ID_LAB", iD_LAB) :
                new ObjectParameter("ID_LAB", typeof(int));
    
            var tIPO_SERVICOParameter = tIPO_SERVICO != null ?
                new ObjectParameter("TIPO_SERVICO", tIPO_SERVICO) :
                new ObjectParameter("TIPO_SERVICO", typeof(string));
    
            var vALORParameter = vALOR.HasValue ?
                new ObjectParameter("VALOR", vALOR) :
                new ObjectParameter("VALOR", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarServicoPrestado", iD_LABParameter, tIPO_SERVICOParameter, vALORParameter);
        }
    
        public virtual int CriarLog(string tIPO_LOG, string mENSAGEM)
        {
            var tIPO_LOGParameter = tIPO_LOG != null ?
                new ObjectParameter("TIPO_LOG", tIPO_LOG) :
                new ObjectParameter("TIPO_LOG", typeof(string));
    
            var mENSAGEMParameter = mENSAGEM != null ?
                new ObjectParameter("MENSAGEM", mENSAGEM) :
                new ObjectParameter("MENSAGEM", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CriarLog", tIPO_LOGParameter, mENSAGEMParameter);
        }
    
        public virtual ObjectResult<ObterAgendaLaboratorio_Result> ObterAgendaLaboratorio(Nullable<int> iD_LAB)
        {
            var iD_LABParameter = iD_LAB.HasValue ?
                new ObjectParameter("ID_LAB", iD_LAB) :
                new ObjectParameter("ID_LAB", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObterAgendaLaboratorio_Result>("ObterAgendaLaboratorio", iD_LABParameter);
        }
    }
}
