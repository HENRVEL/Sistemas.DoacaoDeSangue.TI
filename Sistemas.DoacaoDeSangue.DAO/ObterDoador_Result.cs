//------------------------------------------------------------------------------
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
    
    public partial class ObterDoador_Result
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public string SEXO { get; set; }
        public long CPF { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public string BAIRRO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string CEP { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONE { get; set; }
        public string CELULAR { get; set; }
        public string TIPO_SANGUINEO { get; set; }
        public string FATOR_RH { get; set; }
        public Nullable<bool> DOADOR_DE_SANGUE { get; set; }
        public Nullable<System.DateTime> ULTIMA_DOACAO { get; set; }
    }
}
