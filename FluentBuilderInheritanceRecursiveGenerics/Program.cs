using System;

namespace FluentBuilderInheritanceRecursiveGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = Person.New
                .Called("dmitri")
                .WorkAsA("quant")
                .Build();

            Console.WriteLine(builder);
        }
    }
}
