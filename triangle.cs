namespace Zadanie_1._trójkąt
{
    internal class Program
    {
        static void Main(string[] args, string yesNo)
        {
 
                Console.WriteLine("Zadanie nr.1");
                Console.WriteLine();
                Console.WriteLine("Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie\ninformację czy da się z tych odcinków zbudować trójkąt, czy też nie.");
                Console.WriteLine();
                Console.WriteLine("By zbudować trójkąt, suma dwóch losowych boków musi być dłuższa niż długość boku trzeciego");
                Console.WriteLine();
            string yesNo;
            do
            {               
                int a, b, c;
                Console.Write("Proszę podać długość boku a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Proszę podać długość boku b=");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Proszę podać długość boku c=");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                    Console.WriteLine("Możesz zbudowac trójkąt");
                }
                else
                {
                    Console.WriteLine("Nie możesz zbudować trójkąta");
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