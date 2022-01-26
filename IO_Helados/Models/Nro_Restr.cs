using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Nro_Restr
    {
        public int idRestr { get; set; }
        public int numero { get; set; }
        public Nro_Restr[] getAllNro_Restr()
        {
            return new DAO().getAllNro_Restr();
        }
    }
}