using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Вводим данные 
            Console.WriteLine("Вводим длины ребер куба");
            int a = Convert.ToInt32(Console.ReadLine());           
            #endregion
            #region Условия и вывод
            double V, S;
            CubeVolume(a, out V);
            CubeArea(a, out S);
            Console.WriteLine("Объём куба {0:F2}", V);
            Console.WriteLine("Площадь куба {0:F2}", S);
            Console.ReadKey();
            #endregion
        }
        #region Методы
        static void CubeVolume(int a, out double V)
        {
            V = Convert.ToInt32(Math.Pow(a, 3));
        }
        static void CubeArea(int a, out double S)
        {
            S = 6 * ((Math.Pow(a, 2)));
        }
        #endregion
    }

}
