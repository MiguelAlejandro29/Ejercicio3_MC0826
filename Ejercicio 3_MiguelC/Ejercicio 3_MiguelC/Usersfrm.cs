using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_MiguelC
{
    public partial class Usersfrm : Form
    {
        public Usersfrm()
        {
            InitializeComponent();
        }

        DatosMySql usuarioDA = new DatosMySql();

        private void Usersfrm_Load(object sender, EventArgs e)
        {
            ListarUsuarios();

        }

        private void ListarUsuarios()
        {
            dataGridView1.DataSource = usuarioDA.ListaUsuarios();
        }
    }
}
