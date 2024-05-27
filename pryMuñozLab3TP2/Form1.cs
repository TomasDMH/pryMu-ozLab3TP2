using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using pryMuñozLab3TP2.pryInicioSesionLogs;

namespace pryMuñozLab3TP2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void encontrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void noTieneUnaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            string nombreUsser = txtNombreIS.Text;
            string passUser = txtContraseña.Text;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:D:\Escritorio\PedidoDePrograma\Archivos\BDUsuarios.accdb;";

            OleDbConnection accesoDatos = new OleDbConnection(connectionString);
            accesoDatos.Add(nombreUsser, passUser);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
