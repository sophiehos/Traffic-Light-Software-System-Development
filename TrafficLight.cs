using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophie
{
    public class TrafficLight
    {

        public TrafficLight(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public bool isGreen { get; set; }
    }

}