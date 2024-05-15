using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChainOfResponsabilty
{
    internal class UpperValidator : PasswordValidator
    {
        public override LogError? Validate(string password, LogError error)
        {

            if (!password.Any(char.IsUpper))
            {
                error.isValid = false;
                error.errorMessage.Add("La password deve contenere almeno una lettera maiuscola"); 
            }
            
            return Next?.Validate(password, error);
             
        }
    }
}
