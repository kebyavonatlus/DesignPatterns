using System;

namespace ThroughSerialization
{
    public class Person
    {
        public string[] Names;
        public Address Address;

        public Person()
        {
            
        }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person(Person other)
        {
            Names = other.Names;
            Address = new Address(other.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
        }
    }
}
