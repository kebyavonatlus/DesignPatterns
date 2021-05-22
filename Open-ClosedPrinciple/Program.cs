﻿using System.Collections;
using static System.Console;

namespace Open_ClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            WriteLine("Green products (old):");

            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            WriteLine("Green products (new):");
            foreach (var item in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                WriteLine($" - {item.Name} is green");
            }

            WriteLine("Large blue items");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
}
