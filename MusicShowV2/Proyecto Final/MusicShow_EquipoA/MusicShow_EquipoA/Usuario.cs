using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Lab_Interfaces;
namespace MusicShow_EquipoA
{
    public class Usuario
    {
        String tipoAn;
        AccesoBaseDatos bd;

        /// Constructor de la clase Usuario
        public Usuario()
        {
            // Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
            tipoAn = "";
        }

        public int AgregarAnunciante(string nombre, string tipo){
            String insertar = "exec agregarAnunciante @Name = '" + nombre + "' , @Type = '" + tipo + "';"; 
            return bd.ActualizarDatos(insertar);
        }



        /*public int AgregarBuscador(string nombre, string email){
            
            //return bd.ActualizarDatos(insertar);
        }*/


        public SqlDataReader ObtenerListaNombresUsuarios()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.EjecutarConsulta("SELECT DISTINCT Nombre FROM Usuario");
            }
            catch (SqlException ex)
            {
            }
            return datos;
        }

        public DataTable ObtenerUsuarios(string filtroNombre, string filtroGeneral)
        {
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los Usuarios de la base de datos
            if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.EjecutarConsultaTabla("SELECT * FROM Usuario" );
            }
                //Si el filtro de nombre no es nulo carga los Usuarios cuyo nombre sea el que
                //tiene el filtro
            else if (filtroGeneral != null)
                {
                    /*tabla = bd.EjecutarConsultaTabla("SELECT * FROM Usuario WHERE Nombre = '" 
                        + filtroGeneral + "'" );*/
                  tabla = bd.EjecutarConsultaTabla("SELECT * FROM Usuario WHERE Nombre LIKE '%" +
                filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral +
                "%' OR apellido2 like '%" + filtroGeneral + "%' OR Cedula like '%"
                + filtroGeneral + "%' OR Carné like '%" + filtroGeneral + "%'");
                }
                //Si el filtro general no es nulo cargan los Usuarios con
                //atributos que contengan ese filtro como parte del atributo(like)
                else if (filtroNombre != null)
                {
                    /*tabla = bd.EjecutarConsultaTabla("SELECT * FROM Usuario WHERE Nombre LIKE '%"
                        + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral 
                        + "%' OR Apellido2 LIKE '%" + filtroGeneral + "%' OR Cedula LIKE '%" + 
                        filtroGeneral + "%' OR Carné LIKE '%" + filtroGeneral + "%'");*/
                    tabla = bd.EjecutarConsultaTabla("SELECT * FROM Usuario WHERE Nombre = '"
                    + filtroNombre + "'");
                }
                //Si ninguno de los filtros es nulo carga los Usuarios que
                //coincidan con ambos filtros
                else if (filtroGeneral != null && filtroNombre != null)
                {
                    tabla = bd.EjecutarConsultaTabla("Select * from Usuario where Nombre = '" 
                        + filtroNombre + "' && Nombre like '%" +
                    filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral +
                    "%' OR apellido2 like '%" + filtroGeneral + "%' OR Cedula like '%" 
                    + filtroGeneral + "%' OR Carné like '%" + filtroGeneral + "%'");
                }
            }
            catch (SqlException ex)
            {
            }
            return tabla;
        }

    }

}
