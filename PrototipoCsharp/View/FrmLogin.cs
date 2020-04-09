using System;
using System.Windows.Forms;
using System.Data.OleDb;
using PrototipoCsharp.Connection;

namespace PrototipoCsharp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection.TestConnection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
