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

        ClsListadeUsuarios DAO = new ClsListadeUsuarios();


        public Boolean acceso(Login log)
        {
            
            for (int i = 0; i < DAO.users.Length; i++) { 
            if (log.Usuario.Equals(DAO.users[i]) && log.Password.Equals(DAO.pass[i]))
                {
                    return true;
                }
                }
            return false;
        }
     }
}
