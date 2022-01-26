using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Hel_Ing
    {
        public int idHelado { get; set; }
        public int idIngrediente { get; set; }
        public string NHelado { get; set; }
        public string NIngrediente { get; set; }
        public int CantRequerida { get; set; }


        public Hel_Ing[] getAllHelIng()
        {
            return new DAO().getAllHelIng();
        }
    }
}