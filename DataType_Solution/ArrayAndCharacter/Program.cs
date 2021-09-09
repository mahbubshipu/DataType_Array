using System;
using System.Text;

namespace ArrayAndCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = new int[] { 12, 25, 24, 14, 72, 90 };
            //Array.Reverse(ages);
            string name = "Mahbubulalom";
            var pos = name.IndexOf('u',4);
            name = name.Replace("u", " j");
            Console.WriteLine(name);
            var demoString = "--Hello--World--";
            demoString = demoString.Trim('-');
            Console.WriteLine(demoString);
            int spacePos = name.IndexOf(' ');
            var firstName = name.Substring(spacePos+1);
            Console.WriteLine(firstName);

            string abigText = "alkjahaDlaljaghafjagDGHJGhagfhDgagfajgfjaghfddd";
            StringBuilder sb = new StringBuilder(abigText);
            for(var i=0; i < abigText.Length; i++)
            {
                if (char.ToUpper(sb[i]) =='D')
                    sb[i] = 'p';
            }
            abigText = sb.ToString();
            Console.WriteLine(abigText);

            char c ='A';
            string sd = c.ToString();
            sd=sd.ToLower();
            Console.WriteLine(sd);

            string testString = Console.ReadLine();
            int[] frequency = new int[26];
            foreach(char x in testString)
            {
                var v = x;
                frequency[v - 'a']++;

            }
            for(var i=0; i < 26; i++)
            {
                Console.WriteLine($"{(char)('a' + i)}={frequency[i]}");
            }
           

        }
    }
}
