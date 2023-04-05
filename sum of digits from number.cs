class Program
{
    static void Main()
    {
        Console.Write("Zadanie 9");
        Console.Write("Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.\nUżyj pętli while");
        while (true)
        {
            Console.WriteLine("");
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("");
            Console.WriteLine("Suma cyfr wynosi: {0}", sum);
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
