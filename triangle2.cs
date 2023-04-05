class Program
{
    static void Main()
    {
        Console.WriteLine("Zadanie 13");
        Console.WriteLine("Wczytaj liczbę naturalną n (n>4).\nNarysuj na ekranie ze znaków X kontur trójkąta prostokątnego jak na poniższym przykładzie.\nUżyj pętli for.");
        Console.WriteLine("");
        while (true)
        {
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == i || i == n)
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("nie wiem czemu rysuje ciągle od lewej.... :( \npoza tym jest chyba ok :)");

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

