using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    public class HumanPlayer : Player 
    {
        public HumanPlayer()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
        }
    }
}
