using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaCalificada1.Models
{
    [Table("formulariopc1")]
    public class Formulario
    {

        [Required(ErrorMessage = "Por favor ingrese su DNI")]
        [Display(Name="DNI")]
         [Column("dni")]
        public int dni { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su nombre")]
        [Display(Name="Nombre")]
         [Column("nombre")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su apellido")]
        [Display(Name="Apellido")]
        [Column("apellido")]
        public String apellido { get; set; }

        [Required(ErrorMessage = "Por favor seleccione su distrito")]
        [Display(Name="Distrito")]
        [Column("distrito")]
        public String distrito { get; set; }

        [Required(ErrorMessage = "Por favor seleccione su banco")]
        [Display(Name="Banco")]
        [Column("banco")]
        public String banco { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su edad")]
        [Display(Name="Edad")]
        [Column("edad")]
        public int edad { get; set; }

        [Required(ErrorMessage = "Por favor seleccione su genero")]
        [Display(Name="Genero")]
        [Column("genero")]
        public String genero { get; set; }
        
        [NotMapped]
        public String Response { get; set; }
    }
}