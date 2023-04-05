class Program
{
    static void Main()
    {
        Console.WriteLine("Zadanie 14");
        Console.WriteLine("Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału.");
        Console.WriteLine("");
        while (true)
        {
            Console.Write("Początek przedziału: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Koniec przedziału: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = i; j <= end; j++)
                {
                    for (int k = j; k <= end; k++)
                    {
                        if (i * i + j * j == k * k)
                            Console.WriteLine("{0}, {1}, {2}", i, j, k);

                    }
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


