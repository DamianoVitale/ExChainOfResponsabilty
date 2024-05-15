using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChainOfResponsabilty
{
    internal class DigitValidator : PasswordValidator
    {
        public override LogError? Validate(string password, LogError error)
        {
            short count = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            if (count < 2)
            {
                error.isValid = false;
                error.errorMessage.Add("La password deve contenere almeno 2 numeri"); ;

            }
             return Next?.Validate(password, error);
            
        }
    }
}
