using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task18 : IPrintOfSolution
    {
        double y, k;

        public Task18(double y, double k)
        {
            this.y = y;
            this.k = k;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"R = {(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835)) / ((Math.Log(y + k) + 3 * Math.Pow(y, 2)))}");
        }
    }
}
