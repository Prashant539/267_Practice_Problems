using PracticeProblem.Interface;
using PracticeProblem.TypesOfConstractor;
using PracticeProblem.TypesOfConstructor;
using System;
using System.Drawing;

namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Problem");
            Console.WriteLine("Enter the Options to Excitue Program: ");
            Console.WriteLine("1:Default Constractor\n2:Parameterized Constractor\n3:Interface");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    DefaultConstractor defaultConstractor = new DefaultConstractor();
                    defaultConstractor.Display();
                    Console.ReadLine();
                    break;
                case 2:
                    ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor(10);
                    ParameterizedConstructor parameterizedConstructor1 = new ParameterizedConstructor(20);
                    Console.ReadLine();
                    break;
                case 3:
                    Square square = new Square();
                    square.CalculateArea();
                    break;
            }
  
        }
    }
}
