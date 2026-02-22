using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public class BuscarMat_prof
     {

        public DataTable BuscarMat (string nombreEstudiante)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MostrarMateriaYProfesor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreEstudiante", nombreEstudiante);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ProfeMateria()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MateriaProfe", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Seleccionar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("[dbo].[SelecionarEstudiante]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public void Guardar(Estudiante_Materia agregando)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "[dbo].[sp_Insertar_Est_Mat]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_estudiante", agregando.Id_Estudiante);
                cmd.Parameters.AddWithValue("@id_materia", agregando.Id_Materia);
                cmd.Parameters.AddWithValue("@id_profesor", agregando.Id_profesor);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Reporte( int Id_Estudiante)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MateriaEstudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estudiante", Id_Estudiante);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt; 
        }

    }
}
