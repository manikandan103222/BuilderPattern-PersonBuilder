using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBuilder
{
    public interface IPersonBuilder<T>
    {
        T setCity(string city);
        T setCountry(string country);
        T setAge(int age);
        T setPartTime(bool isPartTime);
    }
}
