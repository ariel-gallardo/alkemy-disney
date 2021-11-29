namespace alkemy_challenge.Models
{
    public class Pelicula
    {
        public string? Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int? Calificacion { get; set; }
        public Genero? Genero { get; set; }
        public List<Personaje>? Personajes { get; set; }
    }
}