using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;


namespace CapaDatos
{
    public class EstudianteDAL
    {
        public List<EstudianteAreaTecnica> Listar()
        {
            List<EstudianteAreaTecnica> lista = new List<EstudianteAreaTecnica>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_listar_estudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EstudianteAreaTecnica
                    {
                        Id_Estudiante = (int)dr["Id_Estudiante"],
                        Nombre = dr["Nombre"].ToString(),
                        Apellidos = dr["Apellidos"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString(),
                        Area_Tecnica = dr["Area_tecnica"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insertar(Estudiante estudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_insertar_estudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_est", estudiante.Nombre);
                cmd.Parameters.AddWithValue("@Apellido_est", estudiante.Apellidos);
                cmd.Parameters.AddWithValue("@direccion_est ", estudiante.Direccion);
                cmd.Parameters.AddWithValue("@telefono_est ", estudiante.Telefono);
                cmd.Parameters.AddWithValue("@email_est ", estudiante.Email);
                cmd.Parameters.AddWithValue("@area_est ", estudiante.ID_Area_tecnica);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Estudiante estudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_actualizar_estudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_estudiante", estudiante.Id_Estudiante);
                cmd.Parameters.AddWithValue("@nombre_est", estudiante.Nombre);
                cmd.Parameters.AddWithValue("@Apellido_est", estudiante.Apellidos);
                cmd.Parameters.AddWithValue("@direccion_est", estudiante.Direccion);
                cmd.Parameters.AddWithValue("@telefono_est", estudiante.Telefono);
                cmd.Parameters.AddWithValue("@email_est", estudiante.Email);
                cmd.Parameters.AddWithValue("@area_est", estudiante.ID_Area_tecnica);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(Estudiante estudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_eliminar_estudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Estudiante", estudiante.Id_Estudiante);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Buscar(string texto)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("BarradeBusqueda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

    }

}
