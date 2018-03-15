using CachingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CachingMVC.Controllers
{
    public class CachingController : Controller
    {
        ModeloCaching modelo;
        public CachingController()
        {
            modelo = new ModeloCaching();
        }
        //GET:CACHING
        [OutputCache (CacheProfile ="corto")]
        public ActionResult Index(String id)
        {
            ViewBag.Hora = "Hora del sistema: " + DateTime.Now.ToLongTimeString();
            List<GATOS> lista = modelo.GetGatos();
            return View(lista);
        }


        [OutputCache(Duration = 50, VaryByParam = "id",Location = OutputCacheLocation.Client, NoStore =true)]
        public ActionResult Details(String id)
        {

            ViewBag.Hora = "Hora del sistema: " + DateTime.Now.ToLongTimeString();
            GATOS gato = modelo.DetalleGato(id);
            return View(gato);
        }

    }
}