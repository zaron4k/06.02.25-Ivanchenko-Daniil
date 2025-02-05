using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate obj1 = new Calculate();
            obj1.Num1 = 4.0;
            obj1.Num2 = 9.0;
            Console.WriteLine(obj1);
            Console.WriteLine("Корень из произведения чисел: " + obj1.ComputeSqrtProduct());
            Calculate obj2 = new Calculate(3.0, 16.0);
            Console.WriteLine(obj2);
            Console.WriteLine("Корень из произведения чисел: " + obj2.ComputeSqrtProduct());
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Calculate obj3 = new Calculate(num1, num2);
            Console.WriteLine(obj3);
            Console.WriteLine("Корень из произведения чисел: " + obj3.ComputeSqrtProduct());
        }
    }
}
