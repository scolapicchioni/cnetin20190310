using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06.ConsoleApp
{
    public interface IPlayer
    {
        int Roll();
        int LastRoll { get; set; }
        string Name { get; set; }
    }
}
