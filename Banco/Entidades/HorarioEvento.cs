using System;

namespace UnusualEvents.Banco.Entidades
{
    public class HorarioEvento
    {
        public int Codigo { get; set; }
        public int CodigoEvento { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraTermino { get; set; }
        public virtual Evento Evento { get; set; }
    }
}
