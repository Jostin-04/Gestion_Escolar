using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Estudiante
    {
        public int Id_Estudiante {  get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public int ID_Area_tecnica { get; set; }

        public bool Estado { get; set; }    

    }

    public class EstudianteAreaTecnica
    {
        public int Id_Estudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Area_Tecnica { get; set; }
    }

    public class Area_Tecnica
    {
        public int Id_Area_Tecnica { get; set; }

        public string Area_tecnica { get; set; }
    }

    public class Materia
    {
        public int Id_Materia { get; set; }

        public string Nombre_Materia { get; set; }
    }

    public class Materia_profe
    {
        public int Id_profesor { get; set; }

        public string Nombre_prof { get; set; }

        public int Id_Materia { get; set; }

        public string Nombre_Materia { get; set; }
    }

    public class Estudiante_Materia
    {
        public int Id_Estudiantes_Mat { get; set; }

        public int Id_Estudiante { get; set; }

        public int Id_Materia { get; set; }

        public int Id_profesor { get; set; }
    }

    public class Profesores
    {
        public int Id_profesor { get; set; }

        public string Nombre_prof {  get; set; }

        public string Apellido_prof { get; set; }

        public string Direccion {  get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
    }

    public class Profesor_Materia
    {
        public int Id_Profesor_materia { get; set; }

        public int Id_profesor { get; set; }

        public int Id_Materia { get; set; }
    }

    public class BuscarMat
    {
        public int Id_Estudiante { get; set; }

        public string Nombre { get; set; }

        public string Area_tecnica { get; set; }

        public int Id_profesor { get; set; }

        public string Nombre_prof { get; set; }

        public int Id_Materia { get; set; }

        public string Nombre_Materia { get; set; }
    }
}
