using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChainOfResponsabilty
{
    internal class LengthValidator : PasswordValidator
    {

        public override LogError? Validate(string password, LogError? error = null)
        {
            if (error is null)
            {
                error = new LogError();
            }

            if (password.Length < 8)
            {
                error.isValid = false;
                error.errorMessage.Add("La password deve essere lunga almeno 8 caratteri");
            }
            return Next?.Validate(password, error);

        }
    }
}