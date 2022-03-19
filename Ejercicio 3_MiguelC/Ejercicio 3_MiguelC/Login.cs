using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Usuarios;
using Datos.Accesos;

namespace Ejercicio_3_MiguelC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            DatosMySql datosMysql = new DatosMySql();
            Usuario usuario = new Usuario();

            usuario = datosMysql.Login(usertxt.Text, passtxt.Text);

            //if (usuario == null)
            //{
            //    MessageBox.Show("Datos incorrectos");
            //    return;
            //}

            Usersfrm frmusers = new Usersfrm();
            frmusers.Show();
        }
    }
}
