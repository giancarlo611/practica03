using System;
using System.ComponentModel.DataAnnotations;

namespace PC03_Program.Models
{
    public class Producto
    {
        public int Id {get;set;}
        
        [Required]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name="URL de la Imagen")]
        public string url {get; set;}

        [Required]
        [Display(Name="Descripción del producto")]
        public string descripcion {get; set;}

          [Required]
        [Display(Name="Categoria")]
        public string categoria {get; set;}

        [Required]
        [Display(Name="Precio del producto")]
        public double precio {get; set;}

        [Required]
        [Display(Name="Celular")]
         public string celular { get; set; }

         [Required]
         [Display(Name="Lugar de compra-")]
         public string lugar { get; set; }

         [Required]
         [Display(Name="Nombre Usuario")]
         public string user { get; set; }

         //DateTime today = DateTime.Today;
         public DateTime fecha { get; set; }
    }
}