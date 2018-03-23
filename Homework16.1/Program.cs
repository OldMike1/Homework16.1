using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework16._1
{
    static class Konvertor
    {
        public static int GetDegreefromKelvin(int kelvin)
        {
            return kelvin - 273;
        }

        public static int GetKelvinfromDegree(int degree)
        {
            return degree + 273;
        }

        public static double GetDegreefromFar(int far)
        {
            return (far - 32) / 1.8;
        }

        public static double GetFarfromDegree(int degree)
        {
            return degree * 1.8 + 32;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int degree = Konvertor.GetDegreefromKelvin(300);
            Console.WriteLine("Degree from Kelvin : " + degree);
            int kelvin = Konvertor.GetKelvinfromDegree(300);
            Console.WriteLine("Kelvin from Degree : " + kelvin);
            double degree1 = Konvertor.GetDegreefromFar(300);
            Console.WriteLine("Degree from Far : " + Math.Round(degree1,2));
            double far = Konvertor.GetFarfromDegree(300);
            Console.WriteLine("Far from degree : " + far);

        }
    }
}
