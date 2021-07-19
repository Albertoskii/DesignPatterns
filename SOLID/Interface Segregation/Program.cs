/*the idea here is to segregate parts of a complicated interface into separate 
 * interfaces so as to avoid forcing clients to implement functionality that 
 * they do not really need. Anytime when you write a plug-in for some 
 * complicated application and you're given an interface with 20 confusing
 * methods to implement with various no-ops and return nulls, more likely 
 * than not the API authors have violated the ISP.*/
using System;


namespace Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
