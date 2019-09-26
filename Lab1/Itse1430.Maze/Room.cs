using System;
using System.Collections.Generic;
using System.Text;

namespace Itse1430.Maze
{
    enum Direction { north, south, east, west};
    class Room : IComparable<Room>{

        private Tuple<int, int> _coord;
        private Room _northDoor;
        private Room _eastDoor;
        private Room _southDoor;
        private Room _westDoor;

        public Room (Tuple<int, int> position){
            Coord = position;
        }

        // creates new room conects rooms
        // direction is the direction of root to this
        public Room ( Room root, Direction direction ){
            ConnectRoom (root, direction);
            switch (direction){
                case Direction.south:                   
                    Coord = Tuple.Create (root.Coord.Item1, root.Coord.Item2-1);
                    break;
                case Direction.north:
                    Coord = Tuple.Create (root.Coord.Item1, root.Coord.Item2+1);
                    break;
                case Direction.west:
                    Coord = Tuple.Create (root.Coord.Item1-1, root.Coord.Item2);
                    break;
                case Direction.east:
                    Coord = Tuple.Create (root.Coord.Item1+1, root.Coord.Item2);
                    break;
            }
            
        }

        public Tuple<int, int> Coord { get => _coord; set => _coord=value; }
        internal Room NorthDoor { get => _northDoor; set => _northDoor=value; }
        internal Room EastDoor { get => _eastDoor; set => _eastDoor=value; }
        internal Room SouthDoor { get => _southDoor; set => _southDoor=value; }
        internal Room WestDoor { get => _westDoor; set => _westDoor=value; }

        //sorts bottom right to top left


        public int CompareTo ( Room other ) {
            if (this.Coord.Item1 == other.Coord.Item1 && this.Coord.Item2 == this.Coord.Item2)
                return 0;
            if (this.Coord.Item2 < other.Coord.Item2 )
                return -1;
            //if (this.Coord.Item2==other.Coord.Item2 && this.Coord.Item1< other.Coord.Item1)
              //  return -1;

            return 1;
        }

        public void ConnectRoom(Room root, Direction direction){
            switch (direction){
                case Direction.south:
                    NorthDoor = root;
                    root.SouthDoor = this;
                    break;
                case Direction.north:
                    SouthDoor = root;
                    root.NorthDoor = this;
                    break;
                case Direction.west:
                    EastDoor = root;
                    root.WestDoor = this;
                    break;
                case Direction.east:
                    WestDoor = root;
                    root.EastDoor = this;
                    break;
            } 
        }
        bool CanTraverse( Direction direction) {
            switch (direction)
            {
                case Direction.south:
                if (SouthDoor!= null)
                    return true;
                break;
                case Direction.north:
                if (NorthDoor!= null)
                    return true;
                break;
                case Direction.west:
                if (WestDoor!= null)
                    return true;
                break;
                case Direction.east:
                if (EastDoor!= null)
                    return true;
                break;
                
            }
            return false;
        }
        public string GetDiscription (){
            return "";
        }
        public override string ToString (){
            return Coord.Item1+", "+Coord.Item2;
        }
    }
   
}
