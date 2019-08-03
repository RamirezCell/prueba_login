using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_login.serviciosemail
{
    class emailsistema:correoserver
    {
        public emailsistema()
        {
            sendermail = "diegosay777@gmail.com";
            password = "HAILLH34";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            initializesmtpclient();
        }
    }
}
