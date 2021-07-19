/*
 The Builder pattern is concerned with the creation of complicated objects, that is,
 objects that cannot be built up in a single-line constructor call. These types of objects may 
 themselves be composed of other objects and might involve less-than-obvious logic, necessitating a 
 separate component specifically dedicated to object construction.
 */

using System;


namespace Builder
{

    class Program 
    {
        static void Main()
        {
            HtmlElement root = HtmlElement.Create("ul").AddChild("li", "hello").AddChild("li", "world").Build();
            Console.WriteLine(root);

        }
    }
}
