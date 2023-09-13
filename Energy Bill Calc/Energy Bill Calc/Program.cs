using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_1
{
    class Program
    {
        static double EnergyCalculator(double PrevReading, double CurrentReading, double CalorificValue)
        {
            double UnitsUsed = CurrentReading - PrevReading;
            double KWh = UnitsUsed * 1.022 * (CalorificValue / 3.6);
            double Price = 2.84 * KWh;
            return Price;
        }

        static void Main(string[] args)
        {
            double PrevReading = 200;
            double CurrentReading = 400;
            const double CALORIFIC_VALUE = 39.3;

            Console.WriteLine(EnergyCalculator(PrevReading, CurrentReading, CALORIFIC_VALUE));

        }
    }
}