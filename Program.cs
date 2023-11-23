using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gwbsa
{
    internal class Program
    {
        struct Datum
        {
            public int dan;
            public int mesec;
            public int godina;
        }
        struct Osoba
        {
            public string ime;
            public Datum rodjenje;
        }
        static void Main(string[] args)
        {
            Osoba[] osoba = new Osoba[2];
            bool b;
            for(int i = 0; i < osoba.Length; i++)
            {
                Console.Write("Unesite ime: ");
                osoba[i].ime = Console.ReadLine();
                do
                {
                    Console.Write("Unesite godinu rodjenja: ");
                    b = int.TryParse(Console.ReadLine(), out osoba[i].rodjenje.godina);
                }
                while (!b);
                do
                {
                    Console.Write("Unesite mesec rodjenja: ");
                    b = int.TryParse(Console.ReadLine(), out osoba[i].rodjenje.mesec);
                    if (osoba[i].rodjenje.mesec > 12 && osoba[i].rodjenje.mesec <= 0)
                    {
                        b = false;
                    }
                }
                while (!b);
                do
                {
                    Console.Write("Unesite dan rodjenja: ");
                    b = int.TryParse(Console.ReadLine(), out osoba[i].rodjenje.dan);
                    switch (osoba[i].rodjenje.mesec)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (osoba[i].rodjenje.dan > 31 && osoba[i].rodjenje.dan <= 0)
                            {
                                b = false;
                            }
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (osoba[i].rodjenje.dan > 30 && osoba[i].rodjenje.dan <= 0)
                            {
                                b = false;
                            }
                            break;
                        case 2:
                            if (osoba[i].rodjenje.godina / 4 == 0 || (osoba[i].rodjenje.godina / 100 == 0 && osoba[i].rodjenje.godina / 400 == 0))
                            {
                                if (osoba[i].rodjenje.dan > 29 && osoba[i].rodjenje.dan <= 0)
                                {
                                    b = false;
                                }
                            }
                            else if (osoba[i].rodjenje.dan > 28 && osoba[i].rodjenje.dan <= 0)
                            {
                                b = false;
                            }
                            break;
                        default:
                            b = false;
                            break;
                    }
                }
                while (!b);
            }
            for(int i = 0; i < osoba.Length; i++)
            {
                Console.Write($"Ime: {osoba[i].ime}\n" +
                    $"Datum rodjenja {osoba[i].rodjenje.dan}.{osoba[i].rodjenje.mesec}.{osoba[i].rodjenje.godina}");
            }
            Console.ReadKey();
        }
    }
}
