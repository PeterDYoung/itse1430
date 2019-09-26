using System;
using System.Collections.Generic;
using System.Text;

namespace Itse1430.Maze
{
    internal class Maze
    {
        private List<Room> _roomList;
        private Room _currRoom;
        private Direction _heading;
        
        private Room _endRoom;
        private Room _startRoom;

        internal List<Room> RoomList { get => _roomList; set => _roomList=value; }
        internal Room CurrRoom { get => _currRoom; set => _currRoom=value; }
        internal Room EndRoom { get => _endRoom; set => _endRoom=value; }
        internal Room StartRoom { get => _startRoom; set => _startRoom=value; }

        public Maze ()
        {
            Room tempRoom;
            Room tempLoopback;
            Room eastWestConvergence;
            RoomList = new List<Room>();

            //start room
            StartRoom = new Room(Tuple.Create(2,0));
            RoomList.Add (StartRoom);

            //north branch from 2,0
            CurrRoom = StartRoom;
            CurrRoom = new Room(CurrRoom, Direction.north); //2,1
            RoomList.Add (CurrRoom);
            //east branch from 2,1
            tempRoom = CurrRoom;
            CurrRoom = new Room (CurrRoom, Direction.east); //3,1
            RoomList.Add (CurrRoom);
            //create reference to 3,1 for loopback from 3,2
            tempLoopback = CurrRoom;

            CurrRoom = new Room (CurrRoom, Direction.east); //4,1
            RoomList.Add (CurrRoom);
            CurrRoom = new Room (CurrRoom, Direction.north); //4,2
            RoomList.Add (CurrRoom);
            CurrRoom = new Room (CurrRoom, Direction.west); //3,2
            RoomList.Add (CurrRoom);
            CurrRoom.ConnectRoom (tempLoopback, Direction.north);
            CurrRoom = new Room (CurrRoom, Direction.north); //3,3
            RoomList.Add (CurrRoom);
            CurrRoom = new Room (CurrRoom, Direction.west); //2,3
            RoomList.Add (CurrRoom);
            //create reference to 2,3 for loopback from 2,2
            tempLoopback = CurrRoom;

            //north branch from 2,1
            CurrRoom = tempRoom;
            CurrRoom = new Room (CurrRoom, Direction.north); //2,2
            RoomList.Add (CurrRoom);
            CurrRoom.ConnectRoom (tempLoopback, Direction.south);
            CurrRoom = new Room (CurrRoom, Direction.west); //1,2
            RoomList.Add (CurrRoom);
            eastWestConvergence = CurrRoom;

            //west branch from 2,0
            CurrRoom = StartRoom;
            CurrRoom = new Room(CurrRoom, Direction.west); //1,0
            RoomList.Add (CurrRoom);

            //north branch from 1,0
            tempRoom = CurrRoom;
            CurrRoom = new Room (CurrRoom, Direction.north); //1,1
            RoomList.Add (CurrRoom);

            // reference to 1,1 for loopback from 0,1
            tempLoopback = CurrRoom;

            //west branch from 1,0
            CurrRoom = tempRoom;
            CurrRoom = new Room (CurrRoom, Direction.west); //0,0
            RoomList.Add (CurrRoom);
            CurrRoom = new Room (CurrRoom, Direction.north); //0,1
            RoomList.Add (CurrRoom);
            CurrRoom.ConnectRoom (tempLoopback, Direction.west);
            CurrRoom = new Room (CurrRoom, Direction.north); //0,2
            RoomList.Add (CurrRoom);
            CurrRoom.ConnectRoom (eastWestConvergence, Direction.west); //connect to 1,2

            // final north branch from  1,2
            CurrRoom = eastWestConvergence;
            CurrRoom = new Room (CurrRoom, Direction.north); //1,3
            RoomList.Add (CurrRoom);
            CurrRoom = new Room (CurrRoom, Direction.north); //1,4 END
            RoomList.Add (CurrRoom);
            EndRoom = CurrRoom;
            CurrRoom= StartRoom;
            _heading= Direction.north;
        }
        void Move ( string direction )
        {

        }
        void Turn ( string direction )
        {

        }
        void Examine ()
        {

        }

        //□
        public override string ToString() {
            RoomList.Sort ();
            RoomList.Reverse();
            string output = "";
            StringBuilder Line1= new StringBuilder ("");
            StringBuilder spacer1 = new StringBuilder ("");
            StringBuilder Line2 = new StringBuilder ("");
            StringBuilder spacer2 = new StringBuilder ("");
            StringBuilder Line3 = new StringBuilder ("");
            StringBuilder spacer3 = new StringBuilder ("");
            StringBuilder Line4 = new StringBuilder ("");
            StringBuilder spacer4 = new StringBuilder ("");
            StringBuilder Line5 = new StringBuilder ("");
            StringBuilder spacer5 = new StringBuilder ("");
            Line1.Append (4 + " ");
            Line2.Append (3 + " ");
            Line3.Append (2 + " ");
            Line4.Append (1 + " ");
            Line5.Append (0 + " ");
            Line1.Append ('-', 45);
            Line2.Append ('-', 45);
            Line3.Append ('-', 45);
            Line4.Append ('-', 45);
            Line5.Append ('-', 45);
            spacer1.Append ('-', 47);
            spacer2.Append ('-', 47);
            spacer3.Append ('-', 47);
            spacer4.Append ('-', 47);
            spacer5.Append ('-', 47);
            RoomList.ForEach (room=> {
                switch (room.Coord.Item2){
                    case 4:{
                        Line1.Replace ('-', 'R', room.Coord.Item1*9+4, 1);
                        if (room.SouthDoor!=null){
                            spacer1.Replace ('-', '|', room.Coord.Item1*9+4, 2);
                        }
                        if (room.EastDoor!=null){
                            Line1.Replace ('-', '=', room.Coord.Item1*9+6, 8);
                        }
                        break;
                    }
                    case 3:{
                        Line2.Replace ('-', 'R', room.Coord.Item1*9+4, 1);
                        if (room.SouthDoor!=null){
                            spacer2.Replace ('-', '|', room.Coord.Item1*9+4, 2);
                        }
                        if (room.EastDoor!=null){
                            Line2.Replace ('-', '=', room.Coord.Item1*9+5, 8);
                        }
                        break;
                    }
                    case 2:{
                        Line3.Replace ('-', 'R', room.Coord.Item1*9+4, 1);
                        if (room.SouthDoor!=null){
                            spacer3.Replace ('-', '|', room.Coord.Item1*9+4, 2);
                        }
                        if (room.EastDoor!=null){
                            Line3.Replace ('-', '=', room.Coord.Item1*9+5, 8);
                        }
                        break;
                    }
                    case 1:{
                        Line4.Replace ('-', 'R', room.Coord.Item1*9+4, 1);
                        if (room.SouthDoor!=null){
                            spacer4.Replace ('-', '|', room.Coord.Item1*9+4, 2);
                        }
                        if (room.EastDoor!=null){
                            Line4.Replace ('-', '=', room.Coord.Item1*9+5, 8);
                        }
                        break;
                    }
                    case 0:{
                        Line5.Replace ('-', 'R', room.Coord.Item1*9+4, 1);
                        if (room.SouthDoor!=null){
                            spacer5.Replace ('-', '|', room.Coord.Item1*9+4, 2);
                        }
                        if (room.EastDoor!=null){
                            Line5.Replace ('-', '=', room.Coord.Item1*9+5, 8);
                        }
                        break;
                    }

                }
                spacer5.Replace ('-', '0', 0*9+4, 1);
                spacer5.Replace ('-', '1', 9+4, 1);
                spacer5.Replace ('-', '2', 2*9+4, 1);
                spacer5.Replace ('-', '3', 3*9+4, 1);
                spacer5.Replace ('-', '4', 4*9+4, 1);

            });
            

            output = Line1.ToString() +"\n" + spacer1.ToString() +"\n"+Line2.ToString() +"\n" + spacer2.ToString() +"\n" +Line3.ToString() +"\n" + spacer3.ToString() +"\n" +Line4.ToString() +"\n" + spacer4.ToString() +"\n" +Line5.ToString() +"\n" + spacer5.ToString() +"\n";



            return output+"asdsadasdasd";
        }
    }
}
