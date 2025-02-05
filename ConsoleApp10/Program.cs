using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time();
            time1.SetTime(2, 30, 45);
            Console.WriteLine(time1.GetTimeInfo());
            Console.WriteLine("Общее количество секунд: " + time1.TotalSeconds());
            Time time2 = new Time(3, 15);
            Console.WriteLine(time2.GetTimeInfo());
            Console.WriteLine("Общее количество минут: " + time2.TotalMinutes());
            Console.Write("Введите часы: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int s = int.Parse(Console.ReadLine());
            Time time3 = new Time(h, m, s);
            Console.WriteLine(time3.GetTimeInfo());
            Console.WriteLine("Общее количество секунд: " + time3.TotalSeconds());
        }
    }
}
