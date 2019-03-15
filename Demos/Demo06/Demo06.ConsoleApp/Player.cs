using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06.ConsoleApp
{
    public class Player : IPlayer
    {
        private IDice _dice;
        public Player(IDice dice)
        {
            _dice = dice;
        }
        public int Roll() {
            LastRoll = _dice.Roll();
            return LastRoll;
        }
        public string Name { get; set; }
        public int LastRoll { get ; set; }
    }
}
