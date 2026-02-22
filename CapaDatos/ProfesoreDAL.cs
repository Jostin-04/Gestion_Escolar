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
    public class ProfesoreDAL
    {
        public List<Profesores> Listar()
        {
            List<Profesores> lista = new List<Profesores>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_listar_profesore", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Profesores
                    {
                        Id_profesor = (int)dr["Id_profesor"],
                        Nombre_prof = dr["Nombre_prof"].ToString(),
                        Apellido_prof = dr["Apellido_prof"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insertar(Profesores profe)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_insertar_profesore", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_prof", profe.Nombre_prof);
                cmd.Parameters.AddWithValue("@apellido_prof", profe.Apellido_prof);
                cmd.Parameters.AddWithValue("@direccion_prof", profe.Direccion);
                cmd.Parameters.AddWithValue("@telefono_prof", profe.Telefono);
                cmd.Parameters.AddWithValue("@email_prof", profe.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Profesores profe)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_actualizar_profesore", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_profesor", profe.Id_profesor);
                cmd.Parameters.AddWithValue("@nombre_prof", profe.Nombre_prof);
                cmd.Parameters.AddWithValue("@apellido_prof", profe.Apellido_prof);
                cmd.Parameters.AddWithValue("@direccion_prof", profe.Direccion);
                cmd.Parameters.AddWithValue("@telefono_prof", profe.Telefono);
                cmd.Parameters.AddWithValue("@email_prof", profe.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(Profesores profe)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_eliminar_profesor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Profesor", profe.Id_profesor);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
