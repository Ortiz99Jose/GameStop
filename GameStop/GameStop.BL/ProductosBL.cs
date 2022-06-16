using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Fifa 2022";
            producto1.Precio = 999;


            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Gta San andrea";
            producto1.Precio = 450;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Gta V";
            producto1.Precio = 1500;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Pesp 2021 ";
            producto1.Precio = 950;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);


            return listadeProductos;
        }
    }
}
