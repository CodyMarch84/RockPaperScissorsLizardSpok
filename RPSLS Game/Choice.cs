using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    public class Choice
    {
        //member variables
        public List<string> choices = new List<string>();

        public Choice()
        {
            choices.Add("Rock");
            choices.Add("Paper");
            choices.Add("Scissors");
            choices.Add("Lizard");
            choices.Add("Spock");
        }
    }
}
