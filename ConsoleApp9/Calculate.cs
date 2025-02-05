using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Calculate
    {

        public double Num1;
        public double Num2;
        public Calculate()
        {
            Num1 = 0.0;
            Num2 = 0.0;
        }
        public Calculate(double num1)
        {
            Num1 = num1;
            Num2 = 0.0;
        }
        public Calculate(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public override string ToString()
        {
            return $"Calculate(Num1={Num1}, Num2={Num2})";
        }
        public double ComputeSqrtProduct()
        {
            return Math.Sqrt(Num1 * Num2);
        }
    }
}
