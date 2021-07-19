using Interface_Segregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Implementation
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        // compose this out of several modules
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(string d)
        {
            printer.Print(d);
        }

        public void Scan(string d)
        {
            scanner.Scan(d);
        }
    }
}