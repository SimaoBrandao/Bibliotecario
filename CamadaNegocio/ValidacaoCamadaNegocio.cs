using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CamadaNegocio
{
    public class ValidacaoCamadaNegocio 
    {
        public ICollection<ValidationResult> ValidationResults { get; private set; }       
        public bool IsValid(object obj)
        {
            ValidationResults = new List<ValidationResult>();
            return Validator.TryValidateObject(obj, new ValidationContext(obj), ValidationResults, true);
        }
        public string ErrorMessages()
        {
            var erros = ValidationResults;
            foreach (var error in erros)
            {
                return error.ErrorMessage;
            }

            return null;
        }

    }
}
