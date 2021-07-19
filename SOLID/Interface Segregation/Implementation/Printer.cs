using Interface_Segregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Implementation
{
    public class Printer : IPrinter
    {
        public void Print(string s)
        {
            Console.WriteLine("Print completed");
        }
    }
}
