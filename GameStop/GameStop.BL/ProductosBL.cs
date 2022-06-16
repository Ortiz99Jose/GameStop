using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class ProductosBL

    {
        Contexto _contexto;
        public List<Producto>ListadeProductos { get; set; }


        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }
        public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos.ToList();
            return _contexto.Productos.ToList();

        }

        public void GuardarProducto(Producto producto)
        {
            _contexto.Productos.Add(producto);
            _contexto.SaveChanges();
        }
    }
}
