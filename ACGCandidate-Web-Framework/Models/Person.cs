using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ACGCandidate_Web_Framework.Models
{
    [DataContract]
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _specialty;
        private string _favoriteColor;

        public Person(string firstName, string lastName, string spec, string color)
        {
            _firstName = firstName;
            _lastName = lastName;
            _specialty = spec;
            _favoriteColor = color;
        }

        [DataMember]
        public string FirstName { get => _firstName; set => _firstName = value; }
        [DataMember]

        public string LastName { get => _lastName; set => _lastName = value; }
        [DataMember]

        public string Specialty { get => _specialty; set => _specialty = value; }
        [DataMember]

        public string FavoriteColor { get => _favoriteColor; set => _favoriteColor = value; }
    }
}