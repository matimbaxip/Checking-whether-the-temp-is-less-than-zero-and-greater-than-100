using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_whether_the__temp_is_less_than_zero_and_greater_than_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two temperatures:");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            int temp2 = Convert.ToInt32(Console.ReadLine());

            //* To check whether the degree is less than zero and greater than 100
            

            bool result = (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0);

            Console.WriteLine("Result: " + result);

        }
    }
}
