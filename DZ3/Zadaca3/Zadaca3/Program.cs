using System;
using System.Collections.Generic;

namespace Zadaca3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "shows.tv";
            string outputFileName = "storage.tv";

            IPrinter printer = new ConsolePrinter();
            printer.Print($"Reading data from file {fileName}");

            List<Episode> episodes = TvUtilities.LoadEpisodesFromFile(fileName);
            Season season = new Season(1, episodes);

            printer.Print(season.ToString());

            Random rand = new Random();
            foreach(Episode episode in episodes)
            {
                episode.AddView(TvUtilities.GenerateRandomScore(rand));
            }

            printer.Print(season.ToString());

            printer = new FilePrinter(outputFileName);
            printer.Print(season.ToString());
        }
    }
}
