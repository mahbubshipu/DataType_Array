using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 5;
            //Console.WriteLine(x);
            decimal y = 6.50M;
            double z = 6.50;
            //Console.WriteLine(z);
            //Console.WriteLine(y);
            DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            int[] ages = new int[20];
            ages[0] = 12;
            ages[1] = 15;
            ages[2] = 20;

            //Console.WriteLine(ages[1]);

            int[,] board = new int[20, 30];
            board[0, 0] = 15;
            //Console.WriteLine(board.Length);

            int[] setvalue1 = new int[] { 10, 20, 30 };
            //Console.WriteLine(setvalue1[1]);//return 20
            int[,,] setValue2 = new int[,,]
            {
                {{ 1, 2, 3,20},{4, 5, 6,25}},//R R C -3D array
                { { 7, 8, 9,35},{10, 11, 12,40}},
                { { 17, 18, 19,55},{20, 21, 12,60}}
            };

            Console.WriteLine(setValue2[0, 1, 2]);//output 6
            Console.WriteLine(setValue2[0, 1, 1]);//output 5
            Console.WriteLine(setValue2[1, 1, 1]);//output 11
            Console.WriteLine(setValue2[1, 0, 1]);//output 8
            Console.WriteLine(setValue2[1, 0, 3]);//output 35
            Console.WriteLine(setValue2[2, 0, 3]);//output 55
            int[,] setvalue3 = new int[,] //2D Array
            {
                {10,20 },
                {30,40 }
            };
            int[,,] shops = new int[,,]
            {
                {{1, 2, 3,20},{4, 5, 6,25 } },
                {{4, 5, 6,25},{4, 5, 6,25 } }
            };

            //Jagged Array
            string[] students =new string[] { "Shipu", "Jerin", "Ruhul" };

            string[][] subjects = new string[3][];
            subjects[0] =new string[4];
            subjects[1] = new string[3];
            subjects[2] = new string[2];

            subjects[0][0] = "Accounting";
            subjects[0][1] = "Finance";
            subjects[0][2] = "Marketing";
            subjects[0][3] = "Management";

            subjects[1][0] = "Bangla";
            subjects[1][1] = "English";
            subjects[1][2] = "Mathematics";

            subjects[2][0] = "Physics";
            subjects[2][1] = "Camisty";
            
            for(int i = 0; i < subjects.Length; i++)
            {
                string[] arrayElement = subjects[i];
                Console.WriteLine(students[i]);
                Console.WriteLine("-----------");
                for(int j=0; j<arrayElement.Length; j++)
                {
                    Console.WriteLine(arrayElement[j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Md. Mahbubul Alom Shipu");
        }
    }
}
