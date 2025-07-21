using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApphiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Number");
            int num1 =Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine("Enter your second Number");
            int num2 = Convert.ToInt32( Console.ReadLine());
            //int num1 = 10;
            //int num2 = 20;
            Console.WriteLine($"Add: {num1} + {num2}  = {num1 + num2 }");
            Console.WriteLine($"Sub: {num1} - {num2}  = {num1 - num2 }");
            Console.WriteLine($"Mul: {num1} * {num2}  = {num1 * num2 }");
            Console.WriteLine($"Div: {num1} / {num2}  = {num1 / num2 }");
            Console.WriteLine($"Mod: {num1} % {num2}  = {num1 % num2 }");


        }
    }
}
