using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PrototipoCsharp.Connection
{
    class MySqlConnection
    {        
        public static OleDbConnection MyOleDbConnection()
        {
            OleDbConnection dbConnection = null;
            try
            {
                String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                          "Data Source=E:/Project/Linguagens/VisualBasic/PrototipoCsharpDB/prototipo.accdb;" +
                                          "Persist Security Info=False;";
                dbConnection = new OleDbConnection(connectionString);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dbConnection;
        }

        public static void TestConnection()
        {
            OleDbConnection oleDbConnection = MyOleDbConnection();
            oleDbConnection.Open();
            if (oleDbConnection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Seja bem vindo ao prototipo, espero que ajude a desenvolver grandes coisas!");
                oleDbConnection.Close();
            }
            else
            {
                MessageBox.Show("Conecção efectuada sem sucesso! reveja as configurações ou contacte o Administrador do sistema> +258846456153");
                oleDbConnection.Close();
                Application.Exit();
            }                        
        }
    }
}
