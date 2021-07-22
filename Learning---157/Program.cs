using System;
using System.IO;

namespace Learning___157
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szybkość dźwięku!");
            string medium;
            double distane;

            while (true)
            {
                try
                {
                    InpuDate(out medium, out distane);
                    Calc(medium, distane);
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Clear();
            }


        }

        private static void InpuDate(out string medium, out double distane)
        {
            Console.WriteLine("Wprowadź: powietrze, woda albo stal:");
            medium = Console.ReadLine();
            Console.WriteLine("Wprwoadź odległośc jaką fala dźwiękowa ma przebyć w wybranym nośniku:");
            distane = double.Parse(Console.ReadLine());
        }

        public static void Calc(string medium, double distane)
        {
            StreamWriter input = File.CreateText("Numbers.text");

            if (medium == "powietrze")
            {
                double time = distane / 343;
                Console.WriteLine($"Czas potrzebny na pokonanie tej odległości w wybranym medium wynosi {time.ToString("n2")} m/s");
                input.WriteLine($"Czas potrzebny na pokonanie tej odległości w wybranym medium wynosi {time.ToString("n2")}");
            }
            else if (medium == "woda")
            {
                double time = distane / 1490;
                Console.WriteLine($"Czas potrzebny na pokonanie tej odległości w wybranym medium wynosi {time.ToString("n2")}  m/s");
                input.WriteLine($"Czas potrzebny na pokonanie tej odległości w wybranym medium wynosi {time.ToString("n2")}");
            }
            else if (medium == "stal")
            {
                double time = distane / 5100;
                Console.WriteLine($"Czas potrzebny na pokonanie tej odległości w wybranym medium wynosi {time.ToString("n2")}  m/s");
                input.WriteLine($"Czas potrzebny na pokonanie tej odległości w wybranym medium wynosi {time.ToString("n2")}"); ;
            }
            else
            {
                Console.WriteLine("Wprowadzono złe dane!");
            }
            input.Close();

        }
    }
}
