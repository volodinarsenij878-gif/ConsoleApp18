using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumDouble = 0.0;
            for (int i = 0; i < 10; i++) sumDouble += 0.1;

            decimal sumDecimal = 0m;
            for (int i = 0; i < 10; i++) sumDecimal += 0.1m;

            Console.WriteLine($"double сумма 0.1*10: {sumDouble:F18} (ошибка округления)");
            Console.WriteLine($"decimal сумма 0.1*10: {sumDecimal:F18} (точно 1.0)");
        }
    }
}

