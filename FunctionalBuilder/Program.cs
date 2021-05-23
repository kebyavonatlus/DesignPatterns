namespace FunctionalBuilder
{
    class Program
    {
        //public sealed class PersonBuilder
        //{
        //    private readonly List<Func<Person, Person>> actions
        //        = new List<Func<Person, Person>>();

        //    public PersonBuilder Called(string name) => Do(p => p.Name = name);

        //    public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

        //    public PersonBuilder Do(Action<Person> action) => AddAction(action);

        //    private PersonBuilder AddAction(Action<Person> action)
        //    {
        //        actions.Add(p =>
        //        {
        //            action(p);
        //            return p;
        //        });

        //        return this;
        //    }
        //}

        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Sarah")
                .WorkAs("Developer")
                .Build();
        }
    }
}
