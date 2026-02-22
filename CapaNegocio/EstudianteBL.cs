using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class EstudianteBl
    {
        public EstudianteDAL dal = new EstudianteDAL();

        public List<EstudianteAreaTecnica> Listar()
        {
            return dal.Listar();
        }

        public void Guardar(Estudiante estudiante)
        {
                dal.Insertar(estudiante);
        }

        public void Actualizar(Estudiante estudiante)
        {
            dal.Actualizar(estudiante);
        }

        public void Eliminar(Estudiante estudiante)
        {
            dal.Eliminar(estudiante);
        }

        public DataTable Buscar (string texto)
        {
            return dal.Buscar(texto);
        }
    }
}

