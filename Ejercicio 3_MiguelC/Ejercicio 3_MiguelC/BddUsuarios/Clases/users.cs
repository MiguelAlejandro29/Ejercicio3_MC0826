using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddUsuarios.Clases
{
    public class users
    {
        public string User { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }

        public users()
        {
        }

        public users(string user, string nombre, string pass)
        {
            User = user;
            Nombre = nombre;
            Pass = pass;
        }
    }
}
