namespace Catalogo2.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rango { get; set; }
        public string Habilidad { get; set; }
        public string Descripcion { get; set; }
        public bool EsDemonio { get; set; }
        public string ImagenUrl { get; set; }
    }
}