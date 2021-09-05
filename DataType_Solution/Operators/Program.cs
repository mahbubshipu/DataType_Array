using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x++;
            int z = ++x;
            Console.WriteLine(z);
            if (x > 4)
            {
                Console.WriteLine("My name is Shipu");
            }
            else if(x>5){
                Console.WriteLine("My name is Jerin");
            }
            else if(x>6){
                Console.WriteLine("My name is Sakib");
            }
            else
            {
                Console.WriteLine("My name is Kichu e na");
            }
        }
    }
}
