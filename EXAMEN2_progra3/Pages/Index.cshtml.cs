using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace EXAMEN2_progra3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public EstudianteModel Estudiantes { get; private set; } // Lista de estudiantes
        public ProfesorModel Profesores { get; private set; } // Lista de profesores

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Inicializamos la lista de estudiantes con algunos ejemplos
            Estudiantes = new EstudianteModel
            {
                ListaDeEstudiantes = new List<Estudiante>
    {
        new Estudiante { Nombre = "Sofía", Carrera = "Arquitectura", Edad = 21, Cedula = 01234565, CantidadCursos = 6 },
        new Estudiante { Nombre = "Carlos", Carrera = "Derecho", Edad = 23, Cedula = 9876543, CantidadCursos = 5 },
        new Estudiante { Nombre = "Ana", Carrera = "Medicina", Edad = 20, Cedula = 2468138, CantidadCursos = 4 }
    }
            };

            Profesores = new ProfesorModel
            {
                ListaDeProfesores = new List<Profesor>
    {
        new Profesor { Nombre = "Juan", Apellido = "Perez", Cedula = 4012348, AreaConocimiento = "Matemáticas" },
        new Profesor  { Nombre = "María", Apellido = "González", Cedula = 4042468, AreaConocimiento = "Física" },
        new Profesor  { Nombre = "Pedro", Apellido = "Sánchez", Cedula = 4576839, AreaConocimiento = "Historia" },
        new Profesor  { Nombre = "Ana", Apellido = "Martínez", Cedula = 4000329, AreaConocimiento = "Literatura" }
    }
            };
        }
    }

}