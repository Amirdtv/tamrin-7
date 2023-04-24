using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_7
{
    internal class Program
    {
        private static int test (int x,int y,int z)
        {
            double result;
            result = x * y * z;
            Console.WriteLine(" hajm = " + result);
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" enter numbers ");
            int w = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            test(w, h, l);
        }
    }
}
