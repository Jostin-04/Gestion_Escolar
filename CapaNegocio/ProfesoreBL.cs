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
    public class ProfesoreBL
    {
        public ProfesoreDAL dal = new ProfesoreDAL();

        public List<Profesores> Listar()
        {
            return dal.Listar();
        }

        public void Guardar(Profesores profe)
        {
            dal.Insertar(profe);
        }

        public void Actualizar(Profesores profe)
        {
            dal.Actualizar(profe);
        }

        public void Eliminar(Profesores profe)
        {
            dal.Eliminar(profe);
        }
    }
}
