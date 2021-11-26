namespace UnusualEvents.Banco.Entidades
{
    public class Bairro
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CodigoCidade { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
