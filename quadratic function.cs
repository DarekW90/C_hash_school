namespace Zadanie_2.__FunkcjaKwadratowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, root, x1, x2, sqrB, x; // zmiennie
            //wprowadzenie
            Console.WriteLine("Zadanie 2\n");
            Console.WriteLine("Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki\r\nfunkcji kwadratowej (a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich\r\nbraku.\n");
            string yesNo;
            do
            {
                //przyładowe dane do testow --- wyłączyc finalnie
                Console.WriteLine("Przykładowe dane dla delty dodatniej:\na=2  b=7  c=6\na=-2 b=-4 c=6");
                Console.WriteLine("Przykładowe dane dla delty ujemnej:\na=2  b=3  c=2");
                Console.WriteLine("Przykładowe dane dla delty zerowej:\na=2  b=4  c=2\n");
                {

                    //wprowadzanie danych
                    Console.Write("Podaj a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj c = ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    //obliczenie kwadratuB oraz delty
                    sqrB = Math.Pow(b, 2);
                    delta = sqrB - 4 * a * c;
                    Console.WriteLine("Obliczanie Delty:\n\nDelta=b^2-4ac=\n={0}^2-4*{1}*{2}=\n={3}\n", b, a, c, (sqrB) - (4 * a * c));
                }
                {
                    //delta mniejsza od zera

                    if (delta < 0)
                    {
                        Console.WriteLine("Delta jest mniejsza od zera, równanie nie ma rozwiązań!\n");
                    }

                    //delta większa od zera
                    else if (delta > 0 && b < 0) //mała zmiana dla poprawnego zapisu by usunąć podwojonych znaków " -- " przy obliczeniach x1 i x2
                    {
                        Console.WriteLine("Delta jest większa od zera, równanie ma dwa rozwiązania!\n");
                        //obliczenie pierwiastka z delta
                        root = Math.Sqrt(delta); //Math.Pow(delta, 2) potegowanie zmienna - double
                        Console.WriteLine("Pierwiastek z delty wynosi {0}\n", root);
                        Console.WriteLine("Obliczanie wartości x1 i x2\n");
                        //obliczenie x1 i x2
                        x1 = (-b - root) / (2 * a);
                        Console.WriteLine("x1=((-b)-PierwiastekDelta)/(2*a)=\n=(({0})-{1})/(2*{2})=\n={3}\n", b, root, a, x1);
                        x2 = (-b + root) / (2 * a);
                        Console.WriteLine("x2=((-b)+PierwiastekDelta)/(2*a)\n=(({0})+{1})/(2*{2})=\n={3}\n", b, root, a, x2);
                        Console.WriteLine("Równanie ma dwa rozwiązania {0} oraz {1}", x1, x2);
                    }
                    else if (delta > 0)
                    {
                        Console.WriteLine("Delta jest większa od zera, równanie ma dwa rozwiązania!\n");
                        //obliczenie pierwiastka z delta
                        root = Math.Sqrt(delta); //Math.Pow(delta, 2) potegowanie zmienna - double
                        Console.WriteLine("Pierwiastek z delty wynosi {0}\n", root);
                        Console.WriteLine("Obliczanie wartości x1 i x2\n");
                        //obliczenie x1 i x2
                        x1 = (-b - root) / (2 * a);
                        Console.WriteLine("x1=((-b)-PierwiastekDelta)/(2*a)=\n=((-{0})-{1})/(2*{2})=\n={3}\n", b, root, a, x1);
                        x2 = (-b + root) / (2 * a);
                        Console.WriteLine("x2=((-b)+PierwiastekDelta)/(2*a)\n=((-{0})+{1})/(2*{2})=\n={3}\n", b, root, a, x2);
                        Console.WriteLine("Równanie ma dwa rozwiązania: {0} oraz {1}", x1, x2);
                    }

                    //delta równa zero
                    else if (delta == 0 && b < 0) // zmiana dla poprawnego zapisu we wzorze do obliczenia x
                    {
                        Console.WriteLine("Delta jest równa zero, równanie ma jedno rozwiązanie!\n");
                        //obliczenie x
                        x = ((-b) / (2 * a));
                        Console.WriteLine("Obliczanie rozwiązania:\nx=-b*(2*a)=\n={0}*(2*{1})=\n={2}\n", b, a, x);
                        Console.WriteLine("Równanie ma jedno rozwiązanie: {0}", x);
                    }
                    else if (delta == 0)
                    {
                        Console.WriteLine("Delta jest równa zero, równanie ma jedno rozwiązanie!\n");
                        //obliczenie x
                        x = ((-b) / (2 * a));
                        Console.WriteLine("Obliczanie rozwiązania:\nx=-b*(2*a)=\n=-{0}*(2*{1})=\n={2}\n", b, a, x);
                        Console.WriteLine("Równanie ma jedno rozwiązanie: {0}", x);
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