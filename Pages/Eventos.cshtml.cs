using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAbdance.Pages;

public class EventosModel : PageModel
{
    public class Evento
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime FechaCierreVenta { get; set; }
        public string? ImagenPortada { get; set; }
        public string? Lugar { get; set; }
    }

    public List<Evento> Eventos { get; set; } = new List<Evento>();

    public void OnGet()
    {
        var eventosMock = new List<Evento>
        {
            new Evento {
                Id = 1,
                Titulo = "Gala de Invierno",
                Descripcion = "Nuestra tradicional presentación de invierno para combatir el frío a puro ritmo y talento.",
                FechaEvento = new DateTime(2026, 7, 25),
                FechaCierreVenta = new DateTime(2026, 7, 20),
                ImagenPortada = "/Recursos/Banner/GALA DE INVIERNO.png",
                Lugar = "Teatro Principal"
            },
            new Evento {
                Id = 2,
                Titulo = "Gala Fin de Año",
                Descripcion = "El gran cierre del ciclo donde todas las disciplinas muestran su máximo nivel artístico.",
                FechaEvento = new DateTime(2026, 12, 15),
                FechaCierreVenta = new DateTime(2026, 12, 10),
                ImagenPortada = "/Recursos/Banner/Gala Fin de Año.jpg",
                Lugar = "Estudio Central"
            },
            new Evento {
                Id = 3,
                Titulo = "Primer Gala Show",
                Descripcion = "Un evento especial diseñado para nuevos talentos y primeras experiencias en escenario.",
                FechaEvento = new DateTime(2026, 9, 10),
                FechaCierreVenta = new DateTime(2026, 9, 5),
                ImagenPortada = "/Recursos/Banner/Primer gala Show.png",
                Lugar = "Teatro Principal"
            },
            new Evento {
                Id = 4,
                Titulo = "Show Bienal 2025",
                Descripcion = "Rememorando el gran evento de nuestra academia. ¡Prepárate para la próxima edición!",
                FechaEvento = new DateTime(2025, 11, 20),
                FechaCierreVenta = new DateTime(2025, 11, 15),
                ImagenPortada = "/Recursos/Banner/SHOW BIENAL 2025.png",
                Lugar = "Estadio Arena"
            }
        };

        Eventos = eventosMock.OrderByDescending(e => e.FechaEvento).ToList();
    }
}
