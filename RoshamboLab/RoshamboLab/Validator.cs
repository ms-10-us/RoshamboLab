using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal static class Validator
    {
        public static string UserAnswer { get; set; }
        public static string SelectedPlayer { get; set; }
        

        public static bool GetYN()
        {
            if (UserAnswer.Trim().ToLower() != "y" && UserAnswer.Trim().ToLower() != "n")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool GetOtherPlayer()
        {
            if (SelectedPlayer.ToLower().Trim() != "rockplayer" && SelectedPlayer.ToLower().Trim() != "randomplayer")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Roshambo GetRoshambo(HumanPlayer humanPlayer)
        {
            while (true)
            {
                try
                {
                    humanPlayer.RoshamboValue = (Roshambo)humanPlayer.selectedValue;

                }
                catch
                {
                    Console.WriteLine("Please enter a valid Roshambo expression!");
                    continue;
                }

                return humanPlayer.RoshamboValue;
            }

        }

    }
}
