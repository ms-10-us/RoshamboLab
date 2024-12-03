using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random randomObject = new Random();
            int randomRoshamboNumber = randomObject.Next(1, 4);
            Roshambo randomRoshambo = (Roshambo)randomRoshamboNumber;
            switch (randomRoshambo)
            {
                case Roshambo.Rock:
                    RoshamboValue = Roshambo.Rock;
                    break;
                case Roshambo.Paper:
                    RoshamboValue = Roshambo.Paper;
                    break;
                case Roshambo.Scissors:
                    RoshamboValue = Roshambo.Scissors;
                    break;
            }

            return RoshamboValue;

        }
    }
}
