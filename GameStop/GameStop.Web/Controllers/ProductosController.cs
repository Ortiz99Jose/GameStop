using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStop.Web.Models;

namespace GameStop.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Fifa 2022";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Gta San andrea";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Gta V";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pesp 2021 ";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);


            return View(listadeProductos);
        }
    }
}