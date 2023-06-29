using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBuilder
{
    public class Person
    {
        public string name;
        private string city;
        private string country;
        private int age;
        public bool isPartTime;
        private bool isAdditonalBenefit;

        public Person(string name, string city, string country, int age, bool isPartTime, bool isAdditionalBenefit)
        {
            this.name = name;
            this.city = city;
            this.country = country;
            this.age = age;
            this.isPartTime = isPartTime;
            this.isAdditonalBenefit = isAdditionalBenefit;
        }
    }
}
