using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample
{
    public class DataUpdated2Event
    {
        public string Text { get; set; }

        //default ctor
        public DataUpdated2Event()
        {
            Text = "Event Type2:";
        }

        //ctor with text param
        public DataUpdated2Event(string text)
        {
            Text = $"Event 2: {text}";
        }
    }
}
