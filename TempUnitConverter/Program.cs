using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            //double c_ered;
            //double cc = 5;
            //TUConverter tuc = new TUConverter();
            //c_ered = tuc.CToF(cc);
            //Console.WriteLine(c_ered);

            const double c = 10;
            const double k = 0;
            const double f = 32;

            TUConverter converter = new TUConverter();

            double result_CK = converter.CToK(c);
            double result_CF = converter.CToF(c);

            double result_FC = converter.FToC(f);
            double result_FK = converter.FToK(f);

            double result_KC = converter.KToC(k);
            double result_KF = converter.KToF(k);


            Console.WriteLine($" {c} C-fok = {result_CK} Kelvin");
            Console.WriteLine($" {c} C-fok = {result_CF} Fahrenheit");

            Console.WriteLine();

            Console.WriteLine($" {f}Fahrenheit = {result_FC} Celsius-fok");
            Console.WriteLine($" {f}Fahrenheit = {result_FK} Kelvin");

            Console.WriteLine();

            Console.WriteLine($" {k}Kelvin = {result_KC} Celsius-fok");
            Console.WriteLine($" {k}Kelvin = {result_KF} Fahrenheit");


            Console.ReadKey();
        }
    }
}
