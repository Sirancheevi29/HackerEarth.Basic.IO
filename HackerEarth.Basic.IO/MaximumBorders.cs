using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    /*
     Problem
        You are given a table with rows and columns. Each cell is colored with white or black. Considering the shapes created by black cells, what is the maximum border of these shapes? Border of a shape means the maximum number of consecutive black cells in any row or column without any white cell in between.
        A shape is a set of connected cells. Two cells are connected if they share an edge. Note that no shape has a hole in it.
     Input format
        The first line contains denoting the number of test cases.
        The first line of each test case contains integers denoting the number of rows and columns of the matrix. Here, '#' represents a black cell and '.' represents a white cell. 
        Each of the next lines contains integers.
     Output format
        Print the maximum border of the shapes.
    */
    public class MaximumBorders
    {
        public static void start()
        {
            try
            {
                int NoOfTestCases = int.Parse(Console.ReadLine().Trim());
                

                for (int t = 0; t < NoOfTestCases; t++)
                {
                    int[] tableFormat = Console.ReadLine().Trim().Split().Select(x => int.Parse(x.Trim())).ToArray();

                    List<Dictionary<int, string>> tableContent = new List<Dictionary<int, string>>();
                
                    while (tableFormat.Length > 0)
                    {
                        for (int r   = 0; r < tableFormat[0]; r++)
                        {
                            char[] colvalues = Console.ReadLine().ToCharArray();
                            Dictionary<int,string> row = new Dictionary<int,string>();  

                            for (int c = 0; c < colvalues.Length; c++)
                            {
                                row.Add(c, colvalues[c].ToString());
                            }

                            tableContent.Add(row);
                        }

                        Console.WriteLine(tableContent);
                    }

                    int MaxBorders = 0;
                    int RowMax = 0;
                    int ColMax = 0;

                    for (int ir = 0; ir < tableFormat[0]; ir++)
                    {
                        Dictionary<int, string> row = new Dictionary<int, string>();
                        row= tableContent[ir];
                        int LRowMax = 0;

                        for (int iv = 1; iv < row.Count; iv++)
                        {
                            if (row[iv] =="#")
                            {
                                if (row[iv] =="#" && row[iv-1] =="#") { LRowMax++; }
                            }
                        }
                        if (LRowMax > RowMax) RowMax = LRowMax;
                    }

                    for (int ir = 1; ir < tableFormat[1]; ir++)
                    {
                        Dictionary<int, string> row = new Dictionary<int, string>();
                        Dictionary<int, string> Prow = new Dictionary<int, string>();

                        Prow = tableContent[ir - 1];
                        row = tableContent[ir];

                        int LRowMax = 0;

                        for (int iv = 1; iv < row.Count; iv++)
                        {
                            if (row[iv] == "#")
                            {
                                if (row[iv] == "#" && row[iv - 1] == "#") { LRowMax++; }
                            }
                        }
                        if (LRowMax > RowMax) RowMax = LRowMax;
                    }

                    Console.WriteLine(MaxBorders);
                }
                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
