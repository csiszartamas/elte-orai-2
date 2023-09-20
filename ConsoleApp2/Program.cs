namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            feladat_1();
            feladat_2();
            feladat_3();
            feladat_4();

            Console.ReadLine();
        }

        private static void feladat_4()
        {
            Console.WriteLine("4. feladat");
            Console.WriteLine("Adja meg az 'a' együtthatót:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg a 'b' együtthatót:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg a 'c' együtthatót:");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double x1, x2;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Az egyenlet tetszőleges x-re igaz.");
                    }
                    else
                    {
                        Console.WriteLine("Az egyenlet semmilyen x-re nem igaz.");
                    }
                }
                else
                {
                    x1 = -c / b;
                    Console.WriteLine($"Az egyenlet lineáris, gyök: x = {x1}");
                }
            }
            else
            {
                if (d < 0)
                {
                    Console.WriteLine("Az egyenletnek nincs valós gyöke.");
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine($"Az egyenletnek egy valós gyöke van: x = {x1}");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Az egyenletnek két valós gyöke van: x1 = {x1}, x2 = {x2}");
                }
            }
        }
        private static void feladat_3()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine("Kérem, adja meg az első számot:");
            int szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem, adja meg a második számot:");
            int szam2 = int.Parse(Console.ReadLine());

            int legnagyobbKozosOszto = LegnagyobbKozosOszto(szam1, szam2);

            Console.WriteLine($"A(z) {szam1} és {szam2} legnagyobb közös osztója: {legnagyobbKozosOszto}");

        }
        private static void feladat_2()
        {
            int k;
            Console.WriteLine("2. feladat");
            Console.WriteLine("adj meg egy tetszőleges számot 1-100 között: ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                if (k > 0 && k <= 100)
                {
                    Console.WriteLine($"átlagok: {Osztando(k)}");
                }
                else
                {
                    Console.WriteLine("A k csak 1 és 100 közötti szám lehet.");
                    feladat_2();
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Ez nem egy szám.");
                feladat_2();
            }
        }

        private static void feladat_1()
        {
            Console.WriteLine("1. feladat");
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine($"A / Az {i} faktoriálisa: {Faktorialis(i)}");
            }
        }

        static int Faktorialis(int b)
        {
            int f = b;
            for (int i = f; i > 0; i--)
            {
                f *= i;
            }
            return f;
        }

        static double Osztando(int k)
        {
            int osszeg = 0;
            int darab = 0;
            int i = k;
            double atlag = 0;

            while (i <= 100)
            {
                if (i % k == 0)
                {
                    osszeg += i;
                    darab++;
                }
                i++;
                atlag = osszeg / darab;
            }


            if (darab > 0)
            {
                return atlag;
            }
            else
            {
                Console.WriteLine($"Nincs {k}-val osztható szám az 1 és 100 között.");
                return 0;
            }
        }

        static int LegnagyobbKozosOszto(int a, int b)
        {
            while (b != 0)
            {
                int maradek = a % b;
                a = b;
                b = maradek;
            }
            return a;
        }
    }
}