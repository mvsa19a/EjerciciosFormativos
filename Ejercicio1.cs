/*using System; // por valor 

namespace AreaT
{
    public class Areat
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la basa del triangulo: ");
            double baset = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la altura del triangulo: ");
            double alturat = Convert.ToDouble(Console.ReadLine());

            double res = AreaT(baset, alturat);

            Console.WriteLine($"El area del triangulo es:{res} ");
            Console.ReadKey();


        }
        public static double AreaT(double x, double y)
        {

            return (x * y) / 2;
        }

    }
}*/
using System; // por referencia 

namespace AreaT
{
    public class Areat
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la basa del triangulo: ");
            double baset = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la altura del triangulo: ");
            double alturat = Convert.ToDouble(Console.ReadLine());

            double res = 0;
            Area(ref baset, ref alturat ,ref res);

            Console.WriteLine($"El area del triangulo es:{res} ");
            Console.ReadKey();


        }
        public static void Area(ref double x, ref double y , ref double res)
        {

            res =  ((x * y) / 2);
        }

    }
}