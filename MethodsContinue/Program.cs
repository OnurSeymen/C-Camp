using System;
using System.Linq;

namespace MethodsContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            int number1 = 20;
            int number2 = 100;

            
            //Console.WriteLine(Add3(1,2));
            //Console.WriteLine(number1);
            
            Console.WriteLine(Multiply(1,2,3));
            Console.WriteLine(Add4(1,2,3,4,5,6,7));
            Console.ReadLine();

            static int Add3 (int number1,int number2)
            {
                return number1 * number2;
            }

            
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4 (int number1,params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
