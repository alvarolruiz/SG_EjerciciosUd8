using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SG_EjerciciosUd8.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SG_EjerciciosUd8.Controllers
{
    public class Home3Controller : Controller
    {
        // GET: Home3Controller
        public ActionResult Editar()
        {
            clsPersona persona = new clsPersona("Álvaro","Lauriño", "Ruiz", "Calle San Vicente de Paul");
            return View(persona);
        }

        public ActionResult PersonaModificada(String Nombre, String Apellido1, String Apellido2, String Direccion)
        {
            clsPersona personaModificada = new clsPersona(Nombre, Apellido1, Apellido2, Direccion);
            return View(personaModificada);
        }

        
    }
}
