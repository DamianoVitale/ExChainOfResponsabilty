using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChainOfResponsabilty
{
    public abstract class PasswordValidator
    {
        
        protected PasswordValidator? Next;
        
        


        public PasswordValidator Successor(PasswordValidator next) 
        {
            Next = next;
            return Next;
        }

        public abstract LogError Validate(string password, LogError? logError = null);
      
    }
}
