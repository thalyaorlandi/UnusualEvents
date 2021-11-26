namespace UnusualEvents.Banco.Entidades
{
    public class EnderecoLocal
    {
        public int Codigo { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public int CodigoBairro { get; set; }
        public virtual Bairro Bairro { get; set; }
    }
}
