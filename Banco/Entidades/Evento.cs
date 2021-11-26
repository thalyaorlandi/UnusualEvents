using System.Collections.Generic;

namespace UnusualEvents.Banco.Entidades
{
    public class Evento
    {
        public int Codigo { get; set; }
        public int CodigoTipoEvento { get; set; }
        public int CodigoEmpresa { get; set; }
        public string Nome { get; set; }
        public int CodigoEnderecoLocal { get; set; }        
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public List<RequisitoEvento> RequisitoEvento { get; set; }
        public virtual TipoEvento TipoEvento { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual EnderecoLocal EnderecoLocal { get; set; }
        public virtual HorarioEvento HorarioEvento { get; set; }
    }
}
