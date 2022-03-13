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
            try
            {
                if (message.ToLower().Contains(""))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch
            {
                return "happy";
            }

        }
    }
}
