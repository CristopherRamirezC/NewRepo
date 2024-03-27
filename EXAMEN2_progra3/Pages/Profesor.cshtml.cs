using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace EXAMEN2_progra3.Pages
{
    public class ProfesorModel : PageModel
    {
        
   
    public List<Profesor> ListaDeProfesores { get; set; }

        public ProfesorModel()
        {
            ListaDeProfesores = new List<Profesor>  
        {
            new Profesor { Nombre = "Juan", Apellido = "Perez", Cedula = 4012348, AreaConocimiento = "Matemáticas" },
            new Profesor  { Nombre = "María", Apellido = "González", Cedula = 4042468, AreaConocimiento = "Física" },
            new Profesor  { Nombre = "Pedro", Apellido = "Sánchez", Cedula = 45768349, AreaConocimiento = "Historia" },
            new Profesor  { Nombre = "Ana", Apellido = "Martínez", Cedula = 4000329, AreaConocimiento = "Literatura" }
        };
        }
    }
}
    

