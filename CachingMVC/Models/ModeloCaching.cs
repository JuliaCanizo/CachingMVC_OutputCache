using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CachingMVC.Models
{
    public class ModeloCaching
    {
        ContextoBBDD contexto;
        public ModeloCaching()
        {
            contexto = new ContextoBBDD();
        }

        public List<GATOS> GetGatos()
        {
            var consulta = from datos in contexto.GATOS
                           select datos;
            return consulta.ToList();
        }
        
    }
}