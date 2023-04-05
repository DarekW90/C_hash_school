class Program
{
    static void Main()
    {

        Console.WriteLine("Zadanie 11");
        Console.WriteLine("Napisz program obliczający sumę n początkowych liczb nieparzystych.\nLiczbę n należy pobrać od użytkownika. Do obliczenia wartości sumy użyj pętli for.");
        while (true)
        {
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("");
            Console.WriteLine("Suma pierwszych " + n + " liczb nieparzystych wynosi: " + sum);
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