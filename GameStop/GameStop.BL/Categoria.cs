﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class Categoria
    {
        public int Id { get; set; }
            
        [Required(ErrorMessage = "Ingrese una cayegoria por favor")]
        public string Descripcion { get; set; }
    }
}