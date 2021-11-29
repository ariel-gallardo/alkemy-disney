namespace alkemy_challenge.Models
{
    public class Personaje
    {
        public string? Imagen { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public string? Historia { get; set; }
        public List<Pelicula>? Peliculas { get; set; }
    }
}