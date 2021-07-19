using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class OldFashionedPrinter : IMachine
    {
        public void Fax(string d)
        {
            Console.WriteLine("Fax completed");
        }

        public void Print(string d)
        {
            throw new NotImplementedException();
        }

        public void Scan(string d)
        {
            throw new NotImplementedException();
        }
    }
}
