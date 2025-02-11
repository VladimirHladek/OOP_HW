﻿using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Episode ep1 = new Episode();
            Episode ep2 = new Episode(10, 64.39, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }

            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
            }
            else
            {
                Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
            }


        }

        private static Random generator = new Random();
        private static double GenerateRandomScore()
        {
            return generator.NextDouble() * 10.0;
        }
    }
}
