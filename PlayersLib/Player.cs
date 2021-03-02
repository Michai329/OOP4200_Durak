using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP4200_Durak.PlayersLib
{
    class Player
    {
        // Private Member Variables
        private string playerName;
        private int playerCardCounter;
        private Cards playerhand;
        private bool isAttacking;

        // Static Data Member
        private static int startingHand = 6;


        // Getters and Setters
        public string Name 
        {
            get 
            { return playerName; }
            set
            { playerName = value; }
        }

        public int CardCounter
        { 
            get { return playerCardCounter; }
        }

    }
}
