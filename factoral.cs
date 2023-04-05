namespace Ćwiczenie_4___silna___petla_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesNo;
            do
            {
                int n, i, wynik = 1;
                Console.WriteLine("Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury liczby naturalnej n.\nUżyj pętli while.\nNp.: dla n=5 wypisz wynik 5!=120.");
                Console.WriteLine();
                Console.Write("Podaj n! = ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                    wynik *= i;
                Console.WriteLine();
                Console.WriteLine("Wynik to: {0}! = {1}", n, wynik);

                Console.WriteLine("Wcisnij 'n' by zakończyć, 't' by powtórzyć");
                yesNo = Console.ReadLine().ToLower();
                while (!yesNo.Equals("t") && !yesNo.Equals("n"))
                {
                    Console.WriteLine("error");
                    Console.WriteLine("Wcisnij 'n' by zakończyć, 't' by powtórzyć");
                    yesNo = Console.ReadLine().ToLower();
                }
            }
            while (yesNo.Equals("t"));
            Console.WriteLine("Wykonał: Dariusz Walda");
            Console.ReadKey(true);
        }
    }
}