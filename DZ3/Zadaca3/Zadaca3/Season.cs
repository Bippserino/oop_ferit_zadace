using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca3
{
    class Season
    {
        public int Number { get; set; }
        public List<Episode> Episodes { get; set; }
        public Season(int number, List<Episode> episodes)
        {
            Number = number;
            Episodes = episodes;
        }

        public override string ToString()
        {
            string episodesString = $"Season {Number}:\n=================================================\n";
            int totalViewers = 0;
            TimeSpan totalDuration = new TimeSpan();
            foreach(Episode episode in Episodes)
            {
                episodesString += episode + "\n";
                totalViewers += episode.ViewerCount;
                totalDuration += episode.MovieDescription.Duration;
            }
            episodesString += $"=================================================\nTotal viewers: {totalViewers}\nTotal duration: {totalDuration}\n=================================================";
            return episodesString;
        }
    }
}
