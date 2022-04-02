using EntreHojas.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntreHojas.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            return View(listadeProductos);
        }
    }
}