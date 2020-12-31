using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Zadaca4
{
    class Season : IEnumerable<Episode>
    {
        public int Number { get; private set; }
        public List<Episode> Episodes { get; private set; }
        public Season(int number, List<Episode> episodes)
        {
            Number = number;
            Episodes = episodes;
        }

        public Season(Season other)
        {
            this.Number = other.Number;
            Episodes = new List<Episode>();

            foreach (var episode in other.Episodes)
            {
                Episodes.Add(new Episode(episode.ViewerCount, episode.GradeSum, episode.MaxGrade, new Description(episode.MovieDescription)));

            }
        }

        public override string ToString()
        {
            string episodesString = $"Season {Number}:\n=================================================\n";
            int totalViewers = 0;
            TimeSpan totalDuration = new TimeSpan();
            foreach (Episode episode in Episodes)
            {
                episodesString += episode + "\n";
                totalViewers += episode.ViewerCount;
                totalDuration += episode.MovieDescription.Duration;
            }
            episodesString += $"=================================================\nTotal viewers: {totalViewers}\nTotal duration: {totalDuration}\n=================================================";
            return episodesString;
        }
        public IEnumerator<Episode> GetEnumerator()
        {
            foreach (Episode episode in Episodes)
            {
                yield return episode;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Episode this[int index]
        {
            get => Episodes[index];
            set => Episodes[index] = value;
        }

        public void Remove(string name)
        {
           int flag = 0;

           for (int i = 0; i < Episodes.Count; i++)
            {
                if (name == Episodes[i].MovieDescription.Title)
                {
                    Episodes.RemoveAt(i);
                    flag = 1;
                    break;
                }
            }
           if (flag == 0)
            {
                throw new TvException("No such episode found.", name);
            }
        }
    }

}
