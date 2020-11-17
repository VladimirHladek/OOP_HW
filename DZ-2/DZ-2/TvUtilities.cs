using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_2
{
    class TvUtilities
    {
        public static Episode Parse(string episodesInputs)
        {
            string[] episodeInfos = episodesInputs.Split(",");

            int viewerCount = Convert.ToInt16(episodeInfos[0]);

            string[] array1 = episodeInfos[1].Split(".");
            double collectiveScore = Convert.ToDouble(array1[0]) + Convert.ToDouble(array1[1]) / 100.0;

            string[] array2 = episodeInfos[2].Split(".");
            double maxScore = Convert.ToDouble(array2[0]) + Convert.ToDouble(array2[1]) / 100.0;

            //double collectiveScore = Convert.ToDouble(episodeInfos[1]);
            //double maxScore = Convert.ToDouble(episodeInfos[2]);
            int episodeNum = Convert.ToInt16(episodeInfos[3]);

            string[] episodeLenInfos = episodeInfos[4].Split(":");

            TimeSpan episodeLen = TimeSpan.FromMinutes(Convert.ToInt16(episodeLenInfos[1]));
            string episodeName = episodeInfos[5];


            return new Episode(viewerCount, collectiveScore, maxScore, new Description(episodeNum, episodeLen, episodeName));
        }

        public static void EpisodeSwap(ref Episode a, ref Episode b)
        {
            Episode temp = a;
            a = b;
            b = temp;
        }

        public static void Sort(Episode[] episodes)
        {
            int i, j, n = episodes.Length;

            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (episodes[i].GetAverageScore() < episodes[j].GetAverageScore())
                    {
                        EpisodeSwap(ref episodes[i], ref episodes[j]);
                    }
                }
            }
        }

        private Random generator = new Random();
        private double GenerateRandomScore()
        {
            return generator.NextDouble() * 10.0;
        }

    }
}
