using System;

namespace Maketas
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ConsoleKeyInfo status;

            while (true)
            {
                Console.Title = "Andriejus Gorbunovas";
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                string pasirinkimas = @"
*********************************************************
*                                                       *
*     Pasirinkite kokia uzduoti noretumete atlikti:     *
*                                                       *
*       1.  Trikampio ploto skaiciavimas                *
*       2.  Dvieju matricu sudetis ir atimtis           *
*       3.                                              *
*                                                       *
*********************************************************
";
                Console.WriteLine(pasirinkimas);
                Console.ResetColor();
                ConsoleKey consoleKey = Console.ReadKey().Key;
                Console.WriteLine();

                //==================================================================================

                switch (consoleKey)
                {
                    //1. Parašyti programą su metodu, kuris apskaičiuotų trikampio plotą pagal duotas dvi kraštines a ir b ir kampą C tarp jų.
                    //   Trikampio ploto formulė S = 1/2 * a * b * sin(C). Vartotojas įveda kraštines ir kampą, o atsakymą konsolėje išvesti dviejų
                    //   skaičių po kablelio tikslumu. Pvz.kraštinės 4 ir 8, kampas tarp jų 60, S = 13,86.
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine();
                        TrikampioPlotoSkaiciavimas();
                        break;

                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine();
                        TrikampioPlotoSkaiciavimas();
                        break;
                    //======================
                    //2.Parašyti programą, kuri gebėtų sudėti ar atimti dvi matricas.Dvi matricas sudėti ar atimti galima, tik jei jos yra vienodo
                    //  dydžio.Sudėties(atimties) produktas yra tokio pačio dydžio matrica.
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine();
                        MatricuSudetisAtimtis();
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine();
                        MatricuSudetisAtimtis();
                        break;
                    //======================
                    // 3.Sukurti programą telefonų knygai, kurioje saugoma kontakto informacija yra - vardas, telefono numeris, el. pašto adresas.
                    //   Vartotojas gali įvesti naują, ištrinti esamą, surasti kontaktą telefonų knygoje. Informacijai saugoti naudokite masyvus.
                    //   (3 balai, ~45 min.) Papildomi balai(vertinami tik įgyvendinus pagrindinius reikalavimus):
                    //   0,5 - el.pašto ir telefono numerio validacija 0,5 - užpildžius adresų knygutę, sukuriama talpesnė, o įrašai neprarandami,
                    //   vartotojas nestebi šių pasikeitimų.
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine();

                        break;

                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine();

                        break;
                    //======================
                    default:
                        Console.WriteLine("Jusu pasirinktos funkcijos nera.");
                        break;
                }

                //==================================================================================
                Console.WriteLine("\n\n Ar norite iseiti? Jei taip, spauskite: (Y/y) arba Esc. Jei ne - (N/n)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y || status.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (status.Key == ConsoleKey.N)
                    continue;
            }
        }

        private static void TrikampioPlotoSkaiciavimas()
        {
            double krastineA, krastineB, trikampioPlotas, kampas;
            Console.WriteLine("Iveskite A krastine:");
            krastineA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite B krastine: ");
            krastineB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite kampa tarp krastiniu: ");
            kampas = Convert.ToDouble(Console.ReadLine());
            trikampioPlotas = 0.5 * krastineA * krastineB * Math.Sin(kampas * Math.PI / 180);
            Console.WriteLine($"Trikampio plotas: {trikampioPlotas}");
        }
        
        private static void MatricuSudetisAtimtis()
        {
            int i, j, n;
            int[,] pirmMatrica = new int[50, 50];
            int[,] antraMatrica = new int[50, 50];
            int[,] sudetaMatrica = new int[50, 50];
            int[,] atimtaMatrica = new int[50, 50];

            Console.Write("Iveskite matricu dydi (maziau nei 5): ");
            n = Convert.ToInt32(Console.ReadLine());
                        
            Console.Write("Iveskite pirmos matricos elementus :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("elementai - [{0},{1}] : ", i, j);
                    pirmMatrica[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Iveskite antros matricos elementus :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("elementai - [{0},{1}] : ", i, j);
                    antraMatrica[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nPirma matrica :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", pirmMatrica[i, j]);
            }

            Console.Write("\nAntra matrica is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", antraMatrica[i, j]);
            }
            
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    sudetaMatrica[i, j] = pirmMatrica[i, j] + antraMatrica[i, j];
            Console.Write("\nDvieju matricu suma : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", sudetaMatrica[i, j]);
            }
            Console.Write("\n\n");
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    atimtaMatrica[i, j] = pirmMatrica[i, j] - antraMatrica[i, j];
            Console.Write("\nDvieju matricu atimtis : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", atimtaMatrica[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}