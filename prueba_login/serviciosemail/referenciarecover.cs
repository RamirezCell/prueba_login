using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Modelo;


namespace prueba_login.serviciosemail
{
    class referenciarecover
    {
        public string recovery(string solicitud, string pass)
        {
            return validarlogin.recover(solicitud,pass);
        }
    }
}
