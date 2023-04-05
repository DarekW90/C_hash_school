class Program
{
    static void Main()
    {
        Console.WriteLine("Zadanie 12");
        Console.WriteLine("Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury.\nUżyj pętli for.");
        while (true)
        {
            Console.Write("Podaj wysokość: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
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
