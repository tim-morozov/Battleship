using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
        }
    }
}
