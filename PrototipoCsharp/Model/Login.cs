using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoCsharp.Model
{
    class Login
    {
        public static int ID { get; set; }
        public static string Nome { get; set; }
        public static string Senha { get; set; }
        public static DateTime DataRegisto { get; set; }
        public static DateTime DataActualizacao { get; set; }
        public static bool Status { get; set; }
    }
}