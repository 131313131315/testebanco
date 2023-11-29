using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base.Socio
{
    public enum TituloDocEspecie
    {
        /// <summary>Não Informado</summary>
        [Display(Name = "Não Informado")]
        NaoDefinido = 00,

        /// <summary>Cheque</summary>
        [Display(Name = "Cheque")]
        CH = 01,

        /// <summary>Duplicata Mercantil</summary>
        [Display(Name = "Duplicata Mercantil")]
        DM = 02,

        /// <summary> Duplicata Mercantil p/ Indicação</summary>
        [Display(Name = "Duplicata Mercantil p/ Indicação")]
        DMI = 03,

        /// <summary>Duplicata de Serviço</summary>
        [Display(Name = "Duplicata de Serviço")]
        DS = 04,

        /// <summary>Duplicata de Serviço p/ Indicação</summary>
        [Display(Name = "Duplicata de Serviço p/ Indicação")]
        DSI = 05,

        /// <summary>Duplicata Rural</summary>
        [Display(Name = "Duplicata Rural")]
        DR = 06,

        /// <summary>Letra de Câmbio</summary>
        [Display(Name = "Letra de Câmbio")]
        LC = 07,

        /// <summary>Nota de Crédito Comercial</summary>
        [Display(Name = "Nota de Crédito Comercial")]
        NCC = 08,

        /// <summary> Nota de Crédito a Exportação</summary>
        [Display(Name = "Nota de Crédito a Exportação")]
        NCE = 09, //

        /// <summary>Nota de Crédito Industrial</summary>
        [Display(Name = "Nota de Crédito Industrial")]
        NCI = 10,

        /// <summary>Nota de Crédito Rural</summary>
        [Display(Name = "Nota de Crédito Rural")]
        NCR = 11,

        /// <summary>Nota Promissória</summary>
        [Display(Name = "Nota Promissória")]
        NP = 12,

        /// <summary>Nota Promissória Rural</summary>
        [Display(Name = "Nota Promissória Rural")]
        NPR = 13,

        /// <summary>Triplicata Mercantil</summary>
        [Display(Name = "Triplicata Mercantil")]
        TM = 14,

        /// <summary>Triplicata de Serviço</summary>
        [Display(Name = "Triplicata de Serviço")]
        TS = 15,

        /// <summary>Nota de Seguro</summary>
        [Display(Name = "Nota de Seguro")]
        NS = 16,

        /// <summary>Recibo</summary>
        [Display(Name = "Recibo")]
        RC = 17,

        /// <summary>Fatura</summary>
        [Display(Name = "Fatura")]
        FAT = 18,

        /// <summary>Nota de Débito</summary>
        [Display(Name = "Nota de Débito")]
        ND = 19,

        /// <summary>Apólice de Seguro</summary>
        [Display(Name = "Apólice de Seguro")]
        AP = 20,

        /// <summary>Mensalidade Escolar</summary>
        [Display(Name = "Mensalidade Escolar")]
        ME = 21,

        /// <summary>Parcela de Consórcio</summary>
        [Display(Name = "Parcela de Consórcio")]
        PC = 22,

        /// <summary>Nota Fiscal</summary>
        [Display(Name = "Nota Fiscal")]
        NF = 23,

        /// <summary>Documento de Dívida</summary>
        [Display(Name = "Documento de Dívida")]
        DD = 24,

        /// <summary>Cédula de Produto Rural</summary>
        [Display(Name = "Cédula de Produto Rural")]
        CPR = 25,

        /// <summary>Warrant</summary>
        [Display(Name = "Warrant")]
        WAR = 26,

        /// <summary>Dívida Ativa Estado</summary>
        [Display(Name = "Dívida Ativa Estado")]
        DAE = 27,

        /// <summary>Dívida Ativa Município</summary>
        [Display(Name = "Dívida Ativa Município")]
        DAM = 28,

        /// <summary>Dívida Ativa União</summary>
        [Display(Name = "Dívida Ativa União")]
        DAU = 29,

        /// <summary>Encargos Condominiais</summary>
        [Display(Name = "Encargos Condominiais")]
        EC = 30,

        /// <summary>Cartão de Crédito</summary>
        [Display(Name = "Cartão de Crédito")]
        CC = 31,

        /// <summary>Boleto Proposta</summary>
        [Display(Name = "Boleto Proposta")]
        BP = 32,

        /// <summary>Outros</summary>
        [Display(Name = "Outros")]
        OU = 99
    }
}
