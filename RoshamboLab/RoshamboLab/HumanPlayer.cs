using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class HumanPlayer : Player
    {
        public int selectedValue {  get; set; }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo humanPlayerRoshambo = (Roshambo)selectedValue;
            switch (humanPlayerRoshambo)
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
                default:
                    Console.WriteLine("Please enter a valid Roshambo Value");
                    break;
            }

            return RoshamboValue;
        }
    }
}
