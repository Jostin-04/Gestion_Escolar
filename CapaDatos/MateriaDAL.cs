using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MateriaDAL
    {
        public List<Materia> Listar()
        {
            List<Materia> lista = new List<Materia>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Materia", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Materia
                    {
                        Id_Materia = (int)dr["Id_Materia"],
                        Nombre_Materia = dr["Nombre_Materia"].ToString(),
                    });
                }
            }
            return lista;
        }
    }
}
