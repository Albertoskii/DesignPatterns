/*
 High-level modules should not depend on low-level modules. Both should depend on abstractions.
    - What this statement basically means is that, if you're interested in logging, your reporting component should not depend on
    a concrete ConsoleLogger, but can depend on an ILogger interface. In this case, we are considering the reporting component
    to be high-level (closer to the business domain), whereas logging, being a fundamental concern (kind of like file I/O or threading, 
    but not quite), is considered a low-level module.
 Abstractions should not depend on details. Details should depend on abstractions.
    This is, once again, restating that dependencies on interfaces or base classes are better than 
    dependencies on concrete types. Hopefully the truth of this statement is obvious, because such an 
    approach supports better configurability and testability… especially if you are using a good framework to handle these dependencies for you.
 */

using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
