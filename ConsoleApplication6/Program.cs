using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Tester
    {
        public void Display(params int[] intVals)
        {
            foreach (int i in intVals)
            {
                Console.WriteLine("Disp {0}", i);
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Display(5, 6, 7, 8);
            int[] explicitArray = new int[] { 1, 2, 3, 4, 5 };
            t.Display(explicitArray);

            Console.ReadLine();
        }
    }
}
