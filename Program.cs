using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        public static int Biggest()
        {

            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > z && x > y)
            {
                return x;
            }

            else if (y > z && y > x)
            {
                return y;
            }
            else
            {
                return z;
            }

        }
              static void Main(string[] args)
                {
                try
                {
                    int big = Biggest();
                    Console.WriteLine("Наибольшее число " + big);

                    int x = big % 2;
                    switch (x)
                    {
                    case 0:
                    Console.WriteLine("Число четное");
                     break;
                     default:
                     Console.WriteLine("Число нечетное");
                      break;
                     }
                     bool r = (big < 100);
                     if (r)
                     Console.WriteLine("Число меньше 100");
                     else
                     {
                      Console.WriteLine("Число меньше  100");
                    }
                    }
                    catch
                    {
                    Console.WriteLine("Нет, введите число");
                    Biggest();
                    }

                   Console.ReadKey();
                }
            }
}
    