class MainClass
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int number;
        Console.WriteLine("Zadanie 10");
        Console.WriteLine("Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do napotkania zera. Wypisz otrzymaną sumę na ekranie.\nUżyj pętli do-while.");
        while (true)
        {
            do
            {
                Console.Write("Podaj liczbę: ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            } while (number != 0);

            Console.WriteLine("Suma liczb: " + sum);
            Console.WriteLine("");
            Console.WriteLine("Czy chcesz kontynuować? (T/N)");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "N")
            {
                Console.Write("Wykonał: Dariusz Walda");
                break;
            }
        }
    }
}

