using static System.Console;

namespace FacetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives.At("London road 123")
                      .In("London")
                      .WithPostcode("sw1234")
                .Works.At("Fabrikam")
                      .AsA("Engineer")
                      .Earning(12342);
            WriteLine(person);
        }
    }
}
