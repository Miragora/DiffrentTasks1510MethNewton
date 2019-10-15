using System;

namespace DiffrentTasks1510
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a:");
            var a_str = Console.ReadLine();
            var a = double.Parse(a_str);

            Console.WriteLine("Enter dx:");
            var dx_str = Console.ReadLine();
            var dx = double.Parse(dx_str);

            Console.WriteLine("Enter x:");
            var x_str = Console.ReadLine();
            var x = double.Parse(x_str);

            Console.WriteLine("Enter Error:");
            var e_str = Console.ReadLine();
            var e = double.Parse(e_str);

            var XX = Meth_Newton(x, a, dx, e);

            Console.WriteLine("x = {0}, f(x) = {1} ", XX, F(XX, a));
            

            Console.ReadLine();
        }

        static double F(double x, double a)
        {
            return x * x * x - a;
            
        }

        static double F_d(double x, double a, double dx)
        {
            return (F(x + dx, a) - F(x, a)) / dx;
        }

        static double Meth_Newton(double x, double a, double dx, double E)
        {

            double xx,x_n;

            do
            {
                xx = x;

                x_n = x - F(x, a) / F_d(x, a, dx);

                x = x_n;
                
            }
            while (Math.Abs(F(x, a) - F(xx, a)) < E);
            

            return x_n; 
        }
    }
}
