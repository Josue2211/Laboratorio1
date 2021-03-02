using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.NEGOCIO
{
    class ClsLogin
    {

        ClsListadeUsuarios cls = new ClsListadeUsuarios();


        public Boolean acceso(Login log)
        {
            
            for (int i = 0; i < cls.user.Length; i++) { 
            if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i]))
                {
                    return true;
                }
                }
            return false;
        }
     }
}
