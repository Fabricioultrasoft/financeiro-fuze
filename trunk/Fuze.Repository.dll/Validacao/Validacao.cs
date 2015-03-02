using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Fuze.Repository.dll.Validacao
{
    public static class Validacao
    {
        public static IEnumerable<ValidationResult> getErroValidacao(Object obj)
        {
            var resultado = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultado, true);
            return resultado;
        }
    }
}
