using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChainOfResponsabilty
{
    public class LogError
    {
        public List<string> errorMessage {  get; set; } = new List<string>();
        public bool isValid { get; set; } = true;

        public void Print()
        {
            foreach (var item in errorMessage)
            {
                Console.WriteLine(item);
            }
        }
    }
}
