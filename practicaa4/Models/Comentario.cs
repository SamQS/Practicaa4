namespace practicaa4.Models
{
    public class Comentario
    {
        public int Id {get;set;}
        public string Comenta { get; set; }

        public Fotos Fotos {get; set; }

        public int FotosId{get; set; }

    }
}