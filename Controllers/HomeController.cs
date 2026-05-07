using Microsoft.AspNetCore.Mvc;
using Catalogo2.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Catalogo2.Controllers
{
    public class HomeController : Controller
    {
        // Esta lista simula nuestra base de datos con los 5 personajes
        private static List<Personaje> listaPersonajes = new List<Personaje>
        {
            new Personaje { Id = 1, Nombre = "Akaza", Rango = "Tercera Luna Superior", Habilidad = "Técnica de Sangre: Aguja de Brújula", EsDemonio = true, ImagenUrl = "Akaza.jpg", Descripcion = "Maestro de las artes marciales que busca al oponente más fuerte." },
            new Personaje { Id = 2, Nombre = "Inosuke", Rango = "Cazador", Habilidad = "Respiración de la Bestia", EsDemonio = false, ImagenUrl = "inosouke.jpeg", Descripcion = "Guerrero audaz que usa máscaras de jabalí y espadas serradas." },
            new Personaje { Id = 3, Nombre = "Muzan Kibutsuji", Rango = "Rey de los Demonios", Habilidad = "Control Total Biológico", EsDemonio = true, ImagenUrl = "Muzan.webp", Descripcion = "El progenitor de todos los demonios y el ser más poderoso." },
            new Personaje { Id = 4, Nombre = "Douma", Rango = "Segunda Luna Superior", Habilidad = "Técnica de Sangre: Loto Gélido", EsDemonio = true, ImagenUrl = "douma.webp", Descripcion = "Líder de un culto con una personalidad gélida y perturbadora." },
            new Personaje { Id = 5, Nombre = "Kokushibo", Rango = "Primera Luna Superior", Habilidad = "Respiración de la Luna", EsDemonio = true, ImagenUrl = "koku.jpg", Descripcion = "Antiguo cazador de la era Sengoku y la luna superior más fuerte." }
        };

        // 1. Pantalla de Inicio (Landing Page)
        public IActionResult Index()
        {
            return View();
        }

        // 2. Pantalla de Catálogo (Aquí es donde se verán los 5)
        public IActionResult Catalogo()
        {
            return View(listaPersonajes);
        }

        // 3. Ficha Técnica (Muestra solo uno basado en el ID)
        public IActionResult Detalle(int id)
        {
            var p = listaPersonajes.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        // 4. Formulario para Agregar
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}