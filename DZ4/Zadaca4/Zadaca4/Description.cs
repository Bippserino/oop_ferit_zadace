using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca4
{
    class Description
    {
        public int EpisodeCount { get; set; }
        public TimeSpan Duration { get; set; }
        public string Title { get; set; }

        public Description(int episodeCount, TimeSpan duration, string title)
        {
            this.EpisodeCount = episodeCount;
            this.Duration = duration;
            this.Title = title;
        }

        public Description(Description other)
        {
            this.EpisodeCount = other.EpisodeCount;
            this.Duration = other.Duration;
            this.Title = other.Title;
        }

        public Description()
        {
            EpisodeCount = 0;
            Duration = new TimeSpan();
            Title = "";
        }

        public override string ToString()
        {
            return ($"{EpisodeCount},{Duration},{Title}");
        }
    }
}
