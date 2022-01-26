using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Hel_Uti
    {
        public int idHelado { get; set; }
        public string NHelado { get; set; }
        public float Utilidad { get; set; }

        public Hel_Uti[] getAllHel_Uti()
        {
            return new DAO().getAllHel_Uti();
        }
    }
}