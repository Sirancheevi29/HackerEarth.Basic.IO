using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    public class Polyndrome
    {
        public static void Start()
        {
            string input = Console.ReadLine();
            bool IsPolyndrome = false;

            try
            {
                string Polyndrome = input.Trim().ToLower();

                if(Polyndrome.Length >=0 && Polyndrome.Length <=100)
                {
                    char[] chars = new char[Polyndrome.Length];
                    chars = Polyndrome.ToCharArray().Reverse<char>().ToArray();

                    string reversedString = new string(chars);

                   IsPolyndrome =  Polyndrome == reversedString ? true : false;

                    Console.WriteLine(IsPolyndrome ? "YES" : "NO");
                }
            }
            catch
            {

            }
        }
    }
}
