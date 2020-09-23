using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Pages
{
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 7, 10 };
            yield return new object[] { 5, -2, 3 };
            yield return new object[] { 2, 2, 4 };
        }
        IEnumerator IEnumerable.GetEnumerator()=> GetEnumerator();
    }
}
