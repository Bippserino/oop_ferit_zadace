using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zadaca4
{
    class FilePrinter : IPrinter
    {
        public string OutputFileName { get; private set; }
        public FilePrinter(string outputFileName)
        {
            OutputFileName = outputFileName;
        }

        public void Print(string stringOutput)
        {
            Console.WriteLine(stringOutput);
            using (StreamWriter writer = new StreamWriter(OutputFileName))
            {
                writer.WriteLine(stringOutput);
            }
        }
    }
}
