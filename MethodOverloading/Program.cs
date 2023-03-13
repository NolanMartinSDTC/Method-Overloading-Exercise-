using System;

namespace MethodOverloading
{
    public class Program
    {
        // Method accepting 2 integers and returns the sum of the 2 integers

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Overload of Add method to add two decimals together

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        // Another overload of Add method to return string, accepts 3 params

        public static string Add(decimal num1, decimal num2, bool isTrue)
        {
            string statementAmount = "";
            while (isTrue)
            {
                if (num1 + num2 > 1)
                {
                    statementAmount += (num1 + num2 + " dollars");
                    break;
                }

                else if (num1 + num2 == 1)
                {
                    statementAmount += (num1 + num2 + " dollar");
                    break;
                }

                else
                {
                    statementAmount += ((num1 + num2)*100 + " cents");
                    break;
                }
            }
            return statementAmount;
        }

        static void Main(string[] args)
        {
            var a = 10;
            var b = 5;

            var sumInts = Add(a, b);

            var c = 0.5m;
            var d = 0.5m;

            var sumDecs = Add(c, d);
            var sumNumAndString = Add(c, d, true);


            
            Console.WriteLine($"Adding integers: {sumInts} \nAdding decimals: {sumDecs} \nAdding dollar amount: {sumNumAndString}");
        }
    }
    
}
