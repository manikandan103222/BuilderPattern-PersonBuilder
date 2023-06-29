using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Employee01 = new PersonBuilder("Mani").setCity("Chennai").setCountry("India").BuildEmployee();
            Console.WriteLine($"Employee Name: {Employee01.name}, Is Part Time Job: {Employee01.isPartTime}");
            Person Employee02 = new PersonBuilder("Kumar").setIsAdditionalBenefit(true).setPartTime(true).BuildEmployee();
            Console.WriteLine($"Employee Name: {Employee02.name}, Is Part Time Job: {Employee02.isPartTime}");

            Console.ReadLine();
        }
    }
}
