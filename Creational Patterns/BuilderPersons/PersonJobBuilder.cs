using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPersons
{
    public class PersonJobBuilder : PersonBuilder
    {
        /// <summary>
        /// It is critical that the base constructor is called – if it is not, the sub-builder 
        /// will call the parameterless constructor automatically, causing the unnecessary 
        /// instantiation of additional Person instance
        /// </summary>
        /// <param name="person"></param>
        public PersonJobBuilder(Person person) : base(person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int income)
        {
            person.AnnualIncome = income;
            return this;
        }

    }
}
