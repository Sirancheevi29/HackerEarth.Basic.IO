using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basic.IO
{
    /*
      Problem
        Bob has a playlist of 
        songs, each song has a singer associated with it (denoted by an integer)
        Favourite singer of Bob is the one whose songs are the most on the playlist
        Count the number of Favourite Singers of Bob

      Input Format 
        The first line contains an integer 
        denoting the number of songs in Bob's playlist.
        The following input contains 
         integers, 
         integer denoting the singer of the 
         song.

      Output Format
        Output a single integer, the number of favourite singers of Bob
        Note: Use 64 bit data type
     * 
     */

    public class FavoriteSinger
    {
        public static void Start()
        {
            try
            {
                int NoOfSongs = int.Parse(Console.ReadLine().Trim());
                List<int> playlist = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

                if (NoOfSongs == playlist.Count)
                    Console.WriteLine(CountFavouriteSingers(playlist));

            }
            catch { }
        }

        static int CountFavouriteSingers(List<int> playlist)
        {
            Dictionary<int, int> singerCounter = new Dictionary<int, int>();
            foreach (int singer in playlist)
            {
                if (singerCounter.ContainsKey(singer))
                    singerCounter[singer]++;
                else
                    singerCounter[singer] = 1;
            }

            int maxOccurrences = singerCounter.Values.Max();
            int numFavouriteSingers = singerCounter.Count(pair => pair.Value == maxOccurrences);
            return numFavouriteSingers;
        }

    }
}
