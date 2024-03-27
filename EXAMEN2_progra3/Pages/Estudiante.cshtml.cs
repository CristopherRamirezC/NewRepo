using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EXAMEN2_progra3.Pages
{
    public class EstudianteModel : PageModel
    {
        
        public List<Estudiante> ListaDeEstudiantes { get; set; }

        public EstudianteModel() => ListaDeEstudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Sofía", Carrera = "Arquitectura", Edad = 21, Cedula = 01234565, CantidadCursos = 6 },
                new Estudiante { Nombre = "Carlos", Carrera = "Derecho", Edad = 23, Cedula = 9876543, CantidadCursos = 5 },
                new Estudiante { Nombre = "Ana", Carrera = "Medicina", Edad = 20, Cedula = 2468138, CantidadCursos = 4 }
            };
    }
}

