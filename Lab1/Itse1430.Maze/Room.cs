using System;
using System.Collections.Generic;
using System.Text;

namespace Itse1430.Maze
{
    class Room{

        Tuple<int, int> coord;
        bool northDoor;
        bool eastDoor;
        bool southDoor;
        bool westDoor;

        bool canTraverse( Room destinationRoom) {
            return false;
        }
    }
}
