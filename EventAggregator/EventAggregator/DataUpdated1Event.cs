using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample
{
    public class DataUpdated1Event
    {
        public string Text { get; set; }

        //default ctor
        public DataUpdated1Event()
        {
            Text = "Event 1:";
        }

        //ctor with text param
        public DataUpdated1Event(string text)
        {
            Text = $"Event 1: {text}";
        }
    }
}
