using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    public class ArraySum
    {
        public static void Start()
        {
            int ArraySize = int.Parse(Console.ReadLine());
            
            int[] arrayvalues = new int[ArraySize];

            arrayvalues = Console.ReadLine().Split().Select(x => int.Parse(x.Trim())).ToArray();

            try
            {
                if(ArraySize >= 1 && ArraySize <= 10)
                {
                    Int64 sum = 0;
                    foreach(int x in arrayvalues)
                    {
                        sum += x;
                    }
                    Console.WriteLine(sum);
                }
            }
            catch
            {

            }
        }
    }
}
