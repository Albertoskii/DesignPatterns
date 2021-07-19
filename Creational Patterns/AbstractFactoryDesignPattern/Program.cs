using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee("267543", "Tom", 5000);
            Employee emp2 = new ContractEmployee("953456", "Ketty", 30);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
    }
}
