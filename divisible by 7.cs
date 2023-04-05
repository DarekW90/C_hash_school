using System;

class Program
{
    static void Main()
    {

        {
            Console.WriteLine("Zadanie 10");
            Console.WriteLine("Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7.\nIlość liczb wczytaj z klawiatury.\nUżyj pętli for.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Ile kolejnych liczb podzielnych przez 7 chcesz wypisac? Podaj: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                for (int i = 1; count < n; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(i);
                        count++;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Czy chcesz kontynuować? (T/N)");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "N")
                {                
                    Console.WriteLine("Wykonał: Dariusz Walda");
                    break;
                }

            }
        }
    }
}