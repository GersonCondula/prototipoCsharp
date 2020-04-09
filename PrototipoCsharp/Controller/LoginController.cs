using System;
using System.Data.OleDb;
using System.Windows.Forms;
using PrototipoCsharp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoCsharp.Controller
{
    class LoginController
    {
        public static Login EfectuaLogin()
        {
            Login login = new Login();
            try
            {
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return login;
        }
    }
}
