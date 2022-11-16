using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int startNumb = 1; startNumb < 5; startNumb++)
            {
                Console.WriteLine("Value of the start number is: " + startNumb);
            }

            Console.ReadKey();

            Console.WriteLine("Extension 1---------------------------------------------------------");
            Extension1();
            Console.ReadKey();

            Console.WriteLine("Extension 2---------------------------------------------------------");
            Extension2();
            Console.ReadKey();

            Console.WriteLine("Extension 3---------------------------------------------------------");
            Extension3();
            Console.ReadKey();
        }

        public static void Extension1()
        {
            int TimesTables;

            Console.WriteLine("Type number 1: ");
            TimesTables = int.Parse(Console.ReadLine());

            for (int TimesTableEnd = 12; TimesTables < TimesTableEnd; TimesTables++)
            {
                Console.WriteLine(TimesTables);
            }
        }

        public static void Extension2()
        {
            string Easy = "Easy";
            string Medium = "Medium";
            string Hard = "Hard";

            int TimesTables;

            Console.WriteLine("Select a level: " + "\n" + "Easy" + "\n" + "Medium" + "\n" + "Hard");
            string UserInput = Console.ReadLine();

            if (UserInput == Easy)
            {
                Console.WriteLine("Type number 1: ");
                TimesTables = int.Parse(Console.ReadLine());

                Console.WriteLine("The times tables of 1 up to 10:");

                for (int TimesTableEnd = 11; TimesTables < TimesTableEnd; TimesTables++)
                {
                    Console.WriteLine(TimesTables);
                }
            }

            if (UserInput == Medium)
            {
                Console.WriteLine("Type number 1: ");
                TimesTables = int.Parse(Console.ReadLine());

                Console.WriteLine("The times tables of 1 up to 30 are:");

                for (int TimesTableEnd = 31; TimesTables < TimesTableEnd; TimesTables++)
                {
                    Console.WriteLine(TimesTables);
                }
            }

            if (UserInput == Hard)
            {
                Console.WriteLine("Type number 1: ");
                TimesTables = int.Parse(Console.ReadLine());

                Console.WriteLine("The times tables of 1 up to 50 are:");

                for (int TimesTableEnd = 51; TimesTables < TimesTableEnd; TimesTables++)
                {
                    Console.WriteLine(TimesTables);
                }
            }
        }

        public static void Extension3()
        {
            Console.WriteLine("This is the ASCII character 0-255");

            for (int ASCII = 0; ASCII < 256; ASCII++)
            {
                Console.WriteLine(ASCII);
            }
        }
    }
}