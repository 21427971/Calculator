using System;
//	Implement a C# class representing a basic calculator that can perform addition, subtraction, multiplication, and division operations.
namespace Calculator
{
    class CalcuProgram
    {
        public static double Add(double A,double B)
        {
            return A + B;
        }
        public static double Multiply(double A, double B)
        {
            return A * B;
        }
        public static double Subtraction(double A, double B)
        {
            return A - B;
        }
        public static double Divide(double A, double B)
        {
            if(B==0)
            {
                throw new DivideByZeroException("cannot divide by zero");
            }

            return A / B;
        }

     
    }
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter a first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition :" + CalcuProgram.Add(num1, num2));

            Console.WriteLine("Multiplication :" + CalcuProgram.Multiply(num1, num2));

            Console.WriteLine("Subtraction :" + CalcuProgram.Subtraction(num1, num2));

            Console.WriteLine("Divide :" + CalcuProgram.Divide(num1, num2));
           
        }
    }
}
