namespace UnusualEvents.Banco.Entidades
{
    public class RequisitoEvento
    {
        public int CodigoRequisito { get; set; }
        public int CodigoEvento { get; set; }
        public virtual Requisito Requisito { get; set; }
    }
}
