using System;

namespace OOPLab2._2
{
    public class Program
    {
        static public double Calculation(double x)
        {           
            double z = Math.Pow(4.0, -Math.Cos(x));
            return z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Результати обчислення функцiї y = f(x) на промiжку вiд 0 до 3 з кроком dx = 0.05.\n\tx\t\ty = f(x)");
            double x = 0;
            double y;
            while (x <= 3)
            {
                y = Calculation(x);
                Console.WriteLine("\t{0}\t\t{1}", Math.Round(x, 2), y);
                x += 0.05;
            }
        }
    }
}
