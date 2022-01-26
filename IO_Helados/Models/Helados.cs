using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Helados
    {        
        public int idHelado { get; set; }
        public string nombre { get; set; }


        public Helados[] getAllHelados()
        {
            return new DAO().getAllHelados();
        }
    }
}