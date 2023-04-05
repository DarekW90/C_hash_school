namespace Zadanie_3._Zamiana_liczb_i_cyfr_na_słowa
{

    class Program
    {

        static string GiveHundreds(int cyfra)
        {
            switch (cyfra)
            {
                case 1: return "sto ";
                case 2: return "dwieście ";
                case 3: return "trzysta ";
                case 4: return "czterysta ";
                case 5: return "pięćset ";
                case 6: return "sześćset ";
                case 7: return "siedemset ";
                case 8: return "osiemset ";
                case 9: return "dziewięćset ";
                default: return "";
            }
        }
        static string GiveTens(int cyfra)
        {
            switch (cyfra)
            {
                case 1: return "dziesięć ";
                case 2: return "dwadzieścia ";
                case 3: return "trzydzieści ";
                case 4: return "czterdzieści ";
                case 5: return "pięćdziesiąt ";
                case 6: return "sześćdziesiąt ";
                case 7: return "siedemdziesiąt ";
                case 8: return "osiemdziesiąt ";
                case 9: return "dziewięćdziesiąt ";
                default: return "";
            }
        }
        static string GiveTeens(int liczba)
        {
            switch (liczba)
            {
                case 10: return "dziesięć ";
                case 11: return "jedenaście ";
                case 12: return "dwanaście ";
                case 13: return "trzynaście ";
                case 14: return "czternascie ";
                case 15: return "piętnaście ";
                case 16: return "szesnaście ";
                case 17: return "siedemnaście ";
                case 18: return "osiemnaście ";
                case 19: return "dziewiętnaście ";
                default: return "";
            }
        }
        static string GiveNumber(int cyfra)
        {
            switch (cyfra)
            {
                case 1: return "jeden ";
                case 2: return "dwa ";
                case 3: return "trzy ";
                case 4: return "cztery ";
                case 5: return "pięć ";
                case 6: return "sześć ";
                case 7: return "siedem ";
                case 8: return "osiem ";
                case 9: return "dziewięć ";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 3:");
            Console.WriteLine("Napisać program wczytujący liczbę arabską od 1 do 1 000 000 i wypisujący na ekranie słownie wczytaną liczbę.\nNp.: wejście=105, wyjście=sto pięć.\n");

            string yesNo;
            do
            {

                Console.Write("Podaj liczbe całkowitą od 1 do 1 000 000: ");
                int liczba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Liczba podana to: " + liczba);
                Console.Write("Liczba słownie to: ");


                if (liczba >= 1 && liczba <= 1000000)
                {
                    //dla jednosci
                    if (liczba >= 1 && liczba < 10)
                    {
                        Console.Write("" + GiveNumber(liczba));
                    }
                    //dla nastek
                    else if (liczba >= 10 && liczba < 20)
                    {
                        Console.Write("" + GiveTeens(liczba));
                    }
                    //dla dziesiętnych
                    else if (liczba >= 20 && liczba < 100)
                    {
                        Console.Write("" + GiveTens(liczba / 10));
                        liczba %= 10;
                        Console.Write("" + GiveNumber(liczba));
                    }
                    //dla setnych
                    else if (liczba >= 100 && liczba < 1000)
                    {
                        if (liczba / 100 >= 1) // || liczba / 100 == 0)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                    }

                    // od 1000 do 1999
                    else if (liczba >= 1000 && liczba < 2000)
                    {
                        if (liczba >= 1000 && liczba < 2000)
                        {
                            Console.Write("tysiąc ");
                            liczba %= 1000;
                        }
                        if (liczba >= 100)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                    }
                    // do tego momentu wszystko dziala                     

                    // od 2000 do 4999
                    else if (liczba >= 2000 && liczba < 5000)
                    {
                        if (liczba >= 2000 && liczba < 5000)
                        {
                            Console.Write("" + GiveNumber(liczba / 1000) + "tysiące ");
                            liczba %= 1000;
                        }
                        if (liczba >= 100)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                    }

                    // od 5000 do 10000

                    else if (liczba >= 5000 && liczba < 10000)
                    {
                        if (liczba >= 5000 && liczba < 10000)
                        {
                            Console.Write("" + GiveNumber(liczba / 1000) + "tysięcy ");
                            liczba %= 1000;
                        }
                        if (liczba >= 100)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                    }

                    // nastki dziesięciotysieczne 

                    else if (liczba >= 10000 && liczba < 20000)
                    {
                        if (liczba >= 10000 && liczba < 20000)
                        {
                            Console.Write("" + GiveTeens(liczba / 1000) + "tysięcy ");
                            liczba %= 1000;
                        }
                        if (liczba >= 100)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                        else if (liczba < 10)
                        {
                            Console.Write(""+ GiveNumber(liczba));
                        }
                    }

                    // 20.000 - 100.000

                    else if (liczba >= 20000 && liczba < 100000)
                    {
                        if (liczba >= 20000 && liczba < 100000)
                        {
                            Console.Write("" + GiveTens(liczba / 10000));
                            liczba %= 10000;
                            Console.Write("" + GiveNumber(liczba / 1000));
                            if (liczba / 1000 == 0 || liczba / 1000 == 1 || liczba / 1000 >= 5)
                            {
                                Console.Write("tysięcy ");
                            }
                            else if (liczba / 1000 == 2 || liczba / 1000 == 3)
                            {
                                Console.Write("tysięce ");
                            }
                            liczba %= 1000;
                        }
                        if (liczba >= 100)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                    }

                    // 100.000 - 1.000.000

                    else if (liczba >= 100000 && liczba < 1000000)
                    {
                        if (liczba >= 100000 && liczba < 120000)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100000));
                            liczba %= 100000;
                            Console.Write("" + GiveTeens(liczba / 1000));
                            liczba %= 10000;
                            Console.Write("" + GiveNumber(liczba / 1000));
                            if (liczba / 1000 == 0 || liczba / 1000 == 1 || liczba / 1000 >= 5)
                            {
                                Console.Write("tysięcy ");
                            }
                            else if (liczba / 1000 == 2 || liczba / 1000 == 3)
                            {
                                Console.Write("tysięce ");
                            }
                            liczba %= 1000;
                        }
                        else if (liczba >= 120000 && liczba < 1000000)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100000));
                            liczba %= 100000;
                            Console.Write("" + GiveTens(liczba / 10000));
                            liczba %= 10000;
                            Console.Write("" + GiveNumber(liczba / 1000));

                            if (liczba / 1000 == 0 || liczba / 1000 == 1 || liczba / 1000 >= 5)
                            {
                                Console.Write("tysięcy ");
                            }
                            else if (liczba / 1000 >= 2 || liczba / 1000 <= 4)
                            {
                                Console.Write("tysięce ");
                            }
                            liczba %= 1000;
                        }
                        if (liczba >= 100)
                        {
                            Console.Write("" + GiveHundreds(liczba / 100));
                            liczba %= 100;
                        }
                        if (liczba >= 10 && liczba < 20)
                        {
                            Console.Write("" + GiveTeens(liczba));
                        }
                        else if (liczba >= 20 || liczba == 0)
                        {
                            Console.Write("" + GiveTens(liczba / 10));
                            liczba %= 10;
                            Console.Write("" + GiveNumber(liczba));
                        }
                        else if (liczba < 10)
                        {
                            Console.WriteLine("" + GiveNumber(liczba));
                        }
                    }

                    // milion !!

                    else if (liczba == 1000000)
                    {
                        Console.Write("milion");
                    }

                    // tutaj konczy się program główny

                }
                else if (liczba <= 0 || liczba > 1000000)
                {
                    if (liczba < 0)
                    {
                        Console.WriteLine("BŁĄD!\nPodana liczba jest mniejsza od zera.\nProszę podać liczbę całkowitą w przedziale 1 do 1 000 000");
                    }
                    else if (liczba == 0)
                    {
                        Console.WriteLine("BŁĄD!\nPodana liczba jest równa zero.\nProszę podać liczbę całkowitą w przedziale 1 do 1 000 000");
                    }
                    else if (liczba > 1000000)
                    {
                        Console.WriteLine("BŁĄD!\nPodana liczba jest większa od miliona.\nProszę podać liczbę całkowitą w przedziale 1 do 1 000 000");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Wcisnij 'n' by opuścic program, lub 't' by powtorzyć program");
                yesNo = Console.ReadLine().ToLower();
                while (!yesNo.Equals("t") && !yesNo.Equals("n"))
                {
                    Console.WriteLine("Błąd!");
                    Console.WriteLine("Wcisnij 'n' by opuścic program, lub 't' by powtorzyć program");
                    yesNo = Console.ReadLine().ToLower();
                }
            } while (yesNo.Equals("t"));
            Console.WriteLine("Wykonał: Dariusz Walda");
            Console.ReadKey();
        }
    }
}