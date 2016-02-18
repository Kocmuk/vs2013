using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            calc.Add(10f, 20f);

            calc.Minus(10f, 20f);
                
        }
    }

    class Calculator
    {
        public float Add(float x, float y)
        {
            Console.WriteLine("Сумма {0} и {1} равна {2}", x, y, x + y);

            Console.ReadLine();
            return x + y;
        }

        public float Minus(float x, float y)
        {
            Console.WriteLine("Разность {0} и {1} равна {2}", x, y, x - y);

            Console.ReadLine();
            return x + y;
        }

        public float mod2(float x, float y)
        {
            Console.WriteLine("Разность {0} и {1} равна {2}", x, y, x % y);

            Console.ReadLine();
            return x + y;
        }
    }
}
