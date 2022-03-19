using BddUsuarios.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddUsuarios.Accesos
{
    public class DatosBD
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=ejercicio3mc; Uid=root; Pwd=queremosla12; ";

        MySqlConnection conect;
        MySqlCommand cmd;

        
        public users Login(string user, string pass)
        {
            users usuario = null;

            try
            {
                string sql = "SELECT * FROM users WHERE User = @User, Pass = @Pass;";

                conect = new MySqlConnection(cadena);
                conect.Open();

                cmd = new MySqlCommand(sql, conect);
                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@Pass", pass);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   usuario = new users();
                    usuario.User = reader[0].ToString();
                    usuario.Nombre = reader[2].ToString();
                    usuario.Pass = reader[1].ToString();  
                }
                reader.Close();
                conect.Close();

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
                    string sql = "SELECT * FROM usuarios;";
                    conect = new MySqlConnection(cadena);
                    conect.Open();

                    cmd= new MySqlCommand(sql, conect);

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

   
