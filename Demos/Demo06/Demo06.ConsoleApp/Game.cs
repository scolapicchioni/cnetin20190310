using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06.ConsoleApp
{
    public class Game
    {
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }

        public Game(IPlayer player1, IPlayer player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public IPlayer Play() {
            int resPlayer1 = Player1.Roll();
            int resPlayer2 = Player2.Roll();
            if (resPlayer1 > resPlayer2)
            {
                return Player1;
            }
            else if (resPlayer2 > resPlayer1)
            {
                return Player2;
            }
            else {
                return null;
            }
        }
    }
}
