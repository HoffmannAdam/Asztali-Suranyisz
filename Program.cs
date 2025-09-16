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
            Console.Write("adjon meg egy számot!:");
            float sz1 = float.Parse(Console.ReadLine());
            Console.WriteLine(sz1*2);
        }

        static void F4()
        {
            Console.Write("adjon meg egy számot!:");
            float sz1 = float.Parse(Console.ReadLine());
            Console.Write("adjon meg még egy számot!:");
            float sz2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"összege: {sz1+sz2}");
            Console.WriteLine($"különbsége: {sz1-sz2}");
            Console.WriteLine($"szorzata:  {sz1*sz2}");
            Console.WriteLine($"hányadosa: {sz1/sz2}");
        }

        static void F5()
        {
            Console.Write("adjon meg egy számot!:");
            int sz1 = int.Parse(Console.ReadLine());
            Console.Write("adjon meg még egy számot!:");
            int sz2 = int.Parse(Console.ReadLine());
            if (sz1 > sz2)
            {
                Console.WriteLine($"nagyobbik szám: {sz1}");
            }
            else {
                Console.WriteLine($"nagyobbik szám: {sz2}");
            }
        }

        static void F6()
        {
            int lk = 0;
            Console.Write("Adjon meg egy egész számot!:");
            int sz1 = int.Parse (Console.ReadLine());
            Console.Write("Adjon meg még egy egész számot!:");
            int sz2 = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg még egy egész számot!:");
            int sz3 = int.Parse(Console.ReadLine());

            if (sz1 < sz2 && sz1 < sz3)
            {
                Console.WriteLine($"legkisebb szám: {sz1}");
            }
            else if (sz2 < sz1 && sz2 < sz3)
            {
                Console.WriteLine($"legkisebb szám: {sz2}");
            }
            else
            {
                Console.WriteLine($"legkisebb szám: {sz3}");
            }
        }

        static void F7()
        {
            Console.Write("Háromszög első oldala:");
            float o1 = float.Parse(Console.ReadLine());
            Console.Write("Háromszög második oldala:");
            float o2 = float.Parse(Console.ReadLine());
            Console.Write("Háromszög harmadik oldala:");
            float o3 = float.Parse(Console.ReadLine());

            if (o1>0 && o2>0 && o3>0)
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
            Console.Write("Adjon meg egy pozitív egész számoz!:");
            int sz1 = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg mégegy povitív egész számot!:");
            int sz2 = int.Parse(Console.ReadLine());

            int sztk = (sz1 + sz2) / 2;
            double mtk = Math.Sqrt(sz1*sz2);

            Console.WriteLine($"Számtani közép: {sztk}");
            Console.WriteLine($"Mértani közép: {mtk}");
        }

        static void F9()
        {
            Console.WriteLine("Másodfokú egyenlet együtthatói:");
            Console.Write("A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C:");
            int c = int.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2)-(4*(a*c));

            if (D > 0 || D < 0)
            {
                Console.WriteLine("Két megoldása van");
            }
            else
            {
                Console.WriteLine("Nincs megoldása");
            }
            
        }

        static void F10()
        {
            Console.WriteLine("Másodfokú egyenlet együtthatói:");
            Console.Write("A:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C:");
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2)-(4*(a * c));

            double x1 = Math.Round(((-b)+(Math.Sqrt(D))/(2*a)), 2);
            double x2 = Math.Round(((-b)-(Math.Sqrt(D))/(2*a)), 2);

            if (D > 0 || D < 0)
            {
                Console.WriteLine("Két megoldása van:");
                Console.WriteLine($"Első megoldás: {x1}");
                Console.WriteLine($"Második megoldás: {x2}");
            }
            else
            {
                Console.WriteLine("Nincs megoldása");
            }
        }

        static void F11()
        {
            Console.Write("Egyik befogó:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Másik befogó:");
            double b = double.Parse(Console.ReadLine());

            double c2 = Math.Pow(a, 2) + Math.Pow(b,2);
            double c = Math.Round(Math.Sqrt(c2), 2);

            Console.WriteLine($"Átfogó hossza: {c}");
        }

        static void F12()
        {
            Console.Write("Téglatest A éle:");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Téglatest B éle:");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Téglatest C éle:");
            double C = double.Parse(Console.ReadLine());

            double térf = A * B * C;
            double felsz = 2 * ((A * B) + (B * C) + (A * C));

            Console.WriteLine($"Téglatest felszíne: {felsz}cm2");
            Console.WriteLine($"Téglatest térfogata: {térf}cm3");
        }

        static void F13()
        {
            Console.Write("Kör átmérője:");
            double r = double.Parse(Console.ReadLine());

            double K = Math.Round((2 * r * Math.PI), 2);
            double T = Math.Round((Math.Pow(r, 2)*Math.PI), 2);

            Console.WriteLine($"Kör kerülete: {K}cm");
            Console.WriteLine($"Kör kerülete: {T}cm2");
        }

        static void F14()
        {
            Console.Write("Körív sugara: ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Középponti szöge: ");
            double szog = double.Parse(Console.ReadLine());

            double A = (Math.Pow(s, 2)*szog)/2;
            double L = szog * s;

            Console.WriteLine($"Ív területe: {A}cm2");
            Console.WriteLine($"Ív hossza: {L}cm");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
 