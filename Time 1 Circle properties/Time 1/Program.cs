using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_1
{
    class Program
    {
        static double Discount(double Total, double Rate)
        {
            return Total - (Total * Rate / 100);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Discount(55,20));
        }
    }
}
