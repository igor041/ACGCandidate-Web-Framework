using ACGCandidate_Web_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACGCandidate_Web_Framework.Repos
{
    public class ValuesRepo : IValuesRepo
    {
        public IList<Person> GetPersons()
        {
            // Mock up some data here
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Igor", "Cosic", "coder extraoridanire", "blue"));
            persons.Add(new Person("Jon", "Osterbrock", "coder extraoridanire", "red"));
            persons.Add(new Person("Jeff", "Langston", "supervisor extraoridanire", "blue"));
            persons.Add(new Person("Bob", "Loblaw", "esquire", "orange"));

            return persons;
        }

        public static IList<Person> GetPersonsStatic()
        {
            // Mock up some data here
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Igor", "Cosic", "coder extraoridanire", "blue"));
            persons.Add(new Person("Jon", "Osterbrock", "coder extraoridanire", "red"));
            persons.Add(new Person("Jeff", "Langston", "supervisor extraoridanire", "blue"));
            persons.Add(new Person("Bob", "Loblaw", "esquire", "orange"));

            return persons;
        }
    }
}