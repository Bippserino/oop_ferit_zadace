using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca3
{
    class ConsolePrinter:IPrinter
    {
        public void Print(string stringOutput)
        {
            Console.WriteLine(stringOutput);
        }
    }
}
