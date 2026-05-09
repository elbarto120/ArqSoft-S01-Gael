using Microsoft.AspNetCore.Mvc;
using Catalogo2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo2.Controllers
{
    public class CatalogoController : Controller
    {
        // Lista unificada con los nombres reales de tus archivos en la carpeta Imagenes/personajes
        private static List<Personaje> personajes = new List<Personaje>
        {
            new Personaje { Id = 1, Nombre = "Akaza", Rango = "Tercera Luna Superior", Habilidad = "Despliegue de Técnica", EsDemonio = true, ImagenUrl = "Akaza.jpg", Descripcion = "asesino del pilar de la llama kyojuro rengoku." },
            new Personaje { Id = 2, Nombre = "Inosuke", Rango = "Cazador", Habilidad = "Respiración de la Bestia", EsDemonio = false, ImagenUrl = "inosouke.jpeg", Descripcion = "Guerrero audaz que usa máscaras de jabalí y espadas serradas." },
            new Personaje { Id = 3, Nombre = "Muzan Kibutsuji", Rango = "Rey de los Demonios", Habilidad = "Control Total Biológico", EsDemonio = true, ImagenUrl = "Muzan.webp", Descripcion = "El progenitor de todos los demonios." },
            new Personaje { Id = 4, Nombre = "Douma", Rango = "Segunda Luna Superior", Habilidad = "Técnica de Sangre: Loto Gélido", EsDemonio = true, ImagenUrl = "douma.webp", Descripcion = "Líder de un culto con una personalidad gélida y asesino del pilar de los insectos." },
            new Personaje { Id = 5, Nombre = "Kokushibo", Rango = "Primera Luna Superior", Habilidad = "Respiración de la Luna", EsDemonio = true, ImagenUrl = "kk.webp", Descripcion = "El demonio más poderoso después de Muzan, antiguo cazador." }
        };

        // Página principal: /Catalogo/Index
        public IActionResult Index()
        {
            return View(personajes);
        }

        // Estadísticas y detalle: /Catalogo/Detalle/5
        public IActionResult Detalle(int id)
        {
            var personaje = personajes.FirstOrDefault(p => p.Id == id);
            if (personaje == null) return NotFound();

            return View(personaje);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Personaje nuevoPersonaje)
        {
            if (ModelState.IsValid)
            {
                nuevoPersonaje.Id = personajes.Count > 0 ? personajes.Max(p => p.Id) + 1 : 1;
                personajes.Add(nuevoPersonaje);
                return RedirectToAction(nameof(Index));
            }
            return View(nuevoPersonaje);
        }
    }
}