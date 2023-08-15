using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    public class MaxBorders
    {
        public static void Start()
        {
            int NoOfTestCases = int.Parse(Console.ReadLine().Trim());


            for (int t = 0; t < NoOfTestCases; t++)
            {
                int[] tableFormat = Console.ReadLine().Trim().Split().Select(x => int.Parse(x.Trim())).ToArray();

                int maxRows = tableFormat[0];
                string[][] tableArray = new string[maxRows][];

                if (tableFormat.Length == 2)
                {
                    for (int r = 0; r < tableFormat[0]; r++)
                    {
                        char[] colvalues = Console.ReadLine().ToCharArray();
                        tableArray[r] = new string[colvalues.Length];

                        for (int c = 0; c < colvalues.Length; c++)
                        {
                            tableArray[r][c] = colvalues[c].ToString();
                        }

                    }

                    int MaxRowBorders = 0;
                    int MaxColBorders = 0;
                    List<int> maxfoundBorders = new List<int>();

                    //for loop for rows
                    for (int i = 0; i < tableFormat[0]; i++)
                    {
                        int RowBorders = 0;
                      

                        //for loop for Columns
                        for (int c = 0; c < tableFormat[1]; c++)
                        {
                            if (tableArray[i][c] == "#")
                            {
                                if (c == 0) RowBorders++;
                                else if (RowBorders == 0) RowBorders++;
                                else if (tableArray[i][c - 1] == "#") RowBorders++;
                            }
                            else
                            {
                                if (RowBorders > 0) { maxfoundBorders.Add(RowBorders); }
                                RowBorders = 0;
                            }
                        }
                        if(RowBorders>0) { maxfoundBorders.Add(RowBorders); }

                        if (maxfoundBorders.Count > 0)
                        {
                            if (maxfoundBorders.Max() > MaxRowBorders) MaxRowBorders = maxfoundBorders.Max();
                        }
                    }

                    if(MaxRowBorders > tableFormat[1])
                    {
                        Console.WriteLine(MaxRowBorders);
                        return;
                    }

                    List<int> maxfoundColBorders = new List<int>();

                    for (int i = 0; i < tableFormat[1]; i++)
                    {
                        int colBorders = 0;

                        for (int j = 0; j < tableFormat[0]; j++)
                        {
                            if (tableArray[j][i] == "#")
                            {
                                if (j == 0) colBorders++;
                                else if (colBorders == 0) colBorders++;
                                else if(tableArray[j - 1][i] == "#") colBorders++;
                            }
                            else
                            {
                                if (colBorders > 0) { maxfoundColBorders.Add(colBorders); }
                                colBorders = 0;
                            }
                        }
                       
                        if(colBorders> 0) { maxfoundColBorders.Add(colBorders); }

                        if (maxfoundColBorders.Count > 0)
                        {
                            if (maxfoundColBorders.Max() > MaxColBorders) { MaxColBorders = maxfoundColBorders.Max(); }
                        }
                    }

                    if (MaxRowBorders > MaxColBorders) { Console.WriteLine(MaxRowBorders); }
                    if (MaxColBorders > MaxRowBorders) { Console.WriteLine(MaxColBorders); }
                }
            }
        }
    }
}
