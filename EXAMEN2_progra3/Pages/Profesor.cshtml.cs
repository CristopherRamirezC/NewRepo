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
            new Profesor { Nombre = "Juan", Apellido = "Perez", Cedula = 4012348, AreaConocimiento = "Matem�ticas" },
            new Profesor  { Nombre = "Mar�a", Apellido = "Gonz�lez", Cedula = 4042468, AreaConocimiento = "F�sica" },
            new Profesor  { Nombre = "Pedro", Apellido = "S�nchez", Cedula = 45768349, AreaConocimiento = "Historia" },
            new Profesor  { Nombre = "Ana", Apellido = "Mart�nez", Cedula = 4000329, AreaConocimiento = "Literatura" }
        };
        }
    }
}
    

