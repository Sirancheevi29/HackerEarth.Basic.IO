using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    public class Factorial
    {

        public static void Start()
        {
            try
            {
                string Input = Console.ReadLine();

                int factorialNumber = int.Parse(Input);

                if (factorialNumber >= 0 && factorialNumber <= 10) {
                    if (factorialNumber == 0 || factorialNumber == 1)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        int sumOutput = 0;
                        for (int i = factorialNumber; i > 0; i--) {
                            if(sumOutput > 0)
                            {
                                sumOutput = sumOutput * i;
                            }
                            else
                            {
                                sumOutput = i;
                            }
                        }
                        Console.WriteLine(sumOutput);
                    }

                }

            }
            catch { }

        }
    }
}
