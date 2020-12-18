using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC3.Models
{
    //[Table("Tb_Registrar")]    
    public class Registrar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre de Producto")]   
        [Display(Name="Nombre de Producto: ")]
        [Column("Nombre")]
        public string Nombre { get; set; }
        
       
        public string url { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una Descripcion")]   
        [Display(Name="Descripcion: ")]
        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Precio")]   
        [Display(Name="Precio: ")]
        [Column("Precio")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una Direccion")]   
        [Display(Name="Direccion: ")]
        [Column("Direccion")]
        
        public string Direccion { get; set; }


        [Required(ErrorMessage = "Por favor ingrese un usuario")]   
        [Display(Name="usuario: ")]
        [Column("usuario")]
        
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Telefono")]   
        [Display(Name="Telefono: ")]
        [Column("Telefono")]
        
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Fecha")]   
        [Display(Name="Fecha: ")]
        [Column("Fecha")]
       public DateTime Fecha { get; set; }
        


    }
    
}