using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
            name = "Computer";
        }

        public override int UserInput()
        {
            Random num = new Random();
            int computerPlayerTurn = num.Next(0, 5);
            return computerPlayerTurn;
        }
    }
}
