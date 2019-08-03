using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_login.Controlador
{
    class constructotlogin
    {

        public static string usuario { get; set; }
        public string clave { get; set; }
        public static string nombre { get; set; }
        public static int nivel { get; set; }
        
        public constructotlogin(string usuario,string clave)
        {
            usuario = constructotlogin.usuario;
            clave = this.clave;
        }
        
    }
}
