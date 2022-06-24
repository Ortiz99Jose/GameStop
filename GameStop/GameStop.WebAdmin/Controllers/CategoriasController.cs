using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStop.BL;

namespace GameStop.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();
            return View(listadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevaCategoria = new Categoria();
            return View(nuevaCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {

            if(ModelState.IsValid) 
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim()) 
                {
                    ModelState.AddModelError("Descripcion", "La descripcion no debe contener espacios al inicio o final de cada palabra");
                    return View(categoria);
                 }
                _categoriasBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Editar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripcion no debe contener espacios al inicio o final de cada palabra");
                    return View(categoria);
                }
                _categoriasBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Detalle(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);

        }
        [HttpPost]
        public ActionResult Eliminar(Categoria producto)
        {
            _categoriasBL.EliminarCategoria(producto.Id);
            return RedirectToAction("Index");
        }
    }
}