using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    public class Client
    {
        public int id { set; get; }
        public string name { set; get; }
        public virtual IEnumerable<ReceivedSamples> samples { set; get; }

    }
}
