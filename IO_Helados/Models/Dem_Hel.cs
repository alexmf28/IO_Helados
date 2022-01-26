using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Dem_Hel
    {
        public int idRestr { get; set; }
        public int Helados_a_producir { get; set; }
        public Dem_Hel[] getAllDem_Hel()
        {
            return new DAO().getAllDem_Hel();
        }
    }
}