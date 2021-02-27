using System;
using Tema3x3.BaseComponents;
using Tema3x3.ConcreteComponents.Numbers;
using Tema3x3.PrinterService;

namespace Tema3x3
{
    class Program
    {
        static void Main(string[] args)
        {
       
            IDisplayable printer = new PrintNumberArray();
            printer.Print(Console.ReadLine());
            
            Console.WriteLine();
        }
    }
}
