using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Zadaca4
{
    class TvUtilities
    {
        public static Episode Parse(string file)
        {
            string[] data;
            int viewerCount, episodeCount;
            double gradeSum, maxGrade;
            TimeSpan duration;
            string title;
            data = file.Split(new string[] { "," }, StringSplitOptions.None);

            viewerCount = Int32.Parse(data[0]);
            gradeSum = Double.Parse(data[1], CultureInfo.InvariantCulture);
            maxGrade = Double.Parse(data[2], CultureInfo.InvariantCulture);
            episodeCount = Int32.Parse(data[3]);
            duration = TimeSpan.ParseExact(data[4], "hhmmss", CultureInfo.InvariantCulture);
            title = data[5];

            Episode episode = new Episode(viewerCount, gradeSum, maxGrade, new Description(episodeCount, duration, title));
            return episode;
        }

        public static void Sort(Episode[] episodes)
        {
            Episode temp;
            for (int j = 0; j < episodes.Length; j++)
            {
                for (int i = 0; i < episodes.Length - j - 1; i++)
                {
                    if (episodes[i].GetAverageScore() < episodes[i + 1].GetAverageScore())
                    {
                        temp = episodes[i + 1];
                        episodes[i + 1] = episodes[i];
                        episodes[i] = temp;
                    }
                }
            }
        }

        public static List<Episode> LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInputs = File.ReadAllLines(fileName);
            List<Episode> episodes = new List<Episode>();
            for (int i = 0; i < episodesInputs.Length; i++)
            {
                episodes.Add(TvUtilities.Parse(episodesInputs[i]));
            }
            return episodes;
        }

        public static double GenerateRandomScore(Random rand)
        {
            return rand.NextDouble() * 10;

        }
    }
}
