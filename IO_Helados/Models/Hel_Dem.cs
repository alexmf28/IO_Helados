using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class Hel_Dem
    {
        public int idHelado { get; set; }
        public int idRestr { get; set; }
        public string NHelado { get; set; }
        public int DemMinima { get; set; }
        public Hel_Dem[] getAllHel_Dem()
        {
            return new DAO().getAllHel_Dem();
        }
    }
}