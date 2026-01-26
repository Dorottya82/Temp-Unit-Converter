using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    public class TUConverter
    {

        public double CToF(double c) 
        {
            return (c * 1.8) + 32;
        }
        public double CToK(double c)
        {
            return c + 273.15;
        }

        public double KToF(double k)
        {
            return (k - 273.15) * 1.8 + 32;
        }

        public double KToC(double k)
        {
            return k - 273.15;
        }

        public double FToC(double f)
        {
            return (f - 32) * (5 / 9);
        }

        public double FToK(double f)
        {
            return (f - 32) * (5 / 9) + 273.15;
        }
    }
}
