using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Вводим данные 
            Console.WriteLine("Вводим длины первого треугольника:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводим длины второго треугольника:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            #endregion
            double p1, p2, S1, S2;
            Triangle1(x1, y1, z1, out p1, out S1);
            Triangle2(x2, y2, z2, out p2, out S2);
            Console.WriteLine("Площадь первого треугольника {0:F2}", S1);
            Console.WriteLine("Площадь второго треугольника {0:F2}", S2);
            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше площади первого");
            }
            Console.ReadKey();
        }
        static void Triangle1(int x1, int y1, int z1, out double p1, out double S1)
        {
            p1 = (x1 + y1 + z1) / 2;
            S1 = Math.Sqrt(Math.Abs(p1 * ((p1 - x1) * (p1 - y1) * (p1 - z1))));
        }
        static void Triangle2(int x2, int y2, int z2, out double p2, out double S2)
        {
            p2 = (x2 + y2 + z2) / 2;
            S2 = Math.Sqrt(Math.Abs(p2 * ((p2 - x2) * (p2 - y2) * (p2 - z2))));
        }
        
    }
}
