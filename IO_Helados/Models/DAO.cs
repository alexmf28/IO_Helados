using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Helados.Models
{
    public class DAO
    {
        //CRUD
        // Read
        public Helados[] getAllHelados()
        {
            dsHelados dsh = new dsHelados();
            dsHeladosTableAdapters.HeladosTableAdapter hta = new
                dsHeladosTableAdapters.HeladosTableAdapter();
            hta.Fill(dsh.Helados);
            Helados he;
            List<Helados> lista = new List<Helados>();
            foreach (dsHelados.HeladosRow fila in dsh.Helados.Rows)
            {
                he = new Helados()
                {
                    idHelado = fila.idHelado,
                    nombre = fila.nombre,
                };
                lista.Add(he);
            }
            return lista.ToArray();
        }
         //CRUD
    // Read
    public Ingredientes[] getAllIngredientes()
        {
        dsIngredientes dsi = new dsIngredientes();
        dsIngredientesTableAdapters.IngredientesTableAdapter ita = new
            dsIngredientesTableAdapters.IngredientesTableAdapter();
        ita.Fill(dsi.Ingredientes);
        Ingredientes ing;
        List<Ingredientes> lista = new List<Ingredientes>();
        foreach (dsIngredientes.IngredientesRow fila in dsi.Ingredientes.Rows)
        {
            ing = new Ingredientes()
            {
                idIngrediente = fila.idIngrediente,
                nombre = fila.nombre,
            };
            lista.Add(ing);
        }
        return lista.ToArray();
       }
        //CRUD
        // Read
        public Hel_Ing[] getAllHelIng()
        {
            dsHel_Ing dshi = new dsHel_Ing();
            dsHel_IngTableAdapters.Hel_IngTableAdapter hita = new
                dsHel_IngTableAdapters.Hel_IngTableAdapter();
            hita.Fill(dshi.Hel_Ing);
            Hel_Ing hi;
            List<Hel_Ing> lista = new List<Hel_Ing>();
            foreach (dsHel_Ing.Hel_IngRow fila in dshi.Hel_Ing.Rows)
            {
                hi = new Hel_Ing()
                {
                    idHelado = fila.idHelado,
                    idIngrediente = fila.idIngrediente,
                    NHelado = fila.NHelado,
                    NIngrediente = fila.NIngrediente,
                    CantRequerida = fila.CantRequerida,
                };
                lista.Add(hi);
            }
            return lista.ToArray();
        }
        //CRUD
        // Read
        public Ing_Und[] getAllIng_Und()
        {
            dsIng_Und dsiu = new dsIng_Und();
            dsIng_UndTableAdapters.Ing_UndTableAdapter iuta = new
                dsIng_UndTableAdapters.Ing_UndTableAdapter();
            iuta.Fill(dsiu.Ing_Und);
            Ing_Und iu;
            List<Ing_Und> lista = new List<Ing_Und>();
            foreach (dsIng_Und.Ing_UndRow fila in dsiu.Ing_Und.Rows)
            {
                iu = new Ing_Und()
                {
                    idIngrediente = fila.idIngrediente,
                    NIngrediente = fila.NIngrediente,
                    UndDisp = fila.UndDisp,                    
                };
                lista.Add(iu);
            }
            return lista.ToArray();
        }
        //CRUD
        // Read
        public Hel_Cant[] getAllHel_Cant()
        {
            dsHel_Cant dsheca = new dsHel_Cant();
            dsHel_CantTableAdapters.Hel_CantTableAdapter helca = new
                dsHel_CantTableAdapters.Hel_CantTableAdapter();
            helca.Fill(dsheca.Hel_Cant);
            Hel_Cant hec;
            List<Hel_Cant> lista = new List<Hel_Cant>();
            foreach (dsHel_Cant.Hel_CantRow fila in dsheca.Hel_Cant.Rows)
            {
                hec = new Hel_Cant()
                {
                    idHelado = fila.idHelado,
                    NHelado = fila.NHelado,
                    Cantidad_KG = fila.Cantidad_KG,
                };
                lista.Add(hec);
            }
            return lista.ToArray();
        }
        //CRUD
        // Read
        public Hel_Uti[] getAllHel_Uti()
        {
            dsHel_Uti dsheuti = new dsHel_Uti();
            dsHel_UtiTableAdapters.Hel_UtiTableAdapter heutita = new
                dsHel_UtiTableAdapters.Hel_UtiTableAdapter();
            heutita.Fill(dsheuti.Hel_Uti);
            Hel_Uti hut;
            List<Hel_Uti> lista = new List<Hel_Uti>();
            foreach (dsHel_Uti.Hel_UtiRow fila in dsheuti.Hel_Uti.Rows)
            {
                hut = new Hel_Uti()
                {
                    idHelado = fila.idHelado,
                    NHelado = fila.NHelado,
                    Utilidad = (float)fila.Utilidad,
                };
                lista.Add(hut);
            }
            return lista.ToArray();
        }
        //CRUD
        // Read
        public Nro_Restr[] getAllNro_Restr()
        {
            dsNro_Restr dsnres = new dsNro_Restr();
            dsNro_RestrTableAdapters.Nro_Restr_DemandaTableAdapter nresta = new
                dsNro_RestrTableAdapters.Nro_Restr_DemandaTableAdapter();
            nresta.Fill(dsnres.Nro_Restr_Demanda);
            Nro_Restr nre;
            List<Nro_Restr> lista = new List<Nro_Restr>();
            foreach (dsNro_Restr.Nro_Restr_DemandaRow fila in dsnres.Nro_Restr_Demanda.Rows)
            {
                nre = new Nro_Restr()
                {
                    idRestr = fila.idRestr,
                    numero = fila.numero,                    
                };
                lista.Add(nre);
            }
            return lista.ToArray();
        }
        //CRUD
        // Read
        public Hel_Dem[] getAllHel_Dem()
        {
            dsHel_Dem dsHel = new dsHel_Dem();
            dsHel_DemTableAdapters.Hel_DemTableAdapter hdemta = new
                dsHel_DemTableAdapters.Hel_DemTableAdapter();
            hdemta.Fill(dsHel.Hel_Dem);
            Hel_Dem hede;
            List<Hel_Dem> lista = new List<Hel_Dem>();
            foreach (dsHel_Dem.Hel_DemRow fila in dsHel.Hel_Dem.Rows)
            {
                hede = new Hel_Dem()
                {
                    idHelado = fila.idHelado,
                    idRestr = fila.idRestr,
                    NHelado = fila.NHelado,
                    DemMinima = fila.DemMinima,
                };
                lista.Add(hede);
            }
            return lista.ToArray();
        }
        //CRUD
        // Read
        public Dem_Hel[] getAllDem_Hel()
        {
            dsDem_Hel dsdem = new dsDem_Hel();
            dsDem_HelTableAdapters.Dem_HelTableAdapter deheta = new
                dsDem_HelTableAdapters.Dem_HelTableAdapter();
            deheta.Fill(dsdem.Dem_Hel);
            Dem_Hel dehe;
            List<Dem_Hel> lista = new List<Dem_Hel>();
            foreach (dsDem_Hel.Dem_HelRow fila in dsdem.Dem_Hel.Rows)
            {
                dehe = new Dem_Hel()
                {
                    idRestr = fila.idRestr,                   
                    Helados_a_producir = fila.Helados_a_producir,
                };
                lista.Add(dehe);
            }
            return lista.ToArray();
        }


    }


}