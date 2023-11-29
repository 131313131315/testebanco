namespace Db.Domain.Enum.Base.NotaFiscal
{
    public enum StatusNotaFiscal
    {
        PreEnvio = 0,

        NaoEncontrado = 1,

        AutorizadoUsoNfe = 100,

        CancelamentoNfeHomologado = 101,

        InutilizacaoNumeroHomologado = 102,

        LoteRecebidoSucesso = 103,

        LoteProcessado = 104,

        ServicoParalisadoMomentaneamenteCurtoPrazo = 108,

        ServicoParalisadoSemPrevisao = 109,

        AutorizadoUsoNfeAutorizacaoForaPrazo = 150,

        DuplicidadeNfe = 204,

        EanInvalido = 611,

        NcmInexistente = 778,

        RejeicaoErroNaoCatalogado = 999,

        DuplicidadeDiferencaChaveAcesso = 539,

        ValorProdutoDifere = 629,

        RazaoSocialDifereNFeEmitidaEmAmbienteHomologacao = 598,
            CFOPNaoPermitidoParaoCSOSN = 386

    }
}
