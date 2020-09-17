using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Pages
{
    //Class added solely for functionality testing
    public class CalculatorSubstitute
    {
        string finalresult;
        public string AddNumbers(string num1, string num2)
        {
            finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
            return finalresult;
        }
        public string SubtractNumbers(string num1, string num2)
        {
            finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
            return finalresult;
        }
        public string MultiplyNumbers(string num1, string num2)
        {
            finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
            return finalresult;
        }
        public string DivideNumbers(string num1, string num2)
        {
            if (Convert.ToDouble(num2) != 0)
            {
                finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
            }
            else
            {
                finalresult = "Cannot Divide by Zero";
            }
            return finalresult;
        }
        public string SquareRoot(string num1)
        {
            if (Convert.ToDouble(num1) < 0)
            {
                return ("Invalid input.");
            }

            string result = Math.Sqrt(Convert.ToDouble(num1)).ToString();
            return result;
        }

        public string Percent(string num1, string num2)
        {
            var partResult = Convert.ToDouble(num1) / 100;
            var result = partResult * Convert.ToDouble(num2);
            return result.ToString();
        }

        public string Power(string num1, string num2)
        {
            string result = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
            return result;
        }
    }
}
