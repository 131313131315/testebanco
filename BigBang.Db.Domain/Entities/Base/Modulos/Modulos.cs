namespace Domain.Entities.Cadastros.Modulos
{
    public class Modulos : BaseEntityGenerico
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Image { get; set; }
        public string Rota { get; set; }
    }
}
