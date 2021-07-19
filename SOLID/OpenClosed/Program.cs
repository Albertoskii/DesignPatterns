using System;

namespace OP
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var bf = new BetterFilter();
            Console.WriteLine("Green products:");
            var largeGreenSpec = new ColorSpecification(Color.Green) & new SizeSpecification(Size.Large);

            foreach (var p in bf.Filter(products, largeGreenSpec))
                Console.WriteLine($"{p.Name} is large and green");
                
        }
    }
}
