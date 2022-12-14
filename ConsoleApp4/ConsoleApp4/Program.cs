using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("witaj w grze");
            Console.WriteLine("jak ci na imię?");
            string nazwa = Console.ReadLine();
            int życie = 0;
            int sila = 0;
            int mana = 0;
            int kaska = 0;
            bool tchorz = false;
            bool żywy = true;
            double zycie2 = 0;
            string klasa = "dwa";
            Console.WriteLine("witaj " + nazwa);
            Console.WriteLine("wybierz klasę postaci: a - ksiadz, b - ministrant, c - biskup Rydzyk, d - aniolek, e - murzyn, f - bialy");
            string KlasaPostaci = Console.ReadLine();
            if (KlasaPostaci == "a")
            {
                życie = 110;
                sila = 110;
                mana = 111;
                kaska = 112;
                klasa = "ksiadz";
            }
            else
            {


                if (KlasaPostaci == "b")
                {
                    życie = 100;
                    sila = 39;
                    mana = 20;
                    kaska = 0;
                    klasa = "ministrant";
                }
                else
                {


                    if (KlasaPostaci == "c")
                    {
                        życie = 70;
                        sila = 100;
                        mana = 10000;
                        kaska = 1000000;
                        klasa = "biskup Rydzyk";
                    }
                    else
                    {


                        if (KlasaPostaci == "d")
                        {
                            życie = 999;
                            sila = 40;
                            mana = 999999;
                            kaska = 1000000;
                            klasa = "aniolek";
                        }
                        else
                        {


                            if (KlasaPostaci == "e")
                            {
                                życie = 1;
                                sila = 1;
                                mana = 1;
                                kaska = 1;
                                klasa = "czarny";
                            }
                            else
                            {


                                if (KlasaPostaci == "f")
                                {
                                    życie = 999999;
                                    sila = 999999;
                                    mana = 999999;
                                    kaska = 999999;
                                    klasa = "czarny";
                                }
                                else
                                {
                                    Console.WriteLine("nie ma takiej klasy");
                                    żywy = false;
                                    zycie2 = 0;
                                }
                            }
                        }
                    }
                }
            }
            Random rnd = new Random();

            if (życie > 0)
            {
                Console.WriteLine("witaj " + nazwa + " twoja klasa to: " + klasa);

                zycie2 = rnd.Next(500, 5000);


                Console.WriteLine("spotykasz innowiercę");
            }
            
            
             while (zycie2 > 0)
            { 
                  if (życie < 0)
                  { 
                    Console.WriteLine("umierasz");
                    żywy = false;
                    break;
                  }
                int atak2 = rnd.Next(40, 120);
                życie -= atak2;

                Console.WriteLine("innowierce cie atakuje");
                Console.WriteLine("zadaje ci " + atak2 + " obrazen" );
                Console.WriteLine("pozostaje ci " + życie + " życia");



                Console.WriteLine("wybierz akcje");
                Console.WriteLine("a - krucjata akcje, b - telefon do papieza, c - wyslij do piekla ,d - ucieczka");
                string akcja = Console.ReadLine();
                if (akcja == "a")
                {
                    Console.WriteLine("wypowiadasz krucjate");
                    zycie2 -= sila;
                    if (zycie2 < 0)
                    {
                        break;
                    }
                    Console.WriteLine("innowiercy zostało " + zycie2 + " życia");


                }
                if (akcja == "b")
                {
                    Console.WriteLine("dzwonisz po papieza");
                    if (kaska > 100)
                    {
                        zycie2 -= 21.37;
                        kaska -= 100;
                        if (zycie2 < 0)
                        {
                            break;
                        }
                        Console.WriteLine("innowiercy zostało " + zycie2 + " życia");
                    }
                    else
                    { 
                        Console.WriteLine("jestes biedny (XD)"); 
                    }
                }
                if (akcja == "c")
                {
                    

                    if (mana > 120)
                    {
                        Console.WriteLine("wysylasz innowierce do piekla");
                        zycie2 -= zycie2;
                        mana -= 120;

                    }
                    else
                    {
                        Console.WriteLine("za malo many");
                    }   

                }
                if (akcja == "d")
                {
                    Console.WriteLine("uciekasz");
                    tchorz = true;
                    break;
                }
                
                if (życie == 0)
                {
                    żywy = false;
                    break;
                }
             }
            if (tchorz == true)
            {
                Console.WriteLine("ale z ciebie tchórz " + nazwa);
                żywy = false;
            }
            if (żywy == true)
            {
                Console.WriteLine("gratulacje użytkowniku");
                Console.WriteLine("pokonales innowierce i przywrociles wiare w Boga na swiecie");
                Console.WriteLine("jestes 12/10 i Bog cie kocha");
            }
            if (żywy == false)
            {
                Console.WriteLine("przegrales");
            }
            Console.ReadKey();
        }

    }
}