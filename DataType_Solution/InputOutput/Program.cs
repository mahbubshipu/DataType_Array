using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string line = Console.ReadLine();

             while (true)
             {
                 int charValue = Console.Read();
                 char c = (char)charValue;
                 Console.WriteLine(c);
             }
             ConsoleKeyInfo key = Console.ReadKey();

             Console.WriteLine("Hello World!");
            */
            //var validNumber = Console.ReadLine();
            //int validNum;
            //bool successfulConverted = int.TryParse(validNumber, out validNum);
            //Console.WriteLine(successfulConverted);

            //var line = Console.ReadLine();
            //var lineparts=line.Split(',');

            //var wholeNumber = int.Parse(lineparts[0]);
            //var fractionNumber = double.Parse(lineparts[1]);

            //Turnering operator
            int x = 5;

            var message = x > 4 ? "This is correct" : "This is not correct";
            Console.WriteLine(message);

        }
    }
}
