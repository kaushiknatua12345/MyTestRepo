using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_19thJuly
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number1: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number2: ");
                int number2 = int.Parse(Console.ReadLine());
                if (number1 < 0 || number2 < 0)
                    throw new ArgumentOutOfRangeException("Numbers can not be negative");
                else if (number2 == 0)
                    throw new DivideByZeroException("Divisor can not be zero");
                else
                {
                    Calculator calculator = new Calculator();
                    int result = calculator.Divide(number1, number2);
                    Console.WriteLine("Result: " + result);
                }
            }
            catch(ArgumentOutOfRangeException negativeValueException)
            {
                Console.WriteLine(negativeValueException.Message);
            }
            catch(DivideByZeroException zeroException)
            {
                Console.WriteLine(zeroException.Message);
            }
        }
    }
}
