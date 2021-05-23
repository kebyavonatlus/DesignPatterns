using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilder
{
    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<Person, Person>> actions
            = new List<Func<Person, Person>>();

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

        public TSelf Do(Action<Person> action) => AddAction(action);

        private TSelf AddAction(Action<Person> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });

            return (TSelf)this;
        }
    }
}
