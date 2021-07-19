using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPersons
{
    public class PersonAddressBuilder : PersonBuilder
    {
        /// <summary>
        /// It is critical that the base constructor is called – if it is not, the sub-builder 
        /// will call the parameterless constructor automatically, causing the unnecessary 
        /// instantiation of additional Person instance
        /// </summary>
        /// <param name="person"></param>
        public PersonAddressBuilder(Person person) : base(person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    };
}
