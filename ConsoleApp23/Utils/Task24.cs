using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task24 : IPrintOfSolution
    {

        double k, e, y;

        public Task24(double y, double e, double d)
        {
            this.k = k;
            this.e = e;
            this.y = y;
        }

        public void PrintSolution()
        {
            throw new NotImplementedException(); Console.WriteLine($"U = {(Math.Log(2 * k + 4.3)) / (Math.Pow(e, k + y) + Math.Sqrt(y))}");
        }
    }
}
