using System.Collections.Generic;

namespace practicaa4.Models
{
    public class Fotos
    {
        public int Id {get;set;}

        public string TituloFoto { get; set; }

        public string Foto { get; set; }

        public ICollection<Comentario> Comenta {get;set;}
    }
}