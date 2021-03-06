using static System.Console;

namespace ThroughSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] {"John", "Smith"},
                new Address("London", 1234));

            var jane = john.DeepCopyXml();

            jane.Address.HouseNumber = 121212;
            jane.Names[0] = "Jane";
             
            WriteLine(john);
            WriteLine(jane);
        }
    }
}
