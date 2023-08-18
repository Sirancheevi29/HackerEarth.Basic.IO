using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    public class Divisibility
    {
        public static void Start()
        {
            int Size = int.Parse(Console.ReadLine());
            int[] sizeArrays = new int[Size];   

            sizeArrays = Console.ReadLine().Split().Select(int.Parse).ToArray();

            try
            {
                if(Size > 0)
                {
                    if (Size == sizeArrays.Length)
                    {
                        int lastVal = sizeArrays.Last<int>();

                        Console.WriteLine(lastVal % 10 == 0 ? "Yes": "No");
                    }
                }

            }
            catch
            {

            }
        }
    }
}
