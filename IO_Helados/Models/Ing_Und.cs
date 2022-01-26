using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Ing_Und
    {
        public int idIngrediente { get; set; }        
        public string NIngrediente { get; set; }
        public int UndDisp { get; set; }


        public Ing_Und[] getAllIng_Und()
        {
            return new DAO().getAllIng_Und();
        }
    }
}