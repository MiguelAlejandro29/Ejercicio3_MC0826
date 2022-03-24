using Datos.Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class DatosMySql
    {
        readonly string cadena = "Server=127.0.0.1; Port=3306; Database=ejercicio3.1; Uid=root; Pwd=queremosla12; ";

        MySqlConnection conn;
        MySqlCommand cmd;


        public Usuario Login(string user, string pass)
        {
           Usuario usuario = null;

            try
            {
                string sql = "SELECT * FROM usuarios WHERE User = @User AND Pass = @Pass;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@Pass", pass);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.User = reader[0].ToString();
                    usuario.Pass = reader[1].ToString();
                    usuario.Nombre = reader[2].ToString();
                    
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {


            }
            return usuario;
        }

        public DataTable ListaUsuarios()
        {
            DataTable ListaUsuariosdt = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuarios;*";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                ListaUsuariosdt.Load(reader);

            }
            catch (Exception ex)
            {


            }
            return ListaUsuariosdt;

        }

    }
}
