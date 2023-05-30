using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a1 = "", b1 = "", c1 = "";
            int x;
            bool proverka = false;

            while (proverka == false)
            {
                Console.Clear();

                Console.WriteLine("a * x^2 + b * x + c = 0");

                VvodChisel(ref a1, ref b1, ref c1);

                proverka = FormatData(a1, b1, c1);
            }

            int d;
            int a, b, c;

            a = int.Parse(a1);
            b = int.Parse(b1);
            c = int.Parse(c1);

            d = b * b - 4 * a * c;

            var aaaa = string.Format("[{0} - {1}]", int.MinValue, int.MaxValue);
            Console.WriteLine(aaaa);

            Reshenie(d, a, b);

            static bool FormatData(string a, string b, string c)
            {
                int a1 = 0, b1 = 0, c1 = 0;
                try
                {
                    a1 = int.Parse(a);
                }
                catch (Exception e)
                {
                    Line();
                    Console.WriteLine("Не верно введено значение a");
                    Line();
                }
                try
                {
                    b1 = int.Parse(b);
                }
                catch (Exception e)
                {
                    Line();
                    Console.WriteLine("Не верно введено значение b");
                    Line();
                }
                try
                {
                    c1 = int.Parse(c);
                }
                catch (Exception e)
                {
                    Line();
                    Console.WriteLine("Не верно введено значение c");
                    Line();
                }
                if (int.TryParse(a, out int number) & int.TryParse(b, out int number2) & int.TryParse(c, out int number3))
                {
                    return true;
                }
                else
                {
                    Console.ReadLine();
                    return false;
                }
                

            }

            static void Line ()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                string line = "--------------------------------------------";
                Console.WriteLine(line);
                Console.ResetColor();
            }

            static void VvodChisel(ref string a,ref string b,ref string c)
            {
                Console.WriteLine("Введите значение a");
                a = Console.ReadLine();
                Console.WriteLine("Введите значение b");
                b = Console.ReadLine();
                Console.WriteLine("Введите значение c");
                c = Console.ReadLine();

            }

            static void Reshenie (int d, int a, int b)
            {
                float x1, x2;

                if (d > 0)
                {
                    x1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
                    x2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }

                if (d == 0)
                {
                    x1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine(x1);
                }

                if (d < 0)
                {
                    Console.WriteLine("Корней нет");
                }
            }
        }
    }
}