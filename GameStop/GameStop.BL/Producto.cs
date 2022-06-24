using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;        
            
            }
        public int Id  { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la descrión")]
        [MinLength (3, ErrorMessage = "Ingrese minimo tres caracteres")]
        [MaxLength(15, ErrorMessage ="Solo se pueden ingresar maximo 15 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(3,1500, ErrorMessage ="Ingrese un precio entre 2 y 1500")]
        public double Precio { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
