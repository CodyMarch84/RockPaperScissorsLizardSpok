﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    public class Player
    {
        //member variables
        public string name;
        public int score = 0;

        public Player()
        {

        }

        public virtual int UserInput()
        {
            Console.WriteLine(name + " Please enter your choice");
            Console.WriteLine("0 = Rock," + " 1 = Paper," + " 2 = Scissors," + " 3 = Lizard," + " 4 = Spock");
            //Console.WriteLine("1 = Paper");
            //Console.WriteLine("2 = Scissors");
            //Console.WriteLine("3 = Lizard");
            //Console.WriteLine("4 = Spock");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
