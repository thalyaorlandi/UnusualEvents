namespace UnusualEvents.Banco.Entidades
{
    public class TipoEvento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
