using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Random rnd = new Random();
            int num01 = rnd.Next(100);

            Console.WriteLine(num01);
            Console.ReadLine();
            goto start;
        }
    }
}
