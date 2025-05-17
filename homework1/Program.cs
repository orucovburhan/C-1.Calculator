using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace MyApp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            System.Console.WriteLine("Calculator: ");

            System.Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("+");
            System.Console.WriteLine("-");
            System.Console.WriteLine("*");
            System.Console.WriteLine("/");
            System.Console.WriteLine("Choose: ");
            string operator1 = System.Console.ReadLine();
            switch (operator1)
            {
                case "+":
                    System.Console.WriteLine("Result is: "+Add(number1, number2));
                    break;
                case "-":
                    System.Console.WriteLine("Result is: "+Subt(number1, number2));
                    break;
                case "*":
                    System.Console.WriteLine("Result is: "+Mult(number1, number2));
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        System.Console.WriteLine("Result is: "+Add(number1, number2));
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Can not divided by 0");
                        break;
                    }
                    
                default:
                    System.Console.WriteLine("Wrong choice.");
                    break;
                
            }
           int Add(int num1, int num2)
        {
            return num1 + num2;
        }
         int Subt(int num1, int num2)
        {
            return num1 - num2;
        }
         int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
            int Div(int num1, int num2)
        {
            return num1 / num2;
        }


        }
            
    }
}