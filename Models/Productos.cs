using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemploproducto.Models
{
    public class Productos
    {
        [Key]
        [Required(ErrorMessage = "Este campo no puede estar vacío!")]
        [Range(0, 10000, ErrorMessage = "Este campo debe ser mayor a 0.")]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacío!")]
        [MinLength(1, ErrorMessage = "Este campo debe tener como mínimo 10 caracteres.")]
        public string Descripcion { get; set; }
       
        [Range(0, 100000, ErrorMessage = "Este campo debe ser mayor a 0.")]
        public float Existencia { get; set; }
        [Range(0, 100000, ErrorMessage = "Este campo debe ser mayor a 0.")]
        public float Costo { get; set; }
        [Range(0, 100000, ErrorMessage = "Este campo debe ser mayor a 0.")]
        public float  valorInventario { get; set; }

    }
}
