using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.DTO;
using Shop.Negocio;

namespace ShopMVC.Controllers
{
    public class HomeController : Controller
    {

        ProductoNegocio prod = new ProductoNegocio();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ListaProductos = ProductoNegocio.ObtenerProductosAllNegocio().ToList();
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ProductoDTO producto)
        {

            prod.CrearProductoNegocio(producto);
            return RedirectToAction("Index");

        }
    }
}