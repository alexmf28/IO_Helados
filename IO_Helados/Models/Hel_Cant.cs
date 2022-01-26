using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Hel_Cant
    {
        public int idHelado { get; set; }
        public string NHelado { get; set; }
        public double Cantidad_KG { get; set; }

        public Hel_Cant[] getAllHel_Cant()
        {
            return new DAO().getAllHel_Cant();
        }
    }
}