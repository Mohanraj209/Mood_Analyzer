using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Analyzer
    {
        public string message;

        public Analyzer(string message)
        {
            this.message = message;
        }
        public Analyzer()
        {

        }
        public string Mood(string message)
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }

    }
}
