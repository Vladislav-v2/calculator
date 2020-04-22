using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = EnterNumber1();
            char operation = EnterOperator();
            double b = EnterNumber2();

            Calculations calc = new Calculations();

            switch (operation)
            {
                case '+':
                    PrdoubleResult(calc.Sum(a, b).ToString());
                    break;
                case '-':
                    PrdoubleResult(calc.Diff(a, b).ToString());
                    break;
                case '*':
                    PrdoubleResult(calc.Multiply(a, b).ToString());
                    break;
                case '/':
                    try
                    {
                        PrdoubleResult(calc.Division(a, b).ToString());

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Divide by zero");
                    }
                    break;
                case '%' :
                    PrdoubleResult(calc.Mod(a, b).ToString());
                    break;
            }
            Console.ReadKey();
        }

        static double EnterNumber1()
        {
            while (true)
            {
                Console.WriteLine("Enter first number:");
                double num1;
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    return num1;
                }

            }

        }
        static char EnterOperator()
        {
            while (true)
            {
                Console.WriteLine("Enter operator:");
                char oper = Console.ReadLine()[0];
                if (oper == '+' || oper == '-' || oper == '*' || oper == '/' || oper == '%')
                    return oper;

                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    continue;
                }
            }
        }
        static double EnterNumber2()
        {
            while (true)
            {
                Console.WriteLine("Enter second number:");
                double num2;
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    return num2;
                }
            }
        }
        static void PrdoubleResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
