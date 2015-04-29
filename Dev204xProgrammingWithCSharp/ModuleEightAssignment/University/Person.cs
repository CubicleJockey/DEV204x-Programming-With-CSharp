using System;

namespace ModuleEightAssignment.University
{
    public abstract class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateTime Birthday { get; protected set; }
        public string Address { get; protected set; }
        public string Address1 { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string Zip { get; protected set; }
        public string Country { get; protected set; }
    }
}
