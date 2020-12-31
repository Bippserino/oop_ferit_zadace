using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Zadaca4
{
    class TvException : Exception
    {
        public string Title { get; private set; }
        public TvException(string message, string title) : base(message) 
        {
            Title = title;
        }
    }
}
