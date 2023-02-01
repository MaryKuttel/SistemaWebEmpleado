using System.ComponentModel.DataAnnotations;
using System;
using SistemaWebEmpleado.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        public int DNI { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression("([A]{2})+([1-9]{5})")]
        public string Legajo { get; set; }


        [FechaDeNacimiento]
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }
    }
}
