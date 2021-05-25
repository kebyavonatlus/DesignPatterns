using static System.Console;

namespace ICloneableIsBad
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] {"John", "Smith"},
                new Address("London", 1234));
            var jane = new Person(john) {Address = {HouseNumber = 1111}, Names = {[0] = "Jane"}};

             
            WriteLine(john);
            WriteLine(jane);
        }
    }
}
