using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int diameter = GetDiameter(10);
            Console.WriteLine(diameter);
            Console.ReadLine();
        }

        public static int GetDiameter(int radius)
        {
            int result = 2 * radius;

                return result;
        }
    }
}
