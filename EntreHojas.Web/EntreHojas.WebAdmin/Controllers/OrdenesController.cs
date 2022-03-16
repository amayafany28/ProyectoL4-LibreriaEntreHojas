using EntreHojas.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntreHojas.WebAdmin.Controllers
{
    public class OrdenesController : Controller
    {
        OrdenesBL _ordenesBL;
    }

        // GET: Ordenes
        public ActionResult Index()
        {
        var listadeOrdenes = _ordenesBL.ObtenerOrdenes();
         return View(listadeOrdenes);
        }
    }
}