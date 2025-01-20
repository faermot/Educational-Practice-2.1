using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task1 : IPrintOfSolution
    {
        double G, e, f, y;

        public Task1(double e, double f, double y)
        {
            this.e = e;
            this.f = f;
            this.y = y;
        }

        public void PrintSolution()
        {
            G = (Math.Pow(e, 2 * y) / (Math.Log(3.8 * y + f)));

            Console.WriteLine($"G = {G}");
        }
    }
}
