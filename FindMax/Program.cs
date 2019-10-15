using System;

namespace FindMax
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter x_0:");
            var x0_str = Console.ReadLine();
            var x0 = double.Parse(x0_str);

            Console.WriteLine("enter lambda:");
            var l_str = Console.ReadLine();

            var l = double.Parse(l_str);

            Console.WriteLine("enter Error:");
            var e_str = Console.ReadLine();
            var e = double.Parse(e_str);

            Console.WriteLine(Meth_Gradient(x0, l, e));

            Console.ReadLine();
        }

        static double F1(double x)
        {
            return -2 * x * x + 3 * x - 7;
        }

        static double grad_F(double x, double lambda)
        {
            return (F1(x + lambda) - F1(x)) / lambda;
        }

        static double Meth_Gradient(double x, double lambda, double E)
        {
            double xx, x_n;
            do
            {
                xx = x;

                x_n = x - lambda * grad_F(x, lambda);

                x = x_n;
            }
            while ((Math.Abs(x - xx)) <= E);

            return x;
        }
    }
}
