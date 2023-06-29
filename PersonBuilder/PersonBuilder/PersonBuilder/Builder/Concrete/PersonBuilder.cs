using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PersonBuilder
{
    public class PersonBuilder: IPersonBuilder<PersonBuilder>
    {
        private string name;
        private string city;
        private string country;
        private int age;
        private bool isPartTime;
        private bool isAdditonalBenefit;

        public PersonBuilder(string name)
        {
            this.name = name;
        }

        public PersonBuilder setCity(string city)
        {
            this.city = city;
            return this;
        }

        public PersonBuilder setCountry(string country)
        {
            this.country = country;
            return this;
        }

        public PersonBuilder setAge(int age)
        {
            this.age = age;
            return this;
        }

        public PersonBuilder setPartTime(bool isPartTime)
        {
            this.isPartTime = isPartTime;
            return this;
        }

        public PersonBuilder setIsAdditionalBenefit(bool isAdditionalBenefit)
        {
            this.isAdditonalBenefit = isAdditionalBenefit;
            return this;
        }

        public Person BuildEmployee()
        {
            return new Person(name, city, country, age, isPartTime, isAdditonalBenefit);
        }


    }
}
