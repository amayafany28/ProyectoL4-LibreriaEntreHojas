using EntreHojas.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntreHojas.WebAdmin.Controllers
{
    public class ClientesController : Controller
    {
        private object clientesBL;
        ClientesBL _clientesBL;

        public ClientesController()
        {
            _clientesBL = new ClientesBL();
        }
        
           
    
        // GET: Clientes
        public ActionResult Index()
        {
            var listadeClientes = clientesBL.ObtenerCliente();
            return View(listadeClientes);
        }
        public ActionResult Crear ()
        {
            var nuevoCliente = new Cliente();

            return View(nuevoCliente);
        } 
        [HttpPost]
        public ActionResult Crear (Cliente cliente)
        {
            _clientesBL.GuardarCliente(cliente);
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id )

        {
           var cliente =  _clientesBL.ObtenerCliente(id);
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Editar (Cliente cliente)
        {
            _clientesBL.GuardarCliente(cliente);
            return RedirectToAction("Index");
        }
        public ActionResult Detalle(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);


            return View(cliente);
        }
        public ActionResult Eliminar(int id);
        {

        var cliente = _clientesBL.ObtenerCliente(id);
        return View(cliente);

        }
    ´public ActionResult Eliminar (Cliente cliente)
    {
        return RedirectToAction("Index");
    }
         

    }
}