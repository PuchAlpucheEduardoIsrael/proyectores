using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.Validations
{
    public class NoRepetirIdValidatorAttribute: ValidationAttribute
    {
        private IList<Proyector> _proyectores;

        public NoRepetirIdValidatorAttribute(
            IList<Proyector> proyectores)
        {
            _proyectores = proyectores;
        }

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;
            }

            return ValidationResult.Success;
        }
    }
}
