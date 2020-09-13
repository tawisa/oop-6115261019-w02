using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261019_w02
{
    class Room
    {
        private string roomCode;
        private string roomName;
        private int roomWidth;
        private int roomLenght;
        private string roomType;
        public string RoomCode
        {
            get { return roomCode; }
            set { roomCode = value; }
        }
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public int RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        public int RoomLength
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public Room() { }
        public Room(string rc, string rn, int rw, int rl, string rt)
        {
            this.roomCode = rc;
            this.roomName = rn;
            this.roomWidth = rw;
            this.roomLenght = rl;
            this.roomType = rt;
        }
        public int calculateArea(int w, int l)
        {
            return w * l;
        }

        public override string ToString()
        {
            return this.RoomCode + " has a area : "
                + this.calculateArea(this.RoomWidth, this.RoomLength);
        }

    }
}