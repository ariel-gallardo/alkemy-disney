namespace alkemy_challenge.Models
{
    public class Genero
    {
        public string Nombre {get;set;}
        public string Imagen {get;set;}
        public List<Pelicula>? Peliculas { get; set; }
    }
}