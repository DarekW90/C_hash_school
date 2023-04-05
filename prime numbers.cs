class Program
{
    static void Main()
    {
        Console.WriteLine("Zadanie 8");
        Console.WriteLine("Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.");
        while (true)
        {
            Console.WriteLine("");
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            bool prime = true;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
                i++;
            }
            Console.WriteLine("");
            if (prime)
                Console.WriteLine("Tak! Liczba {0} jest pierwszą", n);
            else
                Console.WriteLine("Nie! Liczba {0} nie jest pierwsza", n);


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
