using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStop.BL;

namespace GameStop.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();

        } 
        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductos();
            return View(listadeProductos);
        }

   
        public ActionResult Crear()
        {

            var nuevoProducto = new Producto();
            var categorias = _categoriasBL.ObtenerCategorias();
         
            ViewBag.ListaCategoria = new SelectList(categorias, "Id", "Descripcion");
            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear (Producto producto, HttpPostedFileBase imagen)
        {
            if(ModelState.IsValid) 
            {
                if (producto.CategoriaId == 0) 
                {
                    ModelState.AddModelError("CategoriaId", "Selecione una categoria");
                    return View(producto);
                }
                    if(imagen !=null )
                    {
                    producto.UrlImagen = GuardarImagen(imagen);
                    }

                _productosBL.GuardarProducto(producto);
                return RedirectToAction("Index");
            }

            var categorias = _categoriasBL.ObtenerCategorias();
            ViewBag.ListaCategoria = new SelectList(categorias, "Id", "Descripcion");

            return View(producto);
        }



        public ActionResult Editar (int id)
        {

            var producto = _productosBL.ObtenerProductos(id);
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar (Producto producto)
        {
            if (ModelState.IsValid)
            {
                if (producto.CategoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "Selecione una categoria");
                    return View(producto);
                }

                _productosBL.GuardarProducto(producto);
                return RedirectToAction("Index");
            }

            var categorias = _categoriasBL.ObtenerCategorias();
            ViewBag.ListaCategoria = new SelectList(categorias, "Id", "Descripcion");

            return View(producto);
        }

        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProductos(id);
           
            return View(producto);

        }

        public ActionResult Eliminar (int id)
        {
            var producto = _productosBL.ObtenerProductos(id);
           
            
            return View(producto);

        }
        [HttpPost]
        public ActionResult Eliminar (Producto producto)
        {

            _productosBL.EliminarProducto(producto.Id);
            return RedirectToAction("Index");
        }

        private string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);
            return "/Imagenes" + imagen.FileName;
        }

    }
}