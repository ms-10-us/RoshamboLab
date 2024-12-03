using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal abstract class Player
    {
        public string Name {  get; set; }
        public int Win { get; set; } = 0;
        public Roshambo RoshamboValue { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
