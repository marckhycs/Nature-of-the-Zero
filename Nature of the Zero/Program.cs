using System;

namespace Nature_of_the_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nature of the Zeroes of a Quadratic Function ax^2 +bx + c = 0");
            Console.Write("Enter your a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter your b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter your c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double discriminat = Discriminant(a, b, c);
            Nature(discriminat);
            Console.ReadKey();
        }

        public static void Nature(double discriminant)
        {
            if (discriminant > 0)
            {
                Console.WriteLine("The zeros are real and unequal");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("There are no real zeros");
            }
            else
            {
                Console.WriteLine("There is one real zero");
            }
        }
        public static double Discriminant(double a, double b, double c)
        {
            double discriminant = ((b * b) - 4 * a * c);
            return discriminant;
        }
    }
}
