namespace UnusualEvents.Banco.Entidades
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
