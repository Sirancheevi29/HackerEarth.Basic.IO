using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    public class Zoo
    {
        public static void Start()
        {
            try
            {
                string input = Console.ReadLine();
                int ZLetter = input.Length - input.Replace("z", " ").Trim().Length;
                int OLetter = input.Length - input.Replace("o", " ").Trim().Length;

                Console.WriteLine(ZLetter * 2 == OLetter ? "Yes" : "No");
            }
            catch
            {

            }
        }
    }
}