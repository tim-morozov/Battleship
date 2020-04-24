using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        string name;
        List<Ship> allShips = new List<Ship>();
        Gameboard gameboard;

        public Player()
        {
            gameboard = new Gameboard();
            name = Console.ReadLine();
            Battleship battleship = new Battleship();
            Carrier carrier = new Carrier();
            Submarine submarine = new Submarine();
            Destroyer destroyer = new Destroyer();
            allShips.Add(battleship);
            allShips.Add(carrier);
            allShips.Add(submarine);
            allShips.Add(destroyer);
        }
    }
}
