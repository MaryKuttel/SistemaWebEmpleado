using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class FechaDeNacimientoAttribute : ValidationAttribute
    {
        public FechaDeNacimientoAttribute()
        {
            ErrorMessage = "El año de nacimiento debe ser mayor de 2000";
        }

        public override bool IsValid(object value)
        {
            DateTime fechaNacimiento = (DateTime)value;
            int year = fechaNacimiento.Year;

            if (year <= 1999)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}