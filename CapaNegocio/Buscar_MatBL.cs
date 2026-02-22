using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Buscar_MatBL
    {
        public BuscarMat_prof prof = new BuscarMat_prof ();

        public DataTable MostrarMateriaProfesor(string nombre)
        {
                return prof.BuscarMat(nombre);
        }

        public DataTable ProfeMateria()
        {
            return prof.ProfeMateria();
        }

        public DataTable Seleccionar()
        {
            return prof.Seleccionar();  
        }

        public void AgregarMateria(Estudiante_Materia agregando)
        {
            prof.Guardar(agregando);
        }

        public DataTable Reporte(int Id_Estudiante)
        {
            return prof.Reporte(Id_Estudiante);
        }
    }

}
