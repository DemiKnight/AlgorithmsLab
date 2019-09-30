using System;

namespace Lec2
{
    public class Person : IComparable
    {
        private short age;
        private string name;

        private static readonly Person DEFAULT_PERSON = new Person("John Smith", 20);


        public Person(string newName)
        {
            this.name = newName;
            this.age = DEFAULT_PERSON.age;
        }

        public Person(string newName, short newAge)
        {
            this.name = newName;
            this.age = newAge;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public short Age
        {
            get => age;
            set => age = value;
        }

        public Person DefaultPerson
        {
            get => DEFAULT_PERSON;
        }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}