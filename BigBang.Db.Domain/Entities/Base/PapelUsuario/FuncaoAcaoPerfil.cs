namespace Domain.Entities.Cadastros.PapelUsuario
{
    public class FuncaoAcaoPerfil : BaseEntityGenerico
    {
        public string FuncaoNome { get; set; }
        public int FuncaoId { get; set; }
        public Funcao Funcao { get; set; }
        public string AcaoNome { get; set; }
        public int AcaoId { get; set; }
        public Acao Acao { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
    }
}
