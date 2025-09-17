using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int ReadInt(string inputMessage)
        {
            int value;
            Console.Write(inputMessage);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Bevitel nem egész szám!");
                Console.Write(inputMessage);
            }
            return value;
        }

        static double ReadDouble(string inputMessage)
        {
            double value;
            Console.Write(inputMessage);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Bevitel nem szám!");
                Console.Write(inputMessage);
            }
            return value;
        }

        static void F1()
        {
            Console.WriteLine("hello world!");
        }

        static void F2()
        {
            Console.Write("neve?:");
            string felh = Console.ReadLine();
            Console.WriteLine("hello " + felh);
        }

        static void F3()
        {
            double sz1 = ReadDouble("Adj meg egy számot:");
            Console.WriteLine(sz1 * 2);
        }

        static void F4()
        {
            double sz1 = ReadDouble("Adjon meg egy számot!:");
            double sz2 = ReadDouble("Adjon meg egy számot!:");

            Console.WriteLine($"összege: {sz1 + sz2}");
            Console.WriteLine($"különbsége: {sz1 - sz2}");
            Console.WriteLine($"szorzata:  {sz1 * sz2}");
            Console.WriteLine($"hányadosa: {Math.Round(sz1 / sz2, 2)}");
        }

        static void F5()
        {
            int sz1 = ReadInt("Adjon meg egy egész számot!:");
            int sz2 = ReadInt("Adjon meg még egy egész számot!:");
            if (sz1 > sz2)
            {
                Console.WriteLine($"Nagyobbik szám: {sz1}");
            }
            else
            {
                Console.WriteLine($"Nagyobbik szám: {sz2}");
            }
        }

        static void F6()
        {
            int sz1 = ReadInt("Adjon meg egy egész számot!:");
            int sz2 = ReadInt("Adjon meg még egy egész számot!:");
            int sz3 = ReadInt("Adjon meg még egy egész számot!:");

            if (sz1 < sz2 && sz1 < sz3)
            {
                Console.WriteLine($"Legkisebb szám: {sz1}");
            }
            else if (sz2 < sz1 && sz2 < sz3)
            {
                Console.WriteLine($"Legkisebb szám: {sz2}");
            }
            else
            {
                Console.WriteLine($"Legkisebb szám: {sz3}");
            }
        }

        static void F7()
        {
            double o1 = ReadDouble("Háromszög első oldala:");
            double o2 = ReadDouble("Háromszög második oldala:");
            double o3 = ReadDouble("Háromszög harmadik oldala:");

            if (o1 > 0 && o2 > 0 && o3 > 0)
            {
                Console.WriteLine("Lehet háromszöget szerkeszteni.");
            }
            else
            {
                Console.WriteLine("Nem lehet háromszöget szerkeszteni");
            }
        }

        static void F8()
        {
            int sz1 = ReadInt("Adjon meg egy pozitív egész számoz!:");
            int sz2 = ReadInt("Adjon meg még egy pozitív egész számot!:");

            int sztk = (sz1 + sz2) / 2;
            double mtk = Math.Sqrt(sz1 * sz2);

            Console.WriteLine($"Számtani közép: {sztk}");
            Console.WriteLine($"Mértani közép: {mtk}");
        }

        static void F9()
        {
            Console.WriteLine("Másodfokú egyenlet együtthatói:");
            int a = ReadInt("A:");
            int b = ReadInt("B:");
            int c = ReadInt("C:");

            double D = Math.Pow(b, 2) - (4 * (a * c));

            if (D > 0)
            {
                Console.WriteLine("Két megoldása van");
            }
            else if (D == 0)
            {
                Console.WriteLine("Egy megoldása van");
            }
            else
            {
                Console.WriteLine("Nincs valós megoldása");
            }

        }

        static void F10()
        {
            Console.WriteLine("Másodfokú egyenlet együtthatói:");
            double a = ReadDouble("A:");
            double b = ReadDouble("B:");
            double c = ReadDouble("C:");

            double D = Math.Pow(b, 2) - (4 * (a * c));

            if (D > 0)
            {
                double x1 = Math.Round(((-b) + Math.Sqrt(D)) / (2 * a), 2);
                double x2 = Math.Round(((-b) - Math.Sqrt(D)) / (2 * a), 2);
                Console.WriteLine("Két megoldása van:");
                Console.WriteLine($"Első megoldás: {x1}");
                Console.WriteLine($"Második megoldás: {x2}");
            }
            else if (D == 0)
            {
                double x = Math.Round(-b / (2 * a), 2);
                Console.WriteLine("Egy megoldása van:");
                Console.WriteLine($"Megoldás: {x}");
            }
            else
            {
                Console.WriteLine("Nincs valós megoldása.");
            }
        }

        static void F11()
        {
            double a = ReadDouble("Egyik befogó:");
            double b = ReadDouble("Másik befogó:");

            double c2 = Math.Pow(a, 2) + Math.Pow(b, 2);
            double c = Math.Round(Math.Sqrt(c2), 2);

            Console.WriteLine($"Átfogó hossza: {c}");
        }

        static void F12()
        {
            double A = ReadDouble("Téglatest A éle:");
            double B = ReadDouble("Téglatest B éle:");
            double C = ReadDouble("Téglatest C éle:");

            double térf = A * B * C;
            double felsz = 2 * ((A * B) + (B * C) + (A * C));

            Console.WriteLine($"Téglatest felszíne: {felsz}cm2");
            Console.WriteLine($"Téglatest térfogata: {térf}cm3");
        }

        static void F13()
        {
            double d = ReadDouble("Kör átmérője:");
            double r = d / 2;

            double K = Math.Round((2 * r * Math.PI), 2);
            double T = Math.Round((Math.Pow(r, 2) * Math.PI), 2);

            Console.WriteLine($"Kör kerülete: {K}cm");
            Console.WriteLine($"Kör területe: {T}cm2");
        }

        static void F14()
        {
            double s = ReadDouble("Körív sugara: ");
            double szog = ReadDouble("Középponti szöge: ");

            double A = (Math.Pow(s, 2) * szog) / 2;
            double L = szog * s;

            Console.WriteLine($"Ív területe: {A}cm2");
            Console.WriteLine($"Ív hossza: {L}cm");
        }

        static void F15()
        {
            int sz = ReadInt("Adjon meg egy egész számot!: ");
            
            for (int i = 0; i <= sz; i++) 
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        static void F16()
        {
            int sz = ReadInt("Adjon meg egy egész számot!: ");

            for (int i = 0; i <= sz; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }

        static void F17() 
        {
            int sz = ReadInt("Adjon meg egy egész számot!: ");

            for (int i = 1; i <= sz; i++)
            {
                if (sz % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void F18()
        {
            int sz = ReadInt("Adjon meg egy egész számot!: ");

            int szo = 0;

            for (int i = 1;i <= sz; i++)
            {
                if (sz % i == 0)
                {
                    szo = szo + i;
                }
            }
            Console.WriteLine($"A szám osztóinak összege {szo}");
        }

        static void F19()
        {
            int sz = ReadInt("Adjon meg egy egész számot!: ");

            int szao = 0;

            for (int i = 1; i <= sz; i++)
            {
                if (sz % i == 0)
                {
                    szao = szao + i;
                }
            }
            if (szao == sz * 2)
            {
                Console.WriteLine($"{sz} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"{sz} nem tökéletes szám.");
            }
        }

        static void F20()
        {
            int ha = ReadInt("Hatványalap: ");
            int hk = ReadInt("Hatványkitevő: ");

            double he = Math.Pow(ha, hk);

            Console.WriteLine($"Hatványalap: {ha}");
            Console.WriteLine($"Kitevő: {hk}");
            Console.WriteLine($"Hatványérték: {he}");
        }

        static void F21()
        {
            double psz = -1;

            while (psz <= 0) 
            {
                psz = ReadDouble("Adjon meg egy pozitív számot: ");
                
                if (psz < 0)
                {
                    Console.WriteLine("A szám nem pozitív!");
                }
                else if (psz > 0)
                {
                    Console.WriteLine($"{psz} pozitív szám.");
                }
            }
        }

        static void F22()
        {
            double kitossz = 0;
            double kit = 0;

            while (kit < 10)
            {
                kit = ReadDouble("Adjon meg egy számot!: ");

                if (kit < 10)
                {
                    kitossz += kit;
                }
            }

            Console.WriteLine($"A számok összege {kitossz}.");
        }

        static void F23()
        {
            int kosz = ReadInt("Adjon meg egy egész számot!: ");

            int ooo = 0;
            int ekosz = kosz;

            if (kosz % 2 == 1)
            {
                Console.WriteLine("Szám nem osztható 2-vel!");
            }
            else
            {
                while (kosz % 2 == 0)
                {
                    ooo++;
                    kosz = kosz / 2;
                }

                Console.Write($"{ekosz} = 2");
                for (int i = 1; i < ooo; i++)
                {
                    Console.Write("*2");
                }
                Console.WriteLine($"*{kosz}");
            }
        }

        static void F24()
        {
            string alma = "";

            while (alma != "alma")
            {
                Console.Write("Alma?: ");
                alma = Console.ReadLine();

                if (alma != "alma")
                {
                    Console.WriteLine("A szó nem alma!");
                }
            }

            Console.WriteLine("Az alma egy gyümölcs!");
        }

        static void F25()
        {
            int hsz = ReadInt("Adjon egy egész számot: ");
            int ehsz = hsz;

            while (hsz >= 3)
            {
                hsz = hsz - 3;
            }
            Console.WriteLine($"{ehsz} = {ehsz / 3}*3+{ehsz % 3}");

        }

        static void F26()
        {
            int prszam = ReadInt("Adjon meg egy egész számot: ");

            bool prim = true;
            int hh = prszam / 2;

            for (int i = 2; i <= hh && prim; i++)
            {
                if (prszam % i == 0)
                {
                    Console.WriteLine($"{prszam} nem prímszám.");
                    prim = false;
                }
            }

            if (prim)
            {
                Console.WriteLine($"{prszam} prímszám.");
            }
        }

        static void F27()
        {
            int ps = ReadInt("Adjon meg egy egész számot: ");

            for (int i = 2; i <= ps; i++)
            {
                bool prim = true;

                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        prim = false;
                    }
                }

                if (prim)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void F28()
        {
            int prs = ReadInt("Adjon meg egy egész számot: ");

            int oooo = 2;

            while (prs > 1)
            {
                if (prs % oooo == 0)
                {
                    Console.Write(oooo + " ");
                    prs /= oooo;
                    while (prs % oooo == 0)
                    {
                        prs /= oooo;
                    }
                }
                oooo++;
            }
            Console.WriteLine();
        }

        static void F29()
        {
            double ptszam = Math.Round(ReadDouble("Adjon meg egy számot: "));

            double pti = 2;
            while (pti <= ptszam)
            {
                if (ptszam % pti == 0)
                {
                    ptszam = ptszam / pti;
                    Console.Write("*{0}", pti);
                }
                else
                {
                    pti++;
                }
            }
            Console.WriteLine();
        }

        static void F30()
        {
            int sz1 = ReadInt("Adjon meg egy számot: ");
            int sz2 = ReadInt("Adjon meg még egy számot: ");

            int egy = sz1;
            int mas = sz2;

            while (mas != 0)
            {
                int id = mas;
                mas = egy % mas;
                egy = id;
            }
            int lnko = egy;

            Console.WriteLine($"A két szám legnagyobb közös osztója: {lnko}");

        }

        static void F31()
        {
            int sz1 = ReadInt("Adjon meg egy számot: ");
            int sz2 = ReadInt("Adjon meg még egy számot: ");

            int egy = sz1;
            int mas = sz2;

            while (egy != mas)
            {
                if (egy > mas)
                {
                    egy -= mas;
                }
                else
                {
                    mas -= egy;
                }
            }

            int lkkt = (sz1 * sz2) / egy;

            Console.WriteLine($"A két szám legkisebb közös többszöröse: {lkkt}");
        }

        static void Main(string[] args)
        {
            //F();
        }
    }
}
