using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaCalificada1.Models
{
    [Table("formulariopc1")]
    public class Formulario
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "Por favor ingrese su DNI")]
        [Display(Name="dni")]
         [Column("dni")]
        public String dni { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su nombre")]
        [Display(Name="nombre")]
         [Column("nombre")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su apellido")]
        [Display(Name="apellido")]
        [Column("apellido")]
        public String apellido { get; set; }

        [Required(ErrorMessage = "Por favor seleccione su distrito")]
        [Display(Name="distrito")]
        [Column("distrito")]
        public String distrito { get; set; }

        [Required(ErrorMessage = "Por favor seleccione su banco")]
        [Display(Name="banco")]
        [Column("banco")]
        public String banco { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su edad")]
        [Display(Name="edad")]
        [Column("edad")]
        public String edad { get; set; }

        [Required(ErrorMessage = "Por favor seleccione su genero")]
        [Display(Name="genero")]
        [Column("genero")]
        public String genero { get; set; }
        
        [NotMapped]
        public String Response { get; set; }
    }
}