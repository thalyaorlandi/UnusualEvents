namespace UnusualEvents.Banco.Entidades
{
    public class Uf
    {
        public int Codigo { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Sigla;
        }
    }
}
