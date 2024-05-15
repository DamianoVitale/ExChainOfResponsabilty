using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExChainOfResponsabilty
{
    internal class SpecialValidator : PasswordValidator
    {
        public override LogError? Validate(string password, LogError error)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            Match match = regex.Match(password);

            if (!match.Success)
            {
                error.isValid = false;
                error.errorMessage.Add("La password deve contenere almeno un carattere speciale");
            }
           return error;
        }
    }
}
