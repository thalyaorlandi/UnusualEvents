using System;

namespace UnusualEvents.Banco.Entidades
{
    public class Cidade
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CodigoUf { get; set; }
        public virtual Uf Uf { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
