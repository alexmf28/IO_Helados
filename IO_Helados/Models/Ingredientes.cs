using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Ingredientes
    {
        public int idIngrediente { get; set; }
        public string nombre { get; set; }

        public Ingredientes[] getAllIngredientes()
        {
            return new DAO().getAllIngredientes();
        }
    }
}